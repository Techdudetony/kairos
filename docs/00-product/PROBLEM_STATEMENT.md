# Kairos Problem Statement

**Document Status:** Draft
**Version:** 0.1
**Last Updated:** August 2026
**Product:** Kairos
**Document Owner:** Product

---

## 1. Purpose

This document defines the primary problems Kairos intends to address.

The purpose of the problem statement is to establish the user problems that justify the development of Kairos without assuming that any specific feature or technical solution is required.

Product requirements and features should be evaluated according to whether they meaningfully address the problems defined here.

---

## 2. Problem Summary

Computer-based activities often require users to independently manage their attention, priorities, time, and transitions within the same environment that also provides significant opportunities for distraction.

For users who experience executive-function challenges, this can create difficulty maintaining intentional control over what receives their attention and for how long.

Kairos is primarily concerned with three related problem areas:

1. Determining what should receive attention first.
2. Recovering the original intention after becoming distracted.
3. Recognizing when sustained attention has become hyperfocus and transitioning away from the activity when necessary.

Although these problems can appear very different, they share a common consequence:

> **The user may lose intentional control over how their attention and available time are being directed.**

---

## 3. Problem Area: Prioritization

### The Problem

A user may understand that several activities need to be completed without being able to easily determine which activity should receive their attention first.

For example, a user may know that they need to:

- Complete homework
- Study for an upcoming test
- Clean their room
- Respond to a message
- Take a shower
- Continue a personal project

Knowing that these responsibilities exist does not automatically make their relative priority clear.

The user may need to consider:

- Importance
- Urgency
- Deadlines
- Estimated duration
- Available time
- Dependencies
- Required effort
- Scheduled commitments
- Personal priorities

Evaluating these factors can itself create cognitive overhead.

### Consequences

Difficulty determining what should be done first may result in:

- Delayed tasks
- Improper prioritization
- Important work being postponed
- Less important activities receiving attention first
- Increasing backlog of responsibilities
- Difficulty beginning any task
- Available time being used inefficiently

### User Need

Users need support identifying what deserves their attention now without surrendering control over their priorities.

---

## 4. Problem Area: Distraction and Attention Recovery

### The Problem

A user may begin an activity with a clear intention and later become distracted by another application, website, notification, thought, or activity.

The distraction itself may be brief.

The larger problem occurs when the user loses awareness of the original intention.

A typical sequence may resemble:

1. Begin an intended task.
2. Encounter something requiring another application or website.
3. Notice an unrelated activity.
4. Shift attention to the unrelated activity.
5. Continue following additional distractions.
6. Lose awareness of the original task.
7. Eventually recognize that significant time has passed.

The user may then need to reconstruct:

- What they were doing
- Why they were doing it
- Where they stopped
- What should happen next
- How much time remains

This creates additional friction before productive activity can resume.

### Consequences

Distraction and loss of task context may result in:

- Incomplete tasks
- Running out of available time
- Repeated task restarting
- Lost progress
- Missed deadlines
- Reduced concentration
- Increased cognitive overhead
- Difficulty returning to the original activity

### User Need

Users need support maintaining awareness of their current intention and quickly recovering task context after distraction occurs.

The goal should not necessarily be to eliminate every distraction.

The goal is to make distraction less capable of permanently disconnecting the user from what they intended to accomplish.

---

## 5. Problem Area: Hyperfocus and Disengagement

### The Problem

Difficulty regulating attention does not always mean difficulty maintaining attention.

A user may become deeply engaged in an activity and have difficulty recognizing when they should stop, pause, or transition to another responsibility.

During periods of hyperfocus, the user may have reduced awareness of:

- Passing time
- Scheduled activities
- Other responsibilities
- Breaks
- Meals
- Physical discomfort
- Fatigue
- Sleep schedules
- The need to transition

The activity receiving attention may itself be productive or important.

The problem is not the existence of deep focus.

The problem occurs when the user has difficulty intentionally disengaging from that focus when another need should receive attention.

### Consequences

Difficulty disengaging from hyperfocus may result in:

- Missed tasks
- Missed scheduled activities
- Delayed responsibilities
- Mental fatigue
- Physical fatigue
- Inadequate breaks
- Disrupted routines
- Reduced awareness of other priorities

### User Need

Users need support maintaining awareness of time and upcoming responsibilities while deeply engaged in an activity.

They also need assistance preparing for and completing transitions without unnecessarily disrupting beneficial periods of deep focus.

---

## 6. Shared Underlying Problem

Prioritization difficulty, distraction, and hyperfocus can appear to represent different attention problems.

In practice, they can be understood as different points where the user's intentions and actual attention become misaligned.

### Prioritization

The user has not yet determined where attention should go.

```text
Multiple Responsibilities
        ↓
Which matters now?
        ↓
Difficulty choosing
        ↓
Delayed or incorrect priority
```

### Distraction

The user determined where attention should go but unintentionally lost that direction.

```text
Intended Activity
        ↓
Distraction
        ↓
Loss of Task Context
        ↓
Incomplete Activity
```

### Hyperfocus

The user successfully directed attention but has difficulty redirecting it when circumstances change.

```text
Intended Activity
        ↓
Deep Focus
        ↓
Difficulty Disengaging
        ↓
Missed Transition
```

The shared challenge is therefore not simple "focus."

It is the ability to **intentionally direct, maintain, recover, and redirect attention over time.**

---

## 7. Supporting Problems

Kairos may need to address several supporting problems in order to
meaningfully address the three primary problem areas.

### Time Awareness

Users may have difficulty recognizing how much time has passed or how
much time remains.

### Task Initiation

Knowing what should be done does not always make beginning the task easy.

### Working Memory

Users may lose track of intentions, intermediate steps, or thoughts while switching between activities.

### Time Estimation

Users may have difficulty estimating how long activities will realistically require.

### Task Decomposition

Large or vague responsibilities may be difficult to translate into
clear next actions.

### Transition Management

Moving from one activity to another may require preparation and
additional cognitive effort.

### Schedule Recovery

When one activity takes longer than expected, users may struggle to
determine how the remainder of their schedule should change.

These supporting problems should not automatically become independent
product features.

Features should be introduced when they meaningfully contribute to
the primary user problems or other validated user needs.

---

## 8. Why Existing Computer Environments Can Amplify the Problem

Modern computers combine many different activities within a single
environment.

The same device may simultaneously provide access to:

- School
- Work
- Communication
- Research
- Entertainment
- Games
- Social media
- Creative tools
- Personal projects
- Administrative responsibilities

Moving from an intended activity to an unrelated activity may require
only a click, keyboard shortcut, notification, or browser tab.

This creates an environment where productive tools and potential
distractions exist immediately beside one another.

Traditional productivity tools may also depend heavily on the user
remembering to:

- Open the productivity application
- Review their tasks
- Determine priorities
- Start a timer
- Monitor the timer
- Notice upcoming commitments
- Recognize distraction
- Return to the original task
- Reorganize the schedule when plans change

For users already experiencing difficulty in these areas, managing the
productivity system can itself become another responsibility.

---

## 9. Product Opportunity

There is an opportunity to create a system that participates more
directly in the desktop experience while preserving user autonomy.

Rather than requiring users to repeatedly check a separate
productivity application, Kairos can explore ways to maintain
appropriate awareness of:

- Current intention
- Current priority
- Available time
- Upcoming transitions
- Potential distraction
- Extended periods of focus

The product opportunity is not to control how users spend their time.

It is to help users maintain awareness of how their actual attention
relates to their intended attention.

---

## 10. Problem Statement

> **Neurodivergent users and others who experience executive-function
> challenges may struggle to intentionally direct and regulate their
> attention while using a computer. Difficulty prioritizing competing
> responsibilities can delay important tasks. Distractions can cause
> users to lose awareness of their original intentions and run out of
> available time. Deep focus can become difficult to disengage from,
> contributing to missed responsibilities and mental or physical
> fatigue. Existing productivity tools often require users to
> independently recognize and manage these attention transitions,
> creating additional cognitive overhead for the same users those
> tools intend to support.**

Kairos seeks to explore how a user-controlled desktop companion can
reduce this gap between intended attention and actual attention
without removing user autonomy.

---

## 11. What Kairos Is Not Attempting to Solve

Kairos should not position itself as a universal solution for every
challenge associated with neurodivergence or executive functioning.

Kairos is not intended to:

- Diagnose ADHD, autism, or other conditions.
- Provide medical or psychological treatment.
- Replace professional healthcare.
- Eliminate all distractions.
- Force users to remain productive.
- Determine a user's priorities without their input.
- Prevent users from changing their plans.
- Maximize the amount of time users spend working.
- Guarantee task completion.

The product should remain focused on supporting users in managing
their intentions, attention, time, and transitions while preserving
their ability to make their own decisions.

---

## 12. Problem-Solution Boundary

This document intentionally describes problems more extensively than
solutions.

Specific solutions such as:

- Widgets
- Focus modes
- Application restrictions
- Website restrictions
- AI task decomposition
- Personal time models
- Rescue Mode
- Progressive interventions

should be validated separately through product requirements, user
research, UX design, and technical feasibility analysis.

A proposed solution should not be considered necessary simply because
it has already been discussed during product discovery.

The problem should remain stable even if the eventual solution
changes.

---

## 13. Success Direction

Kairos should ultimately reduce the frequency or impact of situations
where users:

- Do not know what deserves their attention first.
- Lose their original intention after becoming distracted.
- Fail to return to an incomplete task.
- Discover too late that available time has been exhausted.
- Remain deeply focused beyond an intended stopping point.
- Miss other responsibilities because they did not transition.
- Experience unnecessary fatigue from extended periods without
  appropriate breaks.

The exact measurements used to evaluate these outcomes will be
defined during product requirements and research planning.
