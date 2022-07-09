//Console.WriteLine("Введите первое число для сложения");
int num1 = new Random().Next(1, 10);         //int.Parse(Console.ReadLine());
//Console.WriteLine("Введите второе число для сложения");
int num2 = new Random().Next(1, 10);         //int.Parse(Console.ReadLine());
int sum = num1 + num2;
Console.WriteLine("Ваш пример: " + num1 + " " + "+" + " " + num2 + " " + "=" + " " +  sum);