# Kairos

Kairos is an adaptive desktop companion designed to help users manage
attention, time, priorities, focus, routines, and transitions while
using a computer.

The product is being designed with neurodivergent users in mind,
beginning with users approximately age 10 and older, while remaining
useful to anyone who benefits from additional support with executive
functioning, organization, focus, or time awareness.

Kairos is intended to function as a customizable support layer within
the desktop environment rather than solely as a traditional planner,
timer, or task-management application.

---

## Product Vision

Kairos aims to create a computer experience that adapts to how an
individual manages attention, time, and responsibilities.

The product is centered around helping users:

- Decide what deserves attention now.
- Recover from distraction.
- Maintain awareness during deep focus.
- Prepare for transitions.
- Better understand how they use their time.
- Recover when plans change.
- Personalize how support is delivered.

Kairos should support the user without becoming controlling,
punitive, or unnecessarily intrusive.

---

## Core Product Philosophy

Kairos is guided by several foundational principles:

- Support, do not punish.
- The user remains in control.
- Adapt to the user.
- Intervene progressively.
- Greater capability requires greater permission.
- Design for needs, not diagnoses.
- Privacy should be considered from the beginning.
- Accessibility is foundational.
- Recovery is part of productivity.
- Meaningful recommendations should be explainable.
- AI should assist rather than decide.
- Personalization should improve outcomes rather than create
  dependence.

Detailed product principles are documented in:

[Product Principles](docs/00-product/PRODUCT_PRINCIPLES.md)

---

## Primary Problem Areas

Kairos is currently focused on three central problems.

### Prioritization

Users may know that several responsibilities need to be completed
without being able to easily determine what should receive attention
first.

### Distraction and Attention Recovery

Users may begin an activity with a clear intention, become distracted,
and later lose track of what they originally intended to accomplish.

### Hyperfocus and Transitions

Users may become deeply engaged in an activity and have difficulty
recognizing when they should stop, pause, or transition to another
responsibility.

These problems share a common theme:

> Kairos seeks to reduce the gap between intended attention and actual
> attention.

---

## Current Project Stage

Kairos is currently in:

**Product Discovery and Planning**

The project is intentionally documentation-first.

No technology stack or implementation architecture has been finalized.

Current work focuses on:

- Product definition
- User research
- Product requirements
- Accessibility requirements
- Privacy and safety requirements
- UX design
- Technical feasibility
- Architecture
- MVP definition
- Development planning

Application development will begin after the product and technical
foundations are sufficiently defined.

---

## Documentation

Project documentation is maintained in the `docs/` directory.

### Product

`docs/00-product/`

Contains the foundational product definition.

Current documents include:

- `PRODUCT_VISION.md`
- `PRODUCT_PRINCIPLES.md`
- `PROBLEM_STATEMENT.md`
- `GOALS_AND_NON_GOALS.md`
- `GLOSSARY.md`

### Research

`docs/01-research/`

Planned documentation for:

- User groups
- User needs
- Executive-function research
- Competitive research
- Research questions

### Requirements

`docs/02-requirements/`

Planned documentation for:

- Product requirements
- Functional requirements
- Non-functional requirements
- Accessibility requirements
- Privacy and safety
- Guardian and youth requirements

### User Experience

`docs/03-ux/`

Planned documentation for:

- Experience profiles
- User journeys
- Intervention behavior
- Notification behavior
- Widgets
- Routines
- Recovery experiences

### Design

`docs/04-design/`

Planned documentation for:

- Design system
- Accessibility design
- Responsive behavior
- Wireframes

### Architecture

`docs/05-architecture/`

Planned documentation for:

- System architecture
- Data model
- Background services
- Operating-system integration
- AI architecture
- Security
- Architecture Decision Records

### Development

`docs/06-development/`

Planned documentation for:

- MVP scope
- Product roadmap
- Development workflow
- Testing strategy
- Definition of Done

### Decisions

`docs/07-decisions/`

Used to document significant project decisions and unresolved
questions.

---

## Product Scope

Kairos is intended to support:

- Focus
- Attention management
- Time awareness
- Prioritization
- Task initiation
- Task decomposition
- Routines
- Transitions
- Schedule recovery
- Personalized assistance

Kairos is not intended to:

- Diagnose neurodivergence.
- Provide medical or psychological treatment.
- Maximize work output.
- Eliminate all distraction.
- Make decisions on behalf of the user.
- Become employee-monitoring software.
- Become general-purpose parental-surveillance software.
- Require AI for basic functionality.

See:

[Goals and Non-Goals](docs/00-product/GOALS_AND_NON_GOALS.md)

---

## Planned Development Approach

Kairos will follow an iterative product-development process.

```text
Discovery
    ↓
Product Definition
    ↓
User Research
    ↓
Requirements
    ↓
UX Design
    ↓
Technical Architecture
    ↓
MVP Definition
    ↓
Backlog Creation
    ↓
Development
    ↓
Testing
    ↓
Release
    ↓
Iteration
```

Features should be connected to validated user problems before entering
the development backlog.

---

## Branching Strategy

Kairos uses a GitFlow-inspired workflow.

Primary branches:

```text
main
  │
  └── develop
        │
        ├── feature/*
        ├── docs/*
        ├── fix/*
        └── refactor/*
```

### `main`

Represents stable project milestones and release-ready work.

### `develop`

Serves as the primary integration branch for ongoing development.

### Working Branches

Changes should generally be developed in focused branches such as:

```text
docs/product-foundation
feature/focus-session
fix/notification-timing
refactor/task-service
```

Changes should be reviewed before being merged into `develop`.

---

## Project Status

| Area                    | Status      |
| ----------------------- | ----------- |
| Product Vision          | Complete    |
| Product Principles      | Complete    |
| Problem Definition      | Complete    |
| Goals and Non-Goals     | Complete    |
| Product Glossary        | Complete    |
| User Research           | Not Started |
| Product Requirements    | Not Started |
| UX Design               | Not Started |
| Technical Architecture  | Not Started |
| MVP Definition          | Not Started |
| Application Development | Not Started |

---

## Repository

This repository currently contains product planning and documentation.

Application source code will be added after the discovery,
requirements, UX, and technical-planning phases establish a validated
foundation for development.
