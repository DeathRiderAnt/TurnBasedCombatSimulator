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
- Items that interact with characters through public methods
- Basic damage and healing rules
- Simple console-based combat flow for testing

## Project Structure

- `Entities/` – Character-related classes (`Character`, `Player`, `Enemy`)
- `Items/` – Item logic (e.g. healing items)
- `Program.cs` – Entry point and basic combat simulation

## Running the Project

Ensure you have the .NET SDK installed, then run:

```bash
dotnet run
```
