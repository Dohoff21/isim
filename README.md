# REALITi Coding Challenge: Mobile Scenario Controller Prototype

## Overview

REALITi by iSimulate is a leading-edge medical simulation ecosystem that allows educators to run realistic training scenarios using patient monitors, ventilators, and other vital simulation tools. This project is a mobile-first prototype for facilitators to control training scenarios more easily while walking around during sessions.

## Features

- **Scenario Overview**: View scenario information including name, description, and patient details
- **Event Timeline**: Navigate through scenario events with clear visual indicators
- **Current Event Tracking**: Clearly identify which event is currently active
- **Mobile-Optimized**: Touch-friendly interface designed for educators standing and walking
- **Next Event Navigation**: Prominent action to progress through scenario steps
- **Event Skipping**: Navigate forward/backward between events or jump to specific ones

## Framework Selection: Blazor WebAssembly

I evaluated the suggested frameworks against REALITi's requirements and chose Blazor WASM:

### 1. Medical Data Integrity
- Strong typing prevents critical errors (can't assign "high" to HeartRate)
- Compile-time validation of vital signs ranges
- No runtime type coercion surprises

### 2. Infrastructure Independence  
Modern JS frameworks increasingly couple with specific vendors:
- Next.js middleware runs differently on Vercel vs other hosts
- Framework features tied to proprietary edge functions
- Deployment requires vendor-specific configurations

Blazor WASM deploys as static files anywhere - crucial for medical devices 
that may run on-premise, air-gapped, or in various cloud environments.

### 3. Long-term Stability
- Medical software has 10+ year lifecycles
- Can't afford framework migrations every 2-3 years
- Microsoft's enterprise commitment vs JS ecosystem churn

### 4. Team Accessibility
- Standard HTML with C# expressions
- No proprietary templating DSLs (v-for, {#each}, <For>)
- Any developer can read and review the code

### 5. Strategic Alignment
- Direct path to MAUI for native mobile apps
- Unified C# codebase across web/mobile/desktop
- Aligns with cross-platform goals

## Technical Requirements

- **Framework**: Blazor WebAssembly (.NET 9)
- **Data Source**: Mock data from scenario.json file
- **Deployment**: Static files (no backend required)
- **Mobile-First**: Responsive design with touch optimization

## Key Dependencies

- **MudBlazor** (6.11.0): Material Design component library providing rich UI components
- **Blazored.LocalStorage** (4.4.0): Browser local storage integration for data persistence
- **Blazored.SessionStorage** (2.4.0): Browser session storage integration
- **Bootstrap**: CSS framework for responsive design and layout

## Setup Instructions

### Prerequisites
- .NET 9 SDK or later ([Download here](https://dotnet.microsoft.com/download/dotnet/9.0))
- Any modern web browser (Chrome, Firefox, Safari, Edge)

### Quick Start

1. **Clone the repository**
   ```bash
   git clone https://github.com/Dohoff21/isim.git
   cd isim
   ```

2. **Navigate to the project directory**
   ```bash
   cd REALITi
   ```

3. **Restore dependencies**
   ```bash
   dotnet restore
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

5. **Open your browser**
   - Navigate to the displayed URL (typically `https://localhost:7000`)
   - Or use the HTTP URL (typically `http://localhost:5106`)

### Alternative: Using Visual Studio or JetBrains Rider

1. Open the `REALITi.sln` solution file
2. Set `REALITi` as the startup project
3. Press F5 or click the "Run" button

### Building for Production

```bash
dotnet publish -c Release -o publish
```

The compiled WebAssembly files will be in the `publish/wwwroot` directory and can be deployed to any static web hosting service.

### Troubleshooting

- **Build errors**: Ensure you have .NET 9 SDK installed
- **Port conflicts**: The app will automatically find available ports
- **Browser compatibility**: Requires WebAssembly support (available in all modern browsers)
- **Performance**: First load may be slow due to WebAssembly initialization

## Project Structure

```
REALITi/
├── Features/
│   └── ScenarioControl/
│       ├── Components/          # Reusable UI components
│       └── Pages/              # Main application pages
├── Models/
│   ├── Dtos/                   # Data transfer objects
│   └── ViewModels/             # Application state models
├── Layout/                     # Application layout components
└── wwwroot/
    ├── data/                   # Mock scenario data
    └── css/                    # Styling
```

## Design Decisions

### Component Architecture
- **Card-based UI**: Each major section (scenario info, current event, navigation) is a separate component
- **Responsive Design**: Mobile-first approach with touch-friendly controls
- **State Management**: Centralized scenario state with event-driven updates

### User Experience
- **Clear Visual Hierarchy**: Important information is prominently displayed
- **Large Touch Targets**: Buttons and interactive elements sized for mobile use
- **Minimal Cognitive Load**: Simple, distraction-free interface for educators

### Data Modeling
- **Strongly Typed**: All scenario data uses C# models with proper validation
- **Immutable State**: Event progression creates new state rather than mutating existing
- **Error Handling**: Graceful fallbacks for missing or invalid data

### Mobile-First Design
- **Touch Controls Positioning**: Placed navigation controls on the side of the screen to minimize hand movement for educators walking around during scenarios
- **Component Structure**: Modular component architecture for maintainability and reusability
- **Mobile UX Patterns**: Optimized touch targets and gestures for one-handed operation

## AI Tool Usage

AI tools were leveraged throughout development:

- **Claude Code**: Primary development assistant for component architecture, C# code generation, and Blazor-specific patterns
- **v0**: Quick UI mockup generation to visualize mobile-first layout concepts

These tools significantly accelerated development while maintaining code quality and consistency.

## References

- [REALITi Control Screen Overview](https://knowledge.isimulate.com/hc/en-us/articles/360048675513-Overview-of-the-REALITi-Control-Screen)
- [REALITi Events Video Walkthrough](https://www.youtube.com/watch?v=uTrK4YmEq34)
- [Sample Scenario Data](https://labs.entegy.com.au/unionlane/exampleScenario.json)