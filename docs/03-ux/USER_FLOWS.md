# Kairos User Flows

**Document Status:** Draft  
**Version:** 0.1  
**Last Updated:** August 2026  
**Product:** Kairos  
**Document Owner:** UX

---

## 1. Purpose

This document defines the primary user flows for the Kairos MVP.

The flows describe how users move through the core Kairos experience
without prescribing final visual design.

The MVP centers on:

```text
Intention
    ↕
Attention
    ↕
Time
```

---

## 2. UX Principles

Kairos flows should follow these principles:

1. Keep common actions short.
2. Preserve user control.
3. Treat plan changes as normal.
4. Avoid assuming distraction from application activity alone.
5. Escalate intervention progressively.
6. Help users recover context after interruption.
7. Prepare users for transitions rather than only announcing them.
8. Avoid unnecessary interruption.

---

## 3. Core MVP Flow

The primary Kairos experience is:

```text
Define intention
      ↓
Start focus session
      ↓
Kairos becomes a background companion
      ↓
User works
      ↓
Kairos maintains time awareness
      ↓
Possible attention drift?
   ↙             ↘
 No              Yes
 ↓                ↓
Continue       Progressive
working        intervention
                  ↓
             User responds
                  ↓
           Return / Correct /
           Change Plan
                  ↓
             Continue work
                  ↓
          Transition warning
                  ↓
          Focus period ends
                  ↓
     Complete / Extend / Reschedule
```

---

## 4. Flow UF-01: Create Focus Intention

**Goal:** Begin a focused work period.

**Related Requirements:**

- FR-FI01
- FR-FI02
- FR-AA02
- FR-LP01

### Flow

```text
Open Kairos
    ↓
Choose Start Focus Session
    ↓
Enter task name
    ↓
Set planned duration
    ↓
Optional:
- Priority
- Task context
- Expected applications
    ↓
Start
    ↓
Focus session becomes active
    ↓
Kairos enters companion state
```

### Required Outcome

The user should be able to start a basic focus session without
completing optional planning fields.

---

## 5. Flow UF-02: Normal Focus Session

**Goal:** Support focus without becoming another distraction.

**Related Requirements:**

- FR-FI02
- FR-TM01
- FR-BC01
- FR-BC02

### Flow

```text
Focus session active
      ↓
User works outside Kairos
      ↓
Companion remains available
      ↓
Kairos displays:
- Current intention
- Remaining time
      ↓
No intervention required
      ↓
Kairos remains low intensity
```

### Required Outcome

Kairos should remain useful without demanding continuous interaction.

---

## 6. Flow UF-03: Possible Attention Drift

**Goal:** Help the user notice possible drift without assuming they are
distracted.

**Related Requirements:**

- FR-AA01
- FR-AA03
- FR-PI01
- FR-PI02
- FR-PI03

### Flow

```text
Focus session active
      ↓
Active application changes
      ↓
Application is not expected
      ↓
Possible attention drift
      ↓
Level 1: Ambient
      ↓
Drift condition continues
      ↓
Level 2: Prompt
      ↓
Drift condition continues
      ↓
Level 3: Focus Intervention
```

Escalation timing will be determined through prototyping and user
testing.

### Required Outcome

Kairos must distinguish:

```text
Possible attention drift
```

from:

```text
Confirmed distraction
```

The latter must not be inferred solely from application activity.

---

## 7. Flow UF-04: Correct Kairos

**Goal:** Allow the user to correct an incorrect interpretation.

**Related Requirements:**

- FR-AA04
- FR-PI04
- NFR-UP04

### Flow

```text
Kairos prompts user
      ↓
"Still working on your current task?"
      ↓
User indicates Yes
      ↓
Kairos acknowledges correction
      ↓
Optional:
Add current application
to expected applications
      ↓
Return to low-intensity state
```

### Required Outcome

Correction should require minimal effort.

Kairos should not repeatedly challenge the same corrected context
during the current session without new evidence.

---

## 8. Flow UF-05: Return to Task

**Goal:** Help the user recover after attention drift.

**Related Requirements:**

- FR-AR01
- FR-AR02
- FR-PI03

### Flow

```text
Kairos intervention
      ↓
User chooses Return to Task
      ↓
Kairos surfaces:
- Current intention
- Current objective
- Next intended action
      ↓
User resumes activity
      ↓
Kairos returns to companion state
```

### Required Outcome

Returning to focus should involve more than dismissing a notification.

Kairos should help answer:

> What was I doing?

---

## 9. Flow UF-06: Change Plan

**Goal:** Allow intentional changes without framing them as failure.

**Related Requirements:**

- FR-FI03
- FR-AR03
- NFR-UP04

### Flow

```text
Active focus session
      ↓
User chooses Change My Plan
      ↓
User may:
- Change intention
- Adjust duration
- Preserve current context
- End current activity
      ↓
Confirm new plan
      ↓
Kairos updates session state
```

### Required Outcome

Kairos should treat a deliberate plan change as valid user input.

---

## 10. Flow UF-07: Transition Warning

**Goal:** Prepare the user before the focus period ends.

**Related Requirements:**

- FR-TM02
- FR-TR01

### Flow

```text
Focus session active
      ↓
10 minutes remaining
      ↓
Low-intensity transition warning
      ↓
5 minutes remaining
      ↓
Stronger preparation cue
      ↓
Prompt user to consider:
- Finish current step
- Preserve context
- Prepare to transition
```

### Required Outcome

Warnings should help the user prepare rather than merely report the
remaining time.

---

## 11. Flow UF-08: Focus Period Ends

**Goal:** Help the user intentionally decide what happens next.

**Related Requirements:**

- FR-TR02
- FR-TR03
- FR-LP03

### Flow

```text
Planned time reached
      ↓
Kairos asks what happens next
      ↓
┌──────────┬──────────┬────────────┐
Complete   Extend     Reschedule
    ↓          ↓           ↓
Finish     Add time    Preserve context
session    Continue    Choose later time
```

### Complete

The activity is marked complete and the focus session ends.

### Extend

The user adds additional time and continues the session.

### Reschedule

Kairos asks the user to preserve:

- What remains unfinished
- What should happen next

The activity can then be resumed later.

---

## 12. Flow UF-09: Dismiss Intervention

**Goal:** Preserve user control.

**Related Requirements:**

- FR-PI04
- NFR-UP04

### Flow

```text
Kairos intervention
      ↓
User chooses Dismiss
      ↓
Intervention closes
      ↓
Kairos returns to companion state
```

Dismissal should not automatically be interpreted as:

- Failure
- Noncompliance
- Distraction
- Loss of motivation

Future UX testing should determine appropriate behavior after repeated
dismissals.

---

## 13. Flow UF-10: Activity Awareness Disabled

**Goal:** Preserve core Kairos functionality when monitoring is
disabled.

**Related Requirements:**

- NFR-UP01
- NFR-UP02

### Flow

```text
User disables activity awareness
      ↓
Kairos stops active-application observation
      ↓
Focus session continues
      ↓
Available functionality:
- Current intention
- Remaining time
- Transition warnings
- Manual controls
```

### Required Outcome

Activity awareness enhances Kairos.

It must not be required for basic focus-session functionality.

---

## 14. Companion States

The user flows produce several high-level Kairos states:

| State        | Purpose                                      |
| ------------ | -------------------------------------------- |
| Idle         | No focus session is active                   |
| Companion    | Focus session active, no intervention needed |
| Ambient      | Possible drift detected                      |
| Prompt       | Direct user confirmation requested           |
| Intervention | Prominent focus assistance                   |
| Transition   | Preparing for end of focus period            |
| Session End  | Complete, extend, or reschedule decision     |

Detailed behavior for these states is defined in:

[Interaction Model](INTERACTION_MODEL.md)

---

## 15. Error and Failure Principle

Kairos failure should never prevent normal computer use.

If a Kairos capability becomes unavailable:

```text
Kairos functionality may degrade
        ↓
User is informed when necessary
        ↓
Computer remains normally usable
```

This supports:

- NFR-RL01
- NFR-RL02

---

## 16. Deferred Flows

The following flows are outside the initial MVP:

- AI task decomposition
- Automatic schedule reconstruction
- Strict Focus
- Application blocking
- Website blocking
- Guardian monitoring
- Cross-device continuation
- Mobile companion interaction
- Cloud synchronization
- Learned time estimation

These should receive dedicated UX flows if they enter a future release.

---

## 17. Related Documentation

### Requirements

- [Product Requirements](../02-requirements/PRODUCT_REQUIREMENTS.md)
- [MVP Scope](../02-requirements/MVP_SCOPE.md)
- [Requirements Traceability](../02-requirements/REQUIREMENTS_TRACEABILITY.md)

### Architecture

- [Technical Stack](../05-architecture/TECH_STACK.md)
- [Architecture Decisions](../05-architecture/ARCHITECTURE_DECISIONS.md)

### UX

- [Interaction Model](INTERACTION_MODEL.md)
