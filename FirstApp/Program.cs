using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            byte choise;
            bool isNumber;
            bool a;
            decimal r;
            do
            {
                Console.WriteLine("=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=> First Application <=<=<=<=<=<=<=<=<=<=<=<=<=<=<=<=<=<=<=<=<=<=<=<=<=<=");
                Console.WriteLine("Daire emeliyyatlri proqramina xos gelmisiniz!");
                Console.WriteLine("Davam etmek ucun asagidaki secimleri edin");
                Console.WriteLine();
                Console.WriteLine("1.Saheni hesabla");
                Console.WriteLine("2.Uzunlugu hesabla");
                Console.WriteLine("0.Proqramdan cixis");
                Console.WriteLine();
                isNumber = byte.TryParse(Console.ReadLine(), out choise);
                if (isNumber)
                {
                    if (choise == 1 || choise == 2)
                    {
                        Console.WriteLine("Zehmet olmasa radiusu daxil edin");
                        a = decimal.TryParse(Console.ReadLine(),out r);
                        if (a)
                        {
                            if (choise == 1)
                            {
                                Cyrcle cyrcle = new Cyrcle();
                                cyrcle.Name = "C1";
                                Console.WriteLine("Dairenin sahesi " + cyrcle.CalcArea(r) + "kv sm");
                                Console.WriteLine("=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>");
                                Console.WriteLine();
                            }
                            else
                            {
                                Cyrcle cyrcle = new Cyrcle();
                                cyrcle.Name = "C1";
                                Console.WriteLine("Dairenin uzunlugu " + cyrcle.CalcLenght(r) + " sm");
                                Console.WriteLine("=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>");
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Zehmet olmasa ede  daxil edin");
                        }
                       

                    }
                    else if (choise == 0)
                    {
                        Console.WriteLine("Proqram sonlandirildi tesekkur edirik");
                    }
                    else
                    {
                        Console.WriteLine("Siz yalniz asagidaki secimleri ede bilersiniz");
                    }
                }
                else
                {
                    choise = 99;
                    Console.WriteLine("Secim duzdun edilmedi");
                    Console.WriteLine("=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>=>");
                    Console.WriteLine();
                }
            } while (choise!=0);
            
            
        }
    }
}
