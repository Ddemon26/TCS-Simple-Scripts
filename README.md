# 🎨 Tent City Studio Simple Scripts

![Unity](https://img.shields.io/badge/Unity-2022.3+-black.svg?style=for-the-badge&logo=unity)
![Contributions welcome](https://img.shields.io/badge/Contributions-Welcome-brightgreen.svg?style=for-the-badge)
[![Odin Inspector](https://img.shields.io/badge/Odin_Inspector-Required-blue?style=for-the-badge)](https://odininspector.com/)

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
![Static Badge](https://img.shields.io/badge/Noobs-0-blue)

✨ **TCS Simple Scripts** is a Unity tool designed to provide a collection of simple yet useful scripts for common tasks in Unity projects. It includes utilities for managing GameObjects, handling input, and more.

![Demo GIF](https://media.giphy.com/media/l4Ep6KDbnTvdhGMP6/giphy.gif)

## 📜 Table of Contents
- [Features](#features)
- [Getting Started](#getting-started)
- [Installation](#installation)
- [Usage](#usage)
- [Customization](#customization)
- [Contributing](#contributing)
- [License](#license)

## ✨ Features

- **DontDestroy**: Ensures that a GameObject is not destroyed when loading a new scene.
- **DestroyOnAwake**: Destroys a GameObject after a specified delay when the script instance is loaded.
- **SimpleRotateObject**: Rotates a GameObject around a specified axis at a specified speed.
- **SimpleRigidBodyPush**: Allows a GameObject with a CharacterController to push Rigidbodies.
- **SimpleCameraController**: A simple camera controller for moving and rotating the camera using keyboard and mouse input.

## 🚀 Getting Started

Follow these steps to start using the **TCS Simple Scripts**:

1. **Install Dependencies**: Ensure that [Odin Inspector](https://odininspector.com/) is installed, as it is required for custom editor features.

2. **Open the Simple Scripts**: In Unity, navigate to `Tools > Simple Scripts` to open the tool's editor window.

3. **Initialize Systems**: Set up the simple scripts in your game scene.

4. **Use Simple Script Features**: Utilize the provided scripts to manage GameObjects, handle input, and more.

## 🔧 Installation

1. Clone or download this repository.
2. Add the folder to the `Assets` directory in your Unity project.
3. Install [Odin Inspector](https://odininspector.com/).
4. Open the Unity Editor and access the Simple Scripts through the `Tools` menu.

## 🛠️ Usage

1. **DontDestroy**: Attach the `DontDestroy` script to a GameObject to ensure it is not destroyed when loading a new scene.
2. **DestroyOnAwake**: Attach the `DestroyOnAwake` script to a GameObject to destroy it after a specified delay.
3. **SimpleRotateObject**: Attach the `SimpleRotateObject` script to a GameObject to rotate it around a specified axis at a specified speed.
4. **SimpleRigidBodyPush**: Attach the `SimpleRigidBodyPush` script to a GameObject with a CharacterController to allow it to push Rigidbodies.
5. **SimpleCameraController**: Attach the `SimpleCameraController` script to a camera to enable simple movement and rotation using keyboard and mouse input.

## ⚙️ Customization

- **DontDestroy**: No customization options.
- **DestroyOnAwake**: Customize the delay before destruction by modifying the `m_delay` field.
- **SimpleRotateObject**: Customize the rotation axis, speed, and direction by modifying the `m_rotationAxis`, `m_rotationSpeed`, and `m_reverse` fields.
- **SimpleRigidBodyPush**: Customize the push layers and strength by modifying the `m_pushLayers` and `m_strength` fields.
- **SimpleCameraController**: Customize the movement keys, boost factor, position lerp time, mouse sensitivity curve, rotation lerp time, cursor lock state, and Y-axis inversion by modifying the respective fields.

## 🤝 Contributing

Contributions are welcome! To contribute:

1. Fork the repository.
2. Create a new feature branch (`git checkout -b feature/NewFeature`).
3. Make your changes and commit (`git commit -m 'Add new feature'`).
4. Push to the branch (`git push origin feature/NewFeature`).
5. Open a pull request.

## 📄 License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.