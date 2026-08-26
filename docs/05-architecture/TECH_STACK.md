# Kairos Technical Stack

**Document Status:** Draft  
**Version:** 0.1  
**Last Updated:** August 2026  
**Product:** Kairos  
**Document Owner:** Engineering

---

## 1. Purpose

This document defines the initial technical stack for the Kairos
Windows desktop MVP.

The stack is selected to support:

- Background desktop operation
- Lightweight companion UI
- Active-application awareness
- Progressive interventions
- Local-first data handling
- Accessibility
- Testability
- Future cross-platform expansion

Major decisions are documented separately in:

[Architecture Decisions](ARCHITECTURE_DECISIONS.md)

---

## 2. Core Technology

| Area                 | Selection                                |
| -------------------- | ---------------------------------------- |
| Language             | C#                                       |
| Runtime              | .NET                                     |
| UI Framework         | Avalonia                                 |
| UI Pattern           | MVVM                                     |
| Architecture         | Layered / Clean Architecture-inspired    |
| Local Storage        | SQLite                                   |
| Dependency Injection | Microsoft.Extensions.DependencyInjection |
| Logging              | Microsoft.Extensions.Logging + Serilog   |
| Unit Testing         | xUnit                                    |
| Assertions           | Shouldly                                 |
| Mocking              | NSubstitute                              |
| CI                   | GitHub Actions                           |
| Source Control       | Git + GitHub                             |

---

## 3. Desktop Framework

### Selection

**Avalonia**

Avalonia will provide the desktop UI layer for the initial Kairos MVP.

The MVP will target Windows first.

The application structure should avoid unnecessary Windows-specific
coupling outside platform integration layers.

### Reasons

Avalonia supports the current Kairos direction by providing:

- .NET and C# development
- Desktop application support
- MVVM-friendly architecture
- System tray support
- Custom window behavior
- Theming and styling
- Future cross-platform potential

Windows-specific functionality may still require native APIs.

Those integrations should be isolated behind application interfaces.

---

## 4. Architecture

Kairos will use a layered architecture inspired by Clean Architecture.

Initial conceptual structure:

```text
Kairos.Domain
        ↓
Kairos.Application
        ↓
Kairos.Infrastructure
        ↓
Kairos.Platform.Windows
        ↓
Kairos.Desktop
```

### Kairos.Domain

Contains core business concepts.

Examples:

- Focus intention
- Focus session
- Intervention level
- Task context
- Transition state

This layer should not depend on UI or Windows APIs.

### Kairos.Application

Contains application behavior and use cases.

Examples:

- Start focus session
- Extend focus session
- End focus session
- Evaluate possible attention drift
- Escalate intervention
- Preserve task context

### Kairos.Infrastructure

Contains infrastructure concerns such as:

- Persistence
- Logging
- Configuration
- Repositories

### Kairos.Platform.Windows

Contains Windows-specific integrations.

Examples:

- Active-window detection
- Native window behavior
- Windows startup behavior
- Notifications
- System-level integration

### Kairos.Desktop

Contains the Avalonia desktop UI.

Examples:

- Main application window
- Companion widget
- Intervention prompts
- Settings
- ViewModels

---

## 5. UI Architecture

Kairos will use **MVVM** for desktop presentation logic.

Conceptually:

```text
View
    ↓
ViewModel
    ↓
Application Service
    ↓
Domain / Infrastructure
```

Views should avoid containing business logic.

ViewModels should coordinate presentation behavior without directly
implementing operating-system integrations.

---

## 6. Local Persistence

### Selection

**SQLite**

Kairos MVP data should be stored locally unless a future requirement
explicitly requires synchronization.

Potential locally stored data includes:

- Focus intentions
- Focus-session history
- Task context
- User preferences
- Expected applications
- Intervention preferences

### Data Access

The exact data-access strategy remains provisional.

Candidates include:

- Entity Framework Core
- Dapper
- Lightweight custom repository implementation

The simplest approach that satisfies MVP requirements should be
preferred.

### Data Access (Decided — KAIROS-26)

**Microsoft.Data.Sqlite**, used directly with hand-written parameterized SQL — no ORM.

For KAIROS-26's scope (a single-row "active focus session" table, no relationships, no complex queries), EF Core's change-tracking and migrations infrastructure and Dapper's mapping layer were both more than the problem needed. A small repository (`SqliteFocusSessionRepository`) implementing `IFocusSessionRepository` wraps a handful of parameterized `INSERT ... ON CONFLICT DO UPDATE` / `SELECT` statements against a fixed single-row table (`Id = 1`).

This decision applies to the current scope only. If future persistence needs (e.g. focus-session history, multiple related tables, complex queries) make hand-written SQL unwieldy, EF Core or Dapper should be reconsidered at that point rather than retrofitted reluctantly.

---

## 7. Windows Integration

Windows-specific behavior will be accessed through dedicated platform
services.

Example:

```csharp
public interface IActiveApplicationService
{
    string? GetActiveApplicationName();
}
```

Windows implementation:

```text
IActiveApplicationService
        ↓
WindowsActiveApplicationService
        ↓
Windows API / PInvoke
```

Application and UI layers should depend on the interface rather than
the Windows implementation.

This preserves future portability.

---

## 8. Dependency Injection

Kairos will use:

**Microsoft.Extensions.DependencyInjection**

Dependency injection will be used for:

- Application services
- Repositories
- Logging
- Platform services
- Configuration

Constructor injection should be preferred.

---

## 9. Logging

Kairos will use:

- `Microsoft.Extensions.Logging`
- Serilog

Logging should support:

- Application startup
- Application shutdown
- Unexpected errors
- Background-service failures
- Platform integration failures
- Diagnostic development information

Logs must not contain sensitive user content unnecessarily.

---

## 10. Testing

### Unit Testing

**xUnit**

### Assertions

**Shouldly**

_(FluentAssertions 8.x moved to a dual license requiring a paid subscription for commercial use as of the Xceed acquisition; Shouldly (MIT) was selected instead to keep Kairos's testing stack free for any future use case.)_

### Mocking

**NSubstitute**

Testing should initially focus on:

- Domain behavior
- Application services
- Intervention-state logic
- Time calculations
- Transition logic
- Repository behavior
- User-override behavior

Platform integrations should be isolated so they can be tested
independently where practical.

---

## 11. Continuous Integration

Kairos will use GitHub Actions for CI.

Initial CI should eventually validate:

```text
Restore
    ↓
Build
    ↓
Test
    ↓
Static validation
```

Pull requests should not be considered complete if required CI checks
fail.

CI configuration will be implemented during the Application Foundation
Epic.

---

## 12. Packaging

The Windows packaging and installer strategy is not yet finalized.

Candidates may include:

- MSIX
- Traditional Windows installer
- Avalonia-supported deployment approaches

Packaging will be evaluated after the initial desktop application
prototype confirms required runtime and platform behavior.

---

## 13. Privacy Architecture

Kairos MVP should follow a local-first approach.

Application awareness for MVP should identify only the active
application.

The MVP will not intentionally inspect:

- Screen contents
- Keystrokes
- Browser page contents
- Private messages

Platform services should expose only the minimum information required
by the application layer.

---

## 14. Deferred Technical Capabilities

The following are not required for the initial technical foundation:

- Cloud synchronization
- Mobile synchronization
- Browser extensions
- Domain-level browser awareness
- Screen analysis
- AI inference
- Remote behavioral telemetry
- Application blocking
- Website blocking

Architecture should avoid making these impossible, but they should not
drive MVP complexity.

---

## 15. Technical Principles

Kairos engineering should prioritize:

1. User control
2. Local-first behavior
3. Safe failure
4. Low background resource usage
5. Separation of platform-specific code
6. Testability
7. Accessibility
8. Maintainability
9. Clear requirement traceability
10. Simplicity before abstraction

---

## 16. Related Documentation

### Requirements

- [Product Requirements](../02-requirements/PRODUCT_REQUIREMENTS.md)
- [MVP Scope](../02-requirements/MVP_SCOPE.md)
- [Requirements Traceability](../02-requirements/REQUIREMENTS_TRACEABILITY.md)

### Research

- [Research Questions](../01-research/RESEARCH_QUESTIONS.md)
- [Assumptions and Hypotheses](../01-research/ASSUMPTIONS_AND_HYPOTHESES.md)

### Architecture

- [Architecture Decisions](ARCHITECTURE_DECISIONS.md)
