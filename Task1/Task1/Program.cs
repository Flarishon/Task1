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
            string rubles_word = "";
            string copeiki_word = "";
            string result = "";

            rubles = number / 100;
            copeiki = number % 100;

            if (copeiki % 10 == 1 && copeiki != 11)
            {
                copeiki_word = " копейка";
            }
            else if ((copeiki % 10 >= 2 && copeiki % 10 <= 4) && !(copeiki >= 12 && copeiki <= 14))
            {
                copeiki_word = " копейки";
            }
            else
            {
                copeiki_word = " копеек";
            }

            if (rubles % 10 == 1 && rubles != 11)
            {
                rubles_word = " рубль";
            }
            else if ((rubles % 10 >= 2 && rubles % 10 <= 4) && !(rubles >= 12 && rubles <= 14))
            {
                rubles_word = " рубля";
            }
            else
            {
                rubles_word = " рублей";
            }

            if (rubles == 0)
            {
                result = copeiki + copeiki_word;
            }
            else if (rubles != 0 && copeiki != 0)
            {
                result = rubles + rubles_word + ", " + copeiki + copeiki_word;
            }
            else if (rubles != 0 && copeiki == 0)
            {
                result = rubles + rubles_word + " ровно";
            }
            Console.WriteLine(result);
        }
    }
}