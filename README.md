# Приложение задачник Task Manager 
Приложение для управления задачами с названием задач, исполнителями, описанием и дедлайнами

# Функционал
- Добавление задач в формате `Название | Исполнитель | Описание | Дедлайн`
- Редактирование задач
- Удаление задач
- Хранение данных в SQLite

# Установка и запуск приложения
1. Установить пакеты в диспетчере пакетов NuGet (вкладка "Средства"), вставить в командную строку
   - `Install-Package System.Data.SQLite`
   - `Install-Package Microsoft.Extensions.DependencyInjection`
2. Запустить приложение

# Структура приложения
Managerr/
    TaskManagerApp.sln
    README.md 
    CoreManage/
      IManagerRepository.cs
      TaskItem.cs
    DataManage/
      ManagerRepository.cs
    TaskManager/
      Manager.cs
      Program.cs
