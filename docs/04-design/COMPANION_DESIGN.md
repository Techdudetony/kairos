# Kairos Companion Design

**Document Status:** Draft  
**Version:** 0.1  
**Last Updated:** August 2026  
**Product:** Kairos  
**Document Owner:** Design

---

## 1. Purpose

This document defines the initial design model for the Kairos desktop
companion.

The companion should combine:

```text
Personality
    +
Utility
```

without becoming distracting.

The MVP companion should support the approved interaction model while
remaining lightweight, accessible, and customizable.

---

## 2. Companion Model

Kairos will use a:

**Companion + Utility Card**

model.

The companion provides:

- Personality
- State awareness
- Theme expression
- Optional visual feedback

The utility card provides:

- Current intention
- Remaining time
- Contextual actions
- Important status information

The user must be able to understand Kairos without relying on the
companion character alone.

---

## 3. Design Goals

The companion should:

1. Remain useful without demanding attention.
2. Communicate Kairos state clearly.
3. Avoid covering important user content unnecessarily.
4. Support keyboard and assistive-technology access.
5. Adapt to themes and presentation preferences.
6. Allow reduced visual intensity.
7. Remain understandable without animation.
8. Preserve user control.

---

## 4. Default Companion Anatomy

Conceptually:

```text
       Companion
           ↓

┌───────────────────────────┐
│ Current intention         │
│                           │
│ Remaining time            │
│                           │
│ Contextual controls       │
└───────────────────────────┘
```

The companion and utility card may be visually connected, but they
should remain functionally separable.

---

## 5. Utility Card Information Priority

The card should prioritize three questions:

```text
What am I doing?

How much time remains?

Does Kairos need something from me?
```

Primary information:

- Current intention
- Remaining time
- Kairos state

Secondary information may include:

- Priority
- Current objective
- Next intended action
- Expected application status

Secondary information should not overwhelm the normal Companion state.

---

## 6. Companion States

The companion should visually reflect the approved interaction states.

### Companion

Normal focus state.

Visual direction:

- Calm
- Neutral
- Low motion
- Low prominence

---

### Ambient

Possible attention drift has been detected.

Visual direction:

- Slightly increased prominence
- Subtle companion reaction
- Optional accent change
- No forced interaction

The visual change should remain easy to ignore if the user is
intentionally working.

---

### Prompt

Kairos is asking for clarification.

The utility card may expand to display:

```text
Still working on your current task?

[ Yes ]
[ Return to Task ]
[ Change My Plan ]
[ Dismiss ]
```

The companion may visually reinforce that Kairos is requesting
attention.

---

### Intervention

Kairos is providing stronger focus assistance.

The card should become more prominent and display clear actions.

The companion may become more expressive, but the intervention must
remain:

- Dismissible
- Non-blocking
- Accessible
- User controlled

---

### Transition

The focus period is approaching its planned end.

The companion may visually communicate preparation or time awareness.

The utility card should emphasize:

- Remaining time
- Current intention
- Transition preparation

---

### Session End

The planned time has ended.

The utility card should provide:

```text
[ Complete ]
[ Extend ]
[ Reschedule ]
```

The companion should not imply failure if the activity remains
unfinished.

---

## 7. Collapsed and Expanded States

The Kairos companion should support at least two presentation sizes.

### Collapsed

Designed for minimal desktop presence.

May show:

```text
Companion
Current task
Remaining time
```

Example:

```text
  ◉  Finish requirements
     24 min
```

The final visual form is not yet defined.

---

### Expanded

Used when:

- The user intentionally opens Kairos.
- Kairos presents a Prompt.
- Kairos presents an Intervention.
- Transition details are needed.
- Session-end actions are needed.

Expanded state may include:

- Full intention
- Objective
- Next action
- Session controls
- Intervention actions

---

## 8. Expansion Principle

Kairos should use the smallest presentation that communicates the
necessary information.

Conceptually:

```text
No action needed
    ↓
Collapsed

More context needed
    ↓
Expanded
```

Kairos should not remain expanded after the need for additional
attention has passed.

---

## 9. Companion Position

The companion should behave as a floating desktop surface.

The user should eventually be able to choose its location.

Potential defaults include:

- Bottom-right
- Bottom-left
- Top-right
- Top-left

Initial prototypes should test these positions rather than assuming
one universal default.

---

## 10. User Position Control

The user should be able to reposition the companion.

Potential interaction:

```text
Drag companion
      ↓
Move to preferred location
      ↓
Kairos remembers position
```

The implementation should account for:

- Multiple monitors
- Display scaling
- Taskbar placement
- Screen boundaries

---

## 11. Always-on-Top Behavior

The companion may use always-on-top behavior during active sessions.

However, the surface should not unnecessarily obstruct the user's work.

Future settings may include:

```text
Always visible

Visible during focus sessions

Auto-hide until needed
```

The MVP default should be determined during prototyping.

---

## 12. Auto-Hide

Auto-hide may reduce distraction for users who prefer minimal desktop
presence.

Potential behavior:

```text
Companion inactive
      ↓
Reduce prominence
      ↓
Pointer approaches
or intervention occurs
      ↓
Restore full presence
```

Auto-hide is not required for the first implementation unless
prototyping demonstrates clear value.

---

## 13. Companion Character

The exact Kairos companion character is intentionally unresolved.

The initial design phase should explore multiple directions before
selecting a final identity.

Potential concepts may include:

- Abstract time-inspired character
- Nature-inspired companion
- Mythology-inspired companion
- Minimal geometric character
- Customizable non-character presence

The companion should not be designed solely for younger users.

---

## 14. Character Design Constraints

If Kairos uses a character-based companion, it should:

- Work at very small sizes.
- Remain recognizable without detailed illustration.
- Support multiple emotional or state expressions.
- Function in light and dark themes.
- Remain appropriate across age groups.
- Avoid requiring animation for comprehension.

The character should enhance Kairos rather than become the product's
only source of identity.

---

## 15. Companion Customization

Future customization may include:

- Companion style
- Companion visibility
- Expression intensity
- Theme relationship
- Motion level
- Size

A user should be able to choose a minimal presentation without losing
Kairos functionality.

---

## 16. Presentation Mode Relationship

Companion behavior may vary according to presentation preference.

### Minimal

- Smaller companion presence
- Reduced decorative elements
- Reduced motion
- Utility-first

### Friendly

- Moderate companion presence
- Warm expression
- Soft visual feedback

### Playful

- More expressive reactions
- Increased optional motion
- Stronger theme personality

### Expressive

- Most prominent theme and companion treatment
- Richer decorative behavior
- Strong visual identity

All modes must preserve identical core functionality.

---

## 17. Theme Relationship

Themes may modify the companion's:

- Accent treatment
- Decorative elements
- Background
- Expression styling
- Optional animation

Themes should not alter the meaning of the companion state.

Example:

```text
Ambient
```

must remain understandable in:

```text
Kairos Calm
Sakura
Future themes
```

without relying on theme-specific knowledge.

---

## 18. Sakura Companion Treatment

The Sakura theme may incorporate:

- Petal accents
- Botanical shapes
- Soft rose tones
- Subtle branch elements
- Optional falling-petal motion

The companion itself does not need to become a cherry-blossom
character.

The theme should influence the environment around the companion without
forcing a specific character identity.

---

## 19. Time Visualization

Remaining time is a core companion function.

Potential representations to prototype include:

- Numeric countdown
- Progress ring
- Progress bar
- Visual time block
- Combined countdown and progress

The MVP should not assume one representation before usability testing.

---

## 20. Progress Ring Concept

A progress ring may work particularly well with a companion model.

Conceptually:

```text
     ◜──────◝
   Companion
     ◟──────◞

   24 min left
```

The ring could represent session progress without requiring additional
screen space.

If used, the ring must not be the only source of remaining-time
information.

---

## 21. Intervention Expansion

When intervention escalates, the utility card may expand rather than
launching an entirely unrelated interface.

Conceptually:

```text
Collapsed Companion
        ↓
Possible drift
        ↓
Expanded Prompt
        ↓
Stronger Intervention
```

This maintains continuity and may reduce context switching.

---

## 22. Attention Recovery Surface

When the user selects `Return to Task`, Kairos should prioritize:

```text
You were working on:

[ Current Intention ]

Next:

[ Next Intended Action ]

Time remaining:

[ Remaining Time ]
```

Additional context should remain secondary.

The surface should make task recovery fast.

---

## 23. Transition Surface

Transition presentation should become gradually more visible.

Conceptually:

```text
10 minutes
Subtle time cue

5 minutes
Preparation prompt

Time reached
Decision surface
```

The companion may reinforce the transition visually, but the utility
card carries the actual information.

---

## 24. Interaction Controls

Common companion actions may include:

- Expand
- Collapse
- Dismiss prompt
- Pause session
- Extend session
- Complete session
- Change plan

The normal Companion state should avoid displaying every possible
action simultaneously.

---

## 25. Context Menu

A secondary context menu may eventually provide low-frequency actions.

Potential actions:

```text
Open Kairos
Pause session
End session
Hide companion
Settings
Exit Kairos
```

This may be accessed through:

- Right-click
- Tray icon
- Companion menu button

Exact behavior will be determined during implementation design.

---

## 26. System Tray Relationship

Kairos should remain accessible through the Windows system tray.

The tray should support recovery if the companion is hidden.

Potential tray actions:

```text
Open Kairos
Show companion
Start focus session
Pause / resume
Settings
Exit
```

The tray should not duplicate every companion interaction.

---

## 27. Keyboard Accessibility

Interactive companion surfaces must be keyboard accessible.

When expanded, users should be able to:

- Navigate actions using keyboard controls.
- Identify the currently focused control.
- Activate controls without a mouse.
- Dismiss supported surfaces through keyboard interaction.

Collapsed companion state should avoid unnecessarily entering keyboard
focus order when the user is working elsewhere.

---

## 28. Screen Reader Behavior

The companion should expose meaningful accessible names and states.

Examples:

```text
Kairos companion

Current task: Finish requirements

24 minutes remaining

Possible attention drift detected
```

Decorative companion expressions should not create unnecessary
screen-reader noise.

---

## 29. Motion

Companion animation should remain optional and purposeful.

Potential uses:

- Small idle movement
- State transition
- Attention cue
- Theme decoration

Animation must not be required to understand Kairos state.

Reduced-motion preferences must be respected.

---

## 30. Sound

The companion may eventually support optional sound cues.

Potential uses include:

- Transition warning
- Session completion
- Prompt

Sounds should remain secondary to visual and accessible information.

---

## 31. Multiple Monitor Behavior

Kairos should preserve companion placement across supported monitor
configurations where practical.

If a previously used monitor is unavailable, the companion should
return to a visible location on an available display.

Kairos must never reopen the companion entirely off-screen.

---

## 32. Full-Screen Applications

Kairos must handle full-screen applications carefully.

The companion should not automatically interfere with:

- Presentations
- Full-screen video
- Games
- Accessibility software

The exact behavior requires implementation testing.

Potential future behavior may include user-configurable suppression or
reduced prominence.

---

## 33. Companion Failure Behavior

If the companion surface fails:

```text
Companion may close
       ↓
Kairos background functionality may continue
       ↓
Computer remains usable
```

A companion failure must never interfere with access to other
applications.

---

## 34. Prototype Questions

The design phase should prototype and evaluate:

1. Companion placement.
2. Collapsed companion size.
3. Utility card dimensions.
4. Companion-to-card relationship.
5. Countdown versus progress visualization.
6. Ambient-state visibility.
7. Prompt expansion behavior.
8. Intervention prominence.
9. Transition presentation.
10. Character versus abstract companion direction.
11. Minimal versus expressive companion modes.
12. Light and dark behavior.
13. Sakura theme treatment.
14. Reduced-motion behavior.

---

## 35. Deferred Companion Capabilities

The following are outside the initial MVP:

- Companion marketplace
- Downloadable characters
- Advanced companion animation
- Voice interaction
- AI-generated companion personalities
- Cross-device companion synchronization
- Guardian-specific companion behavior

These may be explored after the core companion model is validated.

---

## 36. Related Documentation

### Design

- [Design System](DESIGN_SYSTEM.md)

### UX

- [User Flows](../03-ux/USER_FLOWS.md)
- [Interaction Model](../03-ux/INTERACTION_MODEL.md)

### Requirements

- [Product Requirements](../02-requirements/PRODUCT_REQUIREMENTS.md)
- [MVP Scope](../02-requirements/MVP_SCOPE.md)

### Architecture

- [Technical Stack](../05-architecture/TECH_STACK.md)
- [Architecture Decisions](../05-architecture/ARCHITECTURE_DECISIONS.md)
