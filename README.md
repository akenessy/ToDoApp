# ToDoApp

ToDoApp — это простое приложение для управления задачами, созданное на ASP.NET Core и Entity Framework Core. Следуйте этому руководству, чтобы настроить и запустить приложение на вашем компьютере.

## Требования

1. **Git**: Скачайте и установите Git с [git-scm.com](https://git-scm.com/).
2. **.NET SDK**: Установите последнюю версию .NET SDK с [dotnet.microsoft.com](https://dotnet.microsoft.com/download).

---

## Установка и настройка

### 1. Клонирование репозитория

Откройте **Git Bash** или другой предпочитаемый терминал и перейдите в папку, куда вы хотите клонировать репозиторий. Введите:

```bash
git clone <repository_url>
```

Замените `<repository_url>` на фактический URL репозитория.

Перейдите в папку проекта:

```bash
cd ToDoApp-master/ToDoApp
```

---

### 2. Установка dotnet-ef

Установите глобальный инструмент `dotnet-ef` для управления миграциями:

```bash
dotnet tool install --global dotnet-ef
```

После установки перезапустите терминал в папке проекта.

---

### 3. Установка необходимых пакетов

Выполните следующие команды для установки необходимых NuGet-пакетов:

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

---

### 4. Применение миграций

Запустите следующую команду для обновления базы данных с помощью миграций:

```bash
dotnet ef database update
```

---

### 5. Настройка SSL-сертификата

Доверяйте сертификату разработки HTTPS:

```bash
dotnet dev-certs https --trust
```

Следуйте инструкциям на экране, чтобы подтвердить доверие сертификату.

---

## Запуск приложения

### Вариант 1: Использование Visual Studio

1. Откройте файл решения (`ToDoApp.sln`) в Visual Studio.
2. Установите стартовым проектом `ToDoApp`.
3. Нажмите `F5` или выберите **Запустить**, чтобы стартовать приложение.

### Вариант 2: Использование командной строки

Выполните следующие команды в терминале:

1. Очистите решение:
   ```bash
   dotnet clean
   ```
2. Постройте решение:
   ```bash
   dotnet build
   ```
3. Запустите приложение:
   ```bash
   dotnet run
   ```
4. В браузере перейдите по ссылке, которую выдала консоль:
   ```bash
   info : Microsoft.Hosting.Lifetime[14]
          Now listening on: http://localhost:5205
   ```

---

## Функционал

- Создание, редактирование, удаление и просмотр задач.
- Фильтрация задач по названию или дате создания.
- Построено с использованием Entity Framework Core и SQLite.

---

## Лицензия

Этот проект распространяется на условиях GNU Affero General Public License (AGPL).

---


# ToDoApp

ToDoApp is a simple task management application built with ASP.NET Core and Entity Framework Core. Follow this guide to set up and run the application on your computer.

## Requirements

1. **Git**: Download and [install](https://git-scm.com/) Git from [git-scm.com](https://git-scm.com/).
2. **.NET SDK**: Install the latest version of the .NET SDK from [dotnet.microsoft.com](https://dotnet.microsoft.com/download).

---

## Installation and Setup

### 1. Clone the Repository

Open **Git Bash** or another preferred terminal, navigate to the folder where you want to clone the repository, and run:

```bash
git clone <repository_url>
```

Replace `<repository_url>` with the actual repository URL.

Navigate to the project folder:

```bash
cd ToDoApp-master/ToDoApp
```

---

### 2. Install dotnet-ef

Install the global `dotnet-ef` tool for managing migrations:

```bash
dotnet tool install --global dotnet-ef
```

After installation, restart the terminal in the project folder.

---

### 3. Install Required Packages

Run the following commands to install the necessary NuGet packages:

```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

---

### 4. Apply Migrations

Run the following command to update the database using migrations:

```bash
dotnet ef database update
```

---

### 5. Set Up SSL Certificate

Trust the development HTTPS certificate:

```bash
dotnet dev-certs https --trust
```

Follow the on-screen instructions to confirm trust for the certificate.

---

## Running the Application

### Option 1: Using Visual Studio

1. Open the solution file (`ToDoApp.sln`) in Visual Studio.
2. Set `ToDoApp` as the startup project.
3. Press `F5` or select **Run** to start the application.

### Option 2: Using Command Line

Run the following commands in the terminal:

1. Clean the solution:
   ```bash
   dotnet clean
   ```
2. Build the solution:
   ```bash
   dotnet build
   ```
3. Run the application:
   ```bash
   dotnet run
   ```
4. In the browser, click on the link provided by the console:
   ```bash
   info : Microsoft.Hosting.Lifetime[14]
          Now listening on: http://localhost:5205
   ```
---

## Features

- Create, edit, delete, and view tasks.
- Filter tasks by name or creation date.
- Built using Entity Framework Core and SQLite.

---

## License

This project is distributed under the terms of the GNU Affero General Public License (AGPL).

---
