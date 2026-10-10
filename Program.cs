using System;
//int totalLessons = 5;
//int lessonNumber = totalLessons;
//
//while (lessonNumber >= 1) {
//    Console.WriteLine($"Пара {lessonNumber}");
//    lessonNumber--;
//}
//Console.WriteLine("Пары закончились");
//
//Console.WriteLine("Вводите оценки по одной, завершения введите -1:");
//int grade = int.Parse(Console.ReadLine());
//int Res = 0;
//while (grade != -1) {
//    Console.WriteLine($"Оценка принята {grade}");
//    grade = int.Parse(Console.ReadLine());
//    Res++;
//}
//Console.WriteLine("Ввод запрещён");
//Console.WriteLine(Res++);

//int sum = 0;
//int count = 0;
//int maxcount = 0;
//
//Console.WriteLine("Вводите оценки, для завершения введите -1:");
//int grade = int.Parse(Console.ReadLine());
//while (grade != -1) {
//    sum += grade;
//    count++;
//    grade = int.Parse(Console.ReadLine());
//if (maxcount < grade) {maxcount = grade;}
//}
//if (count > 0) {
//    Console.WriteLine($"Средний балл: {(double)sum / count}");
//} else {
//    Console.WriteLine("Оценок не было введено");
//}
//Console.WriteLine($"Максимальная оценка {maxcount}");

//string correctPassword = "qwerty123";
//int failcount = 0;
//while (true) {
//    Console.Write("Введите пароль от личного кабинета: ");
//    string password = Console.ReadLine();
//    if (password == correctPassword){
//        Console.WriteLine("Доступ разрешён");
//        break;
//    }
//    failcount++;
//    Console.WriteLine("Неверный пароль, попробуйте снова");
//}

//string answer;
//do {
//    Console.Write("Введите дату посещения (например, 0,1.09):");
//    string date = Console.ReadLine();
//    Console.WriteLine($"Запись добавлена: {date}");
//
//    Console.Write("Добавить ещё одну записать? (да/нет): ");
//    answer = Console.ReadLine();
//} while(answer =="да");
//Console.WriteLine("Дневник сохранен");

//* a
//int start = 0;
//Console.WriteLine("Введите число");
//int n = int.Parse(Console.ReadLine());
//while (start <= 9) {start++;
//Console.WriteLine($"{start} * {n} = {start*n}");}
//в
//int vvod = int.Parse(Console.ReadLine());
//int count = 0;
//while(vvod != -1){count += vvod; vvod = int.Parse(Console.ReadLine());}
//Console.WriteLine($"Всего страниц прочитанно{count}");
//** 2
//int number = int.Parse(Console.ReadLine());
//int sum = 0;
//
//while (number != 0) {
//    if (number > 0) {
//        sum += number;
//    }
//    number = int.Parse(Console.ReadLine());
//}
//Console.WriteLine($"Сумма: {sum}");
//5 
int cod = 23524;

while (true) {
    Console.Write("Введите код: ");
    int vvod = int.Parse(Console.ReadLine());
    if (vvod == cod) {
        Console.WriteLine("Дверь открыта");
        break;
    }
    Console.WriteLine("Неверный код, попробуйте снова");
}