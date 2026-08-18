# Kairos Design System

**Document Status:** Draft  
**Version:** 0.1  
**Last Updated:** August 2026  
**Product:** Kairos  
**Document Owner:** Design

---

## 1. Purpose

This document defines the initial visual design system for Kairos.

The design system establishes shared rules for:

- Visual personality
- Color
- Typography
- Spacing
- Shape
- Elevation
- Interaction states
- Themes
- Appearance modes
- Accessibility
- Motion
- Experience customization

This document defines design foundations rather than final screen
layouts.

Detailed companion behavior is documented in:

[Companion Design](COMPANION_DESIGN.md)

---

## 2. Design Direction

Kairos uses a **calm modern** visual direction.

The interface should feel:

- Calm
- Supportive
- Modern
- Clear
- Approachable
- Customizable
- Low pressure
- Age-flexible

Kairos should not feel:

- Clinical
- Childish by default
- Corporate
- Judgmental
- Overstimulating
- Gamified by default

Visual prominence should generally increase only when Kairos has a
reason to request more of the user's attention.

---

## 3. Design Principles

### 3.1 Calm Before Attention

Normal Kairos states should remain visually quiet.

Prominence should increase progressively when intervention becomes
necessary.

```text
Companion
    ↓
Ambient
    ↓
Prompt
    ↓
Intervention
```

---

### 3.2 Clarity Before Decoration

Decorative elements must never make important information harder to
understand.

Themes may add personality, but the functional interface remains
primary.

---

### 3.3 Preference Before Assumption

Kairos should not assume that a user's preferred experience can be
determined solely by age.

Users should be able to choose presentation preferences regardless of
age.

---

### 3.4 User Control

Customization should help users make Kairos comfortable to use without
changing the meaning of core interactions.

Users should retain control over:

- Theme
- Appearance mode
- Presentation style
- Motion preferences
- Companion visibility
- Supported sensory cues

---

### 3.5 Accessibility Is Structural

Accessibility is part of the design system rather than a visual
enhancement added later.

Important meaning must not depend exclusively on:

- Color
- Animation
- Sound
- Decorative imagery
- Position

---

## 4. Core UI and Theme Architecture

Kairos separates its functional interface from its visual theme.

```text
Kairos Core UI
      +
Theme Layer
      ↓
User Experience
```

### Core UI

The Core UI defines:

- Layout behavior
- Information hierarchy
- Interaction patterns
- Component anatomy
- Accessibility behavior
- Focus states
- Intervention hierarchy

These should remain consistent across themes.

### Theme Layer

Themes may influence:

- Accent colors
- Surface colors
- Decorative motifs
- Companion appearance
- Background treatments
- Optional animation
- Illustration style

Themes must not change the fundamental meaning of controls or
interaction states.

---

## 5. Default Theme

### Kairos Calm

`Kairos Calm` is the default visual theme.

It should provide:

- Neutral surfaces
- Soft contrast
- Muted accent colors
- Minimal decoration
- Subtle depth
- Clear information hierarchy

The default theme should be suitable for a broad range of users without
strongly implying a particular age or aesthetic preference.

Exact color tokens will be finalized during visual prototyping.

---

## 6. Theme: Sakura

`Sakura` is an optional expressive Kairos theme inspired by Japanese
cherry blossoms.

### Visual Direction

The theme may use:

- Warm off-white
- Soft blush
- Dusty rose
- Muted plum
- Pale botanical accents
- Subtle branch motifs
- Petal motifs

Optional decorative motion may include subtle falling petals.

### Theme Constraints

Sakura decoration must never:

- Obscure functional content.
- Communicate important state by itself.
- Reduce text contrast.
- Require animation to understand application state.
- Override reduced-motion preferences.

The Sakura theme is an aesthetic option rather than an age-specific
theme.

---

## 7. Appearance Modes

Kairos should support:

```text
Light
Dark
System
```

### Light

Uses the active theme's light palette.

### Dark

Uses the active theme's dark palette.

### System

Follows the operating system appearance preference.

Theme implementations should provide both light and dark variants where
practical.

---

## 8. Presentation Preferences

Kairos should support presentation preferences independently from
themes.

Initial conceptual modes are:

| Mode       | Direction                                     |
| ---------- | --------------------------------------------- |
| Minimal    | Reduced decoration and visual activity        |
| Friendly   | Warm, approachable presentation               |
| Playful    | Increased personality and expressive elements |
| Expressive | Stronger theme and companion presence         |

These modes are not age restrictions.

For example:

```text
Sakura + Minimal
Sakura + Expressive
Kairos Calm + Friendly
Kairos Calm + Minimal
```

should all be valid combinations.

The exact behavior of these modes requires design prototyping.

---

## 9. Companion Model

Kairos uses a:

**Companion + Utility Card**

model.

The utility card remains responsible for communicating functional
information.

The companion provides personality and additional state awareness.

Conceptually:

```text
     Companion
         ↓

┌──────────────────────────┐
│ Current intention        │
│                          │
│ Remaining time           │
│                          │
│ Contextual controls      │
└──────────────────────────┘
```

The companion must not become necessary to understand the information
displayed by the utility card.

Detailed behavior is defined in:

[Companion Design](COMPANION_DESIGN.md)

---

## 10. Color System

Kairos should use semantic color tokens rather than embedding raw color
values directly throughout the interface.

Conceptual tokens include:

```text
Background
Surface
Surface Elevated

Text Primary
Text Secondary
Text Disabled

Border
Border Strong

Accent
Accent Hover
Accent Pressed

Focus

Success
Warning
Attention
Error
```

Themes provide the actual values for these tokens.

This allows components to remain consistent while visual themes change.

---

## 11. Intervention Color Behavior

Intervention states may use increased contrast or stronger accents.

However:

```text
Color ≠ State
```

Color alone must never communicate the current intervention level.

State should also be communicated through appropriate combinations of:

- Text
- Shape
- Iconography
- Layout
- Accessible labels

---

## 12. Typography

Kairos should use highly readable sans-serif typography for the primary
interface.

The typography system should prioritize:

- Readability
- Clear hierarchy
- Comfortable line spacing
- Windows rendering quality
- Accessibility
- Support for scaling

Initial typography roles:

```text
Display
Heading
Title
Body
Body Small
Label
Caption
```

Exact typefaces, weights, and sizes will be finalized during visual
prototyping.

---

## 13. Spacing

Kairos should use a consistent spacing scale.

Initial conceptual scale:

```text
4
8
12
16
24
32
48
```

Spacing should support comfortable visual separation without making
desktop surfaces unnecessarily large.

Dense presentation may be explored as a future user preference.

---

## 14. Shape

Kairos should use soft geometry consistent with its calm-modern
direction.

Components may use:

- Rounded cards
- Rounded buttons
- Soft container edges
- Circular companion elements where appropriate

Rounded geometry should not reduce information density or make
interactive boundaries unclear.

Exact radius tokens will be established during prototyping.

---

## 15. Elevation

Elevation should be restrained.

Potential levels include:

```text
Base
Raised
Floating
Intervention
```

The companion and temporary prompts may require stronger separation from
the user's desktop than standard application surfaces.

Elevation should communicate hierarchy without creating excessive
visual depth.

---

## 16. Component States

Interactive components should define at least:

```text
Default
Hover
Pressed
Focused
Disabled
```

Where relevant, components may additionally define:

```text
Selected
Active
Attention
Error
```

Keyboard focus must remain visually identifiable.

---

## 17. Focus Indicators

Keyboard focus indicators must be clearly visible.

Themes may customize their appearance but must preserve sufficient
contrast and visibility.

Decorative theme elements must never obscure focus indicators.

---

## 18. Motion

Motion should be purposeful.

Appropriate uses may include:

- State transitions
- Companion reactions
- Progress changes
- Gentle attention cues
- Theme decoration

Motion should not be used merely because animation is available.

---

## 19. Reduced Motion

Kairos should support reduced-motion preferences.

When reduced motion is enabled:

- Non-essential decorative animation should stop.
- State changes should remain understandable.
- Attention cues should use non-motion alternatives.
- Theme animation should respect the preference.

Operating-system reduced-motion preferences should be respected where
technically practical.

---

## 20. Sound

Sound may eventually provide an optional secondary cue.

Sound should never be the only indicator of:

- Intervention
- Session completion
- Transition warning
- Error
- Required action

Users should be able to reduce or disable non-essential sounds.

Detailed sound design is deferred.

---

## 21. Information Density

Kairos should prioritize immediate comprehension.

The companion surface should emphasize:

```text
What am I doing?

How much time remains?

Does Kairos need something from me?
```

Secondary information should not compete with these questions.

---

## 22. Intervention Visual Hierarchy

The interaction states should increase visual prominence progressively.

Conceptually:

| State        | Visual Direction        |
| ------------ | ----------------------- |
| Companion    | Quiet                   |
| Ambient      | Subtle change           |
| Prompt       | Clear request           |
| Intervention | Strong attention        |
| Transition   | Time-oriented awareness |
| Session End  | Clear decision point    |

Exact visual treatments require prototyping.

---

## 23. Responsive Desktop Behavior

Kairos is a desktop-first application.

Design should account for:

- Different screen sizes
- Display scaling
- Multiple monitors
- Window positioning
- Taskbar placement
- Full-screen applications
- High-DPI displays

The companion should not assume a fixed screen resolution.

---

## 24. Accessibility Foundation

Kairos visual design should target accessible contrast and interaction
patterns.

Design validation should include:

- Text contrast
- Non-text contrast
- Keyboard navigation
- Visible focus
- UI scaling
- Screen-reader semantics
- Reduced motion
- Color-independent meaning

WCAG guidance should inform applicable visual decisions even though
Kairos is a native desktop application.

---

## 25. Customization Boundaries

Customization should affect presentation without making Kairos
unrecognizable or changing core interaction meaning.

Users may eventually customize:

- Theme
- Appearance
- Presentation preference
- Companion style
- Companion visibility
- Motion
- Sound
- Surface density

Users should not be required to customize Kairos before it becomes
usable.

Defaults must provide a complete experience.

---

## 26. Age and Experience

Kairos is initially intended for users age 10 and older.

Age may inform recommended onboarding defaults in future versions.

Age should not lock users into:

- Specific themes
- Child-oriented visuals
- Simplified functionality
- Specific companions
- Specific presentation modes

The user's selected preferences should remain authoritative.

---

## 27. Design Tokens

The implementation should eventually represent foundational design
values as reusable tokens.

Conceptually:

```text
Color
Typography
Spacing
Radius
Elevation
Motion
```

Example:

```text
Color.Surface
Color.Text.Primary
Color.Accent

Spacing.Small
Spacing.Medium
Spacing.Large

Radius.Small
Radius.Medium
Radius.Large
```

Exact implementation naming will be determined during development.

---

## 28. Deferred Design Decisions

The following remain intentionally unresolved:

- Exact color values
- Final typography
- Companion character identity
- Companion illustrations
- Exact component dimensions
- Exact corner radii
- Exact shadows
- Animation timing
- Intervention animations
- Sound design
- Theme catalog beyond initial concepts
- Onboarding visuals

These should be resolved through visual exploration and prototyping.

---

## 29. Related Documentation

### UX

- [User Flows](../03-ux/USER_FLOWS.md)
- [Interaction Model](../03-ux/INTERACTION_MODEL.md)

### Design

- [Companion Design](COMPANION_DESIGN.md)

### Requirements

- [Product Requirements](../02-requirements/PRODUCT_REQUIREMENTS.md)
- [MVP Scope](../02-requirements/MVP_SCOPE.md)

### Architecture

- [Technical Stack](../05-architecture/TECH_STACK.md)
- [Architecture Decisions](../05-architecture/ARCHITECTURE_DECISIONS.md)
