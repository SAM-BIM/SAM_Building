# Icon migration validation — 2026-10-11

Base: `master`. Scope: SAM-BIM only. Reference: [SAM#179](https://github.com/SAM-BIM/SAM/pull/179); [SAM#166](https://github.com/SAM-BIM/SAM/pull/166) is the closed historical design source.

## Changes and decisions

- Grasshopper manifest coverage: 2 concrete objects. GUIDs, APIs, namespaces, component metadata and behavior are preserved.
- Reuse the frozen SAM glyph/palette/badge grammar and frozen SAM-BIM extension v1. Preserve plugin identity, external integration logos, severity symbols and historical attribution.
- Source comparison against current base: 2 icon resource token swaps; 0 other production C# changes, apart from standard SPDX headers and additive resource properties.
- Validated 2 manifest resource references; 0 errors.
- Recovered the icon-only net patch from closed, unmerged PR #3 onto current master. No Q3 product history imported; frozen Q3 remains unchanged.

## Fresh validation

- VS MSBuild Restore,Build, Release: **FAIL**. Scratch APPDATA/USERPROFILE; current sibling SAM-BIM dependencies, OCCT native build skipped.
- Regression suites: No completed regression test result recorded yet; no pass claimed.
- Re-parsed compiled component declarations: 2/2 manifest rows; 0 coverage/canonical 24x24 RGBA PNG errors.

## Blockers — do not merge

Fresh icon branch and unchanged `origin/master` both fail CS1705: legacy RhinoCommon 6.32 references conflict with current SAM RhinoCommon 8.21 assemblies. Exact cached legacy package restored for both runs. Dependent GH output cannot be verified; this requires a separate framework/dependency migration decision. Both parameter GUIDs also collide with SAM core; they are deliberately unchanged. No successful build or hosted Rhino test is claimed.

Next step: retain a draft PR; resolve the legacy dependency baseline separately, then rebuild and verify the two embedded icon resources before considering merge.
