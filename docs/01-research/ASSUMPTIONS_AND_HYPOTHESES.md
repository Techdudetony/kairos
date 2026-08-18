# Kairos Assumptions and Hypotheses

**Document Status:** Draft  
**Version:** 0.1  
**Last Updated:** August 2026  
**Product:** Kairos  
**Document Owner:** Product / Research

---

## 1. Purpose

This document records the assumptions and hypotheses currently
influencing Kairos product decisions.

The purpose of maintaining an explicit assumption register is to
prevent unverified beliefs from silently becoming:

- Product requirements
- UX decisions
- Architecture decisions
- MVP commitments
- User-facing claims

An assumption may be reasonable without being validated.

Research should determine whether important assumptions are:

- Supported
- Not supported
- Partially supported
- Inconclusive
- No longer relevant

High-risk assumptions should receive research priority before major
decisions depend on them.

---

## 2. Terminology

### Assumption

Something the project currently believes or accepts as likely without
sufficient supporting evidence.

Example:

> Users will tolerate Kairos running continuously in the background.

### Hypothesis

A testable prediction derived from one or more assumptions.

Example:

> If Kairos remains unobtrusive while no assistance is needed, users
> will be more willing to keep it running throughout the day.

### Evidence

Information that helps evaluate an assumption or hypothesis.

Evidence may come from:

- User interviews
- Surveys
- Diary studies
- Usability tests
- Literature research
- Competitive research
- Technical experiments
- Production telemetry
- Support feedback

### Finding

An interpretation of collected evidence.

A finding should identify:

- What was observed
- What evidence supports it
- Relevant limitations
- Which assumptions are affected

### Decision

A product, UX, technical, or business choice made using available
evidence and constraints.

A decision should not be confused with a research finding.

---

## 3. Risk Classification

Assumptions will be evaluated using three primary dimensions.

### Impact

How damaging would it be if the assumption were wrong?

#### High

The assumption affects:

- Core product value
- User safety
- Privacy
- Accessibility
- Youth experience
- Major architecture
- MVP viability

#### Medium

The assumption affects meaningful product behavior but could be
changed without fundamentally invalidating Kairos.

#### Low

The assumption affects relatively contained behavior or later-stage
product decisions.

### Uncertainty

How much meaningful evidence currently supports the assumption?

#### High

Little or no direct evidence exists.

#### Medium

Some indirect or partial evidence exists.

#### Low

Strong relevant evidence exists.

### Research Risk

Research risk is determined by combining impact and uncertainty.

Conceptually:

```text
High Impact + High Uncertainty
        ↓
Critical Research Risk

High Impact + Medium Uncertainty
        ↓
High Research Risk

Medium Impact + High Uncertainty
        ↓
High Research Risk

Lower combinations
        ↓
Medium or Low Research Risk
```

Formal scoring may be introduced later if useful.

---

## 4. Assumption Status

Assumptions may use the following statuses:

```text
Unvalidated
In Research
Partial Evidence
Supported
Not Supported
Inconclusive
Revised
Retired
```

An assumption should remain `Unvalidated` until meaningful evidence
exists.

---

## 5. Product Value Assumptions

### A-PV01: Users Experience the Core Problems

**Impact:** High
**Uncertainty:** Medium
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

The Kairos target audience experiences meaningful difficulty with at
least one of the following:

- Prioritization
- Attention recovery
- Hyperfocus
- Time awareness
- Transitions

#### Why It Matters

Kairos has limited product value if the problems identified in the
Product Foundation are uncommon or insufficiently disruptive.

#### Related Research

- [RQ-P01](RESEARCH_QUESTIONS.md#rq-p01-prioritization-frequency)
- [RQ-P02](RESEARCH_QUESTIONS.md#rq-p02-prioritization-consequences)
- [RQ-P03](RESEARCH_QUESTIONS.md#rq-p03-attention-drift)
- [RQ-P05](RESEARCH_QUESTIONS.md#rq-p05-deep-focus-and-hyperfocus)
- [RQ-T01](RESEARCH_QUESTIONS.md#rq-t01-time-awareness)
- [RQ-TR01](RESEARCH_QUESTIONS.md#rq-tr01-transition-difficulty)

#### Hypothesis

> Users who experience these problems will report meaningful negative
> effects on task completion, time use, or fatigue.

---

### A-PV02: Computer Use Amplifies These Problems

**Impact:** High
**Uncertainty:** Medium
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

Using a computer creates or amplifies attention-management problems
because productive activities and distractions coexist within the
same environment.

#### Why It Matters

Kairos is currently positioned primarily as a desktop companion.

If computer-specific context is not meaningful, a desktop-first
approach may be unnecessarily narrow.

#### Related Research

- [RQ-P03](RESEARCH_QUESTIONS.md#rq-p03-attention-drift)
- [RQ-T01](RESEARCH_QUESTIONS.md#rq-t01-time-awareness)
- [RQ-C01](RESEARCH_QUESTIONS.md#rq-c01-existing-solutions)
- [RQ-C02](RESEARCH_QUESTIONS.md#rq-c02-existing-product-gaps)

#### Hypothesis

> Users will describe computer-based distractions and transitions as
> meaningfully different from equivalent offline situations.

---

### A-PV03: A Desktop Companion Provides More Value Than a Separate App

**Impact:** High
**Uncertainty:** High
**Research Risk:** Critical
**Status:** Unvalidated

#### Assumption

Users will benefit from Kairos being present within their normal
desktop environment rather than requiring them to repeatedly open a
traditional productivity application.

#### Why It Matters

This assumption strongly affects:

- Product identity
- Desktop architecture
- Background operation
- Widgets
- Notifications
- Overlays
- System permissions

#### Related Research

- [RQ-AR01](RESEARCH_QUESTIONS.md#rq-ar01-initial-value)
- [RQ-AR03](RESEARCH_QUESTIONS.md#rq-ar03-trust)
- [RQ-TECH01](RESEARCH_QUESTIONS.md#rq-tech01-background-operation)
- [RQ-TECH02](RESEARCH_QUESTIONS.md#rq-tech02-overlay-capability)

#### Hypothesis

> Users will find contextual desktop assistance more useful than a
> productivity system that depends on frequent manual checking.

---

## 6. Attention and Focus Assumptions

### A-AF01: Users Want Help Recovering From Distraction

**Impact:** High
**Uncertainty:** Medium
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

Users want assistance returning to an original task after becoming
distracted.

#### Related Research

- [RQ-P03](RESEARCH_QUESTIONS.md#rq-p03-attention-drift)
- [RQ-P04](RESEARCH_QUESTIONS.md#rq-p04-attention-recovery-information)

#### Hypothesis

> Preserving the user's original objective and next action will reduce
> the effort required to resume an interrupted task.

---

### A-AF02: Progressive Intervention Is Preferable

**Impact:** High
**Uncertainty:** High
**Research Risk:** Critical
**Status:** Unvalidated

#### Assumption

Users will prefer interventions that begin gently and become more
noticeable over time rather than receiving immediate high-intensity
interruptions.

#### Why It Matters

Progressive intervention is currently one of Kairos's foundational
product concepts.

#### Related Research

- [RQ-I01](RESEARCH_QUESTIONS.md#rq-i01-helpful-intervention)
- [RQ-I02](RESEARCH_QUESTIONS.md#rq-i02-escalation)
- [RQ-AR03](RESEARCH_QUESTIONS.md#rq-ar03-trust)

#### Hypothesis

> Users will perceive progressive escalation as less controlling and
> less disruptive than immediate strong intervention.

---

### A-AF03: Intervention Strength Should Be User-Controlled

**Impact:** High
**Uncertainty:** Medium
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

Users want meaningful control over how strongly Kairos intervenes.

#### Related Research

- [RQ-I03](RESEARCH_QUESTIONS.md#rq-i03-dismissal-versus-override)
- [RQ-I04](RESEARCH_QUESTIONS.md#rq-i04-strict-focus)
- [RQ-AR03](RESEARCH_QUESTIONS.md#rq-ar03-trust)

#### Hypothesis

> Users will be more willing to enable stronger interventions when
> they can intentionally configure or delegate that authority.

---

### A-AF04: Strict Focus Has User Value

**Impact:** Medium
**Uncertainty:** High
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

Some users want Kairos to temporarily restrict selected websites or
applications during certain focus sessions.

#### Related Research

- [RQ-I04](RESEARCH_QUESTIONS.md#rq-i04-strict-focus)
- [RQ-TECH04](RESEARCH_QUESTIONS.md#rq-tech04-restrictions)

#### Hypothesis

> Users who intentionally choose Strict Focus will perceive temporary
> restrictions as helpful rather than controlling.

---

### A-AF05: Deep Focus Should Not Be Treated as Failure

**Impact:** High
**Uncertainty:** Medium
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

Users experience deep focus as beneficial in some contexts and
problematic mainly when disengagement becomes difficult.

#### Related Research

- [RQ-P05](RESEARCH_QUESTIONS.md#rq-p05-deep-focus-and-hyperfocus)
- [RQ-TR01](RESEARCH_QUESTIONS.md#rq-tr01-transition-difficulty)
- [RQ-TR02](RESEARCH_QUESTIONS.md#rq-tr02-transition-warning)

#### Hypothesis

> Users will prefer Kairos to preserve beneficial deep focus while
> helping them prepare for required transitions.

---

## 7. Time Management Assumptions

### A-TM01: Users Benefit From Persistent Time Awareness

**Impact:** High
**Uncertainty:** Medium
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

Users benefit from seeing time information while actively engaged in
an activity rather than only receiving scheduled notifications.

#### Related Research

- [RQ-T01](RESEARCH_QUESTIONS.md#rq-t01-time-awareness)
- [RQ-T02](RESEARCH_QUESTIONS.md#rq-t02-time-representation)

#### Hypothesis

> Persistent or contextual time indicators will reduce the frequency
> with which users unexpectedly discover that significant time has
> passed.

---

### A-TM02: Generic Time Estimates Are Insufficient

**Impact:** Medium
**Uncertainty:** High
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

Generic estimates do not adequately represent how long tasks take for
individual users.

#### Related Research

- [RQ-T03](RESEARCH_QUESTIONS.md#rq-t03-time-estimation)
- [RQ-T04](RESEARCH_QUESTIONS.md#rq-t04-context-and-duration)

#### Hypothesis

> Historical user-specific duration data will produce estimates that
> users consider more useful than generic estimates.

---

### A-TM03: Context Meaningfully Affects Duration

**Impact:** Medium
**Uncertainty:** High
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

The same category of task may require substantially different amounts
of time depending on context.

Example:

```text
Task:
Clean room

Context:
Light cleanup
versus
Major cleanup
```

#### Related Research

- [RQ-T04](RESEARCH_QUESTIONS.md#rq-t04-context-and-duration)

#### Hypothesis

> Capturing a small number of relevant context variables will improve
> future task-duration estimates.

---

### A-TM04: Users Will Record Actual Duration

**Impact:** Medium
**Uncertainty:** High
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

Users will provide enough completion-time information for Kairos to
learn from previous activities.

#### Why It Matters

A future Personal Time Model depends on sufficient quality historical
data.

#### Related Research

- [RQ-T03](RESEARCH_QUESTIONS.md#rq-t03-time-estimation)

Additional prototype research may be required.

#### Hypothesis

> Users will record task completion information when the process
> requires minimal effort and produces visible future value.

---

## 8. Planning Assumptions

### A-PL01: Task Decomposition Reduces Initiation Friction

**Impact:** Medium
**Uncertainty:** Medium
**Research Risk:** Medium
**Status:** Unvalidated

#### Assumption

Breaking vague activities into smaller actions helps users begin them.

#### Related Research

- [RQ-PL01](RESEARCH_QUESTIONS.md#rq-pl01-task-initiation)
- [RQ-PL02](RESEARCH_QUESTIONS.md#rq-pl02-vague-tasks)
- [RQ-PL03](RESEARCH_QUESTIONS.md#rq-pl03-decomposition-detail)

#### Hypothesis

> Users will begin vague tasks more easily when Kairos helps identify
> a clear next action.

---

### A-PL02: Too Much Decomposition Can Become Overwhelming

**Impact:** Medium
**Uncertainty:** Medium
**Research Risk:** Medium
**Status:** Unvalidated

#### Assumption

A highly detailed task breakdown may increase cognitive load instead
of reducing it.

#### Related Research

- [RQ-PL03](RESEARCH_QUESTIONS.md#rq-pl03-decomposition-detail)

#### Hypothesis

> Users will prefer task decomposition that initially emphasizes the
> next few actions rather than exposing every possible subtask at
> once.

---

### A-PL03: Users Want Prioritization Recommendations

**Impact:** High
**Uncertainty:** High
**Research Risk:** Critical
**Status:** Unvalidated

#### Assumption

Users want Kairos to help recommend what deserves attention first.

#### Why It Matters

Prioritization is one of the three primary Kairos problem areas.

#### Related Research

- [RQ-P01](RESEARCH_QUESTIONS.md#rq-p01-prioritization-frequency)
- [RQ-P02](RESEARCH_QUESTIONS.md#rq-p02-prioritization-consequences)

#### Hypothesis

> Users will value prioritization recommendations when the factors
> behind the recommendation are understandable and editable.

---

### A-PL04: Users Want Schedule Recovery Assistance

**Impact:** Medium
**Uncertainty:** High
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

Users want help reorganizing the remainder of their schedule after a
plan becomes unrealistic.

#### Related Research

- [RQ-PL04](RESEARCH_QUESTIONS.md#rq-pl04-schedule-recovery)

#### Hypothesis

> Users will prefer receiving a realistic revised plan over being
> shown an increasingly overdue original schedule.

---

## 9. Personalization Assumptions

### A-PE01: Customization Improves Adoption

**Impact:** Medium
**Uncertainty:** Medium
**Research Risk:** Medium
**Status:** Unvalidated

#### Assumption

Users are more likely to continue using Kairos when they can
meaningfully customize the experience.

#### Related Research

- [RQ-PE01](RESEARCH_QUESTIONS.md#rq-pe01-personalization-value)
- [RQ-AR01](RESEARCH_QUESTIONS.md#rq-ar01-initial-value)
- [RQ-AR02](RESEARCH_QUESTIONS.md#rq-ar02-abandonment)

#### Hypothesis

> Behavioral and visual customization will increase perceived fit
> across different users and age groups.

---

### A-PE02: Age Is a Weak Predictor of Style Preference

**Impact:** Medium
**Uncertainty:** High
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

Individual preferences are more useful than age alone for determining
theme, communication style, gamification, and visual presentation.

#### Related Research

- [RQ-PE03](RESEARCH_QUESTIONS.md#rq-pe03-age-and-appearance)

#### Hypothesis

> Significant preference variation will exist within each age cohort,
> making age-based visual defaults insufficient.

---

### A-PE03: Communication Style Affects Intervention Acceptance

**Impact:** Medium
**Uncertainty:** High
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

How Kairos communicates meaningfully affects how users respond to
reminders and interventions.

#### Related Research

- [RQ-PE02](RESEARCH_QUESTIONS.md#rq-pe02-communication-style)
- [RQ-I01](RESEARCH_QUESTIONS.md#rq-i01-helpful-intervention)

#### Hypothesis

> Users will rate otherwise identical interventions differently based
> on communication style.

---

### A-PE04: Communication Style and Strictness Should Be Independent

**Impact:** Medium
**Uncertainty:** Medium
**Research Risk:** Medium
**Status:** Unvalidated

#### Assumption

Users may want combinations such as:

```text
Calm + Strict
Direct + Standard
Playful + Enhanced
Minimal + Strict
```

#### Related Research

- [RQ-PE02](RESEARCH_QUESTIONS.md#rq-pe02-communication-style)
- [RQ-I04](RESEARCH_QUESTIONS.md#rq-i04-strict-focus)

#### Hypothesis

> Preferred communication tone will not reliably predict preferred
> intervention strength.

---

## 10. Privacy Assumptions

### A-PR01: Activity Awareness Improves Focus Assistance

**Impact:** High
**Uncertainty:** High
**Research Risk:** Critical
**Status:** Unvalidated

#### Assumption

Knowing limited information about active applications or websites
allows Kairos to provide meaningfully better attention assistance.

#### Related Research

- [RQ-PR01](RESEARCH_QUESTIONS.md#rq-pr01-activity-awareness)
- [RQ-TECH03](RESEARCH_QUESTIONS.md#rq-tech03-activity-detection)

#### Hypothesis

> Application or domain awareness will improve Kairos's ability to
> identify likely attention drift compared with timer-only awareness.

---

### A-PR02: Users Will Accept Graduated Activity Awareness

**Impact:** High
**Uncertainty:** High
**Research Risk:** Critical
**Status:** Unvalidated

#### Assumption

Users will accept activity awareness when they can choose from clear
permission levels.

#### Related Research

- [RQ-PR01](RESEARCH_QUESTIONS.md#rq-pr01-activity-awareness)
- [RQ-AR03](RESEARCH_QUESTIONS.md#rq-ar03-trust)

#### Hypothesis

> Users will be more willing to enable activity awareness when each
> level clearly explains what Kairos can observe and what additional
> benefit it provides.

---

### A-PR03: Local Processing Increases Trust

**Impact:** High
**Uncertainty:** Medium
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

Users will be more comfortable with advanced activity awareness when
sensitive analysis occurs locally.

#### Related Research

- [RQ-PR02](RESEARCH_QUESTIONS.md#rq-pr02-local-processing)
- [RQ-TECH05](RESEARCH_QUESTIONS.md#rq-tech05-local-intelligence)

#### Hypothesis

> Users will report greater willingness to enable activity awareness
> when activity data remains on their device.

---

### A-PR04: Users Expect Sensitive Defaults

**Impact:** High
**Uncertainty:** Medium
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

Users expect Kairos to avoid monitoring sensitive application
categories unless explicitly permitted.

#### Related Research

- [RQ-PR03](RESEARCH_QUESTIONS.md#rq-pr03-sensitive-applications)

#### Hypothesis

> Privacy-protective defaults will increase trust even when users have
> the option to broaden permissions later.

---

## 11. Youth and Guardian Assumptions

### A-Y01: Younger Users Need Some Guardian Support

**Impact:** High
**Uncertainty:** High
**Research Risk:** Critical
**Status:** Unvalidated

#### Assumption

Some users under 18 will require guardian involvement for setup,
permissions, or selected restrictions.

#### Related Research

- [RQ-Y01](RESEARCH_QUESTIONS.md#rq-y01-guardian-role)

Relevant legal and regulatory research will also be required.

#### Hypothesis

> Guardian-supported setup can provide appropriate safety without
> requiring guardians to control the full Kairos experience.

---

### A-Y02: Surveillance Would Reduce Youth Trust

**Impact:** High
**Uncertainty:** Medium
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

Younger users will trust Kairos less if guardians can inspect detailed
computer activity.

#### Related Research

- [RQ-Y02](RESEARCH_QUESTIONS.md#rq-y02-youth-privacy)
- [RQ-Y04](RESEARCH_QUESTIONS.md#rq-y04-guardian-restrictions)
- [RQ-AR03](RESEARCH_QUESTIONS.md#rq-ar03-trust)

#### Hypothesis

> Youth users will prefer guardian visibility focused on routines and
> permissions rather than detailed activity history.

---

### A-Y03: Transparency Improves Guardian and Youth Trust

**Impact:** High
**Uncertainty:** Medium
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

Both younger users and guardians benefit from clearly understanding
which settings and information each party can access.

#### Related Research

- [RQ-Y03](RESEARCH_QUESTIONS.md#rq-y03-transparency)
- [RQ-AR03](RESEARCH_QUESTIONS.md#rq-ar03-trust)

#### Hypothesis

> Explicit visibility into guardian permissions will produce greater
> trust than hidden or ambiguous controls.

---

## 12. Accessibility Assumptions

### A-AC01: One Intervention Format Is Insufficient

**Impact:** High
**Uncertainty:** Low
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

Kairos cannot depend exclusively on sound, animation, color, or any
other single sensory channel for important interventions.

#### Related Research

- [RQ-A01](RESEARCH_QUESTIONS.md#rq-a01-intervention-accessibility)
- [RQ-A03](RESEARCH_QUESTIONS.md#rq-a03-keyboard-and-assistive-technology)

#### Hypothesis

> Important interventions will require equivalent or complementary
> presentation methods to support different accessibility needs.

---

### A-AC02: Sensory Preferences Vary Significantly

**Impact:** Medium
**Uncertainty:** Medium
**Research Risk:** Medium
**Status:** Unvalidated

#### Assumption

Users differ significantly in their tolerance for:

- Motion
- Sound
- Animation
- Visual density
- Notification intensity

#### Related Research

- [RQ-A02](RESEARCH_QUESTIONS.md#rq-a02-sensory-preferences)

#### Hypothesis

> Configurable sensory behavior will reduce the likelihood that Kairos
> itself becomes distracting or overwhelming.

---

## 13. Explainability Assumptions

### A-EX01: Explanations Increase Appropriate Trust

**Impact:** High
**Uncertainty:** Medium
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

Users are more willing to consider personalized recommendations when
they can understand the reasoning behind them.

#### Related Research

- [RQ-E01](RESEARCH_QUESTIONS.md#rq-e01-explanation-expectations)
- [RQ-E02](RESEARCH_QUESTIONS.md#rq-e02-explanation-depth)
- [RQ-AR03](RESEARCH_QUESTIONS.md#rq-ar03-trust)

#### Hypothesis

> Explanations will increase appropriate trust in Kairos
> recommendations without requiring users to blindly follow them.

---

### A-EX02: Users Want Different Explanation Depths

**Impact:** Medium
**Uncertainty:** High
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

Some users want minimal explanations while others want additional
detail.

#### Related Research

- [RQ-E02](RESEARCH_QUESTIONS.md#rq-e02-explanation-depth)

#### Hypothesis

> Layered explanations will be more usable than forcing the same
> explanation depth on every user.

---

### A-EX03: Corrections Can Improve Personalization

**Impact:** Medium
**Uncertainty:** Medium
**Research Risk:** Medium
**Status:** Unvalidated

#### Assumption

When users correct Kairos, those corrections can provide meaningful
information for future recommendations.

#### Related Research

- [RQ-E03](RESEARCH_QUESTIONS.md#rq-e03-correction)

#### Hypothesis

> A low-friction correction mechanism will improve future
> personalization and user trust.

---

## 14. Adoption Assumptions

### A-AR01: Kairos Must Demonstrate Value Quickly

**Impact:** High
**Uncertainty:** Low
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

Users will not tolerate substantial configuration effort before Kairos
provides meaningful value.

#### Related Research

- [RQ-AR01](RESEARCH_QUESTIONS.md#rq-ar01-initial-value)
- [RQ-AR02](RESEARCH_QUESTIONS.md#rq-ar02-abandonment)

#### Hypothesis

> Users will be more likely to continue using Kairos when onboarding
> produces useful assistance quickly.

---

### A-AR02: Excessive Intervention Will Cause Abandonment

**Impact:** High
**Uncertainty:** Medium
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

Users will disable or uninstall Kairos if it interrupts them too
frequently or at inappropriate moments.

#### Related Research

- [RQ-I01](RESEARCH_QUESTIONS.md#rq-i01-helpful-intervention)
- [RQ-AR02](RESEARCH_QUESTIONS.md#rq-ar02-abandonment)

#### Hypothesis

> Intervention frequency and relevance will strongly influence
> continued product use.

---

### A-AR03: Privacy Concerns May Block Adoption

**Impact:** High
**Uncertainty:** Medium
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

Users may reject Kairos even if they value its functionality when they
do not trust its activity-awareness behavior.

#### Related Research

- [RQ-PR01](RESEARCH_QUESTIONS.md#rq-pr01-activity-awareness)
- [RQ-PR02](RESEARCH_QUESTIONS.md#rq-pr02-local-processing)
- [RQ-AR02](RESEARCH_QUESTIONS.md#rq-ar02-abandonment)
- [RQ-AR03](RESEARCH_QUESTIONS.md#rq-ar03-trust)

#### Hypothesis

> Transparent permissions and privacy-protective defaults will
> meaningfully affect adoption.

---

## 15. Technical Assumptions

### A-TECH01: Continuous Background Operation Is Feasible

**Impact:** High
**Uncertainty:** High
**Research Risk:** Critical
**Status:** Unvalidated

#### Assumption

Kairos can remain active throughout normal computer use without
unacceptable CPU, memory, battery, or performance impact.

#### Related Research

- [RQ-TECH01](RESEARCH_QUESTIONS.md#rq-tech01-background-operation)

#### Hypothesis

> Core Kairos background services can operate within acceptable
> resource limits on supported hardware.

---

### A-TECH02: Reliable Overlays Are Feasible

**Impact:** High
**Uncertainty:** High
**Research Risk:** Critical
**Status:** Unvalidated

#### Assumption

Kairos can present overlays above normal desktop applications in a
reliable and accessible manner.

#### Related Research

- [RQ-TECH02](RESEARCH_QUESTIONS.md#rq-tech02-overlay-capability)

#### Hypothesis

> Supported operating systems provide sufficient APIs for Kairos to
> display user-authorized interventions without unacceptable
> compatibility problems.

---

### A-TECH03: Activity Awareness Is Technically Feasible

**Impact:** High
**Uncertainty:** High
**Research Risk:** Critical
**Status:** Unvalidated

#### Assumption

Kairos can obtain enough application and browser context to support
the proposed awareness model without unsafe or excessively invasive
techniques.

#### Related Research

- [RQ-TECH03](RESEARCH_QUESTIONS.md#rq-tech03-activity-detection)
- [RQ-PR01](RESEARCH_QUESTIONS.md#rq-pr01-activity-awareness)

#### Hypothesis

> At least the lower proposed activity-awareness levels can be
> implemented using supported operating-system capabilities.

---

### A-TECH04: Local Intelligence Is Practical

**Impact:** Medium
**Uncertainty:** High
**Research Risk:** High
**Status:** Unvalidated

#### Assumption

Some future adaptive or intelligent Kairos capabilities can operate
locally.

#### Related Research

- [RQ-TECH05](RESEARCH_QUESTIONS.md#rq-tech05-local-intelligence)
- [RQ-PR02](RESEARCH_QUESTIONS.md#rq-pr02-local-processing)

#### Hypothesis

> Selected classification and personalization capabilities can run
> locally with acceptable performance and model quality.

---

## 16. Highest-Risk Assumptions

The following assumptions currently represent the greatest product or
technical uncertainty.

| ID       | Assumption                                | Risk     |
| -------- | ----------------------------------------- | -------- |
| A-PV03   | Desktop companion adds meaningful value   | Critical |
| A-AF02   | Progressive intervention is preferable    | Critical |
| A-PL03   | Users want prioritization recommendations | Critical |
| A-PR01   | Activity awareness improves assistance    | Critical |
| A-PR02   | Users accept graduated monitoring         | Critical |
| A-Y01    | Guardian support can preserve autonomy    | Critical |
| A-TECH01 | Background operation is feasible          | Critical |
| A-TECH02 | Overlay behavior is feasible              | Critical |
| A-TECH03 | Activity awareness is feasible            | Critical |

These assumptions should receive priority when research planning and
technical experiments begin.

---

## 17. Assumption-to-Decision Traceability

Important decisions should identify which assumptions they depend on.

Example:

```text
A-AF02
Progressive intervention is preferable
        ↓
Research
        ↓
Supported / Revised / Rejected
        ↓
Intervention UX Decision
        ↓
Product Requirement
        ↓
Jira Epic
        ↓
Implementation
```

If an assumption later proves incorrect, traceability should help
identify which decisions require reevaluation.

---

## 18. Assumption Review Process

The assumption register should be reviewed:

- After major research studies
- Before MVP scope is finalized
- Before major architecture decisions
- Before implementing high-risk monitoring capabilities
- Before youth functionality is released
- When evidence contradicts an existing assumption

During review, each assumption should be evaluated for:

1. Current status
2. Available evidence
3. Remaining uncertainty
4. Decision impact
5. Research priority

---

## 19. Adding New Assumptions

New assumptions should receive:

- A unique ID
- A clear statement
- Impact rating
- Uncertainty rating
- Research-risk rating
- Current status
- Explanation of why the assumption matters
- Related research questions
- At least one testable hypothesis

Assumptions should not be removed simply because they are disproven.

When useful for historical traceability, they should remain in the
register with a status such as:

```text
Not Supported
Revised
Retired
```

---

## 20. Current Research Position

Kairos currently contains several high-risk assumptions involving:

- Desktop companion value
- Progressive intervention
- Prioritization assistance
- Activity awareness
- Privacy
- Guardian involvement
- Background operation
- Screen overlays

These assumptions should not be treated as settled product facts.

The purpose of the next stages of research is to reduce uncertainty
before major requirements and architecture decisions depend on them.
