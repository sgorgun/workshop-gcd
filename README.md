# Workshop with GCD algorithms

## Task Description

### 1
Некто `L` начал разработку библиотеки [Gcd.v1](/Gcd.1) для алгебраических вычислений. Согласно требованию библиотека должна быть реализована как статический класс с удобными для использования для различного рода расчетов статическими методами, в частности, методами, реализующими подсчет НОД-а для двух, трех, четырех и т.д. целых чисел алгоритмами Евклида и Стайна, включая возможность подсчета времени вычислений.
- Завершите разработку библиотеки, начатой `L`, добавив недостающий функционал ([Gcd Implementations](Gcd.1/GcdImplementations) и [Static Classes](Gcd.1/StaticClasses)), не изменяя сигнутуры существующих в типах `public, internal, protected` методов.
- Какие класс (классы) необходимо будет изменить в случае, если появиться необходимость добавить реализацию еще одной модификации алгоритма Евклида?
- Обоснуйте целесообразность использования подхода, предложенного `L`, с точки зрения трудозатрат при добавлении такой функциональности.
- Добавьте в [проект](Gcd.1/GcdImplementations) необходимую функциональность для метода Стайна.
- Добавьте в тестовый [класс](/Gcd.v1.Tests) модульные тесты для проверки метода Стайна.
- Подумайте, является ли необходимость подсчета времени ответственностью класса алгоритма (класс `Algorithm`).

### 2
Некто `M` начал разработку библиотеки [Gcd.v2](/Gcd.v2) для алгебраических вычислений. Согласно требованию библиотека должна предоставлять набор типов с удобными для использования различного рода расчетов методами, в частности, методами, реализующими подсчет НОД-а для двух, трех, четырех и т.д. целых чисел классическим алгоритмом Евклида (Стайна), включая возможность подсчета времени вычислений. 
- Завершите разработку библиотеки, начатой M, добавив недостающий функционал, не изменяя сигнатуры обозначенных в типах методов и наборы публичных членов предложенных типов.
- При реализации для обозначенных алгоритмов возможности подсчета НОД-а для трех, четырех и т.д. целых чисел использовать методы расширения.
- При реализации возможности подсчета времени для обозначенных алгоритмов использовать методы расширения.
- Какие класс (классы) необходимо будет изменить в случае, если появиться необходимость добавить реализацию еще одного алгоритма? 
- Добавьте необходимую функциональность для метода Стайна.
- Обоснуйте целесообразность использования подхода, предложенного `M`, с точки зрения трудозатрат при добавлении такой функциональности.

### 3
Некто `N` начал разработку библиотеки [Gcd.v3](/Gcd.v3) для алгебраических вычислений. Согласно требованию библиотека должна предоставлять набор типов с удобными для использования различного рода расчетов методами, в частности, методами, реализующими подсчет НОД-а двух, трех, четырех и т.д. целых чисел классическим алгоритмом Евклида (Стайна), включая возможность подсчета времени вычислений.
- Завершите разработку библиотеки, начатой `N`, добавив недостающий функционал, не изменяя сигнатуры обозначенных в типах методов и наборы публичных членов предложенных типов.
- Для реализации для обозначенных алгоритмов возможности подсчета НОД-а для трех, четырех и т.д. целых чисел разработать новый класс, который расширяет функциональность исходных, не используя классического наследования.
- Добавить в полученный класс возможность подсчета времени работы алгоритмов.
- Какие класс (классы) необходимо будет изменить в случае, если появиться необходимость добавить реализацию еще одного алгоритма?
- Обоснуйте целесообразность использования подхода, предложенного `N`, с точки зрения трудозатрат при добавлении такой функциональности.

При выполнение задания запрещено использование типа делегат и LINQ-запросов в библиотеках классов.