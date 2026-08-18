# Kairos MVP Scope

**Document Status:** Draft  
**Version:** 0.1  
**Last Updated:** August 2026  
**Product:** Kairos

---

## 1. MVP Goal

The Kairos MVP will test whether a persistent desktop companion can
help users maintain and recover their intended focus while using their
computer.

The MVP focuses on the relationship between:

```text
Intention ↔ Attention ↔ Time
```

The goal is to validate the core Kairos experience before introducing
advanced automation, AI, scheduling, or personalization.

---

## 2. Target Platform

The initial MVP will target:

**Windows desktop**

Other platforms may be considered after the core experience is
validated.

### Deferred Platforms

- macOS
- Linux
- Android
- iOS
- Web

---

## 3. MVP Core Capabilities

### 3.1 Focus Intention

Users can:

- Define what they intend to work on.
- Set a planned duration.
- Add basic task context.
- Associate expected applications.
- Complete, extend, edit, or reschedule the activity.

---

### 3.2 Time Awareness

Kairos provides:

- Remaining-time awareness.
- 10-minute transition warning.
- 5-minute transition warning.
- End-of-session notification.
- Time-extension controls.

---

### 3.3 Application Awareness

With user permission, Kairos can:

- Identify the active desktop application.
- Compare it with expected applications.
- Detect possible attention drift.
- Allow the user to correct incorrect interpretations.

Kairos will not inspect browser content during MVP.

---

### 3.4 Progressive Intervention

MVP supports three intervention levels:

```text
Level 1: Ambient
        ↓
Level 2: Prompt
        ↓
Level 3: Focus Intervention
```

The user remains able to dismiss or override Kairos.

---

### 3.5 Attention Recovery

Kairos can preserve basic task context including:

- Current objective
- Short note
- Next intended action

This information can be surfaced when the user returns to an
interrupted activity.

---

### 3.6 Transition Support

Kairos helps the user prepare for the end of a focus period.

At the end of the planned period, the user can:

- Complete the activity.
- Extend the activity.
- Reschedule the activity.

Unfinished context can be preserved for later continuation.

---

### 3.7 Background Companion

Kairos can:

- Run while other applications are active.
- Maintain a lightweight desktop presence.
- Display the current intention.
- Display remaining time.
- Increase visibility during intervention.

The primary Kairos window does not need to remain open.

---

## 4. MVP User Control

The MVP shall preserve user authority.

Users can:

- Disable application awareness.
- Correct Kairos.
- Dismiss interventions.
- Change their current plan.
- Extend focus time.
- End a focus session early.

Kairos will not force the user to continue an outdated plan.

---

## 5. Explicitly Out of Scope

The following capabilities are not part of the initial MVP.

### Advanced Awareness

- Browser-domain awareness
- Browser-content inspection
- Screen-content analysis
- Keystroke monitoring

### Advanced Focus Controls

- Application blocking
- Website blocking
- Strict Focus
- Forced full-screen intervention

### AI and Learning

- AI task decomposition
- AI-generated schedules
- Personal Time Model
- Learned duration estimates
- Behavioral prediction

### Advanced Planning

- Automatic schedule reconstruction
- Full calendar management
- Full project management
- Complex prioritization engine

### Ecosystem

- Mobile companion
- Cross-device synchronization
- Calendar integrations
- Task-manager integrations

### Youth Features

- Guardian dashboard
- Guardian monitoring
- Guardian-managed restrictions

### Advanced Personalization

- Large theme library
- Theme marketplace
- Advanced communication personalities

These capabilities may be considered in future releases.

---

## 6. MVP Privacy Boundary

The MVP should observe the minimum information necessary to provide its
core functionality.

For activity awareness, Kairos needs to know:

```text
Which application is currently active?
```

The MVP does not need to know:

```text
What is the user typing?

What is displayed on the screen?

What webpage content are they reading?

What messages are they sending?
```

Application awareness must be transparent and user-controlled.

---

## 7. MVP Success

The MVP should allow a user to complete this flow:

```text
Create intention
        ↓
Begin focus period
        ↓
Work outside Kairos
        ↓
Maintain time awareness
        ↓
Possible attention drift
        ↓
Progressive intervention
        ↓
Return or correct Kairos
        ↓
Recover task context
        ↓
Prepare for transition
        ↓
Complete / Extend / Reschedule
```

Technical completion of this flow is necessary but not sufficient.

User testing must later determine whether Kairos actually helps users:

- Maintain focus.
- Recover from distraction.
- Manage time.
- Transition between activities.
- Accomplish intended work.

---

## 8. MVP Guardrail

When considering a new MVP feature, ask:

> Does this feature directly help validate the relationship between
> intention, attention, and time?

If the answer is no, the feature should normally be deferred.

If the answer is uncertain, the feature should return to research
rather than automatically entering MVP scope.

---

## 9. Related Documentation

### Requirements

- [Product Requirements](PRODUCT_REQUIREMENTS.md)
- [Requirements Traceability](REQUIREMENTS_TRACEABILITY.md)

### Research

- [User Needs](../01-research/USER_NEEDS.md)
- [Research Questions](../01-research/RESEARCH_QUESTIONS.md)
- [Assumptions and Hypotheses](../01-research/ASSUMPTIONS_AND_HYPOTHESES.md)
- [Executive Function Research](../01-research/EXECUTIVE_FUNCTION_RESEARCH.md)
- [Competitive Research](../01-research/COMPETITIVE_RESEARCH.md)
