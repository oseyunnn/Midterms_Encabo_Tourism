# QAZAQ

QAZAQ is a Kazakhstan-focused tourism website designed as a premium editorial travel experience. The project presents destinations, cultural heritage, traveler stories, and a booking flow for exploring the country’s steppe, alpine landscapes, and Silk Road history.

## Overview

The website is built around a refined, travel-brand aesthetic inspired by luxury editorial layouts. It highlights:

- destination discovery and feature cards
- cultural storytelling about Kazakhstan’s heritage and nomadic traditions
- traveler reviews and social proof
- a booking experience for trip planning and reservations
- a consistent, warm, premium visual identity shaped by gold, charcoal, and ivory tones

## Tech Stack

- Blazor Web App on .NET 8
- Razor Components for UI composition
- Interactive Server rendering for client-side interactivity
- Tailwind CSS v4 for design system styling and layout utilities
- ASP.NET Core static assets and routing

## How the project uses Blazor

This application uses Blazor components to break the interface into reusable, page-oriented sections. The app is structured around Razor pages in the Components folder, where each page handles a specific part of the travel experience.

Key patterns used:

- component-driven layout via Razor files
- reusable navigation and layout shells
- binding and event handling for interactive booking and review flows
- server-side interactivity with InteractiveServer rendering

This makes the project easy to expand with additional travel pages, filters, or booking logic while keeping the UI layered and maintainable.

## How the project uses Tailwind

Tailwind CSS is used as the primary styling system for the site. Instead of scattered inline styling, the design system is centralized in Styles/app.css with:

- theme tokens for palette, fonts, and brand colors
- reusable utility-based component classes such as buttons, cards, badges, and shells
- rapid design iteration for premium layouts and editorial spacing

The CSS build pipeline is configured in the project file and runs through npm before build time.

## Project Structure

- Program.cs: ASP.NET Core app startup and Blazor registration
- QAZAQ.csproj: .NET project configuration and Tailwind build hook
- Components/
  - App.razor: root app shell
  - Routes.razor: route configuration
  - Layout/: shared site shell, navigation, and footer
  - Pages/: public pages such as Home, About, Spots, Reviews, and Booking
- Models/
  - Entities/: tourism domain models for spots, reviews, and heritage data
  - Forms/: booking form models
  - Enums.cs: central enumerations for destination and travel data
- Data/SampleData.cs: static seed data used to populate destinations and cultural content
- Styles/app.css: design tokens and component-level styling
- wwwroot/: static assets and frontend scripts
- appsettings.json and appsettings.Development.json: environment configuration

## Run the Project

1. Install front-end dependencies:
   npm install

2. Build the Tailwind CSS bundle:
   npm run build:css

   Optional dev watch mode:
   npm run watch:css

3. Run the app:
   dotnet run

   Or use watch mode:
   dotnet watch

## Recommended Editing Order

To keep the project cohesive when making theme or content changes, use this order:

1. Styles/app.css — update the theme tokens, palette, typography, and shared component styling
2. Models/ — edit domain classes, enums, and form models
3. Data/SampleData.cs — add or adjust content used across the site
4. Components/Layout/ — change global shell, navigation, and layout structure
5. Components/Pages/ — update landing page, destination pages, reviews, booking flow, and content sections

## Notes

This project is intentionally organized so that visual design, content data, and business logic remain separate. That supports easier maintenance, faster iteration, and a cleaner upgrade path for future tourism features or additional destinations.

