# Kairos Interaction Model

**Document Status:** Draft  
**Version:** 0.1  
**Last Updated:** August 2026  
**Product:** Kairos  
**Document Owner:** UX

---

## 1. Purpose

This document defines how Kairos should behave while supporting a user
during the MVP focus experience.

It describes:

- Presence states
- Intervention levels
- Escalation behavior
- User responses
- Transition behavior
- Dismissal behavior
- Recovery behavior

This document does not define final visual design.

Exact colors, typography, animation, layout, themes, and illustration
belong in the design phase.

---

## 2. Interaction Goal

Kairos should provide enough support to help the user without becoming
a new source of distraction.

The interaction model should balance:

```text
Awareness
    +
Support
    +
User control
    +
Low interruption
```

Kairos should become more prominent only when the current context
justifies greater intervention.

---

## 3. Presence Model

Kairos MVP uses the following primary states:

```text
Idle
  ↓
Companion
  ↓
Ambient
  ↓
Prompt
  ↓
Intervention
```

Transition behavior exists alongside these states when the current
focus period approaches its planned end.

---

## 4. State IM-01: Idle

### Purpose

Kairos is available, but no focus session is active.

### Kairos Behavior

Kairos may provide access to:

- Start Focus Session
- Previous unfinished activity
- Basic settings
- Activity-awareness controls

Kairos should not perform attention-drift intervention while no focus
session is active.

### Exit Conditions

The state ends when the user:

- Starts a focus session.
- Resumes a previous activity.

---

## 5. State IM-02: Companion

### Purpose

Provide continuous awareness without demanding attention.

### Kairos Behavior

The companion should make basic focus information available.

At minimum:

- Current intention
- Remaining time

Optional information may include:

- Current priority
- Session status

### Interaction Characteristics

The Companion state should be:

- Lightweight
- Persistent
- Quickly understandable
- Non-blocking
- Easily accessible

The user should not need to interact with Kairos simply because a focus
session is active.

---

## 6. State IM-03: Ambient Intervention

### Purpose

Provide the lowest-intensity signal that Kairos has detected possible
attention drift.

### Entry Condition

The active application does not match the applications expected for the
current focus intention.

This is considered:

> Possible attention drift

It is not considered confirmed distraction.

### Kairos Behavior

The companion may increase its visual salience without requiring an
immediate response.

Potential behavior may include:

- Visual state change
- Subtle animation
- Small status indicator

Final behavior will be determined during design and usability testing.

### Interaction Characteristics

Ambient intervention should:

- Avoid stealing keyboard focus.
- Avoid blocking application content.
- Avoid requiring immediate action.
- Avoid implying failure.
- Remain easy to ignore when the user is still intentionally working.

---

## 7. State IM-04: Prompt

### Purpose

Request clarification when possible attention drift continues.

### Entry Condition

The possible drift condition remains after the Ambient state.

Exact escalation timing is not yet defined.

### Example Prompt

> Still working on your current task?

### User Actions

The prompt should provide actions equivalent to:

```text
[ Yes ]
[ Return to Task ]
[ Change My Plan ]
[ Dismiss ]
```

Exact wording may change during design.

### Yes

The user indicates that the current application is relevant.

Kairos should:

1. Accept the correction.
2. Return to Companion state.
3. Optionally allow the application to become expected for the current
   focus session.

### Return to Task

Kairos moves into attention recovery.

### Change My Plan

Kairos opens the plan-change flow.

### Dismiss

The prompt closes.

Dismissal does not establish whether the user is distracted.

---

## 8. State IM-05: Focus Intervention

### Purpose

Provide stronger assistance after lower-intensity interventions have
not resolved the possible attention-drift condition.

### Entry Condition

The condition continues after the Prompt state.

Exact escalation rules require usability validation.

### User Actions

The MVP intervention should provide actions equivalent to:

```text
[ Return to Task ]
[ I Need More Time ]
[ Change My Plan ]
[ Dismiss ]
```

### Interaction Characteristics

The intervention may be more visually prominent than the normal
companion.

It must remain:

- Dismissible
- Non-blocking
- Keyboard accessible
- Screen-reader accessible
- User controlled

The intervention must not prevent access to the operating system or
other applications.

---

## 9. Escalation Model

The MVP progressive intervention model is:

```text
Possible drift detected
        ↓
Ambient
        ↓
Condition continues
        ↓
Prompt
        ↓
Condition continues
        ↓
Focus Intervention
```

The following remain unresolved:

- Time between levels
- Whether escalation pauses after user interaction
- Whether repeated dismissals alter timing
- Whether activity type influences timing

These should be determined through prototype testing.

---

## 10. De-Escalation

Kairos should return toward lower-intensity states when the reason for
intervention no longer exists.

Examples include:

```text
User returns to expected application
        ↓
Return to Companion
```

or:

```text
User corrects Kairos
        ↓
Return to Companion
```

or:

```text
User changes plan
        ↓
Reevaluate current context
        ↓
Return to appropriate state
```

Kairos should not remain visually escalated unnecessarily.

---

## 11. Correction Model

Kairos must treat user correction as authoritative.

Example:

```text
Kairos:
Chrome may not match your task.

User:
Chrome is part of this task.

Kairos:
Correction accepted.
```

The user should not need to repeatedly defend the same intentional
behavior during a focus session.

### Session-Level Learning

For MVP, Kairos may allow the user to add the current application to the
expected applications for that session.

Long-term behavioral learning is deferred.

---

## 12. Attention Recovery Model

When the user chooses to return to the intended activity, Kairos should
help restore task context.

The recovery surface should prioritize information such as:

```text
Current intention

Current objective

Next intended action

Remaining time
```

The recovery experience should answer:

> What was I doing, and what should I do next?

The purpose is not simply to close the intervention.

---

## 13. Plan Change Model

Users must be able to intentionally change plans during an active focus
session.

A plan change may include:

- Changing the focus intention
- Adjusting planned duration
- Ending the current activity
- Preserving unfinished context
- Rescheduling the activity

Kairos should treat these changes as valid adjustments.

The interface should avoid language that frames a plan change as
failure or noncompliance.

---

## 14. Time Awareness Model

Remaining time should be available throughout an active focus session.

The user should not need to open the main Kairos application to check
time.

Time-awareness presentation may eventually include:

- Countdown
- Visual progress
- Clock relationship
- Transition proximity

The MVP must support understandable remaining-time awareness.

The final representation will be determined during design.

---

## 15. Transition Model

Transition support begins before the planned focus period ends.

Initial MVP timing:

```text
10 minutes remaining
        ↓
Low-intensity transition cue
        ↓
5 minutes remaining
        ↓
Stronger preparation cue
        ↓
Planned end reached
        ↓
Session decision
```

Transition cues should help the user prepare to disengage.

They should encourage actions such as:

- Finish the current step.
- Save work.
- Record the next action.
- Prepare for the next responsibility.

---

## 16. Session-End Model

When planned focus time reaches zero, Kairos should request a user
decision.

Available actions should include:

```text
[ Complete ]
[ Extend ]
[ Reschedule ]
```

### Complete

Ends the focus session and records completion.

### Extend

Adds additional time and returns the session to Companion state.

### Reschedule

Preserves unfinished context and allows the activity to be continued
later.

Kairos should not automatically mark an unfinished activity as failed.

---

## 17. Dismissal Model

Dismissal means:

> Stop showing this intervention right now.

Dismissal does not automatically mean:

- The user is distracted.
- The user rejected the task.
- The user no longer wants support.
- The user failed the focus session.

For MVP, dismissal returns Kairos to a lower-intensity state.

Repeated-dismissal behavior remains an open UX question.

---

## 18. Activity Awareness Disabled

If application awareness is disabled:

```text
Active application observation
        ↓
OFF
```

Kairos should still support:

- Focus intentions
- Remaining time
- Manual task context
- Transition warnings
- Complete / Extend / Reschedule
- Companion presence

Progressive intervention based on active-application mismatch is
disabled.

---

## 19. Focus and Keyboard Behavior

Kairos should avoid unexpectedly stealing focus from the user's active
application.

Ambient states should never require focus.

Prompts and interventions should only request focus when necessary for
interaction.

Core actions should be keyboard accessible.

Users should be able to:

- Navigate interactive controls using the keyboard.
- Understand which control currently has focus.
- Dismiss supported surfaces without requiring a mouse.

---

## 20. Accessibility Behavior

Important information should not rely exclusively on:

- Color
- Sound
- Animation
- Position

Kairos should support multiple perceivable cues when necessary.

Custom companion and intervention surfaces must preserve accessibility
semantics.

Accessibility validation should include:

- Keyboard navigation
- Visible focus
- Windows Narrator
- Appropriate UI Automation exposure

Detailed visual accessibility standards will be defined during design.

---

## 21. Motion and Sensory Behavior

Animation may support awareness but should not be required to
understand Kairos state.

Future settings should allow users to reduce or disable non-essential
motion.

Sounds should not be the only indicator of important state changes.

Sensory personalization will be explored further during design and
usability testing.

---

## 22. Interaction State Summary

| State        | User Attention Requested | Prominence         | Response Required |
| ------------ | ------------------------ | ------------------ | ----------------- |
| Idle         | Low                      | Low                | No                |
| Companion    | Low                      | Low                | No                |
| Ambient      | Low                      | Slightly increased | No                |
| Prompt       | Moderate                 | Medium             | Preferred         |
| Intervention | High                     | High               | Preferred         |
| Transition   | Contextual               | Increasing         | Sometimes         |
| Session End  | High                     | High               | Yes               |

"High" prominence does not mean blocking the user's computer.

---

## 23. Open UX Questions

The following questions require prototyping or user testing:

1. How long should Kairos wait before entering Ambient state?
2. How long should Ambient remain before Prompt?
3. How long should Prompt remain before Intervention?
4. Should escalation timing vary by user preference?
5. How prominent should Ambient state be?
6. What should happen after repeated dismissal?
7. Should returning to an expected application automatically clear an
   intervention?
8. How should transition warnings interact with active interventions?
9. How much task context should the recovery surface display?
10. What default companion size and placement works best?

These questions should not be resolved through assumption alone.

---

## 24. Deferred Interaction Models

The following interaction models are outside the MVP:

- Strict Focus
- Application blocking
- Website blocking
- Guardian intervention
- AI scheduling
- AI task decomposition
- Domain-aware attention detection
- Cross-device intervention
- Mobile companion behavior

Future releases should define separate interaction requirements before
implementation.

---

## 25. Related Documentation

### UX

- [User Flows](USER_FLOWS.md)

### Requirements

- [Product Requirements](../02-requirements/PRODUCT_REQUIREMENTS.md)
- [MVP Scope](../02-requirements/MVP_SCOPE.md)

### Architecture

- [Technical Stack](../05-architecture/TECH_STACK.md)
- [Architecture Decisions](../05-architecture/ARCHITECTURE_DECISIONS.md)

### Research

- [Research Questions](../01-research/RESEARCH_QUESTIONS.md)
- [Executive Function Research](../01-research/EXECUTIVE_FUNCTION_RESEARCH.md)
