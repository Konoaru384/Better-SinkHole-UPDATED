# 🕳️ Better Sinkholes Updated (Another update for Better Sinkholes)

**Enhance sinkhole behavior with pocket dimension teleportation and custom effects**  
A plugin for SCP: Secret Laboratory powered by EXILED. *(original by blackruby)*

<p align="center">
  <img src="https://img.shields.io/github/downloads/Konoaru384/Better-SinkHole-UPDATED/total?style=for-the-badge" />
  <img src="https://img.shields.io/badge/EXILED-9.6.0-blueviolet?style=for-the-badge" />
  <img src="https://img.shields.io/badge/RP%20Friendly-%E2%9C%94-lightgreen?style=for-the-badge" />
  <a href="https://discord.gg/vxGeGFr5Bc">
    <img src="https://img.shields.io/badge/Discord-Join%20Us-7289DA?style=for-the-badge&logo=discord" />
  </a>
</p>

---

## 📦 What it does

This plugin enhances gameplay by modifying how **Sinkholes** work in SCP:SL maps. When a player **stands at the center of a sinkhole**, they:

- 🌀 Get **teleported to the Pocket Dimension** (`0, 300, 0`)
- 🎭 Receive optional **Corroding effects**
- 📢 See a **custom broadcast message**

All of this is **fully configurable** via `config.yml`.

> 💡 The plugin works **only with sinkholes** (not other environmental hazards). Standing near the edges slows you, but **standing at the center** (within a customizable radius) triggers teleportation.

---

## ⚙️ Configuration

```yaml
is_enabled: true
debug: false
teleport_distance: 0.6
slow_distance: 1.2
teleport_message_duration: 3
teleport_message: "You were consumed by the anomaly..."
