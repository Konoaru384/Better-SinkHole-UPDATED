# 🕳️ Better Sinkholes Updated

**Enhance sinkhole behavior with pocket dimension teleportation**  
A plugin for SCP: Secret Laboratory powered by EXILED. (original by blackruby)

[![Downloads](https://img.shields.io/github/downloads/Konoaru384/Better-SinkHole-UPDATED/total?color=blue&label=Downloads)](https://github.com/Konoaru384/Better-SinkHole-UPDATED/releases)
[![License](https://img.shields.io/github/license/Konoaru384/Better-SinkHole-UPDATED?color=green)](./LICENSE)
[![Exiled Version](https://img.shields.io/badge/Exiled-9.6+-informational)](https://github.com/Exiled-Team/EXILED)
[![Discord](https://img.shields.io/discord/729906333294460998?label=Exiled%20Community&logo=discord&color=7289DA)](https://discord.gg/vxGeGFr5Bc)

---

## 📦 What it does

This plugin enhances gameplay by modifying how **Sinkholes** work in SCP:SL maps. When a player **stands at the center of a sinkhole**, they:

- 🌀 Get **teleported to the Pocket Dimension**
- 🦅 Set the **slow distance**
- 📢 See a **custom broadcast message**

All of this is **fully configurable** via `config.yml`.

> 💡 The plugin works **only with sinkholes** (not other environmental hazards) — staying near the edges slows you, but **standing at the center** (within a customizable radius) will trigger the full teleportation sequence.

---

## ⚙️ Configuration

```yaml
is_enabled: true
debug: false
teleport_distance: 0.6
slow_distance: 1.2
teleport_message_duration: 3
teleport_message: "You were consumed by the anomaly..."
