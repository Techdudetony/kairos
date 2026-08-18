# Kairos Architecture Decisions

**Document Status:** Active  
**Version:** 0.1  
**Last Updated:** August 2026  
**Product:** Kairos  
**Document Owner:** Engineering

---

## 1. Purpose

This document records significant architectural decisions made during
Kairos development.

Architecture Decision Records (ADRs) help preserve:

- What was decided
- Why the decision was made
- Alternatives considered
- Tradeoffs accepted
- When a decision should be reconsidered

ADRs should document meaningful decisions rather than routine
implementation details.

---

## 2. ADR Statuses

| Status     | Meaning                        |
| ---------- | ------------------------------ |
| Proposed   | Under consideration            |
| Accepted   | Current architectural decision |
| Superseded | Replaced by a newer ADR        |
| Rejected   | Considered but not selected    |

A superseded ADR should remain in this document for historical
traceability.

---

# ADR-001: Desktop Framework

**Status:** Accepted  
**Decision:** Avalonia  
**Date:** August 2026

## Context

Kairos requires a desktop framework capable of supporting:

- Windows desktop operation
- Background execution
- Lightweight companion windows
- Progressive intervention UI
- System tray integration
- Custom window behavior
- Accessibility
- Theming
- Native operating-system integration
- Low background resource usage
- Future cross-platform expansion

The initial MVP targets Windows.

However, Windows exclusivity is not currently a long-term product
requirement.

## Options Considered

### Option A: WinUI 3

Advantages:

- Strong Windows integration
- Microsoft-supported Windows UI framework
- Access to Windows App SDK capabilities
- Native Windows experience

Tradeoffs:

- Strong Windows coupling
- Cross-platform expansion would require significant UI work

### Option B: Avalonia

Advantages:

- C# and .NET
- Windows desktop support
- Cross-platform architecture
- MVVM support
- Custom window support
- System tray support
- Flexible styling and theming
- Native interoperability remains available

Tradeoffs:

- Some Windows-specific functionality requires native interop
- Smaller ecosystem than Microsoft's Windows-specific frameworks

### Option C: Tauri

Advantages:

- Small application footprint
- Web-based UI development
- Cross-platform support
- Native backend capabilities

Tradeoffs:

- Introduces a web frontend stack
- Kairos requires substantial desktop and operating-system behavior
- Creates additional frontend/backend technology boundaries

### Option D: Electron

Advantages:

- Mature desktop ecosystem
- Strong cross-platform support
- Extensive window and tray APIs
- Large development ecosystem

Tradeoffs:

- Chromium runtime overhead
- Higher expected memory usage
- Web application architecture is not required for the Kairos MVP

## Decision

Kairos will use **Avalonia** as its desktop UI framework.

The application will use **C# and .NET** as its primary development
platform.

## Rationale

Avalonia provides the strongest balance between:

```text
Windows capability
        +
.NET ecosystem
        +
UI flexibility
        +
Resource awareness
        +
Future portability
```

Kairos can use native Windows APIs where required while keeping those
dependencies isolated from the rest of the application.

## Consequences

Kairos must establish a platform abstraction layer for functionality
that depends on Windows.

Examples include:

- Active-application detection
- Native window behavior
- Startup behavior
- Notifications
- Future system-level integrations

The application should avoid direct Windows dependencies in domain and
application logic.

## Reconsider If

This decision should be reconsidered if:

- Avalonia cannot satisfy required accessibility behavior.
- Required desktop overlays cannot be implemented reliably.
- Windows integrations become significantly more difficult than
  expected.
- Kairos becomes intentionally Windows-only.
- Performance testing reveals unacceptable background resource usage.

---

# ADR-002: Windows-First MVP

**Status:** Accepted  
**Decision:** Windows-first deployment  
**Date:** August 2026

## Context

Kairos eventually may support multiple desktop operating systems.

Supporting multiple operating systems during the MVP would increase:

- Development effort
- Testing requirements
- Platform-specific debugging
- Packaging complexity
- Accessibility testing
- Release management complexity

The MVP exists to validate the Kairos core experience rather than
cross-platform demand.

## Decision

Kairos MVP will officially support **Windows desktop only**.

## Rationale

Windows-first development allows the project to focus on validating:

```text
Intention
    ↕
Attention
    ↕
Time
```

without simultaneously solving multiple operating-system integration
problems.

## Consequences

Windows-specific implementations are acceptable inside the platform
layer.

Core application behavior should remain platform-independent where
practical.

macOS and Linux support are deferred.

## Reconsider If

Reconsider when:

- The MVP core experience is validated.
- User research demonstrates meaningful demand for another platform.
- Platform-specific abstractions have stabilized.

---

# ADR-003: Platform Abstraction

**Status:** Accepted  
**Decision:** Isolate operating-system integrations  
**Date:** August 2026

## Context

Kairos requires operating-system capabilities that are not inherently
cross-platform.

Examples include:

- Detecting the foreground application
- Desktop window management
- Startup behavior
- System notifications

Allowing these implementations to spread throughout the application
would create unnecessary platform coupling.

## Decision

Operating-system functionality will be exposed through application
interfaces.

Example:

```csharp
public interface IActiveApplicationService
{
    string? GetActiveApplicationName();
}
```

The Windows platform layer will provide the implementation.

Conceptually:

```text
Application
      ↓
Platform Interface
      ↓
Windows Implementation
      ↓
Windows API
```

## Rationale

This approach improves:

- Testability
- Maintainability
- Platform isolation
- Future portability
- Failure handling

## Consequences

Platform abstractions should be introduced when a genuine
platform-specific boundary exists.

Interfaces should not be created solely for hypothetical future
requirements.

## Reconsider If

Reconsider individual abstractions when they create more complexity
than the platform separation they provide.

---

# ADR-004: Local-First Data

**Status:** Accepted  
**Decision:** Local-first MVP storage  
**Date:** August 2026

## Context

Kairos may handle information related to:

- User intentions
- Focus activity
- Application usage
- Task context
- Preferences
- Focus history

Much of this information may be personally sensitive.

The MVP does not require cloud synchronization to validate its core
experience.

## Decision

Kairos MVP will use a **local-first data model**.

SQLite will be the initial persistence technology.

Cloud synchronization is deferred.

## Rationale

Local-first storage:

- Reduces privacy exposure
- Reduces infrastructure complexity
- Supports offline operation
- Reduces MVP dependencies
- Aligns with data-minimization principles

## Consequences

MVP data will normally remain on the user's device.

The architecture should not assume that a cloud account exists.

Backup, synchronization, and multi-device behavior are outside the
initial MVP.

## Reconsider If

Reconsider when:

- Cross-device synchronization becomes a validated requirement.
- Account-based functionality becomes necessary.
- Collaborative functionality is introduced.

---

# ADR-005: Layered Application Architecture

**Status:** Accepted  
**Decision:** Clean Architecture-inspired layering  
**Date:** August 2026

## Context

Kairos combines several different concerns:

```text
Domain behavior
UI behavior
Persistence
Background processing
Operating-system integration
```

These concerns should not become tightly coupled.

At the same time, the MVP should avoid unnecessary architectural
complexity.

## Decision

Kairos will use a lightweight layered architecture inspired by Clean
Architecture.

Initial conceptual projects:

```text
Kairos.Domain
Kairos.Application
Kairos.Infrastructure
Kairos.Platform.Windows
Kairos.Desktop
```

Dependencies should generally point toward application and domain
behavior rather than outward toward platform implementations.

## Rationale

The structure provides clear boundaries for:

- Business logic
- Application behavior
- Infrastructure
- Platform-specific behavior
- Presentation

It also improves automated testing.

## Consequences

The project should avoid turning Clean Architecture into a rigid rule
that produces unnecessary abstractions.

Simplicity should be preferred when additional layering provides no
meaningful benefit.

## Reconsider If

Reconsider the project structure if:

- The layers create excessive development overhead.
- Responsibilities become unclear.
- A simpler structure would preserve the same boundaries.

---

# ADR-006: MVVM Presentation Pattern

**Status:** Accepted  
**Decision:** MVVM  
**Date:** August 2026

## Context

Kairos requires multiple UI experiences, including:

- Main application window
- Companion widget
- Focus prompts
- Transition prompts
- Settings

Business behavior should remain testable without requiring the UI.

## Decision

Kairos Desktop will use the **Model-View-ViewModel (MVVM)** pattern.

## Rationale

MVVM aligns naturally with Avalonia and provides separation between:

```text
View
    ↓
ViewModel
    ↓
Application behavior
```

This supports:

- Testability
- UI maintainability
- Reusable application behavior
- Multiple presentation surfaces

## Consequences

Business logic should not be implemented directly inside Views.

ViewModels should not directly perform Windows API operations.

Custom Kairos controls and companion surfaces must preserve platform
accessibility behavior.

Where standard Avalonia automation behavior is insufficient, custom
automation properties or automation peers should be implemented.

Accessibility must be validated through keyboard navigation and
Windows assistive-technology testing.

---

# ADR-007: Minimum Observation

**Status:** Accepted  
**Decision:** Observe only the active application for MVP  
**Date:** August 2026

## Context

Kairos requires enough awareness to identify possible attention drift.

Greater observation could include:

- Browser domains
- Window titles
- Screen contents
- Keystrokes
- Browser content

These capabilities introduce increasing privacy and technical
complexity.

The MVP does not require them.

## Decision

Kairos MVP activity awareness will be limited to identifying the
currently active application.

Kairos will not intentionally inspect:

- Keystrokes
- Screen contents
- Browser page contents
- Private messages

## Rationale

This provides enough information to test the initial application
awareness hypothesis while minimizing observation.

## Consequences

Kairos may produce false positives.

For example:

```text
Expected application:
Visual Studio Code

Observed application:
Google Chrome
```

Kairos cannot automatically know whether Chrome represents research or
distraction.

The user must therefore be able to correct Kairos.

## Reconsider If

Additional awareness should only be considered if:

1. User research demonstrates meaningful value.
2. Existing awareness is insufficient.
3. Privacy implications are evaluated.
4. The user retains meaningful control.

---

# ADR-008: Safe Failure

**Status:** Accepted  
**Decision:** Kairos must never control access to the computer  
**Date:** August 2026

## Context

Kairos will operate in the background and may display increasingly
prominent interventions.

Software failure must not prevent normal computer operation.

## Decision

For MVP, Kairos shall never make access to the operating system or
other applications dependent upon Kairos functioning correctly.

If Kairos fails:

```text
Kairos may stop working.

The computer must continue working.
```

## Rationale

This supports:

- User safety
- User autonomy
- Reliability
- NFR-RL02

## Consequences

MVP interventions must remain dismissible.

Application blocking and forced focus modes remain outside MVP scope.

---

## 3. Future Decisions

The following decisions remain intentionally unresolved:

| Decision                        | Status  |
| ------------------------------- | ------- |
| SQLite access strategy          | Pending |
| Background process model        | Pending |
| Companion window implementation | Pending |
| Active-window Windows API       | Pending |
| Packaging strategy              | Pending |
| Auto-start strategy             | Pending |
| Configuration strategy          | Pending |
| Update mechanism                | Pending |
| Accessibility implementation    | Pending |
| Performance thresholds          | Pending |

These decisions should be made when enough implementation information
exists to evaluate them responsibly.

---

## 4. ADR Rules

New ADRs should be created when a decision:

- Significantly affects architecture.
- Introduces a major dependency.
- Establishes an important engineering constraint.
- Has meaningful alternatives.
- Would be difficult to understand later without context.

Routine implementation decisions do not require ADRs.

Accepted ADRs should not be silently rewritten when the decision
changes.

Instead:

1. Mark the old ADR as `Superseded`.
2. Create a new ADR.
3. Reference the previous decision.

---

## 5. Related Documentation

### Architecture

- [Technical Stack](TECH_STACK.md)

### Requirements

- [Product Requirements](../02-requirements/PRODUCT_REQUIREMENTS.md)
- [MVP Scope](../02-requirements/MVP_SCOPE.md)
- [Requirements Traceability](../02-requirements/REQUIREMENTS_TRACEABILITY.md)

### Product

- [Product Principles](../00-product/PRODUCT_PRINCIPLES.md)
- [Product Vision](../00-product/PRODUCT_VISION.md)
