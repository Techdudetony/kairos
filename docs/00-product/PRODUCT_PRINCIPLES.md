# Kairos Product Principles

**Document Status:** Draft  
**Version:** 0.1  
**Last Updated:** August 2026  
**Product:** Kairos  
**Document Owner:** Product

---

## 1. Purpose

This document defines the foundational product principles that guide
the design, development, and evolution of Kairos.

These principles are intended to act as decision-making guardrails
across product management, UX design, engineering, data, AI,
accessibility, privacy, and quality assurance.

Individual features, technical implementations, and product
requirements may change over time.

These principles should remain comparatively stable.

When a proposed feature conflicts with a product principle, the
conflict should be identified and resolved intentionally rather than
allowing the feature to silently redefine the product.

---

## 2. Support, Don't Punish

Kairos should help users recover from difficulties rather than punish
them for experiencing those difficulties.

Users may become distracted, underestimate tasks, miss scheduled
activities, lose focus, require additional breaks, or abandon an
original plan.

These situations should not automatically be treated as failures.

Kairos should avoid unnecessary use of:

- Shame
- Guilt
- Punitive streak systems
- Failure-oriented messaging
- Excessive warning indicators
- Negative reinforcement
- Artificial urgency

Instead of emphasizing what went wrong, Kairos should help the user
determine what should happen next.

### Example

Avoid:

> You failed your focus session.

Prefer:

> Looks like we got sidetracked. What would you like to do next?

### Principle

> **Support recovery instead of punishing deviation.**

---

## 3. The User Remains in Control

Kairos exists to assist the user, not control them.

The user should retain meaningful authority over how Kairos interacts
with their computer experience.

Kairos may recommend, remind, interrupt, or restrict depending on the
permissions and preferences selected by the user.

Higher levels of control should require intentional authorization.

Users should be able to:

- Change focus strictness.
- Modify schedules.
- Override recommendations.
- Dismiss appropriate interventions.
- Change activity-awareness permissions.
- Configure restrictions.
- Modify communication preferences.
- Disable optional capabilities.
- Correct Kairos when its assumptions are wrong.

Kairos should not silently increase its authority because the system
believes stronger intervention would benefit the user.

### Principle

> **Kairos receives authority from the user. It does not take authority
> from the user.**

---

## 4. Adapt to the User

Kairos should adapt to how an individual user works rather than
expecting every user to adopt the same productivity system.

Different users may require different levels of:

- Structure
- Intervention
- Encouragement
- Visual information
- Time awareness
- Accountability
- Sensory stimulation
- Task breakdown
- Automation

Customization should extend beyond appearance.

Kairos should eventually adapt its behavior, communication, timing,
recommendations, and assistance according to user preferences and
learned patterns.

### Principle

> **The system should adapt to the user whenever reasonably possible,
> rather than requiring the user to adapt to the system.**

---

## 5. Intervene Progressively

Kairos should use progressive intervention as the default response to
distraction and upcoming transitions.

The system should generally begin with the least disruptive
intervention appropriate for the situation.

If the situation continues and the user's preferences allow it,
Kairos may gradually increase intervention strength.

A potential progression may include:

1. Ambient awareness
2. Gentle reminder
3. Active reminder
4. Persistent reminder
5. Screen overlay
6. Strong intervention
7. User-authorized restriction

The exact implementation may vary by feature and context.

### Principle

> **Start gently and escalate intentionally.**

---

## 6. Greater Capability Requires Greater Permission

More advanced Kairos capabilities may require access to additional
information or greater control over the computer.

These capabilities should not be treated as automatic permissions.

Examples include:

- Monitoring active applications
- Identifying website domains
- Evaluating activity context
- Restricting applications
- Restricting websites
- Displaying full-screen interventions
- Using behavioral history
- Using cloud-based processing

Users should understand what capability is being requested and why it
is needed.

Core Kairos functionality should remain available without requiring
the highest level of monitoring or intervention.

### Principle

> **More capability should require more explicit permission.**

---

## 7. Privacy by Design

Privacy should be considered during feature design rather than added
after implementation.

Kairos should collect and process only the information reasonably
necessary to provide the functionality requested by the user.

Where technically feasible, sensitive behavioral and activity
processing should occur locally on the user's device.

Users should be able to understand:

- What information Kairos observes
- Why the information is needed
- How the information is used
- Where the information is processed
- Where the information is stored
- How long the information is retained
- How permissions can be revoked

Special consideration should be given to information involving:

- Children and younger users
- Private communications
- Authentication information
- Financial information
- Health information
- Personal documents
- Private browsing
- User-designated sensitive applications

### Principle

> **Kairos should only know what it needs to know to provide the
> assistance the user requested.**

---

## 8. Design for Needs, Not Diagnoses

Kairos is designed with neurodivergent experiences in mind, but users
should not need to identify themselves through a diagnosis.

The application should focus on what the user wants help with.

For example:

- Staying focused
- Remembering tasks
- Starting activities
- Understanding time
- Managing transitions
- Breaking down large tasks
- Building routines
- Reducing distractions

Kairos should not attempt to determine whether a user has ADHD,
autism, or another medical, developmental, psychological, or
neurological condition.

Age should also not automatically determine the appearance or
personality of the experience.

### Principle

> **Design around expressed needs and preferences rather than labels
> or assumptions.**

---

## 9. Recovery Is Part of Productivity

A productivity system should continue being useful when the original
plan stops working.

Kairos should assume that schedules will sometimes change.

A user may:

- Start late
- Take longer than expected
- Become distracted
- Receive an unexpected interruption
- Lose motivation
- Become overwhelmed
- Need additional rest
- Change priorities

Kairos should help users reevaluate what remains important and build
a realistic path forward.

Future capabilities such as Rescue Mode should embody this principle.

### Principle

> **A disrupted plan should trigger assistance, not judgment.**

---

## 10. Rest and Transitions Matter

Kairos should not define success as maximizing continuous work.

Breaks, recovery periods, preparation time, and transitions are
legitimate parts of effective time management.

The system should avoid rewarding unhealthy patterns such as working
for excessive periods without appropriate breaks.

Kairos should eventually account for:

- Breaks
- Transition time
- Preparation time
- Buffer time
- Recovery time
- Task-switching costs

### Principle

> **Effective time management includes the time required to pause,
> recover, prepare, and transition.**

---

## 11. Explain the Why

Kairos should provide reasonable explanations for meaningful
recommendations involving a user's time, attention, schedule,
behavior, or activity.

Users should not be expected to trust recommendations simply because
the system generated them.

When practical, users should be able to ask:

> Why?

Kairos should then provide an understandable explanation based on the
information used to make the recommendation.

### Example: Scheduling

Kairos may recommend:

> Start your history project at 5:30 PM.

The user should be able to request an explanation such as:

> Your project is estimated to require 90 minutes.
>
> Your evening routine begins at 7:30 PM.
>
> The schedule includes a 10-minute break and 20 minutes of buffer
> time, so I recommended beginning at 5:30 PM.

### Example: Personalized Time Estimate

Kairos may eventually recommend:

> Allow approximately two hours for this task.

The explanation may include:

> Your last four similar tasks took between 1 hour 42 minutes and
> 2 hours 16 minutes.
>
> Based on those sessions, two hours is currently a reasonable
> estimate.

### Explanations Should Be Understandable

Explanations should prioritize information useful to the user rather
than exposing unnecessary technical details.

A user should not need to understand machine learning, statistics, or
software architecture to understand why Kairos made a recommendation.

### Principle

> **If Kairos influences a meaningful decision, the user should have
> a reasonable way to understand why.**

---

## 12. AI Assists, It Does Not Decide

Artificial intelligence may eventually provide significant
capabilities within Kairos.

Potential uses may include:

- Task decomposition
- Schedule suggestions
- Time estimation
- Context classification
- Pattern recognition
- Natural-language task capture
- Personalized recommendations
- Recovery planning

AI should assist the user rather than become the authority over the
user.

AI-generated recommendations should remain subject to user review,
correction, modification, or rejection where appropriate.

Kairos should not present uncertain predictions as objective facts.

### Principle

> **AI may recommend. The user decides.**

---

## 13. Accessibility Is Foundational

Accessibility should be considered a core product requirement rather
than a feature category added after development.

Kairos should consider differences in:

- Vision
- Hearing
- Motor interaction
- Attention
- Cognitive processing
- Reading ability
- Sensory sensitivity
- Language comprehension

Customization should support accessibility whenever possible.

Potential considerations include:

- Keyboard navigation
- Screen-reader compatibility
- Scalable text
- High-contrast experiences
- Reduced motion
- Adjustable animation
- Adjustable sound
- Visual alternatives to audio
- Audio alternatives to visual cues
- Configurable notification intensity
- Clear and predictable navigation

Accessibility requirements will be defined in greater detail during
the requirements and UX phases.

### Principle

> **Accessibility is part of the architecture of Kairos, not a
> finishing step.**

---

## 14. Personalization Should Not Become Manipulation

Kairos may eventually learn from user behavior to provide increasingly
personalized assistance.

Personalization should be used to improve relevance and reduce
friction.

It should not be used to manipulate users into spending more time
inside Kairos or maximizing engagement for its own sake.

Product success should not depend primarily on metrics such as:

- Daily screen time within Kairos
- Number of notifications opened
- Number of interactions with the companion
- Artificial engagement streaks

Kairos should be comfortable becoming less visible when the user does
not need assistance.

### Principle

> **Kairos should optimize for user outcomes, not dependency on
> Kairos.**

---

## 15. Calm Technology

Kairos should respect the fact that it exists within an environment
already competing for the user's attention.

Notifications and interventions should therefore have purpose.

Kairos should avoid becoming another source of unnecessary
distraction.

The application should remain unobtrusive when assistance is not
needed and become more noticeable when the situation or user's
preferences justify intervention.

### Principle

> **Be quiet when possible and noticeable when necessary.**

---

## 16. Build Trust Through Predictability

Users should be able to develop a reasonable understanding of how
Kairos behaves.

Similar actions and situations should produce reasonably consistent
responses unless personalization or context provides a clear reason
for different behavior.

Kairos should avoid surprising users with:

- Unexpected restrictions
- Unexplained monitoring
- Unrequested behavioral changes
- Sudden increases in intervention
- Hidden automation
- Silent permission changes

When Kairos changes behavior because it has learned something new,
the change should be understandable and controllable.

### Principle

> **A helpful companion should not behave unpredictably.**

---

## 17. Product Principle Evaluation

Significant new features should be evaluated against these principles
during product planning and design.

A proposed feature should prompt questions such as:

1. Does this support the user or punish them?
2. Does the user retain meaningful control?
3. Does this adapt to user needs and preferences?
4. Is the intervention proportional to the situation?
5. Does this require additional permission?
6. Are we collecting more information than necessary?
7. Are we making assumptions based on diagnosis or age?
8. What happens when the user's original plan fails?
9. Are appropriate breaks and transitions considered?
10. Can the user understand why Kairos made this recommendation?
11. Is AI assisting the user or making the decision for them?
12. Is the feature accessible?
13. Does personalization benefit the user or primarily increase
    engagement?
14. Does the feature add unnecessary cognitive or notification load?
15. Will the behavior remain understandable and predictable?

A feature does not necessarily need to satisfy every principle in the
same way.

However, conflicts with these principles should be documented and
resolved intentionally.

---

## 18. Principle Priority

When product principles appear to conflict, Kairos should generally
prioritize:

1. User safety
2. User autonomy
3. Privacy
4. Accessibility
5. User understanding
6. User-defined goals
7. Product convenience
8. Engagement

This order is intended as a decision-making guideline rather than an
absolute rule.

Specific safety, privacy, legal, or accessibility requirements may
override normal product behavior.

---

## 19. Living Principles

These principles are expected to evolve as Kairos moves through user
research, UX validation, technical development, and real-world
testing.

Changes should be intentional and documented.

Significant changes to these principles should include:

- The principle being changed
- The reason for the change
- Supporting research or evidence
- Expected product impact
- The date of the decision

Major changes should also be recorded in the Kairos Decision Log.
