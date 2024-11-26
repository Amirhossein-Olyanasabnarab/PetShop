# Pet Shop Web Application

## Overview

The **Pet Shop Web Application** is a modern web solution built using **ASP.NET Core** and adheres to **Clean Architecture principles**. This application aims to streamline the management of a pet shop, enabling features such as managing pets, clients, appointments, and inventory.

---

## Features

- **Client Management**: Register and manage pet shop clients.
- **Pet Management**: Add, view, update, and remove pets associated with clients.
- **Appointment Scheduling**: Book and manage appointments for pet services (grooming, veterinary care).
- **Inventory Management**: Keep track of pet supplies and their stock levels.
- **Payment Integration**: Process payments for services and purchases.
- **Admin Dashboard**: Access to control users, services, and shop settings.
- **Clean and Extensible Design**: Designed with Clean Architecture for scalability and maintainability.

---

## Tech Stack

- **Backend**: ASP.NET Core
- **Architecture**: Clean Architecture
- **Database**: SQL Server
- **UI Framework**: Razor Pages or ASP.NET MVC (to be decided based on requirements)
- **Authentication & Authorization**: Identity Server / ASP.NET Identity

---

## Project Structure (Clean Architecture)

The project follows the Clean Architecture pattern with distinct layers:

1. **Core Layer**:

   - Contains business logic and domain models.
   - Independent of any external libraries or frameworks.
   - Contains use cases and application-specific logic.
   - Includes interfaces for repositories and services.

2. **Infrastructure Layer**:

   - Handles external concerns such as database access, third-party integrations, and logging.

3. **Presentation Layer**:
   - Responsible for UI/UX and API controllers.

---

## Getting Started

### Prerequisites

- **.NET SDK** (5.0 or above)
- **SQL Server**
- **Visual Studio 2022** or any IDE supporting .NET development

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/Amirhossein-Olyanasabnarab/pet-shop-webapp.git
   cd pet-shop-webapp
   ```
