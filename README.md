<h1 align="center">Путешествуй по России Client</h1>

<p align="center"><img  src="./images/logo.png" width="40%"></p>

## Описание проекта

Данное приложение предназначено получения информации о туристических турах. Также с помощью данного приложения можно осуществлять поиск конкретного тура и сортировать полный список.
Данные о турах и их типах выводятся из базы данных с помощью API, которое можно получить, перейдя по [ссылке](https://github.com/AngieReee/PR12Serv/tree/master). 

## О проекте
Программное решение создано на языке C# с использованием Visual Studio, Avalonia UI и EntityFramework. Основной целью проекта является исследование методов работы с данными в базе данных, включая их фильтрацию и отображение.
Интерфейс приложения построен на Avalonia UI, что обеспечивает кроссплатформенность и удобный пользовательский опыт. EntityFramework используется для взаимодействия с базой данных, предоставляя мощные инструменты для работы с запросами и манипуляции данными.
Программа позволяет пользователю задавать различные критерии фильтрации, выбирать параметры сортировки и просматривать результаты в удобном формате. Это решение может быть полезным для изучения и демонстрации принципов работы с данными, полученными из БД.

### Клиентская часть
* Просмотр туров
* Поиск конкретного тура
* Фильтрация списка по турам
* Фильтрация списка по актуальности

### Серверная часть
* Подключени API к решению
* Вывод данных с помощью API
* Конвертирование картинок

## Использование приложение
При запуске приложения запускается главная страница со списком, поиском и фильтрацией.
<p align="center"><img  src="./images/mainpage.png" width="70%"></p>

### Поиск
Для поиска конкретного тура:
* Нажмите на поле ввода вверху страницы
* Введите запрос

![](https://github.com/AngieReee/PR12Client/blob/master/images/SearchLine.gif)

### Фильтрация по типу
Для фильтрации спика по типу:
* Нажмите на выпадающий список
* Выберите интересующий вас тип
![](https://github.com/AngieReee/PR12Client/blob/master/images/TypeFilter.gif)

### Фильтрация по актуальности
Для фильтрации спика по актуальности:
* Нажмите на выпадающий список
* Выберите интересующий вас тип
![](https://github.com/AngieReee/PR12Client/blob/master/images/ActualFilter.gif)

## Технологии и инструменты разработки
* *Язык программирования*: C#
* *Среда разработки*: Visual Studio
* *UI-фреймворк*: Avalonia UI
* *ORM*: Entity Framework
* *База данных*: PostgreSQL

## Особенности проекта
Ключевые особенности решения включают:
* Интуитивно понятный интерфейс для настройки фильтров и сортировки данных.
* Быстрое и эффективное выполнение запросов к базе данных.
* Отображение результатов в удобной форме, с возможностью динамического обновления.

Проект подходит для обучения работе с базами данных, а также для изучения современных подходов к разработке пользовательских интерфейсов и обработки данных.

## Начало работы

Эти инструкции предоставят вам копию проекта и помогут запустить на вашем локальном компьютере для разработки и тестирования.

### Необходимые условия

* Операционная система Windows 10 или выше
* Установленнная Visual Studio 2022
* Установленный .NET Framework 8.0 

### Установка

1. Для установки проекта нужно скопировать репозиторий в проект Visual Studio по ссылке: 
(https://github.com/AngieReee/PR12Client)
2. Запустить проект в Visual Studio 2022
3. Дождаться загрузки решения
4. Выполнить отладку

![](https://github.com/AngieReee/PR12Client/blob/master/images/main.gif)

## Авторы
* *разработчик API* - [Сухарева Анжелика](https://github.com/AngieReee) 
