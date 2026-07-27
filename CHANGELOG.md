# Changelog

All notable changes to this project will be documented in this file.


## [1.0.1] - 2026-07-27

### Added
- Introduced `HasAvailableActions` as an indicator for role-based work-items in tickets. The `AvailableAction` list is excluded from the `ListHandler` to optimise bandwidth for very large ticket or action lists. However, to support inline buttons in lists, a `Dictionary` can be used instead of a `HashSet` for performance.
- Added known limitations section to `README.md`.

### Changed
- Improved performance in `TicketListHandler` and `TicketSaveHandler` by reading `roleIds` from `UserRetrieveService`.

### Fixed
- Fixed a bug in the workflow by preventing the acceptance of a changed `StatusId`.

---

## [1.0.0] - 2026-07-26

### Added
- **Workflow Actions**: Ticket retrieve now includes a list of available actions (`AvailableActions`) based on the current status, user roles, and workflow rules. These are rendered as dynamic buttons in the ticket dialog, replacing the old dropdown.
- **RoleIds in UserDefinition**: Added `RoleIds` property to `UserDefinition` to cache user role IDs, eliminating extra database queries when filtering workflow rules.

### Changed
- **Log Events Grid**: The log entries grid in the ticket dialog is now read-only.
- **Default Values**: New tickets now default to `StatusId = 1` (Creating) and `LastActionId = 1` (Start).
- **Toolbar**: Default Save and Delete buttons are hidden; workflow actions are triggered via the hidden `saveAndCloseButton` and `deleteButton` to maintain proper state handling.

### Fixed
- Prevent `AvailableActions` from being sent in save requests (now removed via `getSaveEntity` override).

### Performance
- Optimized workflow rule lookups by using cached `RoleIds` in `UserDefinition`.