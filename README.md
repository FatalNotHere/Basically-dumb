# Endless Runner Mechanics (WIP) 🏃‍♂️

## About the Project
This repository contains the core 3D game mechanics for an endless runner prototype built in Unity. It serves as my active learning workspace where I am writing, testing, and integrating C# scripts to understand fundamental game logic, player input, and dynamic environment generation. 

*Note: This is an active development repository for learning engine mechanics, not a completed game build.*

## Core Mechanics & Scripts
* **Player Controller (`PlayerController.cs`):** Handles continuous forward movement and lateral input using Unity's coordinate system, alongside collision detection for "Game Over" states.
* **Procedural Environment (`FollowPlayer.cs`):** Logic to dynamically reposition ground elements ahead of the player to create an infinite loop.
* **Dynamic Spawning (`ObstacleSpawner.cs`):** Utilizes `Instantiate` and `Time.deltaTime` to continuously generate random obstacles in the player's path at set intervals.

## About the Developer
I'm Sarthak, an engineering undergraduate heavily focused on software development and interactive tech. I am currently expanding my programming foundation (Python, C, C++) by diving hands-on into C# and the Unity 3D engine to build practical, real-world applications and game mechanics.
