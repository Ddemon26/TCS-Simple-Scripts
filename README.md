# TCS Simple Scripts

[![Join our Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/knwtcq3N2a)
![Discord](https://img.shields.io/discord/1047781241010794506)

![GitHub Forks](https://img.shields.io/github/forks/Ddemon26/TCS-Simple-Scripts)
![GitHub Contributors](https://img.shields.io/github/contributors/Ddemon26/TCS-Simple-Scripts)
![GitHub Stars](https://img.shields.io/github/stars/Ddemon26/TCS-Simple-Scripts)
![GitHub Repo Size](https://img.shields.io/github/repo-size/Ddemon26/TCS-Simple-Scripts)

## Overview

**TCS Simple Scripts** is a collection of lightweight and useful tools designed for Unity developers. These scripts focus on simplifying common tasks such as prefab management, camera manipulation, event handling, and more.

### Key Features:
- **PrefabSpawner**: Easily instantiate prefabs with configurable local/global position and rotation.
- **FlyCamera**: Implement free camera movement for development purposes.
- **Manipulators**: Add interactive manipulations to objects within the scene.
- **Event Functions**: Handle custom events and actions in the scene efficiently.

## Available Classes

### 1. PrefabSpawner
This class allows for customizable prefab spawning. It provides the following functionalities:
- **Custom Positioning and Rotation**: You can choose between using the local position/rotation of the GameObject or specifying custom values.
- **Prefab Instantiation**: The class instantiates prefabs dynamically, offering flexibility for runtime object creation.

### 2. Event Functions Classes

- **DestroyOnAwake**: Handles object destruction on awake.
- **DontDestroyObject**: Ensures that certain objects are not destroyed when new scenes are loaded.
- **DontDestroyOnLoad**: Prevents objects from being destroyed during scene transitions.
- **EnableOrDisableColliderOnAwake**: Manages enabling or disabling colliders on GameObjects at awake.
- **SelfDisable**: Disables a GameObject after a certain condition is met.
- **TimedSelfDestruct**: Destroys GameObjects after a set amount of time.
- **UnsetParentOnAwake**: Removes the parent of a GameObject when the scene starts.

### 3. Manipulators Classes

- **AssignAimConstraint**: Adds constraints for objects aiming at other targets.
- **GameObjectFollowMouse**: Makes GameObjects follow the mouse pointer during runtime.
- **PositionLerper**: Smoothly interpolates (lerps) the position of objects.
- **RandomMovement**: Adds random movement behaviors to objects in the scene.
- **RotationLerper**: Smoothly interpolates the rotation of objects.
- **SimpleRigidBodyPush**: Applies a simple push force to rigidbody objects.
- **SimpleRotateObject**: Rotates objects along specified axes.
- **SimpleTranslateObject**: Moves objects along specified directions.
- **TransformConstraint**: Adds constraints to limit the transformation of objects.

## Getting Started

### Prerequisites
- **Unity Engine**: The scripts are built for use with Unity (version 2020 and later).
- **Basic Understanding of Unity Components**: A basic knowledge of Unity's GameObjects, prefabs, and components is required.

### Installation

1. Clone the repository:
    ```bash
    git clone https://github.com/Ddemon26/TCS-Simple-Scripts.git
    ```

2. Import the scripts into your Unity project:
    - Copy the contents from the `Runtime` folder into your Unity project’s `Assets` directory.

## Contributing

Contributions are welcome! If you'd like to contribute, please fork the repository and use a feature branch. Pull requests are warmly welcomed.

1. Fork the project
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

Distributed under the MIT License. See `LICENSE` for more information.

## Contact

Feel free to reach out via [Discord](https://discord.gg/knwtcq3N2a) if you have any questions or need support!
