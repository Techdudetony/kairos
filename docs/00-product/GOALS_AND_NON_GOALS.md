# Kairos Goals and Non-Goals

**Document Status:** Draft
**Version:** 0.1
**Last Updated:** August 2026
**Product:** Kairos
**Document Owner:** Product

---

## 1. Purpose

This document defines the goals and intentional non-goals of Kairos.

The purpose is to establish clear product boundaries before detailed requirements, architecture, and development planning begin.

Kairos has the potential to address many problems related to productivity, organization, attention, and time management.

Attempting to solve all of these problems simultaneously would create an unfocused product and an unrealistic development scope.

These goals establish areas the product should intentionally avoid or defer unless future research provides a strong reason to reconsider them.

MVP-specific scope will be defined separately in:

[docs/06-development/MVP_SCOPE.md](docs/06-development/MVP_SCOPE.md)

---

# 2. Product Goals

## Goal 1: Help Users Direct Their Attention Intentionally

Kairos should help users identify what deserves their attention at a given moment.

This includes helping users understand:

- What they intended to accomplish
- Which responsibility currently matters most
- What they are currently working on
- What should happen next
- When another responsibility requires attention

Kairos should reduce the cognitive effort required to repeatedly reconstruct these decisions throughout the day.

### Desired Outcome

Users spend less time determining what they should be doing and more time intentionally engaging with the activities they choose.

---

## Goal 2: Help Users Recover From Distraction

Kairos should help users recognize when their attention has shifted awat from an intended activity.

The purpose is not to eliminate all distractoin.

Instead, Kairos should make it easier for users to:

- Recognize that attention has shifted
- Remember the original intention
- Understand where they stopped
- Decide whether to return
- Resume the activity with less friction

### Desired Outcome

A distraction is less likely to result in an abandoned or incomplete task.

---

## Goal 3: Support Healthy Deep Focus

Kairos should recognize that sustained concentration can be valuable.

The product should not unnecessarily interrupt productive periods of deep focus.

However, users should remain aware of:

- Passing time
- Upcoming responsibilities
- Scheduled transitions
- Planned breaks
- Physical needs
- Intended stopping points

Kairos should help users disengage from deep focus when they have previously indicated that another responsibility should take priority.

### Desired Outcome

Users can benefit from periods of deep concentration without unintentionally scrificing other responsibilities or their well-being.

---

## Goal 4: Improve Time Awareness

Kairos should help users better understand the relationship between:

- Current time
- Time already spent
- Time remaining
- Estimated task duration
- Upcoming activities
- Transition time
- Break time

Time information should be presented in ways that are understandable and useful rather than relying exclusively on clocks and timestamps.

### Desired Outcome

Users are less frequently surprised by how much time has passed or how little time remains.

---

## Goal 5: Support Better Prioritization

Kairos should help users evaluate competing responsibilities without removing their authority to determine what matters.

Future prioritization assistance may consider factors such as:

- Deadlines
- Importance
- Urgency
- Available time
- Estimated duration
- Dependencies
- Scheduled commitments
- User-defined priorities

Kairos may recommend priorities.

The user should retain the ability to change them.

### Desired Outcome

Important responsibilities are less likely to be delayed because the user was unsure where to begin.

---

## Goal 6: Reduce Task Initiation Friction

Kairos should help users move from:

> I need to do this.

to:

> I know what to do first.

Large or vague activities may create additional difficulty because the first actionable step is unclear.

Kairos should eventually help users identify manageable starting actions.

### Desired Outcome

Users experience less friction between deciding that something needs to be done and beginning meaningful action.

---

## Goal 7: Support Transitions Between Activities

Kairos should treat transitions as a process rather than a single notification at the moment an activity is supposed to change.

When appropriate, Kairos should help users:

- Recognize that a transition is approaching
- Prepare to stop the current activity
- Preserve unfinished task context
- Understand what is happening next
- Begin the next activity

### Desire Outcome

Users are less likely to miss or significantly delay upcoming responsibilities because they were engaged in another activity.

---

## Goal 8: Help Users Recover When Plans Change

Kairos should remain useful when the user's original schedule becomes unrealistic.

The product should help users reevaluate:

- What still needs to happen
- What can be delayed
- What can be moved
- What should be shortened
- What no longer needs to happen today
- How remaining time can realistically be allocated

Future functionality may include dedicated Rescue Mode.

### Desired Outcome

A disrupted schedule does not automatically cause the remainder of the user's plan to become unusable.

---

## Goal 9: Personalize the User Experience

Kairos should provide an experience that can adapt to different users without relying primarily on age-based assumptions.

Personalization may eventually include:

- Visual themes
- Widget configuration
- Communicaton style
- Focus strictness
- Intervention behavior
- Activity-awareness level
- Notification intensity
- Sounds
- Animation
- Sensory preferences
- Accessibility preferences
- Gamification preferences

### Desired Outcome

Users can create a Kairos experience that feels appropriate for their needs, preferences, and environment.

---

## Goal 10: Learn From the User Over Time

Long-term versions of Kairos should become more useful as the user interacts with the system.

Kairos may learn from:

- Estimated task duration
- Actual task duration
- Task context
- User corrections
- Schedule adjustments
- Focus patterns
- Break patterns
- Repeated routines
- User-provided feedback

This information may contribute to personalized planning and a future Personal Time Model.

Learning should remain transparent, explainable, and subject to user control.

### Desired Outcome

Kairos recommendations become increasingly relevant to the individual rather than remaining dependent on generic assumptions.

---

## Goal 11: Preserve User Autonomy

Kairos should help users direct their own behavior rather than making decisions on their behalf.

Users should maintain meaningful control over:

- Priorities
- Schedules
- Restrictions
- Interventions
- Monitoring
- Recommendations
- Personalization
- Data permissions

### Desired Outcome

Users feel assisted by Kairos rather than controlled by it.

---

## Goal 12: Protect User Privacy

Kairos should minimize unnecessary collection and processing of personal activity information.

Where technically feasible, sensitive behavorial processing should occur locally on the user's device.

Users should understand what information is being used and why.

### Desired Outcome

Users can benefit from adaptive assistance without unnecessarily surrendering privacy.

---

## Goal 13: Provide Explainable Assistance

Meaningful recommendations should have understandable reasoning available to the user.

This is particularly important for recommendations involving:

- Prioritization
- Scheduling
- Task duration
- Focus intervention
- Behavioral patterns
- Personalized predictions

### Desired Outcome

Users can understand why Kairos made a recommendation and make an informed decision about whether to follow it.

---

## Goal 14: Support a Broad Range of Users

Kairos should be designed with neurodivergent experiences in mind without requiring users to identify themselves through a diagnosis.

The product should be useable by people who simply recognize that they benefit from additional support with:

- Attention
- Time
- Organization
- Routines
- Planning
- Transitions

Kairos should also support meaningful customization across age groups.

### Desired Outcome

Users receive support based on what they need rather than which label they have.

---

## Goal 15: Make Accessability Foundational

Accessability should influence the design and architecture of Kairos from the beginning.

The product should consider differences involving:

- Vision
- Hearing
- Motor interaction
- Attention
- Reading
- Cognitive processing
- Sensory sensitivity

### Desired Outcome

Accessibility does not require users to wait for a later "accessibility update" before they can meaningfully use Kairos.

---

# 3. Product Non-Goals

## Non-Goal 1: Diagnosing Neurodivergence

Kairos should not attempt to determine whether a user has:

- ADHD
- Autism
- A learning disability
- An anxiety disorder
- A neurological condition
- Any other medical or psychological condition

Kairos may ask what the user needs help with.

It should not attempt to determine why that need exists.

---

## Non-Goal 2: Providing Medical or Psychological Treatment

Kairos is not intended to replace:

- Physicians
- Therapists
- Psychologists
- Psychiatrists
- Occupational therapists
- Other qualified professiosals

Product messaging should avoid presneting Kairos as treatment for a medical or psychological condition.

---

## Non-Goal 3: Maximizing Productivity

Kairos should not attempt to make users productive during every available moment.

Time used for:

- Rest
- Recreation
- Social interaction
- Breaks
- Personal interests
- Unstructured time

should not automatically be considered wasted time.

Kairos exists to help users direct their time intentionally.

It does not exist to maximize work output.

---

## Non-Goal 4: Eliminating All Distractions

Distraction is not inherently a product failure.

Some interruptions are necessary.

Some changes in attention are intentional.

Some recreational activities are appropriate.

Kairos should focus on helping users recognize and recover from unwanted distraction rather than attempting to create a completely distraction-free computer.

---

## Non-Goal 5: Making Decisions for the User

Kairos may recommend:

- What to do next
- How long to allocate
- When to begin
- When to take a break
- When to transition
- How to reorganize a schedule

These recommendations should not automatically become decisions.

The user remains the final authority unless they have explicitly
delegated a specific action to Kairos.

---

## Non-Goal 6: Becoming Surveillance Software

Kairos should not become a system primarily designed to monitor
computer activity for another person's benefit.

This is particularly important when considering younger users.

Potential guardian functionality should focus on supporting routines,
responsibilities, safety, and appropriate configuration.

Kairos should not become a general-purpose employee-monitoring,
parental-surveillance, or activity-spying platform.

---

## Non-Goal 7: Replacing Dedicated Parental-Control Software

Kairos may eventually provide guardian-supported experiences for
younger users.

However, the primary purpose of Kairos is executive-function and
attention support.

Kairos should not attempt to replace comprehensive parental-control
platforms responsible for:

- Internet filtering
- Content moderation
- Device security
- Location tracking
- Communication monitoring

Any guardian capabilities should remain aligned with the purpose of
Kairos.

---

## Non-Goal 8: Replacing Every Productivity Application

Kairos does not need to recreate every capability provided by:

- Calendars
- Note-taking applications
- Project-management systems
- Email clients
- Communication platforms
- Document editors

Where appropriate, future versions of Kairos may integrate with
existing tools rather than replace them.

---

## Non-Goal 9: Requiring Artificial Intelligence for Core Use

Kairos may eventually use AI for advanced assistance.

However, users should not require generative AI to access fundamental
capabilities such as:

- Focus sessions
- Timers
- Reminders
- Routines
- Widgets
- Basic task management
- Progressive intervention

The usefulness of Kairos should not depend entirely on access to an
external AI service.

---

## Non-Goal 10: Making AI an Unquestionable Authority

AI-generated recommendations should not be presented as guaranteed
facts.

Users should be able to:

- Review recommendations
- Modify recommendations
- Reject recommendations
- Correct incorrect assumptions

Kairos should communicate uncertainty when appropriate.

---

## Non-Goal 11: Forcing a Childlike Experience on Younger Users

Younger users should not automatically receive an interface that is
overly simplified, cartoonish, or childish.

Age may affect:

- Safety requirements
- Privacy requirements
- Guardian permissions
- Available capabilities

Age should not automatically determine aesthetic preference or
communication style.

---

## Non-Goal 12: Forcing a Professional Experience on Adults

Adult users should not be restricted to minimal or corporate visual
experiences.

Adults may prefer:

- Gamification
- Playful communication
- Animated themes
- Characters
- Bright visual experiences

Customization should reflect preference rather than assumptions about
maturity.

---

## Non-Goal 13: Encouraging Dependence on Kairos

Kairos should not intentionally create unnecessary interactions to
increase engagement metrics.

If a user needs less assistance over time, that should be considered
a positive outcome.

Kairos should be capable of becoming quieter when appropriate.

---

## Non-Goal 14: Automatically Sending Detailed Activity Data to the Cloud

Kairos should not assume that detailed computer activity needs to be
stored or processed remotely.

Cloud functionality may eventually provide useful capabilities.

However, cloud processing should have a clear purpose and appropriate
privacy controls.

Local processing should be preferred for sensitive activity data when
technically reasonable.

---

# 4. Goals Versus MVP Scope

The goals in this document describe the intended direction of Kairos.

They do **not** represent a commitment that every capability will be
available in the first release.

For example:

```text
Product Goal

Learn how long activities take for the individual user.

Possible Long-Term Capability

Personal Time Model

Possible MVP Capability

Allow the user to enter an estimated duration and record the
actual duration.
```

Another example:

```text
Product Goal

Help users recover from distraction.

Possible Long-Term Capability

Context-aware activity classification.

Possible MVP Capability

Maintain a persistent current-task widget and provide
progressive focus reminders.

Product goals describe what outcome matters.
```

MVP requirements will determine what minimum capability is needed
to begin testing whether Kairos can produce that outcome.

---

# 5. Scope Decision Framework

When considering a new capability, the product team should ask:

1. Which validated user problem does this address?
2. Which product goal does this support?
3. Does it conflict with a documented non-goal?
4. Does Kairos need to build this capability itself?
5. Could integration with another tool solve the problem better?
6. What additional privacy or security risks does it introduce?
7. What accessibility considerations does it introduce?
8. Does it increase user control or unnecessarily reduce it?
9. Can the behavior be reasonably explained to the user?
10. Is this necessary now, or does it belong in a later release?

If a proposed feature cannot be connected to a validated problem or
product goal, it should not automatically enter the product backlog.

---

# 6. Scope Change Policy

Goals and non-goals may change as Kairos progresses through:

- User research
- Usability testing
- Technical feasibility analysis
- Development
- Beta testing
- Production feedback

Changes should be intentional.

A significant change should document:

- What is changing
- Why it is changing
- What evidence supports the change
- Which requirements are affected
- Which product principles are affected
- Whether roadmap or MVP scope changes are required

Major scope decisions should also be recorded in:

[docs/07-decisions/DECISION_LOG.md](docs/07-decisions/DECISION_LOG.md)

---

# 7. Current Scope Position

Kairos is currently in Product Discovery and Planning.

The current priority is understanding and validating the problem
space before determining the final feature set.

At this stage:

- Product goals describe desired outcomes.
- Non-goals establish initial boundaries.
- Features remain hypotheses.
- Technical approaches remain undecided.
- MVP scope has not yet been finalized.

This distinction should be preserved as the project moves into
requirements and architecture planning.
