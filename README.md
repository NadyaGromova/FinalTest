	# **Итоговая проверочная работа.**

## **Задача:** 
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры:**
* ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
* ["1234", "1567", "-2", "computer science"] -> ["-2"]
* ["Russia", "Denmark", "Kazan"] -> []

---
## **Выполнение задания**

1. Задаем исходный массив строк, который необходимо отсортировать по количеству сиволов (согласно заданию);
2. Создаем void-метод печати массива в консоль, в который будет передаваться массив из строк;
3. Создаем int-метод для подсчета размера отсортированного, согласно условиям задачи, нового массива. В этом методе будет возвращаться кол-во элементов заданного массива, содержащие не более 3х символов.
4. Создаем string-метод для создания нового отсортированного массива, который отвечает требованиям поставленной задачи, а именно: элементы массива содержат не более 3х символов). В этом методе будет возращаться новый отсортированный массив.
5. Используем метод печати массива из пункта 2 для печати нового отсортированного массива. 








