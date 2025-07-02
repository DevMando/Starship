# 🚀 Starship Management App

Live Demo: [https://devmandostarships-ghe2f3acfgdzfrba.centralus-01.azurewebsites.net/](https://devmandostarships-ghe2f3acfgdzfrba.centralus-01.azurewebsites.net/)

A full-stack web application built with **.NET 8**, **Blazor Server**, **Entity Framework Core**, and **SQL Server** that consumes the [SWAPI](https://swapi.info/starships) to manage a list of Star Wars starships. 

This project includes:
- Authentication via Google OAuth
- CRUD functionality for Starships
- Responsive and animated UI using **Radzen** and **MudBlazor**
- Docker support for containerized deployment
- Environment variable support for secrets and configs

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

- **Docker Support**  
  Run the app in a containerized environment using `.env` files and `docker-compose`.

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

```
# === Database ===
ConnectionStrings__DefaultConnection=Server=YOUR_SERVER;Database=StarshipDb;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;

# === Google OAuth ===
Authentication__Google__ClientId=your-google-client-id.apps.googleusercontent.com
Authentication__Google__ClientSecret=your-google-client-secret
```

> ⚠️ Do NOT check in your `.env` file to source control.

### 3. Run with Docker

```bash
docker build -t starshipwebapp .
docker run --env-file .env -p 8080:8080 starshipwebapp
```

Then navigate to `http://localhost:8080`

### 4. (Optional) Run with Docker Compose

```bash
docker-compose up --build
```

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
- SQL Server
- Radzen Blazor Components
- MudBlazor
- Docker

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
