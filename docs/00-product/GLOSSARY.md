# Kairos Product Glossary

**Document Status:** Draft  
**Version:** 0.1  
**Last Updated:** August 2026  
**Product:** Kairos  
**Document Owner:** Product

---

## 1. Purpose

This document defines the canonical terminology used throughout the
Kairos project.

Consistent terminology is important across:

- Product documentation
- User research
- UX and UI design
- Technical architecture
- Source code
- Jira issues
- Testing
- User-facing documentation

When a term has a specific meaning within Kairos, that meaning should
be used consistently unless a documented decision changes it.

This glossary is a living document and should expand as the product
develops.

---

## 2. Core Product Terms

### Kairos

The adaptive desktop companion being developed by this project.

Kairos helps users intentionally manage attention, time, priorities,
focus, routines, and transitions while using a computer.

The name is inspired by the Greek concept of the appropriate or
opportune moment.

---

### Companion

The user-facing role Kairos occupies within the desktop experience.

The term emphasizes that Kairos works alongside the user rather than
acting as an authority over the user.

Depending on user preferences, the companion may behave more like an
assistant, coach, or combination of these roles.

---

### Executive Function

A broad group of cognitive processes involved in managing behavior
toward a goal.

Relevant examples within the Kairos problem space include:

- Planning
- Prioritization
- Working memory
- Task initiation
- Attention regulation
- Time management
- Cognitive flexibility
- Transitioning between activities

Kairos should use this term descriptively and should not use observed
behavior to diagnose executive-function disorders.

---

### Neurodivergent

A broad term describing people whose neurological or cognitive
functioning differs from what is considered typical or neurotypical.

Kairos is designed with neurodivergent experiences in mind but does
not require a user to identify as neurodivergent or disclose a
diagnosis.

---

## 3. Attention Terms

### Intended Attention

The activity, responsibility, or objective the user currently intends
to receive their attention.

Example:

A user begins a focus session intending to write a history paper.

The history paper represents their intended attention.

---

### Actual Attention

The activity currently receiving the user's attention.

Actual attention may or may not match intended attention.

Example:

The user intended to write a history paper but is currently browsing
an unrelated website.

The history paper remains the intended attention while the unrelated
website represents the actual attention.

---

### Attention Alignment

A state where actual attention reasonably matches intended attention.

Kairos should not assume that attention alignment requires the user to
remain inside a single application.

A task may legitimately require multiple applications, websites, or
resources.

---

### Attention Drift

A shift where actual attention begins moving away from intended
attention without the user intentionally changing their objective.

Attention drift may eventually trigger progressive intervention
depending on user permissions and focus configuration.

---

### Distraction

An activity, event, thought, application, website, notification, or
other stimulus that redirects attention away from the user's intended
activity.

Not every change in attention should automatically be classified as a
distraction.

Context and user intent matter.

---

### Attention Recovery

The process of recognizing that attention has shifted and returning to
the intended activity.

Attention recovery may include restoring information about:

- What the user was doing
- Where the user stopped
- What the next action is
- How much time remains

Reducing the friction of attention recovery is a primary Kairos goal.

---

### Hyperfocus

A period of highly sustained attention during which disengaging from
the current activity may become difficult.

Kairos should not automatically treat deep concentration as a
negative condition.

The relevant problem occurs when the user intends or needs to stop,
pause, or transition but has difficulty doing so.

---

## 4. Task and Planning Terms

### Task

A defined activity that the user intends to complete.

A task should generally represent an actionable unit of work.

Example:

> Draft the introduction for my history paper.

---

### Vague Task

A responsibility or intention that does not yet contain enough
information to provide an obvious next action.

Examples:

> Clean my room.

> Work on my project.

> Study for my exam.

A vague task may need to be decomposed before effective planning can
occur.

---

### Task Decomposition

The process of transforming a large, complex, or vague task into
smaller actionable steps.

Example:

> Clean my room.

may be decomposed into:

1. Pick up trash.
2. Collect dirty clothes.
3. Put away clean clothes.
4. Organize the desk.
5. Make the bed.
6. Vacuum the floor.

---

### Next Action

The next specific action the user can take toward completing an
intended activity.

Kairos should favor actionable next steps when helping users begin or
resume work.

---

### Priority

The relative importance or order assigned to an activity.

Priority may be influenced by:

- User preference
- Deadline
- Urgency
- Importance
- Dependencies
- Available time
- Scheduled commitments

Kairos may recommend priority but should not automatically determine
what matters most to the user.

---

### Planned Duration

The amount of time allocated to an activity within the user's
schedule.

Planned duration may differ from both estimated and actual duration.

---

### Estimated Duration

The amount of time an activity is expected to require before the
activity begins.

The estimate may originate from:

- The user
- A generic Kairos estimate
- Previous activity history
- A future Personal Time Model

---

### Active Time

The amount of time the user actively spends performing an activity.

Active time should be distinguished from breaks or unrelated
interruptions when technically possible.

---

### Elapsed Time

The total amount of clock time between the beginning and end of an
activity.

Elapsed time may include:

- Active work
- Breaks
- Interruptions
- Distractions
- Waiting periods

---

### Buffer Time

Additional time intentionally included in a schedule to account for
uncertainty, preparation, delays, or tasks taking longer than
expected.

---

## 5. Focus Terms

### Focus Session

A defined period during which the user intends to direct their
attention toward a particular task, activity, or objective.

A focus session may include:

- A defined objective
- Planned duration
- Break behavior
- Intervention preferences
- Application permissions
- Website permissions
- Focus strictness

---

### Focus Strength

The amount of intervention authority the user gives Kairos during a
focus session.

Current conceptual levels include:

- Standard Focus
- Enhanced Focus
- Strict Focus
- Custom Focus

Final terminology and behavior will be validated during UX design.

---

### Standard Focus

A conceptual focus configuration using progressive reminders without
application or website blocking.

---

### Enhanced Focus

A conceptual focus configuration using more prominent or persistent
interventions than Standard Focus.

Enhanced Focus does not necessarily require application or website
blocking.

---

### Strict Focus

A conceptual focus configuration that may include user-authorized
application or website restrictions in addition to progressive
intervention.

Strict Focus must be intentionally enabled by the user or otherwise
configured through an authorized experience.

---

### Custom Focus

A conceptual focus configuration allowing the user to control
individual focus behaviors rather than selecting a predefined level.

---

## 6. Intervention Terms

### Intervention

An action Kairos takes to bring information, an intention, an
upcoming transition, or another relevant condition to the user's
attention.

Examples may include:

- Widget changes
- Notifications
- Persistent reminders
- Screen overlays
- Audio cues
- Full-screen interruptions
- User-authorized restrictions

---

### Progressive Intervention

The default conceptual strategy where Kairos begins with less
disruptive assistance and increases intervention strength when
appropriate.

A possible progression is:

1. Ambient awareness
2. Gentle reminder
3. Active reminder
4. Persistent reminder
5. Screen overlay
6. Strong intervention
7. User-authorized restriction

The final progression will be determined during UX and technical
design.

---

### Ambient Awareness

Information presented without directly interrupting the user.

Examples may include:

- A desktop widget
- Remaining focus time
- Current task
- Upcoming activity indicator

---

### Screen Overlay

A Kairos interface displayed above another application to increase the
visibility of an intervention.

An overlay does not necessarily prevent interaction with the
underlying application.

---

### Restriction

A user-authorized action that temporarily limits access to a selected
application, website, or other computer activity.

Restrictions should require appropriate permission and should not be
silently enabled by Kairos.

---

## 7. Transition Terms

### Transition

The process of moving from one activity, responsibility, or state to
another.

A transition may involve more than simply stopping one activity and
starting another.

It may require:

- Preparation
- Saving work
- Preserving task context
- Gathering materials
- Mental disengagement
- Physical movement
- Starting the next activity

---

### Transition Window

The period before an upcoming activity during which Kairos may begin
helping the user prepare to transition.

Example:

An appointment beginning at 3:00 PM may have a transition window that
begins significantly earlier if travel or preparation is required.

---

### Transition Assistance

Support provided by Kairos to help a user prepare for, recognize, and
complete a transition.

---

## 8. Activity Awareness Terms

### Activity Awareness

The degree to which Kairos is permitted to observe information about
the user's computer activity.

Activity awareness is conceptually divided into graduated permission
levels.

---

### Session Awareness

The lowest conceptual activity-awareness level.

Kairos knows information about the active Kairos session but does not
monitor which applications or websites the user accesses.

---

### Application Awareness

A conceptual permission level where Kairos may identify the currently
active application.

---

### Domain Awareness

A conceptual permission level where Kairos may identify the domain of
the active website.

Domain awareness does not automatically mean Kairos can inspect the
contents of the webpage.

---

### Context Awareness

A conceptual permission level where Kairos may use additional
information to evaluate whether current computer activity appears
related to the user's intended activity.

Context awareness requires greater privacy consideration than basic
session or application awareness.

---

## 9. Personalization Terms

### Experience Profile

The collection of preferences that determine how Kairos looks,
communicates, and behaves for an individual user.

An Experience Profile may eventually include:

- Theme
- Communication style
- Focus defaults
- Intervention preferences
- Activity-awareness permissions
- Notification preferences
- Sensory preferences
- Accessibility preferences
- Gamification preferences

---

### Communication Style

The manner in which Kairos presents user-facing messages.

Current conceptual styles include:

- Calm
- Direct
- Encouraging
- Playful
- Minimal

Communication style should remain independent from focus strength.

---

### Theme

A configurable visual presentation for Kairos.

Themes may influence:

- Color
- Typography
- Illustration
- Animation
- Widget appearance
- Background elements

A theme should not automatically determine communication style or
focus behavior.

Potential themes include a cherry-blossom-inspired Sakura experience.

---

## 10. Adaptive System Terms

### Personal Time Model

A future capability that may learn how long activities tend to require
for an individual user under different conditions.

A Personal Time Model may consider:

- Estimated duration
- Planned duration
- Active time
- Elapsed time
- Task context
- Previous completion history
- User corrections
- Breaks
- Interruptions

The Personal Time Model is a long-term concept and is not assumed to
be part of the initial MVP.

---

### Context Variable

Information that may affect the expected duration, difficulty, or
behavior of an activity.

Example:

For the task:

> Clean my room.

a context variable might be:

> How dirty is the room?

Possible values may include:

- Light cleanup
- Moderately messy
- Very messy
- Major cleanup

Context variables may eventually improve personalized estimates.

---

### Recommendation

A suggested action generated by Kairos.

Recommendations may involve:

- Priority
- Scheduling
- Duration
- Breaks
- Task decomposition
- Transitions
- Recovery planning

Recommendations should remain explainable and subject to user review
when appropriate.

---

### Explainability

The ability for the user to understand the meaningful factors behind
a Kairos recommendation or decision-support output.

Explainability should answer practical questions such as:

> Why did Kairos recommend this?

rather than requiring the user to understand the internal technical
implementation.

---

## 11. Recovery Terms

### Schedule Disruption

A situation where the user's original schedule is no longer realistic
because circumstances changed.

Examples include:

- A task taking longer than expected
- Starting late
- An unexpected interruption
- Missing an activity
- Needing an additional break
- A priority changing

---

### Recovery Planning

The process of determining how the remaining schedule should change
after a disruption.

Recovery planning may involve:

- Moving activities
- Removing activities
- Shortening activities
- Changing priorities
- Adding breaks
- Recalculating available time

---

### Rescue Mode

A future Kairos experience designed to help users recover when their
original plan has become unrealistic or overwhelming.

Rescue Mode should focus on identifying what still matters and
creating a manageable path forward.

Rescue Mode is currently a product concept rather than a finalized
feature specification.

---

## 12. User Authority Terms

### User Authority

The principle that the user retains meaningful control over how
Kairos affects their computer experience.

Kairos may receive additional authority through explicit user
configuration.

---

### Delegated Authority

A capability the user has intentionally authorized Kairos to perform.

Examples may include:

- Restricting a website during Strict Focus
- Displaying a full-screen transition reminder
- Monitoring active applications

Delegated authority should be understandable and reversible where
appropriate.

---

### Override

A user action that changes, rejects, or bypasses a Kairos
recommendation or behavior when permitted.

Overrides may provide useful feedback for future personalization.

---

## 13. Terms Requiring Future Validation

Some terms in this glossary describe concepts that have not yet
completed UX research or technical validation.

These include:

- Standard Focus
- Enhanced Focus
- Strict Focus
- Custom Focus
- Rescue Mode
- Experience Profile
- Personal Time Model
- Context Awareness

These names should be treated as working terminology.

User-facing terminology may change during research and usability
testing.

---

## 14. Glossary Maintenance

New terminology should be added when:

- A concept appears repeatedly across documentation.
- A term has a Kairos-specific meaning.
- Multiple interpretations could create confusion.
- A technical concept becomes important to product discussions.
- User research establishes preferred terminology.

Existing definitions should be updated when product decisions change.

Significant terminology changes that affect requirements,
architecture, or user experience should also be recorded in:

[docs/07-decisions/DECISION_LOG.md](docs/07-decisions/DECISION_LOG.md)
