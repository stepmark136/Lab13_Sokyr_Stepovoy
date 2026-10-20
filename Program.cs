PrintHeader();
PrintHeader();
Console.WriteLine("Основная часть программы");
PrintFooter();

void PrintHeader() {
    Console.WriteLine("^_^");
    Console.WriteLine("Лабораторная работа №13");
    Console.WriteLine("Дата формирования отчёта: 20.10.2026"); 
    Console.WriteLine("0_0");
}

void PrintFooter() {
    Console.WriteLine(">_<");
    Console.WriteLine("Конец программы");
    Console.WriteLine("X_X");
}

void PrintStudentCard(string name, int age, string group) {
    Console.WriteLine($"Студент: {name}, возраст: {age}, группа: {group}");
}

PrintStudentCard("Erop", 18, "ИВТ-1");
PrintStudentCard("Валерия", 17, "ИВТ-2");

double CalculateScholarship(double baseAmount, double bonusPercent) {
    return baseAmount + baseAmount * bonusPercent / 100;
}

bool IsEligibleForBonus(double averageGrade) {
    return averageGrade >= 4.5;
}

double average = 4.7;
if (IsEligibleForBonus(average)) {
    Console.WriteLine($"Стипендия с надбавкой: {CalculateScholarship(2000, 15)}");
} else {
    Console.WriteLine($"Базовая стипендия: {CalculateScholarship(2000, 0)}");
}

double CalculateAverageGrade(int[] grades) {
    int sum = 0;
    foreach (int grade in grades) {
        sum += grade;
    }
    return (double)sum / grades.Length;
}

int CountFives(int[] grades) {
    int count = 0;
    foreach (int grade in grades) {
        if (grade == 5) count++;
    }
    return count;
}

int[] grades = { 4, 5, 3, 5, 4 };
double average = CalculateAverageGrade(grades);
int fivesCount = CountFives(grades);

Console.WriteLine($"Средний балл: {average}");
Console.WriteLine($"Количество пятёрок: {fivesCount}");

