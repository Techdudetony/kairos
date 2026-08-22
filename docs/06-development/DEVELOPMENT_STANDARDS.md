# Kairos Development Standards

**Document Status:** Active  
**Version:** 0.1  
**Last Updated:** August 2026  
**Product:** Kairos  
**Document Owner:** Engineering

---

## 1. Purpose

Lightweight, practical conventions for consistent Kairos implementation. These describe practices already in use since the Application Foundation tickets — this document formalizes them, it does not introduce new unproven process.

---

## 2. Project Organization

See [Solution Structure](SOLUTION_STRUCTURE.md) for the project layout and dependency-direction rules. Not repeated here.

---

## 3. C# Formatting

Formatting is defined in the repository's root [`.editorconfig`](../../.editorconfig) and enforced via `dotnet format`. Key conventions:

- 4-space indentation, Allman brace style (opening brace on its own line)
- Private fields: `_camelCase`
- Interfaces: `IPascalCase`
- `var` preferred for built-in types and where the type is apparent from the right-hand side; explicit types elsewhere

Before committing, run:

```bash
dotnet format Kairos.slnx --verify-no-changes
```

---

## 4. Nullable Reference Types

Nullable reference types are enabled solution-wide via the root [`Directory.Build.props`](../../Directory.Build.props), not configured per-project. All new projects inherit this automatically.

---

## 5. Compiler Warnings

`AnalysisLevel` is set to `latest` in `Directory.Build.props` so the compiler surfaces the newest available warning/analyzer guidance. Warnings should be treated as issues to resolve, not ignored.

Warnings do not currently fail the build. `TreatWarningsAsErrors` (scoped to Release, aligning with the KAIROS-18 CI pipeline) is a reasonable future hardening step once the existing warning surface has been audited — not something to enable unaudited as part of establishing these standards.

---

## 6. Test Naming

- Test project names: `<ProjectUnderTest>.Tests` (e.g. `Kairos.Domain.Tests`)
- Test class names: describe the subject under test (e.g. `TestConfigurationSmokeTests`)
- Test method names: a descriptive sentence in `Underscore_Separated_Case` stating the behavior being verified (e.g. `Xunit_and_Shouldly_are_configured_correctly`) — not `Test1`, `MethodTest`, or similar non-descriptive names.

---

## 7. Branch Naming

```text
<type>/KAIROS-<number>-<short-description>
```

Types:

- `feature/` — new product functionality
- `task/` — foundation, infrastructure, and engineering work
- `bugfix/` — defect fixes

Examples:

```text
feature/KAIROS-20-focus-intention
task/KAIROS-18-configure-ci
bugfix/KAIROS-42-fix-timer-drift
```

Every implementation branch includes its Jira work-item identifier. One Jira ticket per branch unless explicitly approved otherwise.

---

## 8. Commit Messages

```text
type: concise description

KAIROS-XX

Optional body explaining what changed and why.
```

`type` is one of `feat`, `fix`, `test`, `docs`, or `chore`, matching the actual nature of the change.

When committing via the CLI, prefer writing multiline messages through an editor or IDE (e.g. VS Code's Source Control message box) rather than chaining multiple `-m` flags — shell quoting (particularly in PowerShell) can silently mangle a multi-line message assembled from several `-m` arguments.

---

## 9. Pull Requests

Every implementation ticket gets a focused PR into `develop`. PR descriptions include:

```text
## Summary
## Jira
## Changes
## Architecture
## Validation
## Testing
## Next Step
```

Validation checklist items should only be checked once actually verified — not assumed because code compiles or "should" work. Items that are genuinely out of scope or not yet verifiable should say so explicitly rather than being checked off.

---

## 10. Related Documentation

- [Solution Structure](SOLUTION_STRUCTURE.md)
- [Tech Stack](../05-architecture/TECH_STACK.md)
- [Architecture Decisions](../05-architecture/ARCHITECTURE_DECISIONS.md)
