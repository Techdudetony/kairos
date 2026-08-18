# Kairos Solution Structure

**Document Status:** Active  
**Version:** 0.1  
**Last Updated:** August 2026  
**Product:** Kairos  
**Document Owner:** Engineering

---

## 1. Purpose

This document defines the initial .NET solution structure for the Kairos
desktop MVP.

The goal is to establish clear project responsibilities and dependency
boundaries before the solution is scaffolded.

This structure is intentionally lightweight.

It should support:

- Maintainability
- Testability
- Platform isolation
- Safe failure
- Future portability
- Clear ownership of business logic
- Separation of UI and operating-system concerns

---

## 2. Proposed Solution

The initial solution will contain:

```text
Kairos.Domain
Kairos.Application
Kairos.Infrastructure
Kairos.Platform.Windows
Kairos.Desktop
```

Testing projects will be added alongside the implementation projects as
needed.

Conceptually:

```text
Kairos.Desktop
      │
      ├───────────────┐
      ↓               ↓
Kairos.Application   Kairos.Infrastructure
      │               │
      ↓               │
Kairos.Domain         │
                      │
Kairos.Platform.Windows
```

The exact project references are defined below.

---

## 3. Kairos.Domain

### Responsibility

`Kairos.Domain` contains the core business concepts and rules of Kairos.

Examples include:

- Focus intentions
- Focus sessions
- Intervention levels
- Task context
- Transition state
- Domain value objects
- Domain rules

### May Depend On

- .NET base class libraries

### Must Not Depend On

- Avalonia
- Windows APIs
- SQLite
- Entity Framework Core
- Serilog
- UI concerns
- Infrastructure implementations

### Principle

The Domain project should remain usable and testable without launching
the desktop application.

---

## 4. Kairos.Application

### Responsibility

`Kairos.Application` contains application use cases and orchestration.

Examples include:

- Start focus session
- Edit focus intention
- Complete focus session
- Extend focus session
- Evaluate possible attention drift
- Escalate intervention state
- Preserve task context
- Recover task context
- Prepare for transitions

This layer may also define interfaces required from infrastructure or
platform-specific implementations.

Examples:

```csharp
IActiveApplicationService
IFocusSessionRepository
IClock
```

### May Depend On

- `Kairos.Domain`
- .NET base class libraries

### Must Not Depend On

- Avalonia
- Windows APIs
- Concrete SQLite implementations
- Concrete logging providers
- Desktop Views

### Principle

Application behavior should remain testable without operating-system or
UI dependencies.

---

## 5. Kairos.Infrastructure

### Responsibility

`Kairos.Infrastructure` contains technical implementations for
application-supporting infrastructure.

Examples include:

- SQLite persistence
- Repository implementations
- Configuration
- Logging configuration
- Local storage utilities

### May Depend On

- `Kairos.Application`
- `Kairos.Domain`
- Approved infrastructure libraries

### Must Not Own

- Core business rules
- UI behavior
- Windows-specific active-window detection
- Companion presentation logic

### Principle

Infrastructure implements technical capabilities required by the
application layer.

---

## 6. Kairos.Platform.Windows

### Responsibility

`Kairos.Platform.Windows` contains Windows-specific implementations.

Examples include:

- Active-window detection
- Windows process lookup
- Native window integration
- Startup behavior
- Windows notifications
- Other Win32 or Windows-specific interoperability

### May Depend On

- `Kairos.Application`
- `Kairos.Domain` only where genuinely necessary
- Windows platform APIs
- P/Invoke

### Must Not Own

- Business rules
- Focus-session orchestration
- Avalonia Views
- General persistence logic

### Principle

Windows-specific behavior should remain isolated behind application
interfaces.

Example:

```text
Kairos.Application
IActiveApplicationService
        ↓
Kairos.Platform.Windows
WindowsActiveApplicationService
        ↓
Windows API
```

---

## 7. Kairos.Desktop

### Responsibility

`Kairos.Desktop` is the Avalonia presentation and application-composition
project.

Examples include:

- Application startup
- Dependency injection composition
- Main window
- Companion window
- Views
- ViewModels
- UI resources
- Theme resources
- Interaction surfaces

### May Depend On

- `Kairos.Application`
- `Kairos.Infrastructure`
- `Kairos.Platform.Windows`
- `Kairos.Domain` where presentation requires domain types
- Avalonia

### Must Not Own

- Core domain rules
- Windows API implementations
- Repository implementations
- Business logic that belongs in Application or Domain

### Principle

The Desktop project coordinates presentation.

It should not become the location where all application behavior is
implemented.

---

## 8. Dependency Direction

The intended dependency direction is:

```text
Kairos.Domain
        ↑
Kairos.Application
        ↑
Kairos.Infrastructure

Kairos.Application
        ↑
Kairos.Platform.Windows

Kairos.Application
        ↑
Kairos.Desktop
```

`Kairos.Desktop` acts as the composition root and may reference outer
implementation projects required to assemble the running application.

---

## 9. Allowed Project References

Initial project references should follow this model:

| Project                   | May Reference                                                                                        |
| ------------------------- | ---------------------------------------------------------------------------------------------------- |
| `Kairos.Domain`           | None                                                                                                 |
| `Kairos.Application`      | `Kairos.Domain`                                                                                      |
| `Kairos.Infrastructure`   | `Kairos.Application`, `Kairos.Domain`                                                                |
| `Kairos.Platform.Windows` | `Kairos.Application`, optionally `Kairos.Domain`                                                     |
| `Kairos.Desktop`          | `Kairos.Application`, `Kairos.Infrastructure`, `Kairos.Platform.Windows`, optionally `Kairos.Domain` |

Optional references should only be added when they are actually needed.

---

## 10. Prohibited Dependency Examples

The following dependency patterns are not allowed:

```text
Kairos.Domain
    ↓
Avalonia
```

```text
Kairos.Application
    ↓
Win32 API
```

```text
Kairos.Application
    ↓
Kairos.Desktop
```

```text
Kairos.Domain
    ↓
Kairos.Infrastructure
```

```text
Kairos.Platform.Windows
    ↓
Kairos.Desktop
```

These dependencies would break the intended architectural boundaries.

---

## 11. Interface Ownership

Interfaces should normally live in the layer that requires the
capability.

Example:

```text
Kairos.Application
    IActiveApplicationService
             ↓
Kairos.Platform.Windows
    WindowsActiveApplicationService
```

Another example:

```text
Kairos.Application
    IFocusSessionRepository
             ↓
Kairos.Infrastructure
    SqliteFocusSessionRepository
```

Interfaces should not be created solely because a future abstraction
might be useful.

A real dependency boundary should exist first.

---

## 12. Testing Structure

Testing projects should mirror the areas they validate.

Initial candidates include:

```text
Kairos.Domain.Tests
Kairos.Application.Tests
```

Additional test projects may be added when justified.

Potential future projects include:

```text
Kairos.Infrastructure.Tests
Kairos.Platform.Windows.Tests
Kairos.Desktop.Tests
```

The MVP should avoid creating empty test projects without a clear need.

---

## 13. Initial Repository Layout

The implementation repository may eventually resemble:

```text
src/
├── Kairos.Domain/
├── Kairos.Application/
├── Kairos.Infrastructure/
├── Kairos.Platform.Windows/
└── Kairos.Desktop/

tests/
├── Kairos.Domain.Tests/
└── Kairos.Application.Tests/

docs/
└── ...
```

The actual folders will be created during scaffolding.

---

## 14. Composition Root

`Kairos.Desktop` will act as the initial application composition root.

It is responsible for wiring together:

- Application services
- Infrastructure implementations
- Platform implementations
- Logging
- Configuration
- ViewModels

Example conceptual flow:

```text
Kairos.Desktop
        ↓
Dependency Injection
        ↓
Application Interfaces
      ↙       ↘
Infrastructure  Windows Platform
```

Service-registration details are handled by a separate Jira work item.

---

## 15. Architecture Guardrails

The solution should preserve the following rules:

1. Domain remains independent.
2. Application contains use cases rather than UI logic.
3. Windows APIs remain isolated.
4. Avalonia remains isolated to presentation.
5. Infrastructure implements technical concerns.
6. Business behavior remains testable without the desktop UI.
7. New abstractions require a real architectural need.
8. Circular project references are prohibited.
9. Simplicity is preferred over unnecessary layering.

---

## 16. KAIROS-12 Acceptance Criteria Mapping

This document satisfies the KAIROS-12 acceptance criteria by defining:

- The intended solution structure.
- Responsibilities for each project.
- Dependency direction.
- Avalonia isolation from Domain and Application.
- Windows API isolation from Domain and Application.
- The Windows platform boundary.
- A lightweight MVP-oriented structure.

Actual project creation and reference configuration occur in:

- KAIROS-13: Scaffold Avalonia desktop application
- KAIROS-14: Establish project references and dependency boundaries

---

## 17. Related Documentation

### Architecture

- [Technical Stack](../05-architecture/TECH_STACK.md)
- [Architecture Decisions](../05-architecture/ARCHITECTURE_DECISIONS.md)

### Requirements

- [Product Requirements](../02-requirements/PRODUCT_REQUIREMENTS.md)
- [MVP Scope](../02-requirements/MVP_SCOPE.md)

### Development

Future development documentation should reference this structure rather
than redefining project responsibilities independently.
