![Unity](https://img.shields.io/badge/Unity-2022.3+-black.svg?style=for-the-badge&logo=unity)
![Contributions welcome](https://img.shields.io/badge/Contributions-Welcome-brightgreen.svg?style=for-the-badge)

# 🎨 TCS Simple Scripts

✨ **TCS Simple Scripts** is a Unity tool designed to provide simple, effective scripts for common tasks in Unity projects. These utilities help manage GameObjects, handle input, and more.

## 📜 Table of Contents

- [Features](#-features)
- [Getting Started](#-getting-started)
- [Installation](#-installation)
- [Usage](#-usage)
- [Contributing](#-contributing)
- [License](#-license)

***

![Simple](https://github.com/user-attachments/assets/b6fb6170-2fda-4d24-b405-59dd8a8a1d30)

***

![GitHub Forks](https://img.shields.io/github/forks/Ddemon26/TCS-Simple-Scripts)
![GitHub Contributors](https://img.shields.io/github/contributors/Ddemon26/TCS-Simple-Scripts)
![GitHub Stars](https://img.shields.io/github/stars/Ddemon26/TCS-Simple-Scripts)
![GitHub Repo Size](https://img.shields.io/github/repo-size/Ddemon26/TCS-Simple-Scripts)

[![Join our Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/knwtcq3N2a)
![Discord](https://img.shields.io/discord/1047781241010794506)

![GitHub Issues](https://img.shields.io/github/issues/Ddemon26/TCS-Simple-Scripts)
![GitHub Pull Requests](https://img.shields.io/github/issues-pr/Ddemon26/TCS-Simple-Scripts)
![GitHub Last Commit](https://img.shields.io/github/last-commit/Ddemon26/TCS-Simple-Scripts)
![GitHub License](https://img.shields.io/github/license/Ddemon26/TCS-Simple-Scripts)

## ✨ Features

A set of reusable scripts designed to simplify GameObject management, input handling, and scene control in Unity. These scripts are lightweight and versatile, helping to boost productivity.

## Classes Overview

This repository contains the following C# classes:

### Core Components

- **`PrefabSpawner`**  
  Handles spawning prefabs dynamically during runtime.
- **`DestroyOnAwake`**  
  Destroys the GameObject immediately upon initialization.
- **`DontDestroyObject`**  
  Prevents the object from being destroyed during scene transitions.
- **`DontDestroyOnLoad`**  
  Similar to `DontDestroyObject`, but retains across loads.
- **`EnableOrDisableColliderOnAwake`**  
  Toggles a collider component on or off when the scene starts.
- **`SelfDisable`**  
  Disables the object after a specified action or event.
- **`TimedSelfDestruct`**  
  Destroys the GameObject after a set duration.
- **`UnsetParentOnAwake`**  
  Detaches the object from its parent on scene load.

### Camera and Controls

- **`CameraState`**  
  Manages the state of the camera within the scene.
- **`MoveAxis`**  
  Handles movement logic based on axis inputs.
- **`SimpleCameraController`**  
  Implements basic camera movement controls.

### Object Manipulation

- **`AssignAimConstraint`**  
  Assigns an aim constraint to the object.
- **`GameObjectFollowMouse`**  
  Allows a GameObject to follow the mouse pointer on screen.
- **`PositionLerper`**  
  Smoothly interpolates an object's position.
- **`RotationLerper`**  
  Interpolates the rotation of an object.
- **`SimpleRigidBodyPush`**  
  Applies force to a rigidbody for basic physics-based interactions.
- **`SimpleRotateObject`**  
  Rotates an object based on input or predefined logic.
- **`SimpleTranslateObject`**  
  Translates an object over time.
- **`TransformContraint`**  
  Enforces constraints on an object’s transform.

## 🚀 Getting Started

To get started with **TCS Simple Scripts**, follow these steps:

1. **Download the Repository**  
   Download the ZIP file or copy the repository to your machine.

2. **Add Scripts to Your Unity Project**  
   Copy the `TCS Simple Scripts` folder into your Unity project's `Assets` folder.

3. **Open the Unity Editor**  
   Open Unity, and the scripts will be ready to use.

4. **Access the Scripts**  
   Drag and drop them onto GameObjects or attach them via code.

5. **Explore the Demo Scene**  
   Open the demo scene to see the scripts in action.

## 🔧 Installation

**Install using Git Url**
```
https://github.com/Ddemon26/TCS-Simple-Scripts.git
```

**Downloading Zip Files**
1. Download this repository.
2. Add the `TCS Simple Scripts` folder to the `Assets` directory in your Unity project.
3. Access the Simple Scripts through the Unity Editor under the `Tools` menu.

**Clone The Repository**
1. Open your terminal or command prompt.
2. Navigate to your Unity project folder.
3. Clone the repository into your Unity project's `Assets` folder.
4. After cloning, open Unity, and the scripts will be available under the `Tools` menu for use in your project.

## 🛠 Usage

Attach the scripts to GameObjects in your scene. Explore the examples in the repository to see how to customize them.

## 🤝 Contributing

Contributions are welcome! Here's how:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/NewFeature`).
3. Commit your changes (`git commit -m 'Add new feature'`).
4. Push the branch (`git push origin feature/NewFeature`).
5. Open a pull request.

## 📄 License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
