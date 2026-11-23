// step 1
// int totalExercises = 8;
 
// for (int number = totalExercises; number >= 1; number--) {
//     Console.WriteLine($"Упражнение {number}");
// }
 
// Console.WriteLine("Домашнее задание готово");
 

// step 2
// for (int room = 5; room <= 50; room += 5) {
//     Console.WriteLine($"Кабинет {room}");
// }
 
// step 3
//  int totalWeeks = 3;
 
// for (int week = 1; week <= totalWeeks; week++) {
//     for (int day = 1; day <= 5; day++) {
//         Console.WriteLine($"Неделя {week}, день {day}");
//     }
//     Console.WriteLine("^_^");
// }
 

//  step 4
// int skipped = 0;
 
// for (int ticket = 1; ticket <= 30; ticket++) {
//     if (ticket == 4 || ticket == 12 || ticket == 19) {
//         skipped++;
//         continue; // билет уже вытянут
//     }
 
//     Console.WriteLine($"Первый доступный билет: {ticket}");
//     Console.WriteLine($"Пропущено билетов: {skipped}");
//     break;
// }
 


// step 5 
// for (; ; ) {
//     Console.Write("Введите код группы (для выхода — «выход»): ");
//     string groupCode = Console.ReadLine()!;
 
//     if (groupCode == "выход") {
//         break;
//     }
 
//     Console.WriteLine($"Записан код группы: {groupCode}");
// }
 
// Console.WriteLine("Работа с журналом завершена");
 

// V
// for (int a = 1; a <= 9; a++) {
//     for (int b = 1; b <= 9; b++) {
//         Console.WriteLine($"{a} x {b} = {a * b}");
//     }
//     Console.WriteLine();
// }
 
// G
// for (int i = 1; i <= 50; i++) {
//     if (i % 3 == 0) {
//         continue;
//     }
 
//     Console.WriteLine(i);
 
//     if (i % 7 == 0) {
//         Console.WriteLine($"Первое число, кратное 7: {i}. Цикл остановлен.");
//         break;
//     }
// }
 

// var_2_8
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");
 

// var 2
// int n = 20;
// int m = 3;
 
// for (int i = n; i >= 0; i -= m) {
//     Console.WriteLine(i);
// }
 

//  var 8
// for (int i = 100; i >= 2; i -= 2) {
//     Console.WriteLine(i);
// }
 