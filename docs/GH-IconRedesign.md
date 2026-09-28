# SAM Grasshopper icon redesign — SAM_Building PR record

Branch `feature/sam-gh-icon-redesign`, based on `sow/2026-Q3` @ `c31c4e0`. PR: (to be opened).
Propagates the SAM icon design system from SAM-BIM/SAM#166 (head `cf4d924a`, open, not merged) to this repository.

## Current status
All **2** Grasshopper objects in this repo (0 components + 2 params) use redesigned icons: **2 / 2**.
Built and validated; ready for review. **Not merged.**

## Work completed
- `design/grasshopper-icons/`: the shared SAM-BIM icon kit. `icons.py`, `render.py`, `sam_classify.py` and `ICON_DESIGN_SYSTEM.md` are vendored **verbatim** from SAM#166 (hash-checked). `icons_ext.py` and `ICON_DESIGN_SYSTEM_EXT.md` are the frozen SAM-BIM extension v1 (identical in every SAM-BIM repo). `tools/repo_rules.py` holds this repo's explicit decisions.
- **Inventory**: `tools/inventory.py` parses C# source (every non-abstract class declaring `ComponentGuid`).
- **Manifest** (source of truth): `manifest.json` / `manifest.csv` — per object: GUID, class, source, project, object glyph, operation, modifiers, icon id, resource, glyph/badge origin.
- **Generation**: 2 canonical SVGs → 24×24 PNGs; review sheet `review/contact_sheet.png` (native 24 px on GH normal / orange-warning / dark bodies + 3×) and `review/REVIEW.md`.
- **Integration**: each project's existing mechanism; only the icon token inside each `Icon` getter changes.

| Project | Objects | Icon resources | Mechanism |
|---|---|---|---|
| `SAM.Geometry.Grasshopper.Building` | 2 | 2 | resx / Bitmap |

## Design reuse
- **Reused SAM object families (2)**: `model`, `panel`
- **New SAM-BIM ext v1 families used (0)**: — (none)
- **Verbs**:  (all SAM)
- Distinct icons: **2** (2 on SAM glyphs, 0 on ext glyphs). Icon ids shared with SAM render pixel-identically to SAM's.

## Decisions and assumptions
- Grammar, palette, badge families and construction rules are unchanged (SAM#166). No text, no new colours.
- Qualifier variants (`…By<X>`) share an icon intentionally (see `review/REVIEW.md`).
- Interop direction: external → SAM = import ↓, SAM → external = export ↑.
- The two params reuse SAM `model` (BuildingModel) and `panel` (IPartition); no new glyphs.
- Legacy icon resources are kept (still referenced by context menus / AssemblyInfo); no GUID, name, nickname, category, subcategory, parameter or behaviour change.

## Files changed
- New: `design/grasshopper-icons/**`, `<project>/Resources/Icons/SAM_GH_*.png`, `docs/GH-IconRedesign.md`.
- Modified: 2 component/param `.cs` files (one icon token each), 1× `Resources.resx`, 1× `Resources.Designer.cs`. No csproj change.

## Validation
| Check | Result |
|---|---|
| `tools/classify.py` | 2 classified, 0 unclassified |
| `tools/build.py` identical-pixel collision check | 0 groups (2 distinct icons; 0 intentionally shared icon(s) for qualifier variants, listed in `review/REVIEW.md`) |
| Icon ids shared with SAM#166 vs SAM's `png/24` | 2 shared, 2 byte-identical |
| `tools/integrate.py` re-parse | 2/2 objects reference their `SAM_GH_*` resource; every PNG exists |
| `tools/check_source.py` vs `origin/sow/2026-Q3` | vendored files OK; icon-token swaps: 2, non-icon changes: 0; base 2, now 2 -> UNCHANGED |
| Build (`SAM_Building.sln`, dotnet and VS MSBuild) | **BLOCKED (pre-existing)**: `SAM.Geometry.Building.Rhino` (untouched; packages.config, RhinoCommon 6.32) fails with CS1705 against current SAM Rhino assemblies built on RhinoCommon 8.21, so the dependent GH project cannot be built here. Identical on `sow/2026-Q3`; not caused by this PR. |
| `tools/check_assemblies.py` | not run — no assembly could be built (see build row) |
| `tests/GhIconTest` (real Rhino 8 / Grasshopper, Rhino.Testing) | **not verifiable**: both param GUIDs are also declared by SAM core (`GooArchitecturalModel` etc. share `f11a6c34…`), so Grasshopper returns SAM's object; a pass would be meaningless and is not claimed |
| Repository test projects | none in this repository |
| Visual review (`review/contact_sheet.png`, 24 px on normal / warning / dark bodies) | both icons legible; identical to SAM's `model` / `panel` params |

## Unresolved issues / risks
- Build blocked by the pre-existing RhinoCommon 6 → 8 mismatch in `SAM.Geometry.Building.Rhino` (legacy net472 / packages.config). Icons are verified at source level only (re-parse + icon-token-only diff); the resx wiring is the same mechanism used and build-verified in the other 20 repositories.
- Pre-existing: param GUID `f11a6c34-3376-4a5d-8c6c-1d5331a7c96a` is also declared by SAM core (`SAM/Grasshopper/SAM.Analytical.Grasshopper/Classes/New/GooArchitecturalModel.cs`). If both plugins load, Grasshopper reports a GUID conflict. Not changed here (GUIDs must not change).
- Built against sibling repos as checked out locally (SAM on `feature/sam-gh-icon-redesign` = SAM#166); icon changes are API-neutral.

## Recommended next step
Review this PR (compare `review/contact_sheet.png`), then merge by the maintainer. After merge, add the `PROJECT_PROGRESS.md` closeout entry on `sow/2026-Q3` with the merge SHA. SAM#166 (the reference design system) remains open.
