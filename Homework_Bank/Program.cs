using System;

namespace Homework_Bank
{
    class Program
    {
        delegate void MyDelegate();
        delegate void MyDelegate1(Client param);
        delegate void MyDelegate2(Client param1, Client param2);


        static void Main(string[] args)
        {
            
            Client Afonya = new Client(" Afonya "," Afonasiy ","Afonovich",1);
            Client  Izya= new Client(" Izya ", " Izya ", "Izevich", 2);

            Bank Alfa = new Bank();

            MyDelegate1 one = Alfa.Addclient;
            MyDelegate1 two = Alfa.Addclientcard;
            MyDelegate1 three = Alfa.CardtoCard_Client;

            MyDelegate bunkomat = Alfa.Bunkomat_to_Client;



            MyDelegate2 myDelegate2 = Alfa.Client_to_Client;
            int chose;
            do
            { Console.WriteLine(" Меню: \n 0 - Добавить клиента \n 1 - Добавить карту клиенту \n 2 - Перевод между своими картами  \n 3 - Пополнение карты с банкомата\n 4 - Перевод на карту другого клиента \n 5 - Получить данные  \n 6 - Выход ");
            Console.Write(" Ваш выбор: ");

            chose = int.Parse(System.Console.ReadLine());

                
                    switch(chose)
                    {
                        case 0:
                    {
                                one(Afonya);
                                one(Izya);
                                break;
                    }

                        case 1:
                            {
                                two(Afonya);
                                break;
                            }

                        case 2:
                            {
                                three(Afonya);
                                break;
                            }
                        case 3:
                            {
                                bunkomat();
                                break;
                            }

                        case 4:
                            {
                                myDelegate2(Afonya, Izya);
                                break;
                            }
                        case 5:
                            {
                                Alfa.PrintAll();
                                break;
                            }

                    }
                }
                while (chose != 6 );
            Console.WriteLine(" До свидания! ");

        }
    }
}
