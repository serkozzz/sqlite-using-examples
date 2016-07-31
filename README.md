#sqlite-using-examples

Здесь примеры того как добавить sqlite базу данных в проект и пользоваться ей. Всего 3 примера:
В папке winConsoleAppExample 2 примера использования - напрямую через sqlite API и через ORM sqlite-net
В папке UnityAppExample пример использования базы данных в юнити.

sqlite-net
https://github.com/praeclarum/sqlite-net

Чтобы работать с БД через sqlite-net:
1) Скачиваем sqlite3.dll и кладем её в папку с результатом сборки если это win проект или в Assets/Plugins для unity проекта.
2) Добавляем исходники библиотеки sqlite-net в проект.
Если быть точнее, я копировал лишь один файл SQLite.cs. 
Этого достаточно для синхронной работы с базой данных. На гитхабе простое и понятное руководство по использованию.
Для того чтобы собиралось в unity, пришлось добавить директиву препроцессора в начало этого файла(это не страшно, 
так как пользовательский код в Unity всё равно работает в одном потоке):
#define NO_CONCURRENT 
3) Создаем модель в коде (C# классы), на основании которых будем создавать таблицы БД(это есть в исходниках примеров)

Чтобы работать с базой данных напрямую(как в первом проекте) или через Entity Framework не нужно скачивать отдельно sqlite3.dll
и класть в результат сборки. Просто добавьте sqlite через NuGet. Этот способ, конечно, не для Unity. В Unity также не получится 
испльзовать Entity Framework(информация для Unity 5), так как используемая версия mono не поддерживает Entity Framework.

Полезная информация, которой я пользовался чтобы заставить всё работать.
http://www.sergechel.info/ru/content/using-sqllite-with-c-sharp-part-1-preparing-tools SQLite и .Net
https://habrahabr.ru/post/56694/                      SQLite и .Net
http://xgm.guru/p/unity/sqlite                        SQLite и Unity
https://habrahabr.ru/post/181239/                     SQLite и Unity
http://sqlitebrowser.org/                             визуальный редактор базы данных