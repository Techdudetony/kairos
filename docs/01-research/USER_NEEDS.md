# Kairos User Needs

**Document Status:** Draft  
**Version:** 0.1  
**Last Updated:** August 2026  
**Product:** Kairos  
**Document Owner:** Product / Research

---

## 1. Purpose

This document defines the initial user needs Kairos intends to investigate through research.

The needs described here are based on the current product foundation and initial user-group hypotheses.

They should not yet be treated as validated research findings.

The purpose of documenting these needs before formal research is to make current assumptions explicit and testable.

Research may:

- Validate a need.
- Reject a need.
- Change its importance.
- Reveal differences between user groups.
- Reveal additional needs.
- Show that multiple needs should be combined.
- Show that one need should be separated into several needs.

Validated needs will later inform product requirements and MVP prioritization.

---

## 2. User Need Format

Kairos will generally express user needs using the following format:

> **When [context], I need [need], so that [desired outcome].**

For example:

> When I have several competing responsibilities, I need help understanding what deserves my attention first, so that I can begin meaningful work without spending excessive time deciding.

This format intentionally avoids specifying how Kairos should solve the problem.

A user need should describe the desired outcome rather than a specific feature.

---

## 3. Need Classification

Initial needs are organized into three levels.

### Primary Needs

Needs directly associated with the primary Kairos problem ares:

- [Prioritization](#4-primary-need-prioritization)
- [Attention Recovery](#5-primary-need-attention-recovery)
- [Hyperfocus and Disengagement](#6-primary-need-hyperfocus-and-disengagement)

### Supporting Needs

Needs that may contribute significantly to solving the primary problems.

Examples include:

- [Time Awareness](#7-supporting-need-time-awareness)
- [Task Initiation](#8-supporting-need-task-initiation)
- [Planning](#9-supporting-need-task-decomposition)
- [Transition Preparation](#11-supporting-need-transition-preparation)
- [Schedule Recovery](#12-supporting-need-schedule-recovery)

### Foundational Experience Needs

Needs that determine whether users can trust, understand, configure, and comfortably use Kairos.

Examples include:

- [Autonomy](#13-foundational-need-user-autonomy)
- [Privacy](#15-foundational-need-privacy)
- [Accessibility](#17-foundational-need-accessibility)
- [Personalization](#14-foundational-need-personalization)
- [Explainability](#16-foundational-need-explainability)

The classification does not represent final product priority.

Research should help determine actual importance.

---

## 4. Primary Need: Prioritization

### Context

Users may have multiple responsibilities competing for attention.

Knowing that several activities need to happen does not necessarily make their relative priority clear.

### Need Statement

> **When I have multiple competing responsibilities, I need help understanding what deserves my attention first, so that I can begin without unnecessarily delaying important work.**

### Potential Outcomes

Meeting this need may help users:

- Begin important work sooner.
- Reduce time spent deciding.
- Avoid completing low-priority work first.
- Better understand competing deadlines.
- Reduce task backlog.
- Feel less overwhelmed by competing responsibilities.

### Research Questions

Research should determine:

- How users currently decide what to do first.
- Which factors influence priority.
- How often prioritization becomes difficult.
- Whether difficulty choosing leads to task avoidance.
- Whether users want recommendations or decision-making frameworks.
- How much control users want over prioritization assistance.
- How users respond when they disagree with a recommendation.

### Current Confidence

**Medium**

Prioritization is central to the current product hypotheses, but the specific circumstances and desired forms of assistance require validation.

---

## 5. Primary Need: Attention Recovery

### Context

Users may begin an activity with a clear intention and later become distracted.

After attention shifts, the user may lose track of:

- What they were doing
- Why they were doing it
- Where they stopped
- What should happen next

### Need Statement

> **When my attention unintentionally shifts away from what I intended to do, I need a low-friction way to recover my original intention, so that a distraction does not unnecessarily become an abandoned task.**

### Potential Outcomes

Meeting this need may help users:

- Return to incomplete activities.
- Reduce task abandonment.
- Resume work more quickly.
- Preserve task context.
- Reduce repeated restarting.
- Make distractions less disruptive.

### Research Questions

Research should determine:

- What commonly causes attention shifts.
- How users recognize they have become distracted.
- How long distractions typically continue.
- What information helps users resume work.
- Whether reminders during distraction are helpful.
- When reminders become annoying.
- Whether users want Kairos to recognize attention drift automatically.
- What activity information users are comfortable allowing Kairos to observe.

### Current Confidence

**High**

Attention recovery is one of the strongest current product hypotheses.

The existence of the need should still be validated with users, while the appropriate intervention strategy remains open.

---

## 6. Primary Need: Hyperfocus and Disengagement

### Context

Users may become deeply engaged in an activity and have difficulty recognizing when they should pause, stop, or transition.

The activity may itself be productive.

The problem occurs when continued engagement conflicts with another intention or need.

### Need Statement

> **When I become deeply focused on an activity, I need help remaining aware of time and upcoming responsibilities, so that I can intentionally decide when to continue, pause, or transition.**

### Potential Outcomes

Meeting this need may help users:

- Miss fewer responsibilities.
- Recognize intended stopping points.
- Take appropriate breaks.
- Reduce mental fatigue.
- Reduce physical faitgue.
- Prepare for upcoming activities.
- Preserve the benefits of deep concentration.

### Research Questions

Research should determine:

- How users describe deep focus.
- Whether users distinguish deep focus from hyperfocus.
- How users currently recognize that too much time has passed.
- Which responsibilities are commonly missed.
- How users respond to interruptions while deeply focused.
- What amount of advance warning helps.
- Whether intervention should change during deep focus.
- How users want Kairos to distinguish productive focus from a problem requiring intervention.

### Current Confidence

**High**

The product foundation identifies hyperfocus and disengagement as a primary problem.

The appropriate language, detection methods, and intervention behavior require significant validation.

---

## 7. Supporting Need: Time Awareness

### Context

Users may have difficulty maintaining awareness of passing time while engaged in computer activities.

### Need Statement

> **When I am engaged in an activity, I need understandable awareness of how much time has passed and how much time remains, so that time does not pass without me realizing it.**

### Potential Outcomes

Meeting this need may help users:

- Better pace activities.
- Recognize upcoming transitions.
- Avoid unexpectedly running out of time.
- Make more informed decisions about continuing an activity.

### Research Questions

Research should determine:

- Whether clocks and timers provide sufficient awareness.
- Which representations of time users understand most easily.
- Whether persistent time displays help or distract.
- How frequently time information should be surfaced.
- Whether different activities require different approaches.

### Current Confidence

**High**

Time awareness appears strongly connected to both distraction and hyperfocus.

---

## 8. Supporting Need: Task Initiation

### Context

A user may know what needs to be completed and still experience difficulty beginning.

### Need Statement

> **When I know what I need to accomplish but have difficulty beginning, I need help reducing the effort required to take the first meaningful action.**

### Potential Outcomes

Meeting this need may help users:

- Begin tasks sooner.
- Reduce avoidance.
- Reduce planning paralysis.
- Turn intentions into actions.

### Research Questions

Research should determine:

- Why users delay beginning known tasks.
- Whether the first step is usually clear.
- Whether task size affects initiation.
- Whether emotional factors affect initiation.
- Which existing strategies users use.
- Whether external prompting helps.
- When prompting creates additional pressure.

### Current Confidence

**Medium**

Task initiation is relevant to the broader problem space but has not yet been established as one of the three primary Kairos problems.

---

## 9. Supporting Need: Task Decomposition

### Context

Some responsibilities describe an outcome without providing an obvious sequence of actions.

Examples include:

> Clean my room.

> Study for my exam.

> Work on my portfolio.

### Need Statement

> **When a responsibility feels too large or vague to begin, I need help identifying manageable next actions, so that I can turn the intention into something I can start.**

### Potential Outcomes

Meeting this need may help users:

- Begin vague tasks.
- Reduce overwhelm.
- Improve planning.
- Better estimate required time.
- Track meaningful progress.

### Research Questions

Research should determine:

- Which tasks users consider vague.
- Whether users naturally break tasks into steps.
- How detailed task breakdowns should be.
- Whether too many steps create additional overwhelm.
- Whether users want suggested steps.
- How frequently suggested steps require correction.

### Current Confidence

**Medium**

Task decomposition may strongly support initiation and planning, but the desired level of assistance requires validation.

---

## 10. Supporting Need: Time Estimation

### Context

Users may underestimate or overestimate how long activities will require.

### Need Statement

> **When planning an activity, I need a realistic understanding of how much time it may require, so that I can create a schedule that is more likely to work.**

### Potential Outcomes

Meeting this need may help users:

- Build more realistic schedules.
- Reduce schedule disruption.
- Improve transition planning.
- Allocate appropriate buffer time.
- Learn from previous experiences.

### Research Questions

- How users currently estimate duration.
- Which activities are hardest to estimate.
- How frequently estimates differ from actual duration.
- Whether users review previous task durations.
- Whether contextual factors meaningfully change duration.
- Whether personalized estimates would be trusted.

### Current Confidence

**Medium**

This need supports the long-term Personal Time Model hypothesis but requires substantial validation before advanced implementation.

---

## 11. Supporting Need: Transition Preparation

### Context

Stopping one activity and beginning another may require preparation.

A calendar notification at the exact start time may arrive too late.

### Need Statement

> **When another responsibility is approaching, I need enough warning and context to prepare for the transition, so that I can disengage from my current activity and begin the next one more intentionally.**

### Potential Outcomes

Meeting this need may help users:

- Arrive at commitments on time.
- Save work before transitioning.
- Reduce abrupt interruptions.
- Preserve unfinished task context.
- Mentally prepare for the next activity.

### Research Questions

Research should determine:

- How much advance notice users need.
- Whether transition time varies by activity.
- What preparation users commonly require.
- Whether multiple reminders help.
- When transition reminders become disruptive.
- How deep focus changes transition needs.

### Current Confidence

**High**

Transition difficulty directly intersects with the current hyperfocus problem hypothesis.

---

## 12. Supporting Need: Schedule Recovery

### Context

Schedules frequently stop matching reality.

An activity may take longer than expected, start late, or be
interrupted.

### Need Statement

> **When my original plan no longer fits the time I have available, I
> need help understanding what can realistically happen next, so that
> one disruption does not make the rest of my plan feel unusable.**

### Potential Outcomes

Meeting this need may help users:

- Reprioritize remaining work.
- Reduce schedule abandonment.
- Recover after interruptions.
- Create more realistic plans.
- Reduce overwhelm when falling behind.

### Research Questions

Research should determine:

- What users currently do when schedules fall behind.
- Whether users manually reschedule unfinished activities.
- When users abandon their plan entirely.
- Which information is needed to recover.
- Whether users want automatic suggestions.
- How much control users want over schedule changes.

### Current Confidence

**Medium**

The current Rescue Mode concept depends heavily on this need being
validated.

---

## 13. Foundational Need: User Autonomy

### Context

Kairos may eventually provide increasingly powerful intervention and
activity-awareness capabilities.

### Need Statement

> **When Kairos assists me, I need to remain in meaningful control of
> how much authority it has, so that support does not feel like
> control being taken away from me.**

### Potential Outcomes

Meeting this need may help users:

- Trust Kairos.
- Experiment with stronger support.
- Correct unwanted behavior.
- Customize intervention.
- Understand system boundaries.

### Research Questions

Research should determine:

- Which actions users are comfortable delegating.
- Which actions require explicit confirmation.
- How easy overrides should be.
- Whether users want temporary versus permanent settings.
- How younger users perceive guardian-controlled settings.

### Current Confidence

**High**

Autonomy is a foundational product principle and should be validated
throughout research and usability testing.

---

## 14. Foundational Need: Personalization

### Context

Users may differ substantially in how they want support delivered.

### Need Statement

> **When I use Kairos, I need the experience to reflect how I prefer
> to receive support, so that the companion feels useful rather than
> distracting, childish, overwhelming, or impersonal.**

### Potential Outcomes

Meeting this need may help users:

- Remain comfortable using Kairos.
- Choose appropriate intervention levels.
- Reduce notification fatigue.
- Create an age-appropriate experience without age stereotypes.
- Adjust Kairos for different contexts.

### Research Questions

Research should determine:

- Which customization options matter most.
- Whether visual customization affects continued use.
- Which communication styles users prefer.
- Whether preferences change by activity.
- Whether users understand intervention settings.
- How much customization becomes overwhelming.

### Current Confidence

**High**

Customization is central to the current Kairos concept, but research
should determine which forms provide meaningful value.

---

## 15. Foundational Need: Privacy

### Context

Advanced Kairos functionality may involve awareness of computer
activity.

### Need Statement

> **When Kairos uses information about my computer activity, I need to
> understand and control what it can observe, so that I can receive
> assistance without unnecessarily sacrificing privacy.**

### Potential Outcomes

Meeting this need may help users:

- Make informed permission decisions.
- Trust activity-aware functionality.
- Limit access to sensitive information.
- Understand how data is processed.

### Research Questions

Research should determine:

- Which activity information users consider sensitive.
- Whether users understand different awareness levels.
- Whether local processing increases comfort.
- Which applications users would want excluded.
- How younger users understand activity monitoring.
- How guardian access affects trust.

### Current Confidence

**High**

Privacy is likely to influence whether users are willing to enable
advanced Kairos capabilities.

---

## 16. Foundational Need: Explainability

### Context

Kairos may eventually make personalized recommendations involving
time, priorities, focus, and schedules.

### Need Statement

> **When Kairos recommends something that affects how I use my time, I
> need to understand why it made that recommendation, so that I can
> decide whether the suggestion makes sense for me.**

### Potential Outcomes

Meeting this need may help users:

- Evaluate recommendations.
- Correct incorrect assumptions.
- Build appropriate trust.
- Understand personalization.
- Make informed decisions.

### Research Questions

Research should determine:

- Which recommendations require explanation.
- How much explanation users want.
- Whether explanations should be shown automatically.
- What level of detail becomes overwhelming.
- Whether explanation increases trust.
- How explanation needs vary by age and context.

### Current Confidence

**High**

Explainability is a foundational Kairos product principle.

---

## 17. Foundational Need: Accessibility

### Context

Users may interact with Kairos while experiencing differences in
vision, hearing, motor interaction, reading, cognitive processing,
attention, or sensory sensitivity.

### Need Statement

> **When I use Kairos, I need to access its important information and
> controls in a way that works with my abilities and preferences, so
> that the support itself does not create another barrier.**

### Potential Outcomes

Meeting this need may help users:

- Access critical interventions.
- Configure appropriate sensory behavior.
- Navigate without unnecessary barriers.
- Use alternative input or output methods.

### Research Questions

Research should determine:

- Which accessibility needs are most relevant to target users.
- How sensory preferences affect interventions.
- Whether motion or sound creates problems.
- How keyboard-only users interact with Kairos.
- How screen readers should interact with overlays.
- How accessibility settings interact with personalization.

### Current Confidence

**High**

Accessibility is a foundational product requirement rather than an
optional enhancement.

---

## 18. Need Relationships

User needs should not be treated as isolated problems.

For example:

```text
Vague Task
    ↓
Task Decomposition Need
    ↓
Clear Next Action
    ↓
Task Initiation Need
    ↓
Work Begins
    ↓
Time Awareness Need
    ↓
Attention Drift
    ↓
Attention Recovery Need
    ↓
Deep Focus
    ↓
Transition Preparation Need
```

Kairos may eventually support multiple needs during a single activity.

Research should determine where these relationships are meaningful
and where they create unnecessary product complexity.

## 19. Cross-Cohort Need Matrix

The following represents the current research hypothesis.

It does not represent validated need severity.

| **User Need**          | **10-17** | **18-24** | **25+** |
| ---------------------- | --------- | --------- | ------- |
| Prioritization         | High      | High      | High    |
| Attention Recovery     | High      | High      | High    |
| Hyperfocus Support     | High      | High      | High    |
| Time Awareness         | High      | High      | High    |
| Task Initiation        | High      | High      | High    |
| Task Decomposition     | Medium    | High      | Medium  |
| Time Estimation        | Medium    | High      | High    |
| Transition Preparation | High      | High      | High    |
| Schedule Recovery      | Medium    | High      | High    |
| Autonomy               | High      | High      | High    |
| Personalization        | High      | High      | High    |
| Privacy                | High      | High      | High    |
| Explainability         | Medium    | High      | High    |
| Accessibility          | High      | High      | High    |

These classifications should change when evidence indicates they are incorrect.

---

## 20. Need Prioritization

Research should eventually allow each user need to be evaluated using factors such as:

- Frequency
- Severity
- Consequence
- Current Satisfaction
- Existing Alternatives
- User Importance
- Kairos Relevance
- Technical Feasibility

A need should not enter MVP scope solely because it appears in this document.

---

## 21. From User Need to Requirement

Validated user needs should later connect to requirements through traceability.

Example:

```text
Validated User Need
    ↓
Attention Recovery
    ↓
Product Requirement
    ↓
Functional Requirement
    ↓
UX Behavior
    ↓
Jira Epic / Story
    ↓
Implementation
    ↓
   Test
```

This traceability should make it possible to answer:

> Why are we building this?

A feature without a meaningful connection to a validated user need should require additional justification.

---

## 22. Current Research Position

The current highest-confidence needs are:

- Prioritization
- Attention Recovery
- Hyperfocus Support
- Time Awareness
- Transition Preparation
- User Autonomy
- Personalization
- Privacy
- Explainability
- Accessibility

Supporting hypotheses include:

- Task Initiation
- Task Decomposition
- Time Estimation
- Schedule Recovery

These classifications remain provisional until research provides evidence.

The next step is to document the specific questions Kairos research must answer before major product and MVP decisions are finalized.
