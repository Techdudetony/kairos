# Kairos Executive Function Research

**Document Status:** Research Draft  
**Version:** 0.1  
**Last Updated:** August 2026  
**Product:** Kairos  
**Document Owner:** Product / Research

---

## 1. Purpose

This document summarizes external research relevant to the cognitive
and behavioral problems Kairos intends to investigate.

The research focuses on:

- Executive function
- Working memory
- Inhibitory control
- Cognitive flexibility
- Attention regulation
- Task switching
- Interruptions and task resumption
- Time perception
- Time management
- Deep concentration and hyperfocus
- ADHD
- Autism
- Executive-function development

The purpose of this document is not to establish clinical claims about
Kairos users.

Instead, it provides an evidence base that can help the project:

1. Evaluate existing product assumptions.
2. Identify research questions requiring additional validation.
3. Avoid unsupported claims about neurodivergence.
4. Identify potentially important design considerations.
5. Separate scientific findings from product interpretation.

Kairos is not intended to diagnose or treat ADHD, autism, or any other
medical or psychological condition.

---

## 2. Evidence Interpretation

Three types of statements are distinguished throughout this document.

### Research Finding

A conclusion supported by the external literature reviewed.

### Kairos Relevance

An interpretation of why the research may matter to the Kairos problem
space.

This is a product interpretation rather than a finding made by the
cited researchers.

### Potential Design Implication

A possible product or UX direction suggested by the evidence.

A design implication is not a requirement.

It must still be evaluated through:

- User research
- Usability testing
- Accessibility review
- Privacy review
- Technical feasibility
- MVP prioritization

The relationship should therefore be understood as:

```text
External Evidence
        ↓
Research Finding
        ↓
Kairos Relevance
        ↓
Potential Design Implication
        ↓
User / Technical Validation
        ↓
Possible Requirement
```

---

## 3. Executive Function

### 3.1 What Is Executive Function?

Executive function is an umbrella term describing cognitive processes
used to control thought and behavior in pursuit of goals.

A widely cited review by Diamond identifies three core executive
functions:

1. Inhibitory control
2. Working memory
3. Cognitive flexibility

More complex executive functions, including reasoning, problem
solving, and planning, build upon these core processes.

Executive functions contribute to activities such as:

- Remaining focused
- Resisting competing responses
- Holding goals in mind
- Changing strategies
- Planning
- Responding to unexpected situations

([Diamond, 2013](https://doi.org/10.1146/annurev-psych-113011-143750))

### Research Finding

Executive function should not be treated as one single cognitive
ability.

It contains related but distinguishable processes.

### Kairos Relevance

Many problems Kairos currently describes as a single user experience
may involve several underlying processes.

For example:

```text
"I forgot what I was doing."
```

may involve working memory or goal maintenance.

```text
"I know I need to stop, but I keep doing this."
```

may involve attention regulation, inhibition, cognitive flexibility,
motivation, or several interacting factors.

```text
"I don't know what to do first."
```

may involve planning, prioritization, working memory, cognitive load,
or other factors.

Kairos should therefore avoid assuming that one intervention will
address every superficially similar behavior.

### Potential Design Implication

Kairos may eventually need different forms of assistance for different
functional problems rather than relying on a single generic "focus"
intervention.

### Related Research Questions

- [RQ-P01](RESEARCH_QUESTIONS.md#rq-p01-prioritization-frequency)
- [RQ-P03](RESEARCH_QUESTIONS.md#rq-p03-attention-drift)
- [RQ-PL01](RESEARCH_QUESTIONS.md#rq-pl01-task-initiation)

### Related Assumptions

- [A-PV01](ASSUMPTIONS_AND_HYPOTHESES.md#a-pv01-users-experience-the-core-problems)
- [A-AF01](ASSUMPTIONS_AND_HYPOTHESES.md#a-af01-users-want-help-recovering-from-distraction)

---

## 4. Inhibitory Control

### 4.1 Definition

Inhibitory control refers to processes involved in controlling
attention, behavior, thoughts, or responses when another response may
otherwise dominate.

Diamond describes inhibition as including both response inhibition and
interference control, including selective attention and cognitive
inhibition.

([Diamond, 2013](https://doi.org/10.1146/annurev-psych-113011-143750))

### Research Finding

Inhibitory control contributes to goal-directed behavior and resistance
to competing responses or stimuli.

However, executive-function performance varies between individuals and
should not be inferred solely from diagnostic status.

Comparative reviews of ADHD and autism also show that executive
function profiles overlap and are not cleanly separated by diagnosis.

([Craig et al., 2016](https://doi.org/10.2147/NDT.S104620))

([Townes et al., 2023](https://doi.org/10.1177/10870547231190494))

### Kairos Relevance

A computer creates an environment where goal-relevant and highly
engaging alternatives may exist immediately beside one another.

For example:

```text
Intended Activity:
Research history assignment

Potential Competing Activity:
Recommended entertainment video

Both Activities:
Available within the same browser
```

The presence of a competing activity does not establish that the user
intentionally abandoned the original goal.

### Potential Design Implication

Kairos should avoid framing distraction as misconduct.

Attention-support experiences may be more useful when they help restore
the intended goal rather than criticize the competing behavior.

### Related Research Questions

- [RQ-P03](RESEARCH_QUESTIONS.md#rq-p03-attention-drift)
- [RQ-I01](RESEARCH_QUESTIONS.md#rq-i01-helpful-intervention)

### Related Assumptions

- [A-PV02](ASSUMPTIONS_AND_HYPOTHESES.md#a-pv02-computer-use-amplifies-these-problems)
- [A-AF02](ASSUMPTIONS_AND_HYPOTHESES.md#a-af02-progressive-intervention-is-preferable)

---

## 5. Working Memory

### 5.1 Definition

Working memory supports the temporary maintenance and manipulation of
information while performing an activity.

It contributes to behaviors such as:

- Remembering a goal
- Following multi-step instructions
- Maintaining task state
- Connecting previous and current actions
- Resuming interrupted work

Working memory is one of the core executive functions identified in
major executive-function frameworks.

([Diamond, 2013](https://doi.org/10.1146/annurev-psych-113011-143750))

### Research Finding

Working memory contributes to maintaining information needed for
goal-directed behavior.

Interruptions can create additional cognitive demands because
information about the primary task must be preserved or reconstructed
after attention has moved elsewhere.

Research on interruptions more broadly has documented failures and
performance costs associated with distraction and interruption.

([Couffe & Michael, 2017](https://doi.org/10.5406/amerjpsyc.130.2.0163))

### Kairos Relevance

The Kairos problem:

> "What was I doing?"

has a strong conceptual relationship with interruption recovery and
goal maintenance.

After an interruption, the user may need to reconstruct:

```text
What was my goal?

Where was I?

What had I already completed?

What was I about to do?

What should I do next?
```

The effort required to reconstruct this information creates additional
friction before work can resume.

### Potential Design Implication

Kairos should investigate whether preserving task context reduces
resumption effort.

Potential context may include:

- Current objective
- Last completed action
- Next intended action
- Relevant notes
- Time remaining

This should be tested rather than assumed.

### Related Research Questions

- [RQ-P04](RESEARCH_QUESTIONS.md#rq-p04-attention-recovery-information)
- [RQ-TR03](RESEARCH_QUESTIONS.md#rq-tr03-context-preservation)

### Related Assumptions

- [A-AF01](ASSUMPTIONS_AND_HYPOTHESES.md#a-af01-users-want-help-recovering-from-distraction)

---

## 6. Cognitive Flexibility

### 6.1 Definition

Cognitive flexibility involves adapting thought or behavior when
circumstances, goals, or task demands change.

It contributes to the ability to:

- Switch tasks
- Adjust plans
- Respond to new information
- Change strategies
- Transition between activities

Cognitive flexibility is one of the three core executive functions
described by Diamond.

([Diamond, 2013](https://doi.org/10.1146/annurev-psych-113011-143750))

### Research Finding

Cognitive flexibility supports adaptation to changing circumstances.

Research across ADHD and autism also demonstrates that executive
function differences are heterogeneous and overlapping rather than
being represented by simple diagnosis-specific profiles.

([Craig et al., 2016](https://doi.org/10.2147/NDT.S104620))

([Townes et al., 2023](https://doi.org/10.1177/10870547231190494))

### Kairos Relevance

A transition is not necessarily instantaneous.

The instruction:

> Stop working on this and go to the meeting.

may require several cognitive and practical actions.

For example:

```text
Recognize upcoming meeting
        ↓
Disengage from current task
        ↓
Preserve unfinished context
        ↓
Save work
        ↓
Determine meeting location / link
        ↓
Shift mental context
        ↓
Join meeting
```

### Potential Design Implication

Kairos should investigate transitions as processes rather than single
notification events.

A useful transition system may need to provide preparation time rather
than only alerting the user when the next activity begins.

### Related Research Questions

- [RQ-TR01](RESEARCH_QUESTIONS.md#rq-tr01-transition-difficulty)
- [RQ-TR02](RESEARCH_QUESTIONS.md#rq-tr02-transition-warning)
- [RQ-TR03](RESEARCH_QUESTIONS.md#rq-tr03-context-preservation)

### Related Assumptions

- [A-AF05](ASSUMPTIONS_AND_HYPOTHESES.md#a-af05-deep-focus-should-not-be-treated-as-failure)

---

## 7. Interruptions and Task Resumption

### 7.1 Interruption Costs

Interruptions can require the user to suspend one activity, process
another activity, and later reconstruct enough of the original task to
continue.

A review by Couffe and Michael describes failures associated with both
interruptions and distractions and emphasizes the importance of
understanding the cognitive processes involved when attention is
redirected.

([Couffe & Michael, 2017](https://doi.org/10.5406/amerjpsyc.130.2.0163))

### Research Finding

Interruptions may contribute to:

- Increased cognitive effort
- Difficulty resuming the original task
- Increased opportunity for errors
- Loss or weakening of task context

The severity of interruption effects can depend on characteristics of
the interrupted task, interrupting activity, and individual.

### Kairos Relevance

Kairos should not evaluate successful distraction recovery solely by
whether the user returns to the correct application.

For example:

```text
User returns to VS Code.
```

does not necessarily mean:

```text
User remembers what they were implementing.
```

Physical return and cognitive recovery are different.

### Potential Design Implication

Attention Recovery should investigate two outcomes:

```text
Return

Did the user return to the intended activity?


Recovery

Could the user reconstruct the intended goal and
continue effectively?
```

### Related Research Questions

- [RQ-P03](RESEARCH_QUESTIONS.md#rq-p03-attention-drift)
- [RQ-P04](RESEARCH_QUESTIONS.md#rq-p04-attention-recovery-information)

### Related Assumptions

- [A-AF01](ASSUMPTIONS_AND_HYPOTHESES.md#a-af01-users-want-help-recovering-from-distraction)

---

## 8. Kairos Can Become an Interruption

Kairos itself may interrupt the user's activity.

This creates an important product-design tension.

### Research Finding

Interruption research demonstrates that interruptions can create
cognitive costs and failures.

This means even an interruption intended to help the user may require
the user to temporarily redirect attention away from their current
task.

([Couffe & Michael, 2017](https://doi.org/10.5406/amerjpsyc.130.2.0163))

### Kairos Relevance

A focus application that interrupts too aggressively could contribute
to the same problem it intends to reduce.

For example:

```text
User is focused successfully
        ↓
Kairos interrupts
        ↓
User processes Kairos intervention
        ↓
Original task context may weaken
        ↓
User must resume original task
```

Kairos should therefore distinguish between:

```text
Information worth displaying

and

Information worth interrupting for
```

### Potential Design Implication

This evidence strengthens the need to test the current progressive
intervention hypothesis.

Low-intensity states may need to remain ambient whenever possible.

Stronger interventions should require meaningful justification.

### Related Research Questions

- [RQ-I01](RESEARCH_QUESTIONS.md#rq-i01-helpful-intervention)
- [RQ-I02](RESEARCH_QUESTIONS.md#rq-i02-escalation)
- [RQ-AR02](RESEARCH_QUESTIONS.md#rq-ar02-abandonment)

### Related Assumptions

- [A-AF02](ASSUMPTIONS_AND_HYPOTHESES.md#a-af02-progressive-intervention-is-preferable)
- [A-AR02](ASSUMPTIONS_AND_HYPOTHESES.md#a-ar02-excessive-intervention-will-cause-abandonment)

---

## 9. Time Perception and ADHD

### 9.1 Terminology

Research discussed under the broad concept of time perception can
include several distinct constructs.

These include:

- Time estimation
- Time reproduction
- Time production
- Duration discrimination
- Time management

Mette's 2023 review examined research on adult ADHD and several of
these time-related constructs.

([Mette, 2023](https://doi.org/10.3390/ijerph20043098))

### Research Finding

The adult ADHD time-perception literature remains limited.

Mette found that relatively few studies had examined adult ADHD during
the previous decade.

Some studies reported differences involving time estimation,
reproduction, or management, while others did not demonstrate clear
associations.

The review also identified substantial methodological variation
between studies.

([Mette, 2023](https://doi.org/10.3390/ijerph20043098))

### Research Limitation

The available evidence does not justify treating all people with ADHD
as having one uniform time-perception deficit.

The term "time perception" itself includes several different
constructs that should not automatically be treated as interchangeable.

### Kairos Relevance

Kairos should avoid claims such as:

> People with ADHD cannot perceive time correctly.

A more defensible product position is:

> Some users may experience difficulty estimating, monitoring, or
> managing time, and Kairos should investigate which forms of time
> support are useful to them.

### Potential Design Implication

Time support should be configurable rather than diagnosis-driven.

Potential representations to test include:

- Elapsed time
- Remaining time
- Visual progress
- Transition countdown
- Clock time
- Planned versus actual duration

### Related Research Questions

- [RQ-T01](RESEARCH_QUESTIONS.md#rq-t01-time-awareness)
- [RQ-T02](RESEARCH_QUESTIONS.md#rq-t02-time-representation)
- [RQ-T03](RESEARCH_QUESTIONS.md#rq-t03-time-estimation)

### Related Assumptions

- [A-TM01](ASSUMPTIONS_AND_HYPOTHESES.md#a-tm01-users-benefit-from-persistent-time-awareness)
- [A-TM02](ASSUMPTIONS_AND_HYPOTHESES.md#a-tm02-generic-time-estimates-are-insufficient)

---

## 10. Hyperfocus and Deep Concentration

### 10.1 Terminology Caution

Hyperfocus is widely discussed in relation to ADHD, but the research
literature remains comparatively limited.

A review of hyperfocus literature highlighted inconsistent definitions
and limited empirical investigation.

([Ashinoff & Abu-Akel, 2021](https://doi.org/10.1007/s00426-019-01245-8))

An integrative review examining deep concentration in ADHD also
described a relatively small empirical literature and variation in how
hyperfocus, flow, and related constructs have been defined and
measured.

([Deep Concentration Integrative Review](https://pmc.ncbi.nlm.nih.gov/articles/PMC12438511/))

### Research Finding

Current research suggests that experiences described as hyperfocus or
deep concentration can involve intense and sustained engagement.

The literature also describes both potentially helpful and harmful
aspects of these experiences.

Potentially beneficial experiences may involve:

- Productivity
- Enjoyment
- Sustained engagement
- Creative activity

Potential difficulties may involve:

- Reduced awareness of non-task information
- Difficulty disengaging
- Neglect of other responsibilities
- Difficulty balancing competing needs

The scientific literature remains too limited to treat hyperfocus as a
simple or fully established construct.

### Kairos Relevance

This supports the existing Kairos principle that deep focus should not
automatically be classified as undesirable.

The relevant product question is more likely:

> Does the user's current attention still align with what they intend
> or need to be doing?

rather than:

> Has the user been focused for too long?

### Potential Design Implication

Kairos should investigate preserving productive deep focus while
supporting:

- Time awareness
- Physical breaks
- Upcoming responsibilities
- Planned stopping points
- Intentional disengagement

Intervention should not automatically occur merely because a focus
session is long.

### Related Research Questions

- [RQ-P05](RESEARCH_QUESTIONS.md#rq-p05-deep-focus-and-hyperfocus)
- [RQ-TR01](RESEARCH_QUESTIONS.md#rq-tr01-transition-difficulty)
- [RQ-TR02](RESEARCH_QUESTIONS.md#rq-tr02-transition-warning)

### Related Assumptions

- [A-AF05](ASSUMPTIONS_AND_HYPOTHESES.md#a-af05-deep-focus-should-not-be-treated-as-failure)

---

## 11. Executive Function and ADHD

Executive-function differences are frequently studied in ADHD.

However, executive dysfunction should not be treated as synonymous
with ADHD.

### Research Finding

Reviews comparing ADHD and autism have identified executive-function
differences at the group level, including differences involving
attention, inhibition, working memory, planning, and flexibility.

However, the findings do not support a single executive-function
profile that applies to every person with ADHD.

([Craig et al., 2016](https://doi.org/10.2147/NDT.S104620))

More recent reviews emphasize substantial overlap between ADHD and
autism, between-person heterogeneity, and limitations in common
executive-function measurement approaches.

([Townes et al., 2023](https://doi.org/10.1177/10870547231190494))

### Kairos Relevance

Kairos should avoid:

```text
ADHD selected
        ↓
Assume executive-function profile
        ↓
Automatically configure support
```

A diagnosis alone does not provide enough information to determine how
an individual wants Kairos to behave.

### Potential Design Implication

Onboarding should prioritize functional questions.

For example:

```text
Do you often lose track of what you were doing?

Do you want help deciding what to work on first?

Do you lose awareness of time while focused?

How strongly should Kairos remind you when something
important is approaching?
```

These questions may provide more actionable product information than
asking the user to select a diagnosis.

### Related Research Questions

- [RQ-PE01](RESEARCH_QUESTIONS.md#rq-pe01-personalization-value)
- [RQ-AR01](RESEARCH_QUESTIONS.md#rq-ar01-initial-value)

### Related Assumptions

- [A-PE01](ASSUMPTIONS_AND_HYPOTHESES.md#a-pe01-customization-improves-adoption)

---

## 12. Executive Function and Autism

Executive-function performance has also been studied extensively in
autistic populations.

### Research Finding

A large meta-analysis found group-level executive-function differences
across multiple domains in autism.

The authors also reported substantial heterogeneity and limited
diagnostic specificity of executive-function measures.

([Demetriou et al., 2018](https://doi.org/10.1038/mp.2017.75))

Comparative research examining ADHD and autism has also identified
substantial overlap rather than clearly separated executive-function
profiles.

([Townes et al., 2023](https://doi.org/10.1177/10870547231190494))

### Kairos Relevance

Kairos should not create assumptions such as:

```text
Autistic user
        ↓
Needs flexibility support
```

or:

```text
ADHD user
        ↓
Needs inhibition support
```

Research does not support using diagnosis as a simple shortcut for an
individual user's support profile.

### Potential Design Implication

Kairos should continue following the existing principle:

> Design for needs, not diagnoses.

Users should be able to configure support according to their actual
experience.

### Related Research Questions

- [RQ-PE01](RESEARCH_QUESTIONS.md#rq-pe01-personalization-value)
- [RQ-A02](RESEARCH_QUESTIONS.md#rq-a02-sensory-preferences)

### Related Assumptions

- [A-PE01](ASSUMPTIONS_AND_HYPOTHESES.md#a-pe01-customization-improves-adoption)
- [A-AC02](ASSUMPTIONS_AND_HYPOTHESES.md#a-ac02-sensory-preferences-vary-significantly)

---

## 13. ADHD and Autism Should Not Become Product Modes

The overlap and variability found in executive-function research
creates an important product implication.

### Research Finding

Direct-comparison research does not support a simple one-to-one
mapping between diagnostic category and executive-function profile.

A systematic review and meta-analysis evaluating ADHD and autism found
substantial similarities across many direct executive-function
comparisons.

([Townes et al., 2023](https://doi.org/10.1177/10870547231190494))

Earlier comparative work also identified shared and differing patterns
while demonstrating that executive-function domains do not cleanly
separate the diagnostic groups.

([Craig et al., 2016](https://doi.org/10.2147/NDT.S104620))

### Kairos Relevance

The following model should be avoided:

```text
Choose Profile

[ ADHD ]
[ Autism ]
[ Neurotypical ]
```

followed by automatic behavioral assumptions.

A needs-based model is more consistent with the available evidence.

For example:

```text
What would you like help with?

[ ] Knowing what to do first
[ ] Getting started
[ ] Remembering what I was doing
[ ] Keeping track of time
[ ] Avoiding distractions
[ ] Stopping when I need to
[ ] Preparing for what comes next
```

### Potential Design Implication

Diagnostic disclosure should not be necessary for Kairos to provide
core functionality.

If diagnostic information is ever collected, the project should
identify a clear product or research purpose before requesting it.

### Related Product Principle

See
[Design for Needs, Not Diagnoses](../00-product/PRODUCT_PRINCIPLES.md#8-design-for-needs-not-diagnoses).

---

## 14. Executive Function Develops Across Age

Kairos currently intends to begin supporting users at approximately
age 10.

Developmental differences therefore matter.

### Research Finding

Executive functions develop throughout childhood and adolescence.

Developmental reviews describe continued changes in executive-function
abilities across adolescence.

([Best & Miller, 2010](https://doi.org/10.1111/j.1467-8624.2010.01499.x))

Research specifically examining inhibition, shifting, and working
memory also reports continued developmental change during adolescence.

([Theodoraki et al., 2020](https://doi.org/10.1111/bjdp.12307))

Research extending into late adolescence and early adulthood indicates
that aspects of executive functioning continue to show developmental
change beyond childhood.

([Taylor et al., 2013](https://doi.org/10.1037/a0029871))

### Research Limitation

Development does not occur identically for every individual.

Age should not be treated as a direct measurement of executive
function or independence.

### Kairos Relevance

A 10-year-old and a 25-year-old may differ for reasons extending beyond
visual preference.

Differences may include:

- Independence
- Planning experience
- External structure
- Responsibilities
- Developmental context
- Guardian involvement
- School versus work environment

This supports the decision not to create one identical experience for
every age group.

It does not support stereotyping individual ability based on age.

### Potential Design Implication

Age may appropriately influence:

- Consent
- Privacy
- Guardian involvement
- Language complexity
- Onboarding
- Safety

Functional support should still be personalized.

### Related Research Questions

- [RQ-Y01](RESEARCH_QUESTIONS.md#rq-y01-guardian-role)
- [RQ-Y03](RESEARCH_QUESTIONS.md#rq-y03-transparency)
- [RQ-PE03](RESEARCH_QUESTIONS.md#rq-pe03-age-and-appearance)

---

## 15. Measurement and Everyday Experience

Executive function can be difficult to measure.

Different measurement approaches may capture different aspects of
functioning.

### Research Finding

Research comparing ADHD and autism demonstrates that executive-function
findings can differ depending on whether researchers use direct
neuropsychological tasks or questionnaires concerning everyday
behavior.

A meta-analysis comparing executive-function measures in ADHD and
autism identified differences between results obtained through direct
testing and questionnaire-based measures.

([Ceruti et al., 2024](https://pubmed.ncbi.nlm.nih.gov/38671689/))

Research on adolescent executive-function measurement also identifies
substantial variation in available instruments and their psychometric
properties.

([Nyongesa et al., 2019](https://doi.org/10.3389/fpsyg.2019.00311))

### Kairos Relevance

Kairos should not treat behavioral telemetry as a direct measurement
of a person's cognitive ability or mental state.

For example:

```text
User remained on YouTube for 40 minutes.
```

does not establish:

```text
User was distracted.
```

They may have intentionally planned to watch a tutorial.

Likewise:

```text
User changed applications five times.
```

does not establish:

```text
User cannot maintain attention.
```

The task itself may require multiple applications.

### Potential Design Implication

Kairos should prioritize user intent and context over simplistic
behavior classification.

Activity-awareness systems should remain cautious about inferring
mental states from observable computer behavior.

### Related Research Questions

- [RQ-PR01](RESEARCH_QUESTIONS.md#rq-pr01-activity-awareness)
- [RQ-E03](RESEARCH_QUESTIONS.md#rq-e03-correction)

### Related Assumptions

- [A-PR01](ASSUMPTIONS_AND_HYPOTHESES.md#a-pr01-activity-awareness-improves-focus-assistance)
- [A-EX03](ASSUMPTIONS_AND_HYPOTHESES.md#a-ex03-corrections-can-improve-personalization)

---

## 16. Emerging Design Principles From the Literature

The current evidence suggests several principles worth carrying into
Kairos user research.

These are not yet product requirements.

### 16.1 Preserve Intent

Interruption research suggests that returning to an activity can
require reconstruction of task context.

Kairos should investigate preserving enough information to help users
recover their original intention.

([Couffe & Michael, 2017](https://doi.org/10.5406/amerjpsyc.130.2.0163))

### 16.2 Avoid Becoming the Distraction

Kairos itself can require an attentional shift.

The product should therefore test whether ambient awareness can
communicate information without unnecessary interruption.

([Couffe & Michael, 2017](https://doi.org/10.5406/amerjpsyc.130.2.0163))

### 16.3 Support Transitions Before They Happen

Executive-function research identifies cognitive flexibility as an
important component of adapting to changing demands.

Kairos should investigate whether preparation improves transitions
between activities.

([Diamond, 2013](https://doi.org/10.1146/annurev-psych-113011-143750))

### 16.4 Make Time More Concrete

Some adult ADHD research reports difficulties involving time
estimation, reproduction, or management, although findings remain
inconsistent.

Kairos should test multiple time representations rather than assuming
one universal solution.

([Mette, 2023](https://doi.org/10.3390/ijerph20043098))

### 16.5 Protect Productive Deep Focus

Deep concentration may have both positive and negative consequences.

Kairos should investigate helping users disengage when necessary
without automatically disrupting productive concentration.

([Ashinoff & Abu-Akel, 2021](https://doi.org/10.1007/s00426-019-01245-8))

([Deep Concentration Integrative Review](https://pmc.ncbi.nlm.nih.gov/articles/PMC12438511/))

### 16.6 Personalize by Need

Executive-function profiles show substantial variability within and
across diagnostic groups.

Kairos should prioritize functional needs over diagnosis-based
presets.

([Townes et al., 2023](https://doi.org/10.1177/10870547231190494))

### 16.7 Avoid Inferring Cognitive State From Simple Telemetry

Observable computer behavior provides context, not direct access to
the user's intention or cognitive state.

Kairos should preserve uncertainty when interpreting activity.

### 16.8 Let Users Correct Kairos

When Kairos interprets activity incorrectly, correction should be easy.

This may be important for both user autonomy and future
personalization.

---

## 17. Impact on Current Assumption Register

The literature provides different levels of support for existing
Kairos assumptions.

### 17.1 Evidence Consistent With Current Direction

Current literature provides conceptual support for continuing to
investigate:

- Attention recovery
- Time awareness
- Transition assistance
- Context preservation
- Needs-based personalization
- Protecting productive deep focus

This does not mean the corresponding Kairos implementations have been
validated.

### 17.2 Assumptions Still Requiring Direct User Validation

The literature does not establish that users will prefer:

- Progressive intervention
- Kairos prioritization recommendations
- Strict Focus
- Persistent desktop widgets
- Specific communication styles
- Specific themes
- Automatic activity classification

These remain product hypotheses.

### 17.3 Assumptions Requiring Technical Validation

External cognitive research cannot determine whether Kairos can
technically provide:

- Reliable background operation
- Cross-application overlays
- Application awareness
- Browser-domain awareness
- Local activity classification
- Application or website restrictions

These remain technical research questions.

See the
[Assumptions and Hypotheses Register](ASSUMPTIONS_AND_HYPOTHESES.md)
for the current status of these assumptions.

---

## 18. Research Limitations

The literature reviewed has several important limitations.

### 18.1 Diagnostic Heterogeneity

ADHD and autism both contain substantial individual variation.

Group-level findings should not be converted directly into assumptions
about individual users.

([Townes et al., 2023](https://doi.org/10.1177/10870547231190494))

### 18.2 Measurement Differences

Studies use different definitions and measurements for constructs such
as:

- Executive function
- Hyperfocus
- Time perception
- Attention
- Cognitive flexibility

These differences can contribute to inconsistent findings.

([Mette, 2023](https://doi.org/10.3390/ijerph20043098))

([Nyongesa et al., 2019](https://doi.org/10.3389/fpsyg.2019.00311))

### 18.3 Laboratory Versus Everyday Behavior

Performance on a controlled cognitive task should not automatically be
treated as equivalent to a person's everyday functioning.

Different measurement approaches may capture different aspects of
executive function.

([Ceruti et al., 2024](https://pubmed.ncbi.nlm.nih.gov/38671689/))

### 18.4 Hyperfocus Evidence

Hyperfocus remains less established as a research construct than core
executive functions such as working memory, inhibition, and cognitive
flexibility.

Definitions and assessment methods remain inconsistent.

([Ashinoff & Abu-Akel, 2021](https://doi.org/10.1007/s00426-019-01245-8))

([Deep Concentration Integrative Review](https://pmc.ncbi.nlm.nih.gov/articles/PMC12438511/))

### 18.5 Adult ADHD Time-Perception Evidence

Research specifically examining time perception in adults with ADHD
remains relatively limited and methodologically varied.

([Mette, 2023](https://doi.org/10.3390/ijerph20043098))

### 18.6 Product Evidence

Cognitive research can provide evidence that a problem or cognitive
process exists.

It cannot establish that Kairos is the correct solution.

Direct product research remains necessary.

---

## 19. Research Gaps Relevant to Kairos

The literature does not answer several questions central to the
product.

Kairos still needs direct evidence regarding:

1. Whether users want a persistent desktop companion.
2. Whether progressive intervention feels supportive.
3. Which information most improves attention recovery.
4. How users want transition assistance delivered.
5. Whether users want application or domain awareness.
6. Whether privacy concerns outweigh contextual assistance.
7. Which time representations are most useful.
8. How intervention preferences change by activity.
9. Whether visual personalization affects continued use.
10. How younger users perceive guardian involvement.
11. How frequently users want Kairos to intervene.
12. When Kairos should intentionally remain silent.

These gaps remain part of the
[Research Questions](RESEARCH_QUESTIONS.md).

---

## 20. Current Research Position

The external evidence reviewed supports the broader premise that
executive-function processes are relevant to:

- Goal maintenance
- Distraction resistance
- Working memory
- Flexible responding
- Planning
- Time management
- Transitions

The research also cautions strongly against treating executive-function
needs as uniform across diagnostic categories.

([Diamond, 2013](https://doi.org/10.1146/annurev-psych-113011-143750))

([Townes et al., 2023](https://doi.org/10.1177/10870547231190494))

Kairos should therefore continue with a needs-based and
user-configurable product model.

The evidence is consistent with investigating:

```text
Preserve user intent
        ↓
Reduce unnecessary interruption
        ↓
Support attention recovery
        ↓
Make time more visible
        ↓
Prepare for transitions
        ↓
Protect useful deep focus
        ↓
Adapt support to the individual
```

These directions should be tested through direct user research rather
than converted immediately into product requirements.

---

## 21. References

### Executive Function

1. Diamond, A. (2013).
   [Executive Functions](https://doi.org/10.1146/annurev-psych-113011-143750).
   _Annual Review of Psychology, 64_, 135-168.

2. Best, J. R., & Miller, P. H. (2010).
   [A Developmental Perspective on Executive Function](https://doi.org/10.1111/j.1467-8624.2010.01499.x).
   _Child Development, 81_(6), 1641-1660.

3. Theodoraki, T. E., McGeown, S. P., Rhodes, S. M., &
   MacPherson, S. E. (2020).
   [Developmental Changes in Executive Functions During Adolescence:
   A Study of Inhibition, Shifting, and Working Memory](https://doi.org/10.1111/bjdp.12307).
   _British Journal of Developmental Psychology, 38_(1), 74-89.

4. Taylor, S. J., Barker, L. A., Heavey, L., & McHale, S. (2013).
   [The Typical Developmental Trajectory of Social and Executive
   Functions in Late Adolescence and Early Adulthood](https://doi.org/10.1037/a0029871).
   _Developmental Psychology, 49_(7), 1253-1265.

### ADHD, Autism, and Executive Function

5. Craig, F., Margari, F., Legrottaglie, A. R., Palumbi, R.,
   de Giambattista, C., & Margari, L. (2016).
   [A Review of Executive Function Deficits in Autism Spectrum
   Disorder and Attention-Deficit/Hyperactivity Disorder](https://doi.org/10.2147/NDT.S104620).
   _Neuropsychiatric Disease and Treatment, 12_, 1191-1202.

6. Demetriou, E. A., Lampit, A., Quintana, D. S., Naismith, S. L.,
   Song, Y. J. C., Pye, J. E., Hickie, I., &
   Guastella, A. J. (2018).
   [Autism Spectrum Disorders: A Meta-Analysis of Executive
   Function](https://doi.org/10.1038/mp.2017.75).
   _Molecular Psychiatry, 23_, 1198-1204.

7. Townes, P., Liu, C., Panesar, P., Devoe, D., Lee, S. Y.,
   Taylor, G., Arnold, P. D., Crosbie, J., &
   Schachar, R. (2023).
   [Do ASD and ADHD Have Distinct Executive Function Deficits?
   A Systematic Review and Meta-Analysis of Direct Comparison
   Studies](https://doi.org/10.1177/10870547231190494).
   _Journal of Attention Disorders, 27_(14), 1571-1582.

8. Ceruti, C., et al. (2024).
   [Comparing Executive Functions in Children and Adolescents with
   Autism and ADHD: A Systematic Review and Meta-Analysis](https://pubmed.ncbi.nlm.nih.gov/38671689/).

### Time Perception

9. Mette, C. (2023).
   [Time Perception in Adult ADHD: Findings from a Decade - A
   Review](https://doi.org/10.3390/ijerph20043098).
   _International Journal of Environmental Research and Public
   Health, 20_(4), 3098.

### Interruptions and Distraction

10. Couffe, C., & Michael, G. A. (2017).
    [Failures Due to Interruptions or Distractions: A Review and a
    New Framework](https://doi.org/10.5406/amerjpsyc.130.2.0163).
    _The American Journal of Psychology, 130_(2), 163-181.

### Hyperfocus and Deep Concentration

11. Ashinoff, B. K., & Abu-Akel, A. (2021).
    [Hyperfocus: The Forgotten Frontier of Attention](https://doi.org/10.1007/s00426-019-01245-8).
    _Psychological Research, 85_, 1-19.

12. [Experiences of Deep Concentration in Individuals with Attention
    Deficit Hyperactivity Disorder (ADHD): An Integrative Review of
    the Literature](https://pmc.ncbi.nlm.nih.gov/articles/PMC12438511/).
    PubMed Central.

### Executive-Function Measurement

13. Nyongesa, M. K., et al. (2019).
    [Assessing Executive Function in Adolescence: A Scoping Review of
    Existing Measures and Their Psychometric Robustness](https://doi.org/10.3389/fpsyg.2019.00311).
    _Frontiers in Psychology, 10_, 311.

---

## 22. Related Kairos Documentation

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
