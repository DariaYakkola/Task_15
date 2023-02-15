Console.Write("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 1 && number <= 7)
  if (number >= 1 && number < 6)
  {
    Console.WriteLine("Идем на работу :( ");
  }
  else
  {
    Console.WriteLine("ОТДЫХАЕМ!!! ");
  }
else
  {
    Console.WriteLine("Такого дня недели не существует! ");
  }
