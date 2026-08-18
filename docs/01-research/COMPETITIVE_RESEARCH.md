# Kairos Competitive Research

**Document Status:** Research Draft  
**Version:** 0.1  
**Last Updated:** August 2026  
**Product:** Kairos  
**Document Owner:** Product / Research

---

## 1. Purpose

This document evaluates products that currently address portions of
the problem space Kairos intends to explore.

The purpose of this research is not to identify features Kairos should
copy.

Instead, competitive research should help determine:

1. Which user problems existing products already address.
2. Which interaction patterns are common in the market.
3. Where existing products overlap with Kairos.
4. Where existing products approach the problem differently.
5. Which Kairos assumptions are challenged by existing solutions.
6. Which potential product gaps may exist.
7. Which apparent gaps still require direct user validation.

Competitive presence does not prove that a feature is valuable.

Likewise, the absence of a feature from competitors does not prove
that users want it.

Competitive findings should therefore inform, rather than replace,
user research.

---

## 2. Research Scope

The current competitive review focuses on products addressing one or
more of the following areas:

- Distraction management
- Focus sessions
- Website or application blocking
- Time awareness
- Activity tracking
- Daily planning
- Task prioritization
- Timeboxing
- Automatic scheduling
- Schedule recovery
- Habit scheduling
- Visual planning
- Attention support

The initial competitive set includes:

- Freedom
- RescueTime
- Sunsama
- Motion
- Reclaim
- Structured

This list is not intended to represent every productivity application.

Additional products may be added as research continues.

---

## 3. Competitive Categories

Kairos overlaps with several existing product categories rather than
fitting cleanly into one.

### 3.1 Distraction Blockers

Products in this category primarily reduce access to applications,
websites, or other digital distractions.

Example:

- Freedom

### 3.2 Activity and Focus Trackers

Products in this category observe computer activity, provide time-use
insights, and may combine tracking with focus interventions.

Example:

- RescueTime

### 3.3 Guided Daily Planners

Products in this category help users intentionally construct a
realistic plan for the day.

Example:

- Sunsama

### 3.4 Automatic Scheduling Systems

Products in this category automatically place tasks into available
calendar time and adapt when schedules change.

Examples:

- Motion
- Reclaim

### 3.5 Visual Day Planners

Products in this category emphasize visual representation of tasks and
time.

Example:

- Structured

---

## 4. Competitive Relationship to Kairos

None of the products reviewed should currently be treated as a perfect
one-to-one competitor.

Kairos presently combines hypotheses from several product categories.

Conceptually:

```text
Distraction Blocking
        +
Time Awareness
        +
Task Prioritization
        +
Attention Recovery
        +
Transition Support
        +
Schedule Recovery
        +
Personalization
        +
Desktop Intervention
        ↓
      Kairos
```

This creates both an opportunity and a risk.

### Opportunity

Kairos may address a combination of needs that users currently solve
through multiple applications.

### Risk

Attempting to combine too many productivity categories could create an
overly complex product without a clear primary value proposition.

This risk should remain visible during MVP planning.

---

## 5. Competitor: Freedom

### 5.1 Product Position

Freedom is primarily a distraction-blocking product.

Its current product offering includes:

- Website blocking
- Application blocking
- Internet blocking
- Custom blocklists
- Website exceptions
- Recurring focus schedules
- Scheduled sessions
- Cross-device blocking
- Focus sounds
- Locked Mode

Freedom's Locked Mode can prevent the user from ending a blocking
session early.

Sources:

- [Freedom Features](https://freedom.to/features)
- [Freedom Plan Features](https://support.freedom.to/en/articles/13764747-what-s-included-in-free-and-premium-plans)

### 5.2 Problem Approach

Freedom primarily addresses distraction by removing access to
user-selected competing activities.

Conceptually:

```text
User identifies distraction
        ↓
User creates blocklist
        ↓
Focus session begins
        ↓
Distraction becomes inaccessible
        ↓
User remains within permitted environment
```

### 5.3 Strengths Relevant to Kairos

Freedom demonstrates that users can intentionally delegate significant
authority to focus software.

Relevant patterns include:

- User-defined blocklists
- Temporary focus restrictions
- Recurring focus schedules
- Cross-device enforcement
- Increasing restriction through Locked Mode

### 5.4 Difference From Current Kairos Direction

Freedom primarily attempts to prevent access to distractions.

Kairos currently hypothesizes a broader model:

```text
Attention Drift
        ↓
Awareness
        ↓
Progressive Intervention
        ↓
Attention Recovery
        ↓
Optional Restriction
```

Under the current Kairos concept, restriction is one possible
intervention rather than the default purpose of the product.

### 5.5 Competitive Insight

Freedom challenges the assumption that strong restrictions are
inherently unacceptable.

Users may intentionally want software that prevents them from changing
their minds during a focus period.

The more useful Kairos research question is therefore not:

> Should software ever restrict the user?

It is:

> Under what circumstances do users want to intentionally delegate
> restriction authority?

### Related Research Questions

- [RQ-I04](RESEARCH_QUESTIONS.md#rq-i04-strict-focus)
- [RQ-AR03](RESEARCH_QUESTIONS.md#rq-ar03-trust)

### Related Assumptions

- [A-AF03](ASSUMPTIONS_AND_HYPOTHESES.md#a-af03-intervention-strength-should-be-user-controlled)
- [A-AF04](ASSUMPTIONS_AND_HYPOTHESES.md#a-af04-strict-focus-has-user-value)

---

## 6. Competitor: RescueTime

### 6.1 Product Position

RescueTime combines automatic activity tracking with focus support.

Current capabilities include:

- Automatic time tracking
- Application and website activity tracking
- Productivity categorization
- Focus Sessions
- Application and website blocking
- Goals
- Alerts
- Reports
- Behavioral time-use insights

Focus Sessions may be started manually, triggered from calendar
activity, initiated from Focus Zones, or triggered when excessive time
has been spent on distracting activity.

Sources:

- [RescueTime](https://www.rescuetime.com/)
- [Starting a RescueTime Focus Session](https://help.rescuetime.com/article/297-how-to-start-a-focus-session)

### 6.2 Problem Approach

RescueTime addresses attention management partly through observation.

Conceptually:

```text
Observe activity
        ↓
Classify time
        ↓
Identify patterns
        ↓
Provide feedback
        ↓
Trigger focus behavior
```

This differs substantially from a traditional manually configured
timer.

### 6.3 Strengths Relevant to Kairos

RescueTime demonstrates several concepts directly relevant to Kairos:

- Passive activity awareness
- Application-level observation
- Website-level observation
- Automatic detection of distracting behavior
- Behavior-triggered focus sessions
- Historical behavioral reporting

### 6.4 Difference From Current Kairos Direction

RescueTime's activity tracking is primarily oriented around:

- Time use
- Productivity classification
- Focus behavior
- Reports

Kairos is currently more interested in:

- Intended attention
- Actual attention
- Task context
- Attention recovery
- Transition preparation
- Progressive intervention

For Kairos, knowing that a user visited YouTube may not be sufficient.

The more relevant question may be:

> Was YouTube related to what the user intended to accomplish?

### 6.5 Competitive Insight

RescueTime provides evidence that application and website awareness are
technically and commercially viable product concepts.

However, its existence does not validate the current Kairos
Context Awareness hypothesis.

Kairos still needs to determine whether users value understanding the
relationship between observed behavior and the user's stated
intention.

### Related Research Questions

- [RQ-PR01](RESEARCH_QUESTIONS.md#rq-pr01-activity-awareness)
- [RQ-P03](RESEARCH_QUESTIONS.md#rq-p03-attention-drift)
- [RQ-TECH03](RESEARCH_QUESTIONS.md#rq-tech03-activity-detection)

### Related Assumptions

- [A-PR01](ASSUMPTIONS_AND_HYPOTHESES.md#a-pr01-activity-awareness-improves-focus-assistance)
- [A-TECH03](ASSUMPTIONS_AND_HYPOTHESES.md#a-tech03-activity-awareness-is-technically-feasible)

---

## 7. Competitor: Sunsama

### 7.1 Product Position

Sunsama is a guided daily planner centered around realistic planning
and timeboxing.

Current capabilities include:

- Guided daily planning
- Task and calendar integration
- Timeboxing
- Calendar visualization
- Task projections
- Focus Mode
- Break support
- Daily and weekly planning
- Task rollover
- Actual time tracking
- AI-generated task estimates
- Integration with external task-management systems

Sunsama's task projections consider existing calendar events and the
user's preferred shutdown time.

Its task-estimation functionality can also use historical data to
suggest an initial duration for a task.

Sources:

- [Sunsama Timeboxing](https://www.sunsama.com/features/timeboxing)
- [Sunsama Daily Planning](https://www.sunsama.com/daily-planning)
- [Sunsama User Manual](https://help.sunsama.com/)

### 7.2 Problem Approach

Sunsama primarily addresses the planning problem before work begins.

Conceptually:

```text
Identify responsibilities
        ↓
Estimate duration
        ↓
Compare against available time
        ↓
Timebox tasks
        ↓
Create realistic daily plan
        ↓
Execute
```

### 7.3 Strengths Relevant to Kairos

Sunsama overlaps strongly with several Kairos hypotheses:

- Task-duration estimation
- Historical duration learning
- Planned versus actual time
- Timeboxing
- Realistic capacity planning
- Focus sessions
- Breaks
- Daily planning
- End-of-day boundaries

Its use of historical task data is particularly relevant to the
Kairos Personal Time Model concept.

### 7.4 Difference From Current Kairos Direction

Sunsama remains primarily a planning environment.

Kairos currently hypothesizes that support should continue while the
user operates elsewhere on the computer.

Conceptually:

```text
Sunsama

Open planner
        ↓
Plan day
        ↓
Use plan


Kairos Hypothesis

Plan intention
        ↓
Leave Kairos interface
        ↓
Use normal computer
        ↓
Kairos remains contextually available
```

### 7.5 Competitive Insight

The existence of historical task estimation directly challenges the
idea that personalized duration estimation alone would substantially
differentiate Kairos.

The stronger Kairos hypothesis is not simply:

> Learn how long my tasks take.

It may instead be:

> Learn how long my tasks take in context and use that understanding
> during planning, focus, transitions, and schedule recovery.

That distinction still requires validation.

### Related Research Questions

- [RQ-T03](RESEARCH_QUESTIONS.md#rq-t03-time-estimation)
- [RQ-T04](RESEARCH_QUESTIONS.md#rq-t04-context-and-duration)
- [RQ-PL04](RESEARCH_QUESTIONS.md#rq-pl04-schedule-recovery)

### Related Assumptions

- [A-TM02](ASSUMPTIONS_AND_HYPOTHESES.md#a-tm02-generic-time-estimates-are-insufficient)
- [A-TM03](ASSUMPTIONS_AND_HYPOTHESES.md#a-tm03-context-meaningfully-affects-duration)
- [A-TM04](ASSUMPTIONS_AND_HYPOTHESES.md#a-tm04-users-will-record-actual-duration)

---

## 8. Competitor: Motion

### 8.1 Product Position

Motion is an automatic scheduling and work-management platform.

Its current scheduling functionality can:

- Prioritize tasks
- Automatically place tasks onto a calendar
- Consider task duration
- Consider deadlines
- Consider task priority
- Consider availability
- Split tasks into chunks
- Add breaks between tasks
- Reschedule work when the schedule changes
- Surface the highest-priority task
- Identify overloaded schedules
- Warn about at-risk deadlines

Sources:

- [Motion AI Calendar](https://www.usemotion.com/features/ai-calendar)
- [Motion AI Task Manager](https://www.usemotion.com/features/ai-task-manager)
- [Motion Auto-Scheduling](https://www.usemotion.com/help/time-management/auto-scheduling)

### 8.2 Problem Approach

Motion attempts to reduce the cognitive effort of deciding when work
should occur.

Conceptually:

```text
Tasks
+
Priorities
+
Deadlines
+
Duration
+
Calendar Availability
        ↓
Automatic Scheduling
        ↓
Continuously Updated Plan
```

When circumstances change, Motion can automatically reorganize the
schedule.

### 8.3 Strengths Relevant to Kairos

Motion directly addresses two major current Kairos problems:

#### "What should I do first?"

Motion can prioritize work and surface what it determines should
receive attention next.

#### "My schedule no longer works."

Motion can automatically reschedule tasks when conditions change.

These capabilities substantially overlap with the current
prioritization and Rescue Mode hypotheses.

### 8.4 Difference From Current Kairos Direction

Motion emphasizes automatic decision-making.

Kairos currently emphasizes explainable recommendation and user
authority.

Conceptually:

```text
Motion-Oriented Model

System evaluates plan
        ↓
System reorganizes plan
        ↓
User follows updated schedule
```

Compared with the current Kairos hypothesis:

```text
Kairos-Oriented Model

System identifies problem
        ↓
System recommends change
        ↓
System explains reasoning
        ↓
User accepts, changes, or rejects
```

This distinction should not be assumed to be better.

Some users may prefer Motion's stronger automation.

### 8.5 Competitive Insight

Motion directly challenges one of the strongest Kairos philosophical
assumptions:

> AI should recommend. The user decides.

For some forms of scheduling, users may prefer the system to simply
make routine adjustments automatically.

Kairos research should therefore investigate different levels of
delegated scheduling authority rather than assuming all schedule
changes require manual approval.

### Related Research Questions

- [RQ-P01](RESEARCH_QUESTIONS.md#rq-p01-prioritization-frequency)
- [RQ-PL04](RESEARCH_QUESTIONS.md#rq-pl04-schedule-recovery)
- [RQ-E01](RESEARCH_QUESTIONS.md#rq-e01-explanation-expectations)

### Related Assumptions

- [A-PL03](ASSUMPTIONS_AND_HYPOTHESES.md#a-pl03-users-want-prioritization-recommendations)
- [A-PL04](ASSUMPTIONS_AND_HYPOTHESES.md#a-pl04-users-want-schedule-recovery-assistance)
- [A-EX01](ASSUMPTIONS_AND_HYPOTHESES.md#a-ex01-explanations-increase-appropriate-trust)

---

## 9. Competitor: Reclaim

### 9.1 Product Position

Reclaim is an adaptive calendar-planning system focused on
automatically protecting and reorganizing time.

Current capabilities include:

- Task scheduling
- Priority-based scheduling
- Focus Time
- Habit scheduling
- Smart Meetings
- Buffer Time
- Calendar synchronization
- Automatic rescheduling
- Work and personal calendar coordination
- Focus protection
- Break protection
- Time tracking
- Scheduling rules
- Human approval for some AI-driven behavior

Reclaim can schedule activities according to:

- Priority
- Duration
- Frequency
- Availability
- Due dates
- User-defined scheduling windows

Sources:

- [Reclaim AI Planner](https://reclaim.ai/features/planner)
- [Reclaim Focus Time](https://reclaim.ai/features/focus-time)
- [How Reclaim Manages Schedules](https://help.reclaim.ai/en/articles/6207587-how-reclaim-manages-your-schedule-automatically)
- [Reclaim Priorities](https://help.reclaim.ai/en/articles/8291694-how-reclaim-uses-priorities-to-intelligently-plan-your-workweek)

### 9.2 Problem Approach

Reclaim treats the calendar as a flexible system of priorities.

Conceptually:

```text
Tasks
+
Meetings
+
Habits
+
Focus Goals
+
Priorities
        ↓
Flexible Calendar
        ↓
Automatic Rebalancing
```

### 9.3 Strengths Relevant to Kairos

Reclaim demonstrates several concepts relevant to Kairos:

- Priority-based automatic planning
- Flexible versus fixed commitments
- Protected focus periods
- Protected buffer periods
- Habit scheduling
- Dynamic rescheduling
- Multiple calendar contexts
- Work and personal schedule integration

The explicit inclusion of buffer time is particularly relevant to the
Kairos principle that transitions and recovery require real time.

### 9.4 Difference From Current Kairos Direction

Like Motion, Reclaim primarily operates at the schedule level.

Kairos currently intends to investigate what happens **during** an
activity as well as between activities.

For example:

```text
Calendar-Level Question

What should happen from 2:00 PM to 3:00 PM?


Kairos Attention-Level Question

It is 2:23 PM.

What did the user intend to be doing?

What are they currently doing?

Do they need assistance?

What happens at 3:00 PM?

When should transition preparation begin?
```

### 9.5 Competitive Insight

Kairos differentiation is unlikely to come from calendar automation
alone.

Motion and Reclaim already provide sophisticated schedule
reorganization.

If Kairos enters this space, its distinctive value may need to come
from how scheduling connects to:

- Attention state
- Task context
- Transition support
- Attention recovery
- Personalized intervention
- Explainability

### Related Research Questions

- [RQ-PL04](RESEARCH_QUESTIONS.md#rq-pl04-schedule-recovery)
- [RQ-TR02](RESEARCH_QUESTIONS.md#rq-tr02-transition-warning)
- [RQ-AR01](RESEARCH_QUESTIONS.md#rq-ar01-initial-value)

### Related Assumptions

- [A-PL04](ASSUMPTIONS_AND_HYPOTHESES.md#a-pl04-users-want-schedule-recovery-assistance)
- [A-PV03](ASSUMPTIONS_AND_HYPOTHESES.md#a-pv03-a-desktop-companion-provides-more-value-than-a-separate-app)

---

## 10. Competitor: Structured

### 10.1 Product Position

Structured is a visual day planner that combines tasks and calendar
activities into a unified timeline.

Current product capabilities include:

- Visual daily timeline
- Tasks
- Calendar imports
- Weekly views
- Monthly views
- Cross-device access
- AI-assisted planning

Source:

- [Structured](https://structured.app/)

### 10.2 Problem Approach

Structured makes time visually concrete.

Conceptually:

```text
Tasks
+
Calendar
        ↓
Visual Timeline
        ↓
See how the day fits together
```

### 10.3 Strengths Relevant to Kairos

Structured is particularly relevant to Kairos's time-awareness
hypothesis.

Rather than presenting time only through:

```text
2:00 PM
3:00 PM
4:00 PM
```

a visual timeline communicates the spatial relationship between:

- Activities
- Duration
- Gaps
- Upcoming commitments

### 10.4 Difference From Current Kairos Direction

Structured primarily helps the user visualize the plan.

Kairos currently hypothesizes that time awareness may need to remain
available while the user is working outside the planner.

Potential Kairos concepts may therefore investigate:

- Persistent time visualization
- Current-task visualization
- Transition countdowns
- Focus progress
- Upcoming-event proximity

### 10.5 Competitive Insight

Visual time representation is not unique to Kairos.

Kairos should therefore avoid assuming that visual time awareness
alone provides meaningful differentiation.

The research opportunity is whether visual time becomes more useful
when integrated into a persistent desktop companion and contextual
intervention system.

### Related Research Questions

- [RQ-T01](RESEARCH_QUESTIONS.md#rq-t01-time-awareness)
- [RQ-T02](RESEARCH_QUESTIONS.md#rq-t02-time-representation)

### Related Assumptions

- [A-TM01](ASSUMPTIONS_AND_HYPOTHESES.md#a-tm01-users-benefit-from-persistent-time-awareness)
- [A-PV03](ASSUMPTIONS_AND_HYPOTHESES.md#a-pv03-a-desktop-companion-provides-more-value-than-a-separate-app)

---

## 11. Feature Comparison Matrix

The following matrix compares capabilities relevant to the current
Kairos hypotheses.

This matrix reflects product capabilities identified during the
current research pass.

It should be periodically revalidated because competitor products
change over time.

| Capability                      |   Freedom   |   RescueTime   |        Sunsama        |      Motion      |     Reclaim      |  Structured   | Kairos Hypothesis |
| ------------------------------- | :---------: | :------------: | :-------------------: | :--------------: | :--------------: | :-----------: | :---------------: |
| Task management                 |   Limited   |    Limited     |          Yes          |       Yes        |       Yes        |      Yes      |        Yes        |
| Calendar planning               |   Limited   |    Limited     |          Yes          |       Yes        |       Yes        |      Yes      |        Yes        |
| Automatic scheduling            |     No      |       No       |        Partial        |       Yes        |       Yes        |    Limited    |      Future       |
| Automatic rescheduling          |     No      |       No       |          Yes          |       Yes        |       Yes        |    Limited    |      Future       |
| Prioritization support          |   Limited   |    Limited     |          Yes          |       Yes        |       Yes        |    Limited    |        Yes        |
| Website blocking                |     Yes     |      Yes       |          No           |        No        |        No        |      No       |     Optional      |
| Application blocking            |     Yes     |      Yes       |          No           |        No        |        No        |      No       |     Optional      |
| Activity tracking               |     No      |      Yes       |        Limited        |        No        |  Time-oriented   |      No       |     Proposed      |
| Focus sessions                  |     Yes     |      Yes       |          Yes          |     Indirect     |    Focus Time    |      No       |        Yes        |
| Visual timeline                 |   Limited   |    Reports     |          Yes          |     Calendar     |     Calendar     |      Yes      |     Proposed      |
| Historical task duration        |     No      | Time tracking  |          Yes          |  Duration input  |  Time tracking   |    Limited    |     Proposed      |
| Personalized task estimate      |     No      |       No       |          Yes          | Scheduling-based | Scheduling-based |    Limited    |      Future       |
| Schedule recovery               |     No      |       No       | Rollover / reschedule |       Yes        |       Yes        |    Manual     |     Proposed      |
| Transition preparation          |   Limited   |    Limited     |    Calendar-based     |  Calendar-based  |   Buffer-based   |    Visual     |     Proposed      |
| Progressive intervention        |     No      | Partial alerts |          No           |        No        |        No        |      No       |     Proposed      |
| Attention recovery              |     No      |    Partial     |          No           |        No        |        No        |      No       |     Proposed      |
| Context preservation            |     No      |       No       |        Limited        |   Task details   |   Task details   |    Limited    |     Proposed      |
| Communication styles            |     No      |       No       |          No           |        No        |        No        |      No       |     Proposed      |
| Visual themes                   |   Limited   |    Limited     |        Limited        |     Limited      |     Limited      | Visual design |     Proposed      |
| Needs-based onboarding          | No evidence |  No evidence   |      No evidence      |   No evidence    |   No evidence    |  No evidence  |     Proposed      |
| Graduated awareness permissions |     No      |       No       |          No           |        No        |        No        |      No       |     Proposed      |
| Explainable recommendations     |   Limited   |    Reports     |        Partial        |     Limited      | Scheduling rules |    Limited    |     Proposed      |
| Guardian experience             |     No      |       No       |          No           |        No        |        No        |      No       |      Future       |

### Matrix Limitation

A `No` entry means the capability was not identified as a meaningful
current product function during this research pass.

It does not prove that no version, experiment, hidden setting, or
future release contains the capability.

---

## 12. Competitive Problem Coverage

The competitors reviewed provide substantial coverage of planning and
distraction prevention.

### Strong Existing Coverage

#### Distraction Blocking

Strongly addressed by:

- Freedom
- RescueTime

#### Automatic Scheduling

Strongly addressed by:

- Motion
- Reclaim

#### Daily Planning and Timeboxing

Strongly addressed by:

- Sunsama
- Motion
- Reclaim

#### Visual Time Planning

Strongly addressed by:

- Structured
- Sunsama
- Motion
- Reclaim

#### Activity Tracking

Strongly addressed by:

- RescueTime

---

## 13. Potentially Less-Served Areas

The current research pass identified several areas that appear less
directly addressed by the reviewed competitors.

These are **potential gaps**, not validated market opportunities.

### 13.1 Attention Recovery

Most reviewed products attempt to:

```text
Prevent distraction
```

or:

```text
Measure distraction
```

Kairos is explicitly exploring:

```text
Distraction happened.
Now help me remember what I was doing.
```

That distinction may be significant.

### 13.2 Progressive Intervention

Existing products commonly use:

- Notifications
- Alerts
- Blocking
- Timers

The current competitive set did not reveal a strong equivalent to the
Kairos hypothesis of configurable escalation:

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
Restriction
```

This requires direct validation.

### 13.3 Transition Preparation

Calendar systems indicate that something begins at a specific time.

Some competitors also protect buffer time.

Kairos is exploring a more explicit transition process:

```text
Upcoming responsibility
        ↓
Prepare user
        ↓
Preserve current context
        ↓
Begin disengagement
        ↓
Transition
        ↓
Begin next activity
```

### 13.4 Needs-Based Companion Behavior

The reviewed products generally organize behavior around:

- Productivity preferences
- Scheduling rules
- Focus settings
- Task configuration

Kairos is exploring configuration around functional support needs such
as:

- Attention recovery
- Time awareness
- Prioritization
- Task initiation
- Transition difficulty
- Hyperfocus

### 13.5 Communication Personalization

The reviewed products provide varying visual experiences, but the
current research did not identify communication-style personalization
as a major product model.

Kairos is exploring communication independently from intervention
strength.

For example:

```text
Calm + Strict
Direct + Standard
Playful + Enhanced
Minimal + Strict
```

### 13.6 Contextual Attention Alignment

Activity tracking products can observe applications and websites.

Kairos is exploring a more difficult question:

> Does the user's observed activity reasonably align with their stated
> intention?

This distinction may represent meaningful differentiation.

It also creates significant privacy and technical risk.

---

## 14. Competitive Challenges to Kairos Assumptions

Competitive research should identify where the market challenges our
thinking rather than only where Kairos appears different.

### 14.1 Strong Automation May Be Desirable

Motion and Reclaim demonstrate products built around substantial
automatic decision-making.

This challenges the assumption that users always want to approve
meaningful schedule changes.

#### Research Implication

Kairos should investigate configurable automation authority.

---

### 14.2 Restriction Can Be a Desired Feature

Freedom demonstrates strong user-configured restriction behavior,
including sessions designed to resist early cancellation.

This challenges any assumption that restriction is inherently
anti-autonomy.

#### Research Implication

Autonomy may include the ability to deliberately restrict one's future
choices.

---

### 14.3 Historical Duration Learning Already Exists

Sunsama currently uses historical information to assist with task
duration estimates.

This weakens duration learning as a standalone Kairos
differentiator.

#### Research Implication

The Personal Time Model would need to provide additional value beyond
historical averages or generic task estimation.

---

### 14.4 Schedule Recovery Is Already Sophisticated

Motion and Reclaim can dynamically reorganize calendars when
circumstances change.

Kairos cannot assume Rescue Mode is unique simply because it
recalculates a schedule.

#### Research Implication

Potential differentiation may depend on combining schedule recovery
with:

- User state
- Remaining energy
- Attention context
- Task context
- Explainability
- User-controlled tradeoffs

---

### 14.5 Visual Planning Is Already Common

Structured, Sunsama, Motion, and Reclaim all provide ways to visualize
tasks against time.

#### Research Implication

Kairos should investigate **persistent contextual time awareness**
rather than treating a visual daily schedule itself as the innovation.

---

## 15. Emerging Kairos Differentiation Hypothesis

Based on the current competitive landscape, the strongest Kairos
differentiation hypothesis is becoming more specific.

Kairos may not primarily differentiate through:

```text
Task Lists
Timers
Calendars
Website Blocking
Automatic Scheduling
Time Tracking
```

These are established categories.

The stronger hypothesis is:

> **Kairos helps users maintain the relationship between intention,
> attention, and time while they are actively using their computer.**

This can be represented as:

```text
What did I intend to do?
        ↓
What am I doing now?
        ↓
Does that still make sense?
        ↓
How much time remains?
        ↓
What happens next?
        ↓
Do I need help returning or transitioning?
```

This is currently a **differentiation hypothesis**, not a validated
product position.

---

## 16. Potential Product Position

The competitive landscape suggests that Kairos may be better framed as
an **attention and transition companion** than as another productivity
planner.

For example:

```text
Traditional Planner

"What do you need to do today?"


Distraction Blocker

"What should you not be allowed to access?"


Automatic Scheduler

"When should your tasks happen?"


Activity Tracker

"Where did your computer time go?"


Kairos Hypothesis

"Does what you're doing right now still match
what you intended to be doing?"
```

That distinction provides a potentially clearer product identity.

It must still be validated through direct user research.

---

## 17. Direct and Adjacent Competition

### Direct Competitor Candidates

At the current stage, RescueTime may be the closest reviewed product
to direct competition because it combines:

- Background activity awareness
- Focus support
- Behavior-triggered intervention
- Distraction blocking

Even so, its primary model differs from the broader Kairos attention
and transition hypothesis.

### Strong Adjacent Competitors

#### Freedom

Adjacent through distraction prevention.

#### Sunsama

Adjacent through intentional planning, task estimation, and focus.

#### Motion

Adjacent through prioritization and adaptive scheduling.

#### Reclaim

Adjacent through adaptive planning, focus protection, and schedule
recovery.

#### Structured

Adjacent through visual time awareness.

---

## 18. Competitive Risks

### 18.1 Feature Creep

Kairos overlaps with several mature categories.

Attempting to compete feature-for-feature with every reviewed product
could result in an excessively broad product.

### 18.2 Weak Differentiation

Features such as:

- Timers
- Task lists
- Timeboxing
- Blocking
- AI scheduling
- Calendar integrations

are already widely available.

These capabilities should only enter Kairos when they directly support
its validated core experience.

### 18.3 Integration Burden

Recreating mature calendar, task-management, or project-management
systems may provide less value than integrating with them.

### 18.4 Privacy Burden

Kairos's proposed attention-awareness model could require more
sensitive permissions than many traditional planners.

Privacy may therefore become both a product differentiator and a major
adoption risk.

### 18.5 Intervention Risk

Kairos proposes to become more visible than some traditional
productivity applications.

If intervention behavior is poorly designed, Kairos could become more
distracting than the products it intends to improve upon.

---

## 19. Build Versus Integrate Opportunities

Competitive research suggests that Kairos should seriously consider
integration rather than replacement in several areas.

### Calendars

Potential integration targets may eventually include:

- Google Calendar
- Outlook Calendar
- Apple Calendar

Kairos may not need to become a complete calendar platform.

### Project and Task Systems

Potential integration may eventually be more appropriate than
rebuilding every project-management capability.

Examples could include:

- Todoist
- Microsoft To Do
- Jira
- Trello
- Asana
- GitHub

### Principle

Kairos should ask:

> Does this capability directly contribute to the Kairos core
> experience?

If not, integration may be preferable to duplication.

---

## 20. Competitive Research Questions

The current research creates several additional questions.

### CRQ-01

Do users currently combine multiple productivity applications to solve
the problems Kairos intends to address?

### CRQ-02

Would users prefer Kairos to replace existing planners or integrate
with them?

### CRQ-03

Does attention recovery provide meaningful value beyond blocking
distractions?

### CRQ-04

Would progressive intervention be perceived as more useful than
traditional notifications?

### CRQ-05

Does contextual attention alignment provide enough value to justify
the privacy required?

### CRQ-06

Would users prefer Kairos's recommendation-oriented schedule recovery
or stronger automatic rescheduling?

### CRQ-07

Does communication personalization meaningfully affect long-term
adoption?

### CRQ-08

Does persistent desktop support provide meaningful value compared with
opening a dedicated planner?

These questions should be incorporated into future user-research
planning where appropriate.

---

## 21. Impact on Current Assumptions

### Strengthened Assumptions

Competitive evidence makes several capabilities appear technically or
commercially plausible:

- User-authorized application restrictions
- Website restrictions
- Passive computer activity tracking
- Automatic scheduling
- Automatic rescheduling
- Historical duration tracking
- Focus-time protection

This does not validate Kairos's specific implementation.

### Challenged Assumptions

Competitive evidence challenges several current ideas:

#### Personal Time Model as Differentiator

Historical task estimation already exists.

#### Rescue Mode as Differentiator

Automatic schedule recovery already exists.

#### Restriction as Potentially Too Controlling

Users already adopt products built specifically around strong
self-imposed restrictions.

#### Recommendation-Only Automation

Existing products demonstrate meaningful demand for stronger automated
planning.

### Still-Unvalidated Assumptions

Competitive research does not validate:

- Progressive intervention
- Attention recovery
- Context-aware attention alignment
- Communication-style personalization
- Youth guardian experience
- Needs-based onboarding
- Kairos as a persistent desktop companion

These remain high-priority research areas.

---

## 22. Competitive Opportunity Map

The current landscape can be represented conceptually as:

```text
                 PLANNING
                    ↑
                    |
             Sunsama
          Motion / Reclaim
                    |
                    |
BLOCKING ← Freedom | RescueTime → TRACKING
                    |
                    |
                    |
                    ↓
               EXECUTION
```

Kairos is hypothesized to occupy a different position:

```text
                 PLANNING
                    ↑
                    |
                    |
               [ KAIROS ]
                    |
       Intention ↔ Attention ↔ Time
                    |
                    ↓
               EXECUTION
```

Kairos would therefore connect planning with what happens during
execution.

This positioning remains hypothetical.

---

## 23. Current Competitive Position

The competitive landscape already contains strong solutions for:

- Blocking distractions
- Tracking digital activity
- Planning daily tasks
- Timeboxing
- Automatically scheduling tasks
- Automatically rescheduling work
- Visualizing time
- Protecting focus periods

Kairos should not attempt to compete primarily by reproducing these
capabilities.

The most promising current differentiation hypothesis is instead:

> **Kairos remains aware of the user's intended activity and helps
> maintain, recover, or redirect attention as time and circumstances
> change.**

Potentially distinctive areas include:

1. Attention recovery after distraction.
2. Progressive intervention.
3. Context-aware attention alignment.
4. Transition preparation.
5. Task-context preservation.
6. Needs-based personalization.
7. Communication-style personalization.
8. User-controlled levels of intervention and awareness.
9. Integration between planning and active computer use.

These remain hypotheses until validated by users.

---

## 24. Research Limitations

### 24.1 Product Features Change

Competitor functionality can change frequently.

This document represents the competitive landscape observed during the
current research period.

### 24.2 Public Documentation

The analysis relies primarily on publicly available official product
documentation.

It does not represent exhaustive hands-on testing of every product.

### 24.3 Capability Does Not Equal Quality

A product containing a feature does not establish that the feature is
well designed or effective.

### 24.4 Market Presence Does Not Equal Validation

Competitor adoption does not prove that every individual feature
provides meaningful value.

### 24.5 Missing Feature Does Not Equal Opportunity

A capability absent from competitors may be absent because:

- Users do not want it.
- It is technically difficult.
- It creates privacy concerns.
- It creates poor UX.
- It does not provide enough commercial value.

Competitive gaps must therefore be validated through user research.

---

## 25. References

### Freedom

1. Freedom.
   [Freedom Features](https://freedom.to/features).

2. Freedom Support.
   [What's Included in Free and Premium Plans?](https://support.freedom.to/en/articles/13764747-what-s-included-in-free-and-premium-plans).

### RescueTime

3. RescueTime.
   [RescueTime](https://www.rescuetime.com/).

4. RescueTime Help Center.
   [How to Start a Focus Session](https://help.rescuetime.com/article/297-how-to-start-a-focus-session).

### Sunsama

5. Sunsama.
   [Timeboxing](https://www.sunsama.com/features/timeboxing).

6. Sunsama.
   [Daily Planning](https://www.sunsama.com/daily-planning).

7. Sunsama.
   [User Manual](https://help.sunsama.com/).

### Motion

8. Motion.
   [AI Calendar](https://www.usemotion.com/features/ai-calendar).

9. Motion.
   [AI Task Manager](https://www.usemotion.com/features/ai-task-manager).

10. Motion Help Center.
    [Auto-Scheduling](https://www.usemotion.com/help/time-management/auto-scheduling).

### Reclaim

11. Reclaim.
    [AI Planner](https://reclaim.ai/features/planner).

12. Reclaim.
    [Focus Time](https://reclaim.ai/features/focus-time).

13. Reclaim Help Center.
    [How Reclaim Manages Your Schedule Automatically](https://help.reclaim.ai/en/articles/6207587-how-reclaim-manages-your-schedule-automatically).

14. Reclaim Help Center.
    [How Reclaim Uses Priorities to Intelligently Plan Your
    Workweek](https://help.reclaim.ai/en/articles/8291694-how-reclaim-uses-priorities-to-intelligently-plan-your-workweek).

### Structured

15. Structured.
    [Structured Daily Planner](https://structured.app/).

---

## 26. Related Kairos Documentation

### Product Foundation

- [Product Vision](../00-product/PRODUCT_VISION.md)
- [Product Principles](../00-product/PRODUCT_PRINCIPLES.md)
- [Problem Statement](../00-product/PROBLEM_STATEMENT.md)
- [Goals and Non-Goals](../00-product/GOALS_AND_NON_GOALS.md)
- [Product Glossary](../00-product/GLOSSARY.md)

### Research

- [User Groups](USER_GROUPS.md)
- [User Needs](USER_NEEDS.md)
- [Research Questions](RESEARCH_QUESTIONS.md)
- [Assumptions and Hypotheses](ASSUMPTIONS_AND_HYPOTHESES.md)
- [Executive Function Research](EXECUTIVE_FUNCTION_RESEARCH.md)
