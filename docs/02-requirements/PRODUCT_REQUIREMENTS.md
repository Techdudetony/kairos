# Kairos Product Requirements

**Document Status:** Draft  
**Version:** 0.1  
**Last Updated:** August 2026  
**Product:** Kairos  
**Document Owner:** Product

---

## 1. Purpose

This document defines the initial product requirements for the Kairos
Minimum Viable Product (MVP).

The MVP is intended to test one central product hypothesis:

> Can a persistent desktop companion help users maintain and recover
> their intended focus while using their computer?

These requirements are intentionally limited.

Features that do not directly support this core experience should be
deferred unless later research demonstrates that they are necessary.

---

## 2. MVP Core Loop

The Kairos MVP shall support the following core experience:

```text
User defines intention
        ↓
Kairos keeps the intention visible
        ↓
Kairos helps the user remain aware of time
        ↓
Kairos detects possible attention drift
        ↓
Kairos progressively intervenes
        ↓
User confirms, changes, or returns to their intention
        ↓
Kairos supports transition when time is ending
```

The MVP should prove this loop before Kairos expands into more advanced
planning, scheduling, or personalization capabilities.

---

## 3. Requirement Priorities

Requirements use the following priorities.

| Priority | Meaning                                   |
| -------- | ----------------------------------------- |
| Must     | Required for MVP                          |
| Should   | Valuable, but MVP can function without it |
| Could    | Candidate for later development           |
| Deferred | Explicitly outside MVP                    |

---

## 4. Focus Intention

### FR-FI01: Create Focus Intention

**Priority:** Must

Kairos shall allow the user to define an intended focus activity.

At minimum, an intention shall support:

- Task name
- Planned duration

Optional information may include:

- Priority
- Short task context
- Expected applications

---

### FR-FI02: Display Current Intention

**Priority:** Must

Kairos shall keep the current intention accessible while the user works
outside the main Kairos interface.

The presentation should remain lightweight when no intervention is
required.

---

### FR-FI03: Update Intention

**Priority:** Must

The user shall be able to:

- Edit the current intention.
- Extend its planned duration.
- End it early.
- Mark it complete.
- Change the current plan.

Kairos shall not require the user to continue an outdated intention.

---

## 5. Time Awareness

### FR-TM01: Display Remaining Time

**Priority:** Must

Kairos shall provide a persistent representation of the time remaining
for the current focus activity.

The representation shall be understandable without requiring the user
to open the primary Kairos window.

---

### FR-TM02: Provide Transition Warnings

**Priority:** Must

Kairos shall notify the user before the planned focus period ends.

The initial MVP shall support warnings at approximately:

- 10 minutes remaining
- 5 minutes remaining

Warning timing should be configurable in future versions.

---

### FR-TM03: Support Time Extension

**Priority:** Must

The user shall be able to extend the current focus period when
additional time is needed.

Extending time shall be treated as an intentional plan change rather
than a failure.

---

## 6. Application Awareness

### FR-AA01: Detect Active Application

**Priority:** Must

Kairos shall be capable of identifying the currently active desktop
application while activity awareness is enabled.

Examples may include:

```text
Visual Studio Code
Google Chrome
Microsoft Word
Steam
Discord
```

Kairos shall not require browser-page content inspection for MVP.

---

### FR-AA02: Expected Applications

**Priority:** Must

The user shall be able to associate expected applications with a focus
intention.

Example:

```text
Intention:
Work on Kairos requirements

Expected:
Visual Studio Code
Google Chrome
GitHub Desktop
```

---

### FR-AA03: Possible Attention Drift

**Priority:** Must

Kairos shall be able to identify a possible mismatch between the
current active application and the applications associated with the
user's intention.

A mismatch shall be treated as **possible attention drift**, not proof
of distraction.

Kairos shall not infer the user's cognitive state solely from the
active application.

---

### FR-AA04: User Correction

**Priority:** Must

When Kairos incorrectly identifies possible attention drift, the user
shall be able to correct the interpretation.

Example:

```text
Kairos:
Still working on your current task?

User:
Yes, this app is part of the task.
```

Kairos should allow the application to be added to the current
intention when appropriate.

---

## 7. Progressive Intervention

Kairos MVP shall use three intervention levels.

```text
Level 1
Ambient
        ↓
Level 2
Prompt
        ↓
Level 3
Focus Intervention
```

Escalation shall not automatically imply that the user has done
something wrong.

---

### FR-PI01: Level 1 Ambient Intervention

**Priority:** Must

Kairos shall provide a low-intensity visual indication when possible
attention drift is detected.

The indication should avoid unnecessarily interrupting the user's
current activity.

---

### FR-PI02: Level 2 Prompt

**Priority:** Must

If possible attention drift continues, Kairos shall be able to present
a direct prompt.

Example:

> Still working on your current task?

The user shall be able to respond without navigating through the full
application.

---

### FR-PI03: Level 3 Focus Intervention

**Priority:** Must

If the condition continues after lower intervention levels, Kairos
shall be able to present a more prominent intervention.

The intervention shall provide actions equivalent to:

```text
[ Return to Task ]
[ I Need More Time ]
[ Change My Plan ]
[ Dismiss ]
```

Exact wording will be determined during UX design.

---

### FR-PI04: User Intervention Control

**Priority:** Must

The user shall retain control over Kairos intervention behavior.

The MVP shall not:

- Lock the user out of applications.
- Prevent the user from dismissing Kairos.
- Force a full-screen takeover.
- Prevent the user from changing their plan.

Stronger intervention modes are deferred.

---

## 8. Attention Recovery

### FR-AR01: Preserve Task Context

**Priority:** Must

Kairos shall allow the user to preserve basic context for the current
activity.

Context may include:

- Current objective
- Short note
- Next intended action

This information should remain available if the user needs help
returning to the task.

---

### FR-AR02: Return to Intention

**Priority:** Must

When the user chooses to return after an intervention, Kairos shall
surface enough context to remind the user what they intended to do.

Kairos should support cognitive recovery rather than only returning
attention to an application.

---

### FR-AR03: Change Plan

**Priority:** Must

The user shall be able to indicate that their original intention is no
longer appropriate.

Kairos shall allow the plan to be changed without treating the change
as failure.

---

## 9. Transition Support

### FR-TR01: Transition Preparation

**Priority:** Must

Kairos shall begin preparing the user before the planned activity
ends.

The MVP transition flow shall support:

```text
10 minutes remaining
        ↓
5 minutes remaining
        ↓
Prepare to stop
        ↓
Preserve current context
        ↓
Planned time reached
```

---

### FR-TR02: End-of-Session Decision

**Priority:** Must

When the planned time is reached, Kairos shall allow the user to choose
an appropriate next action.

At minimum:

```text
[ Complete ]
[ Extend ]
[ Reschedule ]
```

Exact wording and presentation will be determined during UX design.

---

### FR-TR03: Preserve Unfinished Context

**Priority:** Must

If an activity is unfinished when its planned time ends, Kairos shall
allow the user to preserve enough context to resume it later.

At minimum, the user should be able to record:

- What remains unfinished.
- What should happen next.

---

## 10. Lightweight Planning

### FR-LP01: Basic Task Planning

**Priority:** Must

Kairos shall provide enough planning functionality to create and manage
focus intentions.

The MVP is not intended to replace a full task-management or
project-management system.

---

### FR-LP02: Basic Priority

**Priority:** Should

Kairos should allow a task to be assigned a simple priority.

Initial values may include:

```text
High
Medium
Low
```

Priority behavior will be refined during UX design.

---

### FR-LP03: Reschedule Incomplete Activity

**Priority:** Must

An unfinished activity shall be capable of being rescheduled rather
than discarded.

Automatic schedule reconstruction is not required for MVP.

---

## 11. Background Companion

### FR-BC01: Background Operation

**Priority:** Must

Kairos shall be capable of remaining active while the user works in
other applications.

The user shall not need to keep the primary Kairos window open for
core focus support to function.

---

### FR-BC02: Lightweight Desktop Presence

**Priority:** Must

Kairos shall provide a lightweight desktop presence capable of
displaying information such as:

- Current intention
- Remaining time
- Focus status
- Transition state

The final visual implementation will be defined during UX design and
technical architecture.

---

### FR-BC03: Prominent Intervention

**Priority:** Must

Kairos shall be capable of becoming more visually prominent when an
intervention reaches Level 3.

The intervention shall not become an unavoidable full-screen takeover
during MVP.

---

## 12. User Control and Privacy

### NFR-UP01: User-Controlled Awareness

**Priority:** Must

Application awareness shall require user permission.

The user shall be able to disable activity awareness.

---

### NFR-UP02: Minimize Observation

**Priority:** Must

Kairos shall collect or observe only the information necessary to
support enabled functionality.

MVP activity awareness shall focus on identifying the active
application.

Browser content inspection is outside MVP scope.

---

### NFR-UP03: Avoid Unsupported Inference

**Priority:** Must

Kairos shall not represent observed application activity as definitive
evidence of:

- Distraction
- ADHD symptoms
- Productivity
- Motivation
- Cognitive ability
- Mental state

Observed behavior should be presented as contextual information or
possible attention drift.

---

### NFR-UP04: User Override

**Priority:** Must

The user shall be able to override Kairos when its interpretation,
recommendation, or intervention does not match their intention.

---

## 13. Accessibility and Personalization

### NFR-AP01: Accessible Core Experience

**Priority:** Must

Core Kairos functionality shall be designed with accessibility as a
baseline requirement rather than a later enhancement.

Accessibility requirements will be expanded during UX and technical
design.

---

### NFR-AP02: Visual Customization Architecture

**Priority:** Should

The MVP architecture should support future visual themes without
requiring major restructuring.

A large theme library is not required for MVP.

---

### NFR-AP03: Age-Neutral Core Functionality

**Priority:** Must

Core functionality shall not assume cognitive ability based solely on
the user's age.

Age-specific experiences may later modify:

- Language
- Visual presentation
- Privacy
- Consent
- Guardian functionality

These experiences are outside the initial MVP unless separately
approved.

---

## 14. Reliability

### NFR-RL01: Background Stability

**Priority:** Must

Kairos shall remain stable during extended background operation.

A failure of the desktop companion should not interfere with normal
computer use.

---

### NFR-RL02: Safe Failure

**Priority:** Must

If Kairos fails, crashes, or loses activity-awareness capability, the
user's operating system and other applications shall remain usable.

Kairos shall never make normal computer access dependent upon the
application remaining operational.

---

### NFR-RL03: Resource Awareness

**Priority:** Must

Kairos shall be designed to avoid excessive:

- CPU usage
- Memory usage
- Battery consumption
- Disk activity

Specific performance thresholds will be established during technical
architecture and testing.

---

## 15. Explicitly Deferred From MVP

The following capabilities are outside the initial MVP unless later
requirements review determines otherwise:

- Browser-domain awareness
- Browser-content inspection
- AI task decomposition
- AI-generated schedules
- Automatic schedule reconstruction
- Personal Time Model
- Learned duration estimates
- Strict Focus
- Application blocking
- Website blocking
- Forced full-screen interventions
- Guardian dashboards
- Guardian monitoring
- Cross-device synchronization
- Mobile companion
- Calendar replacement
- Project-management replacement
- Diagnosis-based user modes
- Large theme marketplace
- Advanced communication personalities

Deferral does not mean these concepts have been rejected.

They remain candidates for future releases.

---

## 16. MVP Success Criteria

The MVP should allow the project to evaluate whether users can
successfully complete the following experience:

1. Define what they intend to work on.
2. Define how long they intend to work.
3. Begin working outside Kairos.
4. Remain aware of the current intention and time.
5. Receive progressive assistance after possible attention drift.
6. Correct Kairos when its interpretation is wrong.
7. Recover task context after distraction.
8. Receive preparation before the focus period ends.
9. Complete, extend, or reschedule the activity.
10. Preserve unfinished context for later continuation.

The MVP should not be considered successful solely because these
features technically function.

Future usability testing must evaluate whether the experience actually
helps users remain focused and manage their time more effectively.

---

## 17. Research Traceability

These requirements are informed by the existing Kairos research
foundation.

### Product Research

- [User Groups](../01-research/USER_GROUPS.md)
- [User Needs](../01-research/USER_NEEDS.md)
- [Research Questions](../01-research/RESEARCH_QUESTIONS.md)
- [Assumptions and Hypotheses](../01-research/ASSUMPTIONS_AND_HYPOTHESES.md)

### External Research

- [Executive Function Research](../01-research/EXECUTIVE_FUNCTION_RESEARCH.md)

### Market Research

- [Competitive Research](../01-research/COMPETITIVE_RESEARCH.md)

Detailed requirement-to-research mapping will be maintained in:

[Requirements Traceability](REQUIREMENTS_TRACEABILITY.md)

---

## 18. Current MVP Definition

The Kairos MVP is a persistent desktop focus companion that helps the
user maintain the relationship between:

```text
Intention
    ↕
Attention
    ↕
Time
```

The MVP accomplishes this through five core capabilities:

1. Focus intention
2. Time awareness
3. Basic application awareness
4. Progressive intervention
5. Attention recovery and transition support

Everything else should justify its inclusion by demonstrating that it
is necessary to validate this core experience.
