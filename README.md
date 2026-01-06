# Turn-Based Combat Simulator

This project is a small C# console application that acts as a framework for a turn-based combat system.

The combat currently runs automatically when the application starts and is intended as a learning project rather than a finished game.

## Purpose

The main goal of this project is to improve my understanding of C# and object-oriented programming concepts by building a simple but structured game system from scratch.

This project focuses on:

- Object-oriented design
- Encapsulation and inheritance
- Modelling game systems in code
- Incremental development and refactoring

## Features

- Abstract `Character` base class with shared combat logic
- Concrete `Player` and `Enemy` implementations
- Items that interact with characters through public methods (eg. healing)
- Status effects system (`StatusEffect` base class, eg. `Poison`)
- Basic combat rules: damage, healing, turn order, and health checks
- Simple console-based combat flow for testing

## How It Works

1. Characters are initialized in Program.cs with stats such as health, attack,    defense, and speed.

2. Status effects can be added to characters before the battle starts.

3. BattleManager handles the combat loop:

    - Applies start-of-turn effects (like Poison)

    - Executes attacks for each character

    - Logs each action and current health to the console

4. The battle continues until one character is defeated.

## Project Structure

- `Entities/` – Character-related classes (`Character`, `Player`, `Enemy`)
- `Items/` – Item logic (e.g. healing items)
- `StatusEffects/` – Status effect base class and implementations (eg. `Poison`)
- `Combat/` – BattleManager and combat logic
- `Program.cs` – Entry point and basic combat simulation

## Running the Project

Ensure you have the .NET SDK installed, then run:

```bash
dotnet run
```

You will see console output for each turn, showing attacks, health changes and the battle outcome. 