# Kairos Requirements Traceability

**Document Status:** Draft  
**Version:** 0.1  
**Last Updated:** August 2026  
**Product:** Kairos

---

## 1. Purpose

This document connects Kairos MVP requirements to the research and
product decisions that support them.

Traceability will eventually connect:

```text
Research
    ↓
Requirement
    ↓
Jira Issue
    ↓
Implementation
    ↓
Test
```

Jira and implementation references will be added as development
progresses.

---

## 2. Traceability Status

Requirements use the following evidence classifications.

| Status     | Meaning                                              |
| ---------- | ---------------------------------------------------- |
| Supported  | Existing research provides meaningful support        |
| Partial    | Some evidence exists, but validation is still needed |
| Hypothesis | Primarily a Kairos product hypothesis                |
| Technical  | Requires technical validation                        |

A supported requirement is not automatically a validated Kairos
solution.

Direct user testing is still required.

---

## 3. Functional Requirements

| ID      | Requirement                     | Research | Evidence   |  MVP   |
| ------- | ------------------------------- | -------- | ---------- | :----: |
| FR-FI01 | Create focus intention          | RQ-P01   | Partial    |  Yes   |
| FR-FI02 | Display current intention       | RQ-P04   | Hypothesis |  Yes   |
| FR-FI03 | Update intention                | RQ-E03   | Partial    |  Yes   |
| FR-TM01 | Display remaining time          | RQ-T01   | Partial    |  Yes   |
| FR-TM02 | Transition warnings             | RQ-TR02  | Partial    |  Yes   |
| FR-TM03 | Extend focus time               | RQ-TR01  | Hypothesis |  Yes   |
| FR-AA01 | Detect active application       | RQ-PR01  | Technical  |  Yes   |
| FR-AA02 | Define expected applications    | RQ-PR01  | Hypothesis |  Yes   |
| FR-AA03 | Detect possible attention drift | RQ-P03   | Hypothesis |  Yes   |
| FR-AA04 | Correct activity interpretation | RQ-E03   | Partial    |  Yes   |
| FR-PI01 | Ambient intervention            | RQ-I01   | Hypothesis |  Yes   |
| FR-PI02 | Direct prompt                   | RQ-I01   | Hypothesis |  Yes   |
| FR-PI03 | Focus intervention              | RQ-I02   | Hypothesis |  Yes   |
| FR-PI04 | Intervention control            | RQ-I01   | Partial    |  Yes   |
| FR-AR01 | Preserve task context           | RQ-P04   | Supported  |  Yes   |
| FR-AR02 | Support return to intention     | RQ-P04   | Partial    |  Yes   |
| FR-AR03 | Allow plan changes              | RQ-E03   | Partial    |  Yes   |
| FR-TR01 | Prepare for transition          | RQ-TR02  | Partial    |  Yes   |
| FR-TR02 | End-of-session decision         | RQ-TR01  | Hypothesis |  Yes   |
| FR-TR03 | Preserve unfinished context     | RQ-TR03  | Supported  |  Yes   |
| FR-LP01 | Basic task planning             | RQ-P01   | Partial    |  Yes   |
| FR-LP02 | Basic priority                  | RQ-P01   | Partial    | Should |
| FR-LP03 | Reschedule incomplete activity  | RQ-PL04  | Partial    |  Yes   |
| FR-BC01 | Background operation            | RQ-AR01  | Hypothesis |  Yes   |
| FR-BC02 | Lightweight desktop presence    | RQ-AR01  | Hypothesis |  Yes   |
| FR-BC03 | Prominent intervention          | RQ-I02   | Hypothesis |  Yes   |

---

## 4. Non-Functional Requirements

| ID       | Requirement                    | Basis                       | Evidence   |  MVP   |
| -------- | ------------------------------ | --------------------------- | ---------- | :----: |
| NFR-UP01 | User-controlled awareness      | Privacy research            | Supported  |  Yes   |
| NFR-UP02 | Minimize observation           | Privacy principle           | Supported  |  Yes   |
| NFR-UP03 | Avoid unsupported inference    | Executive-function research | Supported  |  Yes   |
| NFR-UP04 | User override                  | Product principles          | Supported  |  Yes   |
| NFR-AP01 | Accessible core experience     | Accessibility principle     | Supported  |  Yes   |
| NFR-AP02 | Theme-ready architecture       | Product vision              | Hypothesis | Should |
| NFR-AP03 | Age-neutral core functionality | User research               | Supported  |  Yes   |
| NFR-RL01 | Background stability           | Technical requirement       | Technical  |  Yes   |
| NFR-RL02 | Safe failure                   | Technical requirement       | Technical  |  Yes   |
| NFR-RL03 | Resource awareness             | Technical requirement       | Technical  |  Yes   |

---

## 5. Research Source Map

Research identifiers originate from:

- [Research Questions](../01-research/RESEARCH_QUESTIONS.md)
- [Assumptions and Hypotheses](../01-research/ASSUMPTIONS_AND_HYPOTHESES.md)
- [Executive Function Research](../01-research/EXECUTIVE_FUNCTION_RESEARCH.md)
- [Competitive Research](../01-research/COMPETITIVE_RESEARCH.md)

The traceability matrix intentionally references research rather than
duplicating its contents.

---

## 6. Future Jira Traceability

Once Jira is configured, requirements should be referenced from the
issues that implement them.

Example:

```text
Requirement:
FR-AR01

Jira:
KAIROS-XX

Implementation:
PR #XX

Validation:
TEST-AR01
```

A requirement may map to multiple Jira issues.

A Jira issue may also satisfy multiple closely related requirements.

---

## 7. Traceability Rules

When requirements change:

1. Keep the requirement ID stable whenever its intent remains the same.
2. Update the requirement text in `PRODUCT_REQUIREMENTS.md`.
3. Update this traceability matrix.
4. Update affected Jira issues after Jira tracking begins.
5. Record significant product decisions when necessary.

If a requirement is removed, its ID should not be silently reused for
an unrelated requirement.

---

## 8. MVP Traceability Summary

The MVP currently contains:

| Category       |   Must | Should |
| -------------- | -----: | -----: |
| Functional     |     25 |      1 |
| Non-Functional |      9 |      1 |
| **Total**      | **34** |  **2** |

The primary areas requiring direct product validation remain:

- Persistent desktop presence
- Application-based attention awareness
- Progressive intervention
- Intervention escalation
- Transition behavior
- User response to Kairos prompts

These areas should receive particular attention during prototype and
usability testing.

---

## 9. Related Documentation

### Requirements

- [Product Requirements](PRODUCT_REQUIREMENTS.md)
- [MVP Scope](MVP_SCOPE.md)

### Research

- [User Groups](../01-research/USER_GROUPS.md)
- [User Needs](../01-research/USER_NEEDS.md)
- [Research Questions](../01-research/RESEARCH_QUESTIONS.md)
- [Assumptions and Hypotheses](../01-research/ASSUMPTIONS_AND_HYPOTHESES.md)
- [Executive Function Research](../01-research/EXECUTIVE_FUNCTION_RESEARCH.md)
- [Competitive Research](../01-research/COMPETITIVE_RESEARCH.md)
