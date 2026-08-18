# Kairos Research Questions

**Document Status:** Draft  
**Version:** 0.1  
**Last Updated:** August 2026  
**Product:** Kairos  
**Document Owner:** Product / Research

---

## 1. Purpose

This document defines the questions Kairos research should investigate
before major product, UX, MVP, and technical decisions are finalized.

The questions are derived from:

- Product goals
- Product principles
- Problem hypotheses
- Initial user groups
- Initial user needs
- Privacy concerns
- Accessibility considerations
- Current feature concepts

Research should reduce uncertainty rather than simply confirm ideas
the project already prefers.

Findings that contradict current assumptions should be treated as
valuable research outcomes.

---

## 2. Research Objectives

The initial research program should help determine:

1. Whether the primary Kairos problems occur as currently understood.
2. Which problems have the greatest impact on users.
3. How users currently manage those problems.
4. Where existing strategies and products fail.
5. Which forms of assistance users actually want.
6. Which interventions feel helpful versus controlling.
7. How support needs vary by user and activity.
8. What users expect regarding privacy.
9. How younger users and guardians should interact with Kairos.
10. Which product assumptions should influence the MVP.
11. Which assumptions should be rejected or deferred.
12. Which questions require further research.

---

## 3. Research Question Priority

Research questions will use the following priority levels.

### P0: Decision-Critical

The project should obtain reasonable evidence before making a major
product decision that depends on the answer.

Examples may affect:

- MVP scope
- Core interaction model
- Privacy architecture
- Youth experience
- Intervention behavior

### P1: High Priority

The answer is likely to significantly improve product decisions but
does not necessarily block early planning.

### P2: Exploratory

The question may reveal useful opportunities or inform later
development.

Priority represents decision importance rather than research value.

---

## 4. Research Methods

Different questions require different forms of evidence.

Initial method categories include:

### User Interview

Useful for understanding:

- Experiences
- Motivations
- Existing behaviors
- Frustrations
- Expectations
- Language

### Survey

Useful for exploring:

- Frequency
- Preference patterns
- Self-reported behavior
- Larger-sample trends

### Usability Test

Useful for evaluating:

- Interface comprehension
- Intervention behavior
- Workflows
- Navigation
- Configuration

### Diary Study

Useful for understanding behavior across time and context.

Participants may record:

- Distractions
- Focus sessions
- Missed transitions
- Schedule changes
- Task estimates
- Actual task duration

### Contextual Observation

Useful for understanding how computer behavior occurs in realistic
environments.

### Literature Research

Useful for understanding established research involving:

- Executive functioning
- Attention
- Time perception
- Task switching
- Neurodivergence
- Accessibility

### Competitive Research

Useful for understanding:

- Existing solutions
- Common interaction patterns
- Product gaps
- User complaints
- Market expectations

### Technical Experiment

Useful when a question depends on operating-system behavior,
performance, privacy, or implementation feasibility.

---

## 5. Problem Validation Questions

### RQ-P01: Prioritization Frequency

**Priority:** P0  
**Primary Methods:** Interview, Survey

How frequently do users experience difficulty determining what
responsibility deserves attention first?

#### Follow-Up Questions

- What situations make prioritization hardest?
- How many competing responsibilities are usually involved?
- What happens when the user cannot decide?
- Does the user delay starting?
- Does the user choose the easiest activity?
- Does the user choose the most enjoyable activity?
- Does someone else typically establish the priority?

#### Decision Supported

Whether prioritization should remain a primary Kairos problem.

---

### RQ-P02: Prioritization Consequences

**Priority:** P0  
**Primary Methods:** Interview, Diary Study

What consequences occur when users prioritize activities poorly or
delay choosing?

#### Investigate

- Delayed tasks
- Missed deadlines
- Increased backlog
- Stress
- Task avoidance
- Lost available time

#### Decision Supported

How heavily prioritization should influence MVP scope.

---

### RQ-P03: Attention Drift

**Priority:** P0  
**Primary Methods:** Interview, Diary Study

How do users experience unintended attention shifts while using a
computer?

#### Follow-Up Questions

- What commonly causes the shift?
- How quickly do users notice?
- How long does the distraction continue?
- Do users remember the original task?
- How difficult is returning?
- What helps them return?

#### Decision Supported

Whether attention recovery should remain a primary Kairos capability.

---

### RQ-P04: Attention Recovery Information

**Priority:** P0  
**Primary Methods:** Interview, Usability Test

What information helps users return to an interrupted or distracted
task?

Potential information to investigate includes:

- Current task
- Original goal
- Last completed step
- Next action
- Time remaining
- Upcoming commitment

#### Decision Supported

What information Kairos should preserve or surface during attention
recovery.

---

### RQ-P05: Deep Focus and Hyperfocus

**Priority:** P0  
**Primary Methods:** Interview, Diary Study

How do users experience periods of unusually deep or sustained focus?

#### Follow-Up Questions

- What activities commonly produce deep focus?
- Is the experience considered positive, negative, or contextual?
- How aware is the user of passing time?
- What responsibilities are missed?
- What physical effects occur?
- What mental effects occur?
- What currently causes the user to disengage?

#### Decision Supported

How Kairos should conceptualize hyperfocus without treating deep focus
itself as a failure.

---

## 6. Intervention Research Questions

### RQ-I01: Helpful Intervention

**Priority:** P0  
**Primary Methods:** Interview, Usability Test

What makes a focus or transition intervention feel helpful rather than
annoying?

#### Investigate

- Timing
- Frequency
- Visual prominence
- Sound
- Language
- Persistence
- Dismissibility
- Context

#### Decision Supported

Initial progressive-intervention design.

---

### RQ-I02: Escalation

**Priority:** P0  
**Primary Methods:** Usability Test

How should intervention intensity increase when an earlier reminder
does not result in the intended response?

#### Investigate

A conceptual progression such as:

```text
Ambient
    ↓
Gentle
    ↓
Active
    ↓
Persistent
    ↓
Overlay
    ↓
Strong Intervention
    ↓
Authorized Restriction
```

#### Decision Supported

Whether the current progressive-intervention model matches user
expectations.

---

### RQ-I03: Dismissal Versus Override

**Priority:** P1
**Primary Methods:** Interview, Usability Test

When should users be able to dismiss an intervention immediately, and
when should Kairos ask whether the underlying plan has changed?

#### Decision Supported

Interaction behavior for reminders and interventions.

---

### RQ-I04: Strict Focus

**Priority:** P0
**Primary Methods:** Interview, Usability Test

Do users want the ability to intentionally delegate stronger
restriction authority during selected focus sessions?

#### Investigate

- Website restrictions
- Application restrictions
- Temporary overrides
- Emergency overrides
- Session-specific permissions
- User regret after enabling restrictions

#### Decision Supported

Whether restrictive focus behavior belongs in Kairos and eventually
in MVP scope.

---

## 7. Time Research Questions

### RQ-T01: Time Awareness

**Priority:** P0
**Primary Methods:** Interview, Diary Study

How frequently do users lose awareness of passing time while using a
computer?

#### Investigate

- Activity type
- Time of day
- Deep focus
- Recreation
- Work
- Schoolwork
- Existing timers

#### Decision Supported

Importance of persistent time-awareness functionality.

---

### RQ-T02: Time Representation

**Priority:** P1
**Primary Methods:** Usability Test

Which forms of time representation are easiest for users to
understand while focused?

Examples to investigate may include:

- Clock time
- Countdown
- Progress bar
- Visual time block
- Percentage remaining
- Transition countdown

#### Decision Supported

Time-awareness UX.

---

### RQ-T03: Time Estimation

**Priority:** P1
**Primary Methods:** Interview, Diary Study

How accurately do users estimate activity duration?

#### Investigate

- Which tasks are difficult to estimate?
- How large are typical estimation errors?
- Do users account for breaks?
- Do users account for setup?
- Do users learn from previous estimates?

#### Decision Supported

Importance of duration tracking and future personalized estimation.

---

### RQ-T04: Context and Duration

**Priority:** P2
**Primary Methods:** Diary Study

How much does activity context affect task duration?

Example:

```text
Task:
Clean my room

Context A:
Light cleanup

Context B:
Very messy
```

#### Decision Supported

Whether contextual variables could meaningfully improve a future
Personal Time Model.

---

## 8. Planning Research Questions

### RQ-PL01: Task Initiation

**Priority:** P1
**Primary Methods:** Interview

What causes users to delay beginning a task they already know they
need to complete?

#### Investigate

- Unclear first step
- Task size
- Perceived difficulty
- Boredom
- Competing activities
- Fear of failure
- Lack of urgency

#### Decision Supported

Whether initiation assistance should become a core Kairos capability.

---

### RQ-PL02: Vague Tasks

**Priority:** P1
**Primary Methods:** Interview, Usability Test

When does a task feel too vague or large to begin?

#### Decision Supported

Whether task decomposition should be included in early product scope.

---

### RQ-PL03: Decomposition Detail

**Priority:** P1
**Primary Methods:** Usability Test

How much task decomposition is useful before the number of steps
itself becomes overwhelming?

#### Decision Supported

Task decomposition UX and future AI behavior.

---

### RQ-PL04: Schedule Recovery

**Priority:** P1
**Primary Methods:** Interview, Usability Test

What do users do when their original schedule becomes unrealistic?

#### Investigate

- Replanning
- Abandoning the schedule
- Moving tasks
- Skipping breaks
- Working later
- Ignoring lower-priority activities

#### Decision Supported

Whether Rescue Mode should become an early product capability.

---

## 9. Transition Research Questions

### RQ-TR01: Transition Difficulty

**Priority:** P0
**Primary Methods:** Interview, Diary Study

Which activity transitions are most difficult for users?

Examples may include:

- Recreation to homework
- Focused work to meeting
- Gaming to bedtime
- Creative work to household responsibility
- Break to work

#### Decision Supported

Which transitions Kairos should prioritize.

---

### RQ-TR02: Transition Warning

**Priority:** P0
**Primary Methods:** Usability Test

How much advance notice do users need before different types of
transitions?

#### Decision Supported

Transition-window behavior.

---

### RQ-TR03: Context Preservation

**Priority:** P1
**Primary Methods:** Interview, Usability Test

What information should be preserved when a user stops an unfinished
activity?

#### Decision Supported

Whether Kairos should support explicit task-state preservation.

---

## 10. Personalization Research Questions

### RQ-PE01: Personalization Value

**Priority:** P1
**Primary Methods:** Interview, Survey

Which forms of customization meaningfully affect whether users want
to continue using Kairos?

#### Investigate

- Theme
- Companion appearance
- Communication style
- Sound
- Motion
- Widget layout
- Intervention strength
- Notification behavior

#### Decision Supported

Which personalization capabilities deserve early development.

---

### RQ-PE02: Communication Style

**Priority:** P1
**Primary Methods:** Usability Test

How does communication style affect user response to interventions?

Potential styles include:

- Calm
- Direct
- Encouraging
- Playful
- Minimal

#### Decision Supported

Communication-style system.

---

### RQ-PE03: Age and Appearance

**Priority:** P1
**Primary Methods:** Interview, Usability Test

Do visual and communication preferences meaningfully correlate with
age, or are individual preferences more predictive?

#### Decision Supported

Whether onboarding should use age to influence presentation.

---

## 11. Privacy Research Questions

### RQ-PR01: Activity Awareness

**Priority:** P0
**Primary Methods:** Interview, Usability Test

What types of computer activity information are users comfortable
allowing Kairos to observe?

#### Investigate

Conceptual levels:

```text
Session Awareness
Application Awareness
Domain Awareness
Context Awareness
```

#### Decision Supported

Activity-awareness permission architecture.

---

### RQ-PR02: Local Processing

**Priority:** P0
**Primary Methods:** Interview, Technical Research

Does knowing that activity information is processed locally affect
user willingness to enable advanced awareness?

#### Decision Supported

Local-first architecture requirements.

---

### RQ-PR03: Sensitive Applications

**Priority:** P0
**Primary Methods:** Interview

Which applications or categories should Kairos avoid observing by
default?

Potential categories may include:

- Password managers
- Banking
- Healthcare
- Private messaging
- Authentication
- Private browsing

#### Decision Supported

Privacy exclusions and safe defaults.

---

### RQ-PR04: Data Retention

**Priority:** P0
**Primary Methods:** Interview, Literature / Regulatory Research

How much behavioral history should Kairos retain, and how much control
should users have over retention?

#### Decision Supported

Data architecture and privacy requirements.

---

## 12. Youth and Guardian Research Questions

### RQ-Y01: Guardian Role

**Priority:** P0
**Primary Methods:** Interviews with Youth and Guardians

What role should a guardian have in a younger user's Kairos
experience?

#### Investigate

- Setup
- Permissions
- Restrictions
- Schedules
- Privacy
- Reports
- Overrides

#### Decision Supported

Guardian experience requirements.

---

### RQ-Y02: Youth Privacy

**Priority:** P0
**Primary Methods:** Youth Research, Guardian Research,
Legal / Regulatory Research

What information should remain private to the younger user?

#### Decision Supported

Guardian visibility boundaries.

---

### RQ-Y03: Transparency

**Priority:** P0
**Primary Methods:** Usability Test

Can younger users clearly understand:

- What Kairos observes?
- What guardians can see?
- Which settings guardians control?
- Which settings the user controls?

#### Decision Supported

Youth onboarding and permission UX.

---

### RQ-Y04: Guardian Restrictions

**Priority:** P0
**Primary Methods:** Interviews with Youth and Guardians

How do guardian-configured restrictions affect trust in Kairos?

### Decision Supported

Whether and how guardian-controlled restrictions should exist.

---

## 13. Accessibility Research Questions

### RQ-A01: Intervention Accessibility

**Priority:** P0
**Primary Methods:** Accessibility Research, Usability Test

Can important Kairos interventions be perceived and understood
without depending on a single sensory channel?

#### Decision Supported

Notification and overlay accessibility requirements.

---

### RQ-A02: Sensory Preferences

**Priority:** P1
**Primary Methods:** Interview, Usability Test

How do sound, animation, motion, visual density, and notification
intensity affect different users?

#### Decision Supported

Sensory customization requirements.

---

### RQ-A03: Keyboard and Assistive Technology

**Priority:** P0
**Primary Methods:** Accessibility Testing

Can core Kairos functionality be operated effectively using keyboard
navigation and appropriate assistive technologies?

#### Decision Supported

Foundational accessibility requirements.

---

## 14. Explainability Research Questions

### RQ-E01: Explanation Expectations

**Priority:** P1
**Primary Methods:** Interview, Usability Test

Which Kairos recommendations do users expect to be explainable?

#### Decision Supported

Explainability requirements.

---

### RQ-E02: Explanation Depth

**Priority:** P1
**Primary Methods:** Usability Test

How much explanation is useful before the explanation itself becomes
cognitively burdensome?

#### Decision Supported

Explanation UX.

---

### RQ-E03: Correction

**Priority:** P1
**Primary Methods:** Usability Test

When Kairos makes an incorrect assumption, how should the user correct
it?

#### Decision Supported

Feedback and personalization architecture.

---

## 15. Competitive Research Questions

### RQ-C01: Existing Solutions

**Priority:** P1
**Primary Method:** Competitive Research

Which existing products address portions of the Kairos problem space?

Categories may include:

- Focus applications
- Task managers
- Time-awareness tools
- Website blockers
- Desktop companions
- ADHD-oriented productivity tools
- Calendar assistants
- Routine applications

---

### RQ-C02: Existing Product Gaps

**Priority:** P1
**Primary Methods:** Competitive Research, Review Analysis

What problems do users report with existing solutions?

#### Investigate

- Excessive rigidity
- Notification fatigue
- Poor customization
- Difficult setup
- Lack of context
- Privacy concerns
- Punitive design
- Weak recovery support

---

### RQ-C03: Differentiation

**Priority:** P1
**Primary Methods:** Competitive Research, User Interview

Which aspects of the Kairos concept provide meaningful value that
users do not receive from existing tools?

#### Decision Supported

Product positioning and MVP differentiation.

---

## 16. Adoption and Retention Questions

### RQ-AR01: Initial Value

**Priority:** P0
**Primary Methods:** Interview, Prototype Testing

What must Kairos help with quickly enough for a new user to consider
keeping it installed?

#### Decision Supported

MVP value proposition and onboarding.

---

### RQ-AR02: Abandonment

**Priority:** P0
**Primary Methods:** Interview, Competitive Review Analysis

What would cause users to disable or uninstall Kairos?

Potential reasons may include:

- Too many interruptions
- Privacy concerns
- Excessive setup
- Poor recommendations
- Feeling controlled
- Resource usage
- Visual distraction
- Lack of meaningful benefit

#### Decision Supported

MVP quality thresholds.

---

### RQ-AR03: Trust

**Priority:** P0
**Primary Methods:** Interview, Usability Test

What behavior causes users to trust or distrust a desktop companion
that can intervene in their computer experience?

#### Decision Supported

Product behavior across the entire Kairos experience.

---

## 17. Technical Research Questions

Some product questions depend on technical feasibility.

These should eventually be investigated alongside architecture
planning.

### RQ-TECH01: Background Operation

**Priority:** P0
**Primary Method:** Technical Experiment

Can Kairos reliably operate in the background while maintaining
acceptable CPU, memory, and battery usage?

---

### RQ-TECH02: Overlay Capability

**Priority:** P0
**Primary Method:** Technical Experiment

Can Kairos reliably present interventions above active applications
without creating unacceptable compatibility or accessibility issues?

---

### RQ-TECH03: Activity Detection

**Priority:** P0
**Primary Method:** Technical Experiment

What activity information can Kairos reliably access on supported
operating systems at each proposed awareness level?

---

### RQ-TECH04: Restrictions

**Priority:** P1
**Primary Method:** Technical Experiment

What application and website restriction capabilities are technically
possible without requiring unsafe or excessively invasive system
access?

---

### RQ-TECH05: Local Intelligence

**Priority:** P1
**Primary Method:** Technical Experiment

Which future intelligent capabilities could reasonably operate
locally rather than requiring cloud processing?

---

## 18. Research Decision Gates

Some product decisions should remain provisional until related P0
questions have reasonable evidence.

### Gate A: Core Problem Validation

Before finalizing MVP scope, obtain evidence regarding:

- [RQ-P01](#rq-p01-prioritization-frequency)
- [RQ-P02](#rq-p02-prioritization-consequences)
- [RQ-P03](#rq-p03-attention-drift)
- [RQ-P04](#rq-p04-attention-recovery-information)
- [RQ-P05](#rq-p05-deep-focus-and-hyperfocus)
- [RQ-T01](#rq-t01-time-awareness)
- [RQ-TR01](#rq-tr01-transition-difficulty)

#### Gate Question

> Are we solving problems users actually experience frequently enough
> and severely enough to justify Kairos?

---

### Gate B: Intervention Model

Before finalizing focus and intervention UX, obtain evidence
regarding:

- [RQ-I01](#rq-i01-helpful-intervention)
- [RQ-I02](#rq-i02-escalation)
- [RQ-I04](#rq-i04-strict-focus)
- [RQ-TR02](#rq-tr02-transition-warning)
- [RQ-AR03](#rq-ar03-trust)

#### Gate Question

> Can Kairos intervene in a way that users consider supportive rather
> than controlling or distracting?

---

### Gate C: Activity Awareness

Before implementing advanced activity monitoring, obtain evidence
regarding:

- [RQ-PR01](#rq-pr01-activity-awareness)
- [RQ-PR02](#rq-pr02-local-processing)
- [RQ-PR03](#rq-pr03-sensitive-applications)
- [RQ-PR04](#rq-pr04-data-retention)
- [RQ-TECH03](#rq-tech03-activity-detection)

#### Gate Question

> What does Kairos actually need to observe, and what are users
> comfortable allowing it to observe?

---

### Gate D: Youth Experience

Before releasing Kairos for users under 18, obtain appropriate
evidence regarding:

- [RQ-Y01](#rq-y01-guardian-role)
- [RQ-Y02](#rq-y02-youth-privacy)
- [RQ-Y03](#rq-y03-transparency)
- [RQ-Y04](#rq-y04-guardian-restrictions)

Relevant legal and regulatory requirements must also be investigated.

#### Gate Question

> Can Kairos provide meaningful support to younger users while
> preserving appropriate safety, privacy, transparency, and autonomy?

---

### Gate E: Desktop Feasibility

Before committing to an implementation architecture, investigate:

- [RQ-TECH01](#rq-tech01-background-operation)
- [RQ-TECH02](#rq-tech02-overlay-capability)
- [RQ-TECH03](#rq-tech03-activity-detection)

#### Gate Question

> Can the core Kairos desktop experience be implemented reliably
> without unacceptable performance, compatibility, privacy, or
> accessibility tradeoffs?

---

## 19. Evidence Standards

A research question should not be marked "validated" simply because:

- The project team agrees with it.
- One participant mentions it.
- A competitor implements it.
- The idea appears intuitive.
- The proposed feature is technically interesting.

Evidence should be evaluated according to:

- Research method
- Number and diversity of participants
- Consistency of findings
- Strength of observed behavior
- Quality of external sources
- Relevance to the target population
- Limitations and potential bias

Research documentation should distinguish between:

```text
Assumption
Hypothesis
Observation
Finding
Decision
```

These terms should not be treated as interchangeable.

---

## 20. Research Status

Questions may use the following statuses:

```text
Not Started
In Research
Partial Evidence
Supported
Not Supported
Inconclusive
Deferred
```

`Supported` should not imply permanent truth.

Future evidence may change a finding.

---

## 21. Research Traceability

Research should eventually connect product decisions back to
evidence.

Example:

```text
Research Question
        ↓
RQ-P04: Attention Recovery Information
        ↓
Research Finding
        ↓
Users consistently need the original objective
and next action after distraction.
        ↓
Validated User Need
        ↓
Attention Recovery
        ↓
Product Requirement
        ↓
UX Requirement
        ↓
Jira Epic / Story
```

This traceability should make it possible to explain why significant
Kairos capabilities exist.

---

## 22. Current Research Position

The research questions in this document represent the initial Kairos
research agenda.

They are intentionally broader than the eventual MVP.

The immediate research priorities are:

1. Validate the primary problem areas.
2. Understand existing user behavior.
3. Understand intervention preferences.
4. Investigate time and transition needs.
5. Establish acceptable privacy boundaries.
6. Investigate youth and guardian requirements.
7. Validate desktop technical feasibility.
8. Identify the minimum value Kairos must provide.

Research findings should inform requirements.

Requirements should not be finalized first and then supported with
research after the fact.
