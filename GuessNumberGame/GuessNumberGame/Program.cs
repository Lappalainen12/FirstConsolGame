using System;



namespace GuessNumberGame
{


    class Program
    {
        static void Main(string[] args)
        {

            // Код, отвечающий за выбор игрового режима

            Console.WriteLine("Пожалуйста, выберите режим игры: ");
            Console.WriteLine("\nИгра с пользователем (для выбора, наберите на клавиатуре - с игроком).");
            Console.WriteLine("Игра с компьютером (для выбора, наберите на клавиатуре - с компьютером).");

            // Инициализация строковой переменной о выборе режима игры
            string ChoiceWithPlayersOrComputer = Console.ReadLine();


            //Блок кода, отвечающий за режим игры с 1-м или несколькими игроками
            if (ChoiceWithPlayersOrComputer == "с игроком")
            {

                Console.WriteLine("\nВыбор сделан!");

                //Блок кода, отвечающий за выбор уровня сложности игроком
                Console.WriteLine("Пожалуйста, выберите уровень сложности игры:");

                Console.WriteLine("\nЛегко");
                Console.WriteLine("Средне");
                Console.WriteLine("Сложно");

                string choiceLevel = Console.ReadLine();
                

                // Уровень сложности - легко
                if (choiceLevel == "легко")
                {
                    Console.WriteLine("\n1-й игрок, пожалуйста введите своё имя.");
                    string FirstPlayerName = Console.ReadLine();

                    Console.WriteLine("\n2-й игрок, пожалуйста введите своё имя. ");
                    string SecondPlayerName = Console.ReadLine();

                    //Инициализируем генератор псевдослучайных чисел

                    // Инициализация переменной, в которую будет помещено псевдорандомное число
                    int gameNumber;

                    //Инициализация нового компонента для генерации чисел
                    Random rand = new Random();

                    //Присвоение псевдорамного числа переменной RandomNumber


                    gameNumber = rand.Next(12, 120);

                    //Вывод на консоль сообщения о том, что компьютер загадал своё число и игра может быть начата
                    Console.WriteLine("\nИтак, игроки, компьютером загадно число " + gameNumber);
                    Console.WriteLine("\nДа начнётся поединок!");


                    
                    //Булевая переменная, определяющая выход из цикла
                    bool stopCycle = false;

                    // Создаём цикл for в котором будут производиться необходимые расчёты/подсчёты
                    for (int i = 0; i < 100; i++)
                    {

                        // Данная логическая конструкция определяет порядок ходов, закреплённых за игроками
                        if (i % 2 == 0)
                        {
                            //Вывод сообщения на экран о вводе значения 1-м игроком
                            Console.WriteLine(FirstPlayerName + " - введите число от 1 до 4-х:");
                        }

                        else if (i % 2 != 0)
                        {
                            //Вывод сообщения на экран о вводе значения 2-м игроком
                            Console.WriteLine(SecondPlayerName + " - введите число от 1 до 4-х:");
                        }

                        // Инициализация числовой переменной, в которой сохраняется значение, заданное пользователем
                        byte useTry = Convert.ToByte(Console.ReadLine());

                        //Оператор switch отвечающий за вычисления
                        switch (useTry)
                        {

                            case 1:
                            case 2:
                            case 3:
                            case 4:

                                gameNumber -= useTry;
                                Console.WriteLine("Вычисленное значение: " + gameNumber);


                                // Логические операторы, определяющие ход поединка (победу либо проигрыш)
                                if (gameNumber == 0)
                                {

                                    if (i % 2 == 0)
                                    {
                                        Console.WriteLine(FirstPlayerName + ", поздравляю! Вы выиграли!");
                                        stopCycle = true;
                                        
                                        
                                    }

                                    else if (i % 2 != 0)
                                    {
                                        Console.WriteLine(SecondPlayerName + ", поздравляю! Вы выиграли!");
                                        stopCycle = true;
                                      
                                    }


                                }

                                // Логические операторы, определяющие ход поединка (победу либо проигрыш)
                                else if (gameNumber < 0)
                                {
                                    if (i % 2 == 0)
                                    {
                                        Console.WriteLine(FirstPlayerName + ", сожалею, вы проиграли.");
                                        stopCycle = true;
                                    }

                                    else if (i % 2 != 0)
                                    {
                                        Console.WriteLine(SecondPlayerName + ", сожалею, вы проиграли.");
                                        stopCycle = true;
                                    }
                                }

                                break;

                            /* Вывод сообщения, в случае если введённое пользователем число не соответствует правилам
                              либо введён иной тип данных */
                            default:
                                Console.WriteLine("Заданное программе число не соответствует правилам!");
                                stopCycle = true;
                                break;

                        }

                        //Оператор, определяющий своевременное завершение работы цикла
                        if (stopCycle == true)
                        {
                            break;
                        }
                    }
                }


                // Уровень сложности - средне.
                else if (choiceLevel == "средне")
                {
                    Console.WriteLine("\n1-й игрок, пожалуйста введите своё имя.");
                    string FirstPlayerName = Console.ReadLine();

                    Console.WriteLine("\n2-й игрок, пожалуйста введите своё имя. ");
                    string SecondPlayerName = Console.ReadLine();


                    //Инициализируем генератор псевдослучайных чисел

                    // Инициализация переменной, в которую будет помещено псевдорандомное число
                    int RandomNumber;

                    //Инициализация нового компонента для генерации чисел
                    Random rand = new Random();

                    //Присвоение псевдорамного числа переменной RandomNumber


                    RandomNumber = rand.Next(55, 256);

                    //Вывод на консоль сообщения о том, что компьютер загадал своё число и игра может быть начата
                    Console.WriteLine("\nИтак, игроки, компьютером загадно число " + RandomNumber);
                    Console.WriteLine("\nДа начнётся поединок!");

                    // Создаём цикл for в котором будут производиться необходимые расчёты/подсчёты
                    
                    bool stopCycle = false;

                    for (int i = 0; i < 100; i++)
                    {

                        // Данная логическая конструкция определяет порядок ходов, закреплённых за игроками
                        if (i % 2 == 0)
                        {
                            //Вывод сообщения на экран о вводе значения 1-м игроком
                            Console.WriteLine(FirstPlayerName + " - введите число от 1 до 7-х:");
                        }

                        else if (i % 2 != 0)
                        {
                            //Вывод сообщения на экран о вводе значения 2-м игроком
                            Console.WriteLine(SecondPlayerName + " - введите число от 1 до 7-х:");
                        }



                        // Инициализация числовой переменной, в которой сохраняется значение, заданное пользователем
                        byte useTry = Convert.ToByte(Console.ReadLine());

                        //Оператор switch отвечающий за вычисления
                        switch (useTry)
                        {

                            case 1:
                            case 2:
                            case 3:
                            case 4:
                            case 5:
                            case 6:
                            case 7:

                                RandomNumber -= useTry;
                                Console.WriteLine("Вычисленное значение: " + RandomNumber);


                                // Логические операторы, определяющие ход поединка (победу либо проигрыш)
                                if (RandomNumber == 0)
                                {

                                    if (i % 2 == 0)
                                    {
                                        Console.WriteLine(FirstPlayerName + ", поздравляю! Вы выиграли!");
                                        stopCycle = true;
                                        
                                    }

                                    else if (i % 2 != 0)
                                    {
                                        Console.WriteLine(SecondPlayerName + ", поздравляю! Вы выиграли!");
                                        stopCycle = true;
                                    }


                                }

                                // Логические операторы, определяющие ход поединка (победу либо проигрыш)
                                else if (RandomNumber < 0)
                                {
                                    if (i % 2 == 0)
                                    {
                                        Console.WriteLine(FirstPlayerName + ", сожалею, вы проиграли.");
                                        stopCycle = true;
                                    }

                                    else if (i % 2 != 0)
                                    {
                                        Console.WriteLine(SecondPlayerName + ", сожалею, вы проиграли.");
                                        stopCycle = true;
                                    }
                                }

                                break;

                            /* Вывод сообщения, в случае если введённое пользователем число не соответствует правилам
                              либо введён иной тип данных */
                            default:
                                Console.WriteLine("Заданное программе число не соответствует правилам!");
                                stopCycle = true;
                                break;

                        }

                        //Логическое условие, определяющее выход из цикла
                        if (stopCycle == true)
                        {
                            break;
                        }
                    
                    }
                }

                // Уровень сложности - сложно.
                else if (choiceLevel == "сложно")
                {
                    Console.WriteLine("\n1-й игрок, пожалуйста введите своё имя.");
                    string FirstPlayerName = Console.ReadLine();

                    Console.WriteLine("\n2-й игрок, пожалуйста введите своё имя. ");
                    string SecondPlayerName = Console.ReadLine();

                    //Инициализируем генератор псевдослучайных чисел

                    // Инициализация переменной, в которую будет помещено псевдорандомное число
                    int RandomNumber;

                    //Инициализация нового компонента для генерации чисел
                    Random rand = new Random();

                    //Присвоение псевдорамного числа переменной RandomNumber


                    RandomNumber = rand.Next(112, 457);

                    //Вывод на консоль сообщения о том, что компьютер загадал своё число и игра может быть начата
                    Console.WriteLine("\nИтак, игроки, компьютером загадно число " + RandomNumber);
                    Console.WriteLine("\nДа начнётся поединок!");


                    //Булевая переменная, определяющая выход из цикла
                    bool stopCycle = false;

                    // Создаём цикл for в котором будут производиться необходимые расчёты/подсчёты
                    for (int i = 0; i < 100; i++)
                    {

                        // Данная логическая конструкция определяет порядок ходов, закреплённых за игроками
                        if (i % 2 == 0)
                        {
                            //Вывод сообщения на экран о вводе значения 1-м игроком
                            Console.WriteLine(FirstPlayerName + " - введите число от 1 до 11-х:");
                        }

                        else if (i % 2 != 0)
                        {
                            //Вывод сообщения на экран о вводе значения 2-м игроком
                            Console.WriteLine(SecondPlayerName + " - введите число от 1 до 11-х:");
                        }

                        // Инициализация числовой переменной, в которой сохраняется значение, заданное пользователем
                        byte useTry = Convert.ToByte(Console.ReadLine());

                        //Оператор switch отвечающий за вычисления
                        switch (useTry)
                        {

                            case 1:
                            case 2:
                            case 3:
                            case 4:
                            case 5:
                            case 6:
                            case 7:
                            case 8:
                            case 9:
                            case 10:
                            case 11:

                                RandomNumber -= useTry;
                                Console.WriteLine("Вычисленное значение: " + RandomNumber);


                                // Логические операторы, определяющие ход поединка (победу либо проигрыш)
                                if (RandomNumber == 0)
                                {

                                    if (i % 2 == 0)
                                    {
                                        Console.WriteLine(FirstPlayerName + ", поздравляю! Вы выиграли!");
                                        stopCycle = true;
                                    }

                                    else if (i % 2 != 0)
                                    {
                                        Console.WriteLine(SecondPlayerName + ", поздравляю! Вы выиграли!");
                                        stopCycle = true;
                                    }


                                }

                                // Логические операторы, определяющие ход поединка (победу либо проигрыш)
                                else if (RandomNumber < 0)
                                {
                                    if (i % 2 == 0)
                                    {
                                        Console.WriteLine(FirstPlayerName + ", сожалею, вы проиграли.");
                                        stopCycle = true;
                                    }

                                    else if (i % 2 != 0)
                                    {
                                        Console.WriteLine(SecondPlayerName + ", сожалею, вы проиграли.");
                                        stopCycle = true;
                                    }
                                }

                                break;

                            /* Вывод сообщения, в случае если введённое пользователем число не соответствует правилам
                              либо введён иной тип данных */
                            default:
                                Console.WriteLine("Заданное программе число не соответствует правилам!");
                                stopCycle = true;
                                break;

                        }

                        //Логическое условие, определяющее выход из цикла
                        if (stopCycle == true)
                        {
                            break;
                        }
                    
                    }
                }
            }





            
            //Блок кода, отвечающий за режим игры с компьютером
            else if (ChoiceWithPlayersOrComputer == "с компьютером")
            {
                Console.WriteLine("\nВыбор сделан!");

                //Инициализируем генератор псевдослучайных чисел

                int RandomNumberComputerGames;

                Random rand = new Random();

                RandomNumberComputerGames = rand.Next(12, 120);

                // Вывод сообщения на консоль о том, что компьютер загадал число и готов к игре
                Console.WriteLine("\nИтак, товарищ, компьютером загадно число " + RandomNumberComputerGames);
                Console.WriteLine("\nНе забывай, что твой соперник - электронно-вычислительная машина! Да начнётся поединок!");


                //Булевая переменная, определяющая выход из цикла
                bool stopCycle = false;

                // Создаём цикл for в котором будут производиться необходимые расчёты/подсчёты
                for (int i = 0; i < 100; i++)
                {

                    // Данная логическая конструкция определяет порядок ходов, закреплённых за игроками
                    
                    //Ход человека
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("\nЧеловек, введите число от 1 до 4-х:");
                        byte useTry = Convert.ToByte(Console.ReadLine());

                        // Вычисления со стороны человека, а также логические операторы, отвечающие за итог партии
                        switch (useTry)
                        {

                            case 1:
                            case 2:
                            case 3:
                            case 4:

                                RandomNumberComputerGames -= useTry;
                                Console.WriteLine("Вычисленное значение: " + RandomNumberComputerGames);

                                // Если значение переменной равно нулю, на консоль отображается сообщение о выигрыше.
                                if (RandomNumberComputerGames == 0)
                                {
                                    Console.WriteLine("Поздравляю! Человек выиграл!");
                                    stopCycle = true;
                                }

                                // Если значение переменной меньше нуля, на консоль отображается сообщение о проигрыше.
                                else if (RandomNumberComputerGames < 0)
                                {
                                    Console.WriteLine("К сожалению, человек проиграл!");
                                    stopCycle = true;
                                }
                                
                                break;

                            default:
                                Console.WriteLine("Заданное программе число не соответствует правилам!");
                                stopCycle = true;
                                break;

                        }
                    }

                    //Ход компьютера
                    else if (i % 2 != 0)
                    {

                        //Генерация псевдорандомных чисел, которые компьютер использует для своих ходов
                        int ComputerRand;

                        Random randint = new Random();

                        ComputerRand = randint.Next(1, 4);


                        // Вычисления со стороны компьютера, а также логические операторы, отвечающие за итог партии
                        switch (ComputerRand)
                        {

                            case 1:
                            case 2:
                            case 3:
                            case 4:

                                RandomNumberComputerGames -= ComputerRand;
                                Console.WriteLine("\nИтак, теперь ход компьютера...");
                                Console.WriteLine(ComputerRand);
                                Console.WriteLine("Вычисленное значение: " + RandomNumberComputerGames);

                                // Если значение переменной равно нулю, на консоль отображается сообщение о выигрыше.
                                if (RandomNumberComputerGames == 0)
                                {
                                    Console.WriteLine("Компьютер выиграл!");
                                    stopCycle = true;
                                }

                                // Если значение переменной меньше нуля, на консоль отображается сообщение о проигрыше.
                                else if (RandomNumberComputerGames < 0)
                                {
                                    Console.WriteLine("Компьютер проиграл!");
                                    stopCycle = true;
                                }
                                break;
                        }
                    }

                    //Логическое условие, определяющее выход из цикла
                    if (stopCycle == true)
                    {
                        break;
                    }
                
                }
            }
        }          
    }
}
