# TextRpgLib Build Plan

---

# Table of Contents

<!-- TOC -->
* [TextRpgLib Build Plan](#textrpglib-build-plan)
* [Table of Contents](#table-of-contents)
* [🔧 Core Modules](#-core-modules)
  * [1. Game Engine Core](#1-game-engine-core)
  * [2. YAML Integration](#2-yaml-integration)
* [🧙 Content Modules](#-content-modules)
  * [1. Story / Scene Module](#1-story--scene-module)
  * [2. Character Module](#2-character-module)
  * [3. Item Module](#3-item-module)
  * [4. Enemy/Combat Module](#4-enemycombat-module)
* [💾 Persistence Modules](#-persistence-modules)
  * [1. Save/Load System](#1-saveload-system)
  * [2. Game State Flags](#2-game-state-flags)
* [🧠 Dialogue & Events Modules](#-dialogue--events-modules)
  * [1. Dialogue System](#1-dialogue-system)
  * [2. Event System](#2-event-system)
* [🧩 Addons](#-addons)
  * [1. Scripting/Logic Hooks](#1-scriptinglogic-hooks)
  * [2. Localization Support](#2-localization-support)
  * [3. Debug/Editor Tools](#3-debugeditor-tools)
<!-- TOC -->

# 🔧 Core Modules

---

## 1. Game Engine Core

- Game loop
- Command parser (e.g. go north, take sword)
- Event dispatcher / game state manager

## 2. YAML Integration

- YAML loader/validator (e.g. YamlDotNet)
- Schema definitions for different content types 
- Hot-reloading (optional but cool for testing story changes)

# 🧙 Content Modules

---

## 1. Story / Scene Module

- Scenes/Rooms with descriptions, exits, and triggers
- Non-linear navigation (map or node-based)
- Story branching logic
- Scripting support (optional) for dynamic conditions

## 2. Character Module

- Player character with inventory, stats, traits
- NPCs with dialogues, behaviors, and states

## 3. Item Module

- Items with types (usable, equippable, key item, etc.)
- Effects (heal, buff, unlock something)
- Inventory system

## 4. Enemy/Combat Module

- Enemy definitions: stats, loot, AI
- Simple turn-based combat system
- Optional: expandable to support puzzles or mini-games

# 💾 Persistence Modules

---

## 1. Save/Load System

- YAML or JSON save file structure
- State serialization (player, inventory, flags, current scene, etc.)

## 2. Game State Flags

- Global/local flags to drive story conditions
- Used for branching logic and remembering choices

# 🧠 Dialogue & Events Modules

---

## 1. Dialogue System

- Multi-choice dialogue tree
- Conditional dialogue based on flags or inventory
- Branching consequences

## 2. Event System

- Triggers: on enter, on command, on item use, etc.
- Effects: set flag, give item, start battle, etc.

# 🧩 Addons

---

## 1. Scripting/Logic Hooks

- Lightweight scripting or logic evaluator
- Evaluate conditions in YAML like: if: { flag: door_open }

## 2. Localization Support

- Text in multiple languages via YAML
- Easy for internationalizing the game

## 3. Debug/Editor Tools

- Maybe a simple GUI editor or validator for YAML files
- Console commands for testing