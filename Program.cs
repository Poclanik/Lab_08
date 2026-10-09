using System;
int totalLessons = 5;
int lessonNumber = totalLessons;

while (lessonNumber >= 1) {
    Console.WriteLine($"Пара {lessonNumber}");
    lessonNumber--;
}
Console.WriteLine("Пары закончились");

Console.WriteLine("Вводите оценки по одной, завершения введите -1:");
int grade = int.Parse(Console.ReadLine());
int Res = 0;
while (grade != -1) {
    Console.WriteLine($"Оценка принята {grade}");
    grade = int.Parse(Console.ReadLine());
    Res++;
}
Console.WriteLine("Ввод запрещён");
Console.WriteLine(Res++);


