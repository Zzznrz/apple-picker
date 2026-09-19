# 🍎 Apple Picker

*Apple Picker* is a Unity game in which players move a basket to catch falling apples, avoid poison apples, and build a high score as the challenge increases over time. The project demonstrates core Unity concepts, including gameplay programming, scene management, prefab instantiation, collision detection, UI implementation, persistent data storage, and progressive difficulty.

> **Game Preview**
> 
>https://github.com/user-attachments/assets/3fe6577f-1e46-4ca1-b288-ab74940d77ad
> 
---

# ✨ Features

### 🧺 Mouse-Controlled Basket
Move the basket horizontally by following the mouse position.

### 🍎 Apple Types & Collision Rules
Different apples affect gameplay in different ways:

| Apple Type | Collision Result |
|------------|------------------|
| 🍎 Normal Apple | Adds `100` points |
| ⭐ Golden Apple | Adds `200` points |
| ☠️ Poison Apple | Removes one basket |

Missing a normal or golden apple also removes one basket and clears the falling apples.

### 📈 Progressive Difficulty Scaling
The game becomes increasingly challenging over time by dynamically adjusting:

- Tree movement speed
- Apple spawn delay
- Tree direction-change probability

Difficulty advances at timed intervals across the configured levels, creating a gradual increase in challenge rather than relying on one fixed difficulty setting.

### 🏆 Persistent High Score
- High scores are saved using Unity's `PlayerPrefs`.
- The high score remains available after restarting the game.

### 🗺️ Complete Game Flow
The project includes a complete gameplay loop with:

- **Start Scene** — Launch the game or exit the application.
- **Game Scene** — Catch apples, manage baskets, and build a score.
- **Game Over Scene** — Review the final score and restart the game.

All three scenes are configured in Unity Build Settings.

### 🎨 Unity Rendering & UI
The project uses:

- Universal Render Pipeline (URP)
- 3D models and materials
- TextMeshPro UI
- Custom game objects and prefabs

---

# 🛠️ Tech Stack

- **Game Engine:** Unity 6
- **Language:** C#
- **Rendering:** Universal Render Pipeline (URP)
- **UI:** TextMeshPro
- **Data Persistence:** PlayerPrefs
- **Version Control:** Git & GitHub

---

# 🚀 How to Run

### Requirements

- Unity Hub
- Unity 6 (`6000.5.9f1`)
- Git

### Installation

```bash
git clone https://github.com/Zzznrz/Apple-Picker.git
cd Apple-Picker
```

Open the project folder in **Unity Hub** using Unity `6000.5.9f1`.

### Start the Game

1. Open `Assets/Scenes/StartScene.unity` in the Unity Editor.
2. Click the **Play** button.
3. Click **Start** to begin the game.
4. Move the mouse horizontally to control the basket.

The project does not require any additional environment variables or external services.

---

# 🔮 Future Improvements

Planned enhancements include:

- 🔊 Background music (BGM) and sound effects (SFX)
- ⌨️ Keyboard controls (A/D or Arrow Keys)
- ⏸️ Pause and Settings menu
- 🎁 Additional collectible items and power-ups
- 🎨 Improved UI backgrounds and animations

---

# 👤 Author

**Zhongyu Hu**

Created as a course assignment for learning Unity game development.

---

# 📄 License

This project is intended for educational purposes and does not currently include a formal open-source license. Add a `LICENSE` file before redistributing the project or using its code in another project.
