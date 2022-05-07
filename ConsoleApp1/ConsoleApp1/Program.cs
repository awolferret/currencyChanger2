using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int rubToUsd = 66;
            int usdToRub = 68;
            int rubToEuro = 90;
            int euroToRub = 95;
            float euroToUsd = 1.04f;
            float usdToEuro = 1.06f;
            Console.WriteLine("Введите баланс рублей");
            float rubBallance = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите баланс долларов");
            float usdBallance = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите баланс евро");
            float euroBallance = Convert.ToSingle(Console.ReadLine());
            float wantToChange;
            Console.WriteLine("Чтобы обменять рубли на доллары нажмите 1");
            Console.WriteLine("Чтобы обменять доллары на рубли нажмите 2");
            Console.WriteLine("Чтобы обменять рубли на евро нажмите 3");
            Console.WriteLine("Чтобы обменять евро на рубли нажмите 4");
            Console.WriteLine("Чтобы обменять доллары на евро нажмите 5");
            Console.WriteLine("Чтобы обменять евро на доллары нажмите 6");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("Обмен рублей на доллары");
                    Console.WriteLine("Сколько долларов вы хотите купить?");
                    wantToChange = Convert.ToSingle(Console.ReadLine());
                    if (rubBallance >= wantToChange * rubToUsd)
                    {
                        rubBallance -= wantToChange * rubToUsd;
                        usdBallance += wantToChange;
                        Console.WriteLine($"У вас {rubBallance} рублей и {usdBallance} долларов");
                    }

                    else
                    {
                        Console.WriteLine("недостаточный балланс");
                    }
                    break;
                case 2:
                    Console.WriteLine("Обмен долларов на рубли");
                    Console.WriteLine("Сколько долларов вы хотите продать?");
                    wantToChange = Convert.ToSingle(Console.ReadLine());
                    if (usdBallance >= wantToChange)
                    {
                        usdBallance -= wantToChange;
                        rubBallance += wantToChange * usdToRub;
                        Console.WriteLine($"У вас {rubBallance} рублей и {usdBallance} долларов");
                    }

                    else
                    {
                        Console.WriteLine("недостаточный балланс");
                    }
                    break;
                case 3:
                    Console.WriteLine("Обмен рублей на евро");
                    Console.WriteLine("Сколько евро вы хотите купить?");
                    wantToChange = Convert.ToSingle(Console.ReadLine());

                    if (rubBallance >= wantToChange * rubToEuro)
                    {
                        rubBallance -= wantToChange * rubToEuro;
                        euroBallance += wantToChange;
                        Console.WriteLine($"У вас {rubBallance} рублей и {euroBallance} евро");
                    }

                    else
                    {
                        Console.WriteLine("недостаточный балланс");
                    }
                    break;
                case 4:
                    Console.WriteLine("Обмен евро на рубли");
                    Console.WriteLine("Сколько Евро вы хотите продать?");
                    wantToChange = Convert.ToSingle(Console.ReadLine());

                    if (euroBallance >= wantToChange)
                    {
                        euroBallance -= wantToChange;
                        rubBallance += wantToChange * euroToRub;
                        Console.WriteLine($"У вас {rubBallance} рублей и {euroBallance} евро");
                    }

                    else
                    {
                        Console.WriteLine("недостаточный балланс");
                    }
                    break;
                case 5:
                    Console.WriteLine("Обмен долларов на евро");
                    Console.WriteLine("Сколько Евро вы хотите купить?");
                    wantToChange = Convert.ToSingle(Console.ReadLine());

                    if (euroBallance >= wantToChange)
                    {
                        euroBallance -= wantToChange;
                        usdBallance += wantToChange * euroToUsd;
                        Console.WriteLine($"У вас {usdBallance} долларов и {euroBallance} евро");
                    }

                    else
                    {
                        Console.WriteLine("недостаточный балланс");
                    }
                    break;
                case 6:
                    Console.WriteLine("Обмен евро на доллары");
                    Console.WriteLine("Сколько евро вы хотите продать?");
                    wantToChange = Convert.ToSingle(Console.ReadLine());

                    if (euroBallance >= wantToChange * usdToEuro)
                    {
                        euroBallance -= wantToChange * usdToEuro;
                        usdBallance += wantToChange;
                        Console.WriteLine($"У вас {euroBallance} евро и {usdBallance} долларов");
                    }

                    else
                    {
                        Console.WriteLine("недостаточный балланс");
                    }
                    break;
            }
        }
    }
}
