# Выполнение задания: совместная разработка

## 1. Распределение модулей
- Участник 1 — каталог книг, ветка `feature/books`, файл `BooksModule.cs`.
- Участник 2 — читатели, ветка `feature/readers`, файл `ReadersModule.cs`.
- Участник 3 — выдача книг, ветка `feature/loans`, файл `LoansModule.cs`.

## 2–3. Ветки и закреплённые модули
В ZIP сохранён настоящий репозиторий `.git`, ветки `main`, `feature/books`, `feature/readers`, `feature/loans` и коммиты. Проверка: `git branch -a`, `git log --oneline --graph --all --decorate`.

## 4. Осмысленные коммиты
У каждого модуля собственный коммит `feat(...)`. Интеграция сделана отдельными merge-коммитами.

## 5. Интеграция
Ветка `main` содержит все три модуля и объединённый WPF-интерфейс. Слияния выполнены `git merge --no-ff`.

## 6. Совместимость
Открыть программу, нажать «Книги», «Читатели», «Выдачи», затем «Проверить модули». Проверяются уникальные идентификаторы, ссылки выдач на существующие книги и читателей и отсутствие двойной активной выдачи одной книги.

## 7. Конфликт
Реальных конфликтов при интеграции независимых файлов не было. Чтобы безопасно показать учебный конфликт, создать две временные ветки от `main`, в каждой изменить одну и ту же строку `StatusText.Text = ...` в `MainWindow.xaml.cs` по-разному и сделать коммит. Слить первую ветку в учебную ветку, затем вторую: Git покажет конфликт. Открыть файл, удалить маркеры `<<<<<<<`, `=======`, `>>>>>>>`, оставить согласованный вариант, выполнить `git add src/LibraryInformationSystem/MainWindow.xaml.cs`, `git commit -m "fix: resolve demonstration merge conflict"`. Учебный конфликт не включён в `main`, чтобы не ломать рабочую программу.

## Скриншоты
1. `git branch -a` — отдельные ветки.
2. `git log --oneline --graph --all --decorate` — коммиты и слияния.
3. Окно приложения: книги.
4. Окно приложения: читатели.
5. Окно приложения: выдачи.
6. Сообщение «Проверка пройдена».
7. Учебный конфликт и его разрешение (по инструкции выше).

## Запуск Windows PowerShell
```powershell
dir
cd .\LibraryInformationSystem
 dotnet restore .\LibraryInformationSystem.sln
 dotnet build .\LibraryInformationSystem.sln
 dotnet run --project .\src\LibraryInformationSystem\LibraryInformationSystem.csproj
```
Требуется Windows и .NET 8 SDK с поддержкой WPF. На macOS напрямую WPF не запускается — используйте Windows в Parallels.
