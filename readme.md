# DnD Character Management Backend

## Overview

The **DnD Character Management Backend** is a C#/.NET Core Web API that allows for the creation, management, and storage of Dungeons & Dragons (5e) characters. The application serves as a backend system that will eventually be integrated with a React-based frontend to provide a full D&D character management experience. The backend currently manages characters, their spells, inventories, skills, saving throws, and other attributes.

This project aims to serve as the foundation for a more extensive D&D toolset, including an auto-battler game mode for Dungeons & Dragons.

## Features

- Create, update, retrieve, and delete D&D characters.
- Manage character attributes, including spells, inventory, proficiencies, skills, saving throws, and class features.
- Relational database design using SQLite and Entity Framework Core.
- RESTful API endpoints for interacting with character data.

### Current Endpoints

| Endpoint               | Description                                                |
|------------------------|------------------------------------------------------------|
| `GET /api/Character`    | Retrieves all characters                                   |
| `GET /api/Character/{id}`| Retrieves a specific character by ID                      |
| `POST /api/Character`   | Adds a new character                                       |
| `PUT /api/Character/{id}`| Updates an existing character                             |
| `DELETE /api/Character/{id}`| Deletes a character by ID                              |

## Technologies Used

- **C#**: Primary language for backend development.
- **.NET Core**: Web API framework.
- **Entity Framework Core**: ORM for database access and migrations.
- **SQLite**: Lightweight relational database for development and testing.
- **Visual Studio Code**: IDE used for developing and running the project.
- **WSL (Windows Subsystem for Linux)**: For development on Windows 10.

## Setup

To run this project locally, follow these steps:

### Prerequisites

- [.NET SDK 6.0+](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQLite](https://www.sqlite.org/index.html) (optional if you want to inspect the database)
- Git

### Steps

1. **Clone the Repository:**

   ```bash
   git clone https://github.com/yourusername/dnd-c.git
   cd dnd-c/DnDCBackendb
   ```

2. **restore Dependencies:**

Run the following command to restore the necessary NuGet packages:

    ```bash
        dotnet restore
    ```

3. **Set Up the Database:**

Update the database and run migrations:

    ```bash
        dotnet ef database update
    ```

4. **Start the backend server by running:**

    ```bash
        dotnet run
    ```

The application will be available at https://localhost:5001.

Testing the API
You can use tools like Postman or cURL to interact with the API. For example:

Get all characters:

    ```bash
        curl https://localhost:5001/api/Character
    ```

Create a new character:

    ```bash
    curl -X POST https://localhost:5001/api/Character -H "Content-Type: application/json" -d '{
        "name": "Gandalf",
        "race": "Maia",
        "class": "Wizard",
        "level": 20,
        "strength": 18,
        "dexterity": 12,
        "constitution": 16,
        "intelligence": 20,
        "wisdom": 18,
        "charisma": 15
    }'
    ```

Future Plans & Roadmap
1. Phase 1: Integrate with React Frontend
The backend will be integrated with a React frontend that will allow users to create, manage, and view their D&D characters through a user-friendly interface. This frontend will consume the RESTful API provided by this backend and visually represent character data.

Planned Features:
Character Sheets: Display character stats, equipment, spells, and more.
Character Creation Tool: An intuitive interface for creating new characters, complete with validations based on D&D 5e rules.
Spell and Equipment Management: Allow players to manage spells, weapons, and other inventory items.
2. Phase 2: D&D Auto-Battler Game Mode
The long-term goal is to develop an auto-battler game mode where players can pit their D&D characters against enemies or other players in strategic, automated combat. This game will leverage the character management system and build upon the following ideas:

Planned Features:
Combat System: The auto-battler will simulate turn-based combat where characters automatically use their abilities, spells, and weapons to fight.
AI Dungeon Master: An AI system will control enemies and encounter events, ensuring balanced combat and dungeon crawling experiences.
Battle History: Track battle outcomes, including detailed logs of damage, spells used, and other actions taken during combat.
PvE and PvP Modes: Players can compete against AI-controlled monsters (PvE) or other players' characters (PvP) in the auto-battler system.
3. Phase 3: Full D&D Campaign Management
Beyond character and combat management, the goal is to transform this system into a full-fledged D&D campaign manager where Dungeon Masters can manage campaigns, track progress, and engage with players in real-time.

Planned Features:
Campaign Manager: A tool for Dungeon Masters to run and manage campaigns.
Real-Time Session Tracking: Players and DMs can track encounters, combat, and events in real time during D&D sessions.
Inventory and Spell Tracking: Simplify tracking for DMs and players by integrating real-time updates for inventory and spell usage.
Story Mode Integration: Incorporate a guided storytelling tool for DMs to run campaigns smoothly.
Contributing
Contributions are welcome! If you would like to contribute to this project, please follow these steps:

Fork the repository.
Create a new branch (git checkout -b feature/my-feature).
Make your changes.
Commit your changes (git commit -m "Add my new feature").
Push to the branch (git push origin feature/my-feature).
Create a new Pull Request.
License
This project is licensed under the MIT License - see the LICENSE file for details.

Contact
If you have any questions or suggestions, feel free to open an issue or reach out to me:

Email: erikaburdet@gmail.com
GitHub: ErikBurdett

Will fix formatting on the readme soon :) 