Console.Clear();
Console.Write("Введите первое число: ");
double NumberA = Convert.ToInt32(Console.ReadLine()); // int для целых чисел, double для вещественных(со знаками после запятой)
Console.Write("Введите второе число: ");
double NumberB = Convert.ToInt32(Console.ReadLine());
double Sum = NumberA / NumberB;
Console.WriteLine(Sum);

// значок % означает нахождение остатка от деления
// new Random().Next(min, max); даст случайное целое число от min до max1