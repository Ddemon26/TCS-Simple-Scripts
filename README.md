
# 🎨 TCS Simple Scripts

![Unity](https://img.shields.io/badge/Unity-2022.3+-black.svg?style=for-the-badge&logo=unity)
![Contributions welcome](https://img.shields.io/badge/Contributions-Welcome-brightgreen.svg?style=for-the-badge)

***

![Banner Image](https://via.placeholder.com/1000x300.png?text=assets+TCS+Simple+Scripts+for+Unity)

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

✨ **TCS Simple Scripts** is a Unity tool designed to provide a collection of simple yet effective scripts for common tasks in Unity projects. These utilities help manage GameObjects, handle input, and more.

![Demo GIF](https://media.giphy.com/media/l4Ep6KDbnTvdhGMP6/giphy.gif)

## 📜 Table of Contents

- [Features](#-features)
- [Getting Started](#-getting-started)
- [Installation](#-installation)
- [Usage](#-usage)
- [Customization](#-customization)
- [Contributing](#-contributing)
- [License](#-license)

## ✨ Features

A set of reusable scripts designed to simplify GameObject management, input handling, and scene control in Unity. These scripts are designed to be lightweight and versatile, helping to boost productivity during game development.

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
  Similar to `DontDestroyObject`, but specifically retains across loads.
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
  Assigns an aim constraint to the object, directing its aim.
- **`GameObjectFollowMouse`**  
  Allows a GameObject to follow the mouse pointer on screen.
- **`PositionLerper`**  
  Smoothly interpolates an object's position.
- **`RotationLerper`**  
  Interpolates the rotation of an object over time.
- **`SimpleRigidBodyPush`**  
  Applies a force to a rigidbody for basic physics-based interactions.
- **`SimpleRotateObject`**  
  Rotates an object based on input or predefined logic.
- **`SimpleTranslateObject`**  
  Translates an object in space over time.
- **`TransformContraint`**  
  Enforces constraints on an object’s transform for position, rotation, or scale.

## 🚀 Getting Started

Follow these steps to start using **TCS Simple Scripts** in your Unity project:

1. **Open the Simple Scripts**: In Unity, navigate to `Tools > Simple Scripts` to access the tool's editor window.
2. **Initialize Systems**: Integrate the simple scripts into your scene setup.
3. **Leverage Simple Script Features**: Utilize the scripts to easily manage GameObjects, handle input, and enhance your project’s interactivity.

## 🔧 Installation

1. Clone or download this repository.
2. Place the folder in the `Assets` directory of your Unity project.
3. Access the Simple Scripts through the Unity Editor under the `Tools` menu.

## 🛠 Usage

To use the scripts effectively, ensure that they are properly attached to GameObjects within your scene. Explore the examples in this repository to see how the various scripts can be customized and combined for unique functionality.

## 🤝 Contributing

Contributions are always welcome! Here's how to contribute:

1. Fork the repository.
2. Create a new feature branch (`git checkout -b feature/NewFeature`).
3. Make your changes and commit them (`git commit -m 'Add new feature'`).
4. Push the branch (`git push origin feature/NewFeature`).
5. Open a pull request, and we’ll review your changes.

## 📄 License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.
