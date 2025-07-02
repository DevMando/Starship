# 🚀 Starship Management App

Live Demo: [https://devmandostarships-ghe2f3acfgdzfrba.centralus-01.azurewebsites.net/](https://devmandostarships-ghe2f3acfgdzfrba.centralus-01.azurewebsites.net/)

A full-stack web application built with **.NET 8**, **Blazor Server**, **Entity Framework Core**, and **SQL Server** that consumes the [SWAPI](https://swapi.info/starships) to manage a list of Star Wars starships. 

This project includes:
- Authentication via Google OAuth
- CRUD functionality for Starships
- Responsive and animated UI using **Radzen** and **MudBlazor**
- Docker support using **Docker Compose** and **SQL Server in a container**
- Secrets and config values loaded from a `.env` file

I had a lot of fun styling this project! Future features may include:
- Relational data linking Pilots and Films to Starships
- Application-wide logging
- Audit history of starship changes (who changed what and when)

---

## 🚧 Features

- **Google OAuth Authentication**  
  Users must log in using a Google account to access the app.

- **Starship CRUD Functionality**  
  Create, edit, update, and delete starships. All forms are validated and styled.

- **Docker Compose Setup**  
  Fully containerized app and SQL Server using `docker-compose`. No manual SQL installation required.

- **Environment-Based Secrets**  
  All sensitive credentials and connection strings are configured via `.env` to support secure and flexible deployments.

- **Responsive UI with Animations**  
  A modern, sci-fi-inspired user interface using Radzen Panels and MudBlazor animations.

---

## 🔧 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/DevMando/Starship.git
cd StarshipWebApp
```

### 2. Setup Environment Variables

Create a `.env` file at the root of the `StarshipWebApp` project based on `.env.example`.

```env
# === Database ===
DEFAULT_CONNECTION_STRING=Server=sqlserver;Database=StarshipDb;User Id=sa;Password=YourStrong!Passw0rd;TrustServerCertificate=True;

# === Google OAuth ===
GOOGLE_CLIENT_ID=your-google-client-id.apps.googleusercontent.com
GOOGLE_CLIENT_SECRET=your-google-client-secret
```

> ⚠️ Do NOT check in your `.env` file to source control.

### 3. Run with Docker Compose (Recommended)

```bash
docker-compose up --build
```

Then navigate to [http://localhost:8080](http://localhost:8080)

This will:
- Start SQL Server in a container
- Build and launch the Blazor web app
- Automatically apply EF Core migrations and seed the database

---

## 🔐 Google OAuth Setup

1. Go to [Google Cloud Console](https://console.cloud.google.com/)
2. Create a new project
3. Navigate to **APIs & Services → Credentials**
4. Create **OAuth Client ID** for a **Web Application**
5. Add authorized redirect URI:  
   `http://localhost:8080/signin-google` *(or your deployed URL)*
6. Copy your **Client ID** and **Client Secret** into the `.env` file

---

## 🧪 Tech Stack

- .NET 8
- Blazor Server
- EF Core
- SQL Server (Docker containerized)
- Radzen Blazor Components
- MudBlazor
- Docker & Docker Compose

---

## 📂 Project Structure

- `StarshipWebApp/` — Main Blazor project
- `.env.example` — Sample configuration
- `docker-compose.yml` — Compose file for local development
- `Program.cs` — Configuration & startup logic
- `Data/` — EF Core DbContext and models

---

## 🎯 Future Enhancements

- Pilot and Film relationships
- Application logging
- Starship edit history and change tracking
- Deployment pipeline

---

## ✅ Status

This project is feature-complete for the coding challenge but open to future polish and enhancements.

