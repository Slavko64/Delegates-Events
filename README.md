# Delegates-Events
Зробити 3-ма варіантами: Event, Delegate, Action/Func/Predicate delegate наступне завдання.
Консольна програма має дозволяти користувачеві вводити безмежну кількість стрічок. Стрічку в
якій є хоча б одна цифра повинен опрацьовувати клас з назвою AlphaNumbericCollector, в іншому
випадку клас StringCollector. Згадані вище класи повинні зберігати стрічки в списку(накопичувати
їх). Слід реалізувати 4 класи: перший, який буде відповідальний за ввід даних(InputHandler).
Другий (Progam void main), який буде зв'язувати між собою InputHandler i Collector класи і робити
підписку на подію. Третій, AlphaNumbericCollector і четвертий StringCollector. Взаємодію між
вводом даних і згаданими класами слід реалізувати через події/делегати.