namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            while (true)
            {
                try
                {
                    Console.Write("Введите число от 1 до 9999: ");
                    number = int.Parse(Console.ReadLine());

                    if (number < 1 || number > 9999)
                    {
                        throw new ArgumentOutOfRangeException("", "Ошибка: Число должно быть в диапазоне от 1 до 9999 включительно!\n");
                    }

                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введено не целое число!\n");
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            int rubles;
            int copeiki;
            string result = "";

            rubles = number / 100;
            copeiki = number % 100;

            if (rubles == 0)
            {
                if (copeiki % 10 == 1 && copeiki != 11)
                {
                    result = copeiki + " копейка";
                }
                else if ((copeiki % 10 >= 2 && copeiki % 10 <= 4) && !(copeiki >= 12 && copeiki <= 14))
                {
                    result = copeiki + " копейки";
                }
                else
                {
                    result = copeiki + " копеек";
                }
            }
            Console.WriteLine(result);
        }
    }
}