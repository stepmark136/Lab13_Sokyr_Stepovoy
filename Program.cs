// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader() {
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабораторная работа №13");
//     Console.WriteLine("Дата формирования отчёта: 20.10.2026"); 
//     Console.WriteLine("0_0");
// }

// void PrintFooter() {
//     Console.WriteLine(">_<");
//     Console.WriteLine("Конец программы");
//     Console.WriteLine("X_X");
// }

// void PrintStudentCard(string name, int age, string group) {
//     Console.WriteLine($"Студент: {name}, возраст: {age}, группа: {group}");
// }

// PrintStudentCard("Erop", 18, "ИВТ-1");
// PrintStudentCard("Валерия", 17, "ИВТ-2");

// double CalculateScholarship(double baseAmount, double bonusPercent) {
//     return baseAmount + baseAmount * bonusPercent / 100;
// }

// bool IsEligibleForBonus(double averageGrade) {
//     return averageGrade >= 4.5;
// }

// double average = 4.7;
// if (IsEligibleForBonus(average)) {
//     Console.WriteLine($"Стипендия с надбавкой: {CalculateScholarship(2000, 15)}");
// } else {
//     Console.WriteLine($"Базовая стипендия: {CalculateScholarship(2000, 0)}");
// }

// double CalculateAverageGrade(int[] grades) {
//     int sum = 0;
//     foreach (int grade in grades) {
//         sum += grade;
//     }
//     return (double)sum / grades.Length;
// }

// int CountFives(int[] grades) {
//     int count = 0;
//     foreach (int grade in grades) {
//         if (grade == 5) count++;
//     }
//     return count;
// }

// int[] grades = { 4, 5, 3, 5, 4 };
// double average = CalculateAverageGrade(grades);
// int fivesCount = CountFives(grades);

// Console.WriteLine($"Средний балл: {average}");
// Console.WriteLine($"Количество пятёрок: {fivesCount}");

// class Program { 
//     static void Main() { 
//         Console.WriteLine(Add(2, 3)); 
//         Console.WriteLine(Add(2.5, 3.5)); 
//         Console.WriteLine(Add(2, 3, 4)); 
//     } 

//     static int Add(int a, int b) { 
//         return a + b; 
//     } 

//     static double Add(double a, double b) { 
//         return a + b; 
//     } 

//     static int Add(int a, int b, int c) { 
//         return a + b + c; 
//     } 
// }

// // Задача A
// void PrintDivider() {
//     Console.WriteLine("-----------------------------------");
// }

// PrintDivider();
// Console.WriteLine("Заголовок");
// PrintDivider();
// Console.WriteLine("Содержимое");
// PrintDivider();

// // Задача Б

// void PrintPerson(string name, int age)
// {

//     Console.WriteLine($"Имя: {name}");
//     Console.WriteLine($"Возраст: {age} лет");
// }

// PrintPerson("Иван Петров", 25);
// PrintPerson("Мария Сидорова", 32);
// PrintPerson("Алексей Иванов", 19);



// // Задача В

// bool IsEven(int number) {
//     return number % 2 == 0;
// }


// int num = 7;
// if (IsEven(num))
// {
//     Console.WriteLine("Число чётное");
// }
// else
// {
//     Console.WriteLine("Число нечётное");
// }
// // Задача Г

// int FindMax(int[] numbers) {
//     int max = numbers[0];
//     foreach (int num in numbers) {
//         if (num > max) max = num;
//     }
//     return max;
// }
// int[] arr = { 3, 8, 2, 5, 10 };
// Console.WriteLine($"Максимальное число: {FindMax(arr)}");

// Console.Write("Введите свою фамилию: "); 
// string surname = Console.ReadLine()!.Trim(); 
// if (string.IsNullOrEmpty(surname)) { 
// Console.WriteLine("Фамилия не введена. Завершение работы."); 
// return; 
// } 
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear); 
// var assigned = Enumerable.Range(1, 10) 
// .OrderBy(_ => rnd.Next()) 
// .Take(2) 
// .OrderBy(x => x) 
// .ToList(); 
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}"); 

// // 8 Степовой Сокур

// double CelsiusToFahrenheit(double celsius)
// {
//     return celsius * 9 / 5 + 32;
// }
// double tempC1 = 0;
// double tempC2 = 25;
// double tempC3 = -10;

// Console.WriteLine($"{tempC1}C = {CelsiusToFahrenheit(tempC1)}F");
// Console.WriteLine($"{tempC2}C = {CelsiusToFahrenheit(tempC2)}F");
// Console.WriteLine($"{tempC3}C = {CelsiusToFahrenheit(tempC3)}F");

// // 9 Сокур

// bool ContainsValue(int[] numbers, int target)
// {
//     foreach (int number in numbers)
//     {
//         if (number == target)
//         {
//             return true;
//         }
//     }
//     return false;
// }
// int[] array = { 1, 5, 8, 12, 25 };

// Console.WriteLine($"Содержит 8: {ContainsValue(array, 8)}"); 
// Console.WriteLine($"Содержит 10: {ContainsValue(array, 10)}");
// Console.WriteLine($"Содержит 25: {ContainsValue(array, 25)}");

// // 10 
// bool IsPalindrome(string word) {
//     int length = word.Length;
    
//     for (int i = 0; i < length / 2; i++) {
//         if (word[i] != word[length - 1 - i]) {
//             return false;
//         }
//     }
//     return true;
// }

//     Console.WriteLine($"хакер в реках: {IsPalindrome("хакер в реках")}");   

//     Console.WriteLine($"мошина: {IsPalindrome("мошина")}");   
   