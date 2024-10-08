![Unity](https://img.shields.io/badge/Unity-2022.3+-black.svg?style=for-the-badge&logo=unity)
![Contributions welcome](https://img.shields.io/badge/Contributions-Welcome-brightgreen.svg?style=for-the-badge)
![GitHub Forks](https://img.shields.io/github/forks/Ddemon26/TCS-Simple-Scripts)
![GitHub Stars](https://img.shields.io/github/stars/Ddemon26/TCS-Simple-Scripts)
![GitHub Issues](https://img.shields.io/github/issues/Ddemon26/TCS-Simple-Scripts)
![GitHub Pull Requests](https://img.shields.io/github/issues-pr/Ddemon26/TCS-Simple-Scripts)
![GitHub Last Commit](https://img.shields.io/github/last-commit/Ddemon26/TCS-Simple-Scripts)
![GitHub License](https://img.shields.io/github/license/Ddemon26/TCS-Simple-Scripts)

# 🎨 TCS Simple Scripts

**TCS Simple Scripts** is a sophisticated toolkit for Unity that offers a comprehensive collection of reusable, lightweight scripts aimed at streamlining a multitude of common tasks within Unity projects. These scripts are meticulously designed to facilitate efficient GameObject management, input handling, prefab spawning, and camera manipulation, enabling developers to concentrate their efforts on higher-level game design and logic. This repository aims to enhance productivity, simplify repetitive operations, and provide standardized methods to tackle common scenarios in Unity development. By leveraging these scripts, developers can ensure consistency across projects, expedite development workflows, and maintain a focus on creative aspects of game development rather than reinventing solutions for common issues.

The tools included in **TCS Simple Scripts** are particularly valuable for both beginner and advanced developers, providing a scaffold for learning fundamental Unity operations while also offering highly reusable modules that can be extended or modified to meet specific project needs. This flexibility ensures that developers can customize the tools without sacrificing productivity, making them an excellent fit for prototyping as well as more mature projects.

## 📜 Table of Contents
- [Features](#-features)
- [Getting Started](#-getting-started)
- [Installation](#-installation)
- [Usage](#-usage)
- [Classes Overview](#-classes-overview)
- [Contributing](#-contributing)
- [License](#-license)

## ✨ Features
- **Prefab Spawning**: Provides functionality to instantiate game objects dynamically during runtime with ease and precision. It supports configuration options to manage spawning rates, object pooling, and other advanced settings that allow a controlled spawning process, suitable for game scenarios such as wave-based enemy spawning or procedurally generated content.
- **Input Handling**: Simplifies the implementation of user input, expediting the prototyping process. It provides easy-to-use, customizable scripts for handling different input types such as keyboard, mouse, and game controllers, making it straightforward to integrate player movement, interactions, and camera control into a project.
- **Fly Camera**: Incorporates a versatile free-fly camera script suitable for both in-editor scene navigation and gameplay scenarios. This camera controller script is highly adaptable, offering smooth control settings, adjustable speeds, and intuitive user navigation, which makes it invaluable for both debugging and immersive gameplay environments.
- **Manipulators**: Includes components for rotating, translating, and transforming GameObjects, offering substantial flexibility in object manipulation. These components allow for the creation of compelling animations, object movement, and dynamic scene interaction, all configurable via scriptable properties that can be modified in real-time or through the editor.
- **Assembly Definition**: Enhances project performance by utilizing assembly definitions to optimize Unity's compilation process. By creating separate assemblies, the compilation time can be significantly reduced, making development workflows more efficient and improving iteration speeds for large-scale projects.

These scripts are inherently easy to integrate and necessitate minimal configuration, making them ideal for prototyping as well as production environments. The modular design and simplicity of configuration make it possible to use these components right out of the box or adapt them as required by more complex game logic.

## 🚀 Getting Started
To initiate the use of **TCS Simple Scripts** within your Unity project, adhere to the following steps:

1. **Clone the Repository**: Clone this repository onto your local machine by executing the command:
   ```
   git clone https://github.com/Ddemon26/TCS-Simple-Scripts.git
   ```

2. **Add Scripts to Your Project**: Transfer the `TCS Simple Scripts` folder to your Unity project's `Assets` directory.

3. **Open Unity**: Open your project in Unity, where the scripts will be automatically recognized and imported. Ensure that your Unity version is compatible with the provided scripts to prevent any issues with the integration process.

4. **Explore the Demo**: A demo scene is provided to illustrate the utility and implementation of the scripts. This demo serves as an instructional resource, allowing developers to experiment with various components and understand how to use them effectively.

## 🔧 Installation
### Install via Git URL
The repository can be directly added to your project using Unity's Package Manager:

1. Open Unity.
2. Navigate to **Window > Package Manager**.
3. Click on the **+** button and select **Add package from git URL**.
4. Insert the repository URL:
   ```
   https://github.com/Ddemon26/TCS-Simple-Scripts.git
   ```

### Manual Installation
1. **Download the Repository**: Download the ZIP file of this repository and extract its contents.
2. **Add to Assets**: Copy the `TCS Simple Scripts` folder into your Unity project's `Assets` directory.

After installing, make sure to open Unity and allow it to re-import all assets so that the scripts are properly linked to your project structure. Additionally, you may wish to configure the scripts through the Unity Inspector to customize behavior to fit your particular project requirements.

## 🛠 Usage
The scripts can be attached to GameObjects within your scene as needed. You have the option to drag and drop the scripts directly onto GameObjects, or to attach them programmatically via code.

### Example Use Cases
- **PrefabSpawner**: Utilize this script to dynamically spawn enemy units, collectibles, or other interactive objects during gameplay. This component is extremely flexible and supports pooling systems to reduce runtime instantiation overhead, which is particularly beneficial for maintaining high frame rates during scenes with multiple spawned objects.
- **FlyCamera**: Integrate this script into your scene to facilitate free navigation, either during development or as part of a player-controlled camera system. Developers can use the Fly Camera to traverse large scenes easily while testing interactions and object placement, thereby providing a more fluid experience during the design phase.
- **Manipulators**: Employ these scripts to rotate or translate GameObjects, enabling dynamic and interactive animations. The Manipulators offer options for smooth interpolation between transforms, making them excellent for crafting engaging visual effects or responsive environmental interactions in your game.

## 📂 Classes Overview
The repository features several essential C# scripts designed to address frequent Unity development requirements:

### Core Components
- **`PrefabSpawner.cs`**: Manages the dynamic instantiation of prefabs at runtime, crucial for the procedural generation of enemies, items, or other game elements. The script offers configurable parameters for spawn locations, rate, and the ability to tie into other game events to control when objects are generated.
- **`FlyCamera`**: Implements a free-fly camera controller, which is highly effective for debugging purposes as well as creating player-controlled exploration mechanics. The script is equipped with smooth camera movement, adjustable sensitivity settings, and simple activation controls to make camera navigation intuitive.
- **`EventFunctions`**: Provides a suite of utility functions to facilitate event-driven operations within Unity, streamlining game logic execution. This script is especially useful for handling Unity events such as collisions, triggers, and custom user-defined actions, making it easy to create responsive game environments.
- **`Manipulators`**: Contains scripts for modifying the transform properties of GameObjects, including position, rotation, and scaling, allowing for versatile object interaction and animation. These manipulators can be used for anything from simple object rotations to complex animations involving multiple transformations triggered by player inputs or timed events.

## 🤝 Contributing
Contributions to this repository are highly encouraged. If you wish to contribute, please adhere to the following process:

1. **Fork the Repository**: Click on the "Fork" button located at the top right of this page.
2. **Create a Branch**: Establish a new branch to accommodate your feature or bug fix:
   ```
   git checkout -b feature/amazing-feature
   ```
3. **Commit Your Changes**: Implement your changes and commit them with a descriptive message:
   ```
   git commit -m 'Add amazing feature'
   ```
4. **Push to GitHub**: Push the changes to your repository:
   ```
   git push origin feature/amazing-feature
   ```
5. **Open a Pull Request**: Navigate to the original repository and submit a pull request.

We welcome all types of contributions, whether they involve bug fixes, feature enhancements, documentation improvements, or performance optimizations. Please ensure that any contributions are thoroughly tested and documented to maintain the quality and usability of the scripts.

## 📄 License
This project is licensed under the MIT License. For more information, please refer to the [LICENSE](LICENSE) file. The MIT License grants permission to use, distribute, and modify this software for both commercial and private purposes, provided that appropriate credit is given to the original authors.

## 📞 Support
Should you have any questions or encounter issues, please feel free to open an issue in this repository or join our Discord community:

[![Join our Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/knwtcq3N2a)

The Discord community is an excellent resource for support, discussion, and collaboration. Whether you are experiencing issues or seeking advice on extending the functionalities provided by the toolkit, community members and developers are available to assist.

---

Thank you for utilizing **TCS Simple Scripts**. If you find this project beneficial, consider giving it a ⭐ on GitHub as a token of your appreciation. Your support is instrumental in encouraging continued development and improvement of these tools. Feel free to share this repository with others who might benefit from these scripts, and stay tuned for future updates that will add even more capabilities to this growing library.
