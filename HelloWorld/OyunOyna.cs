using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class OyunOyna
    {
        Map map = new Map();
        public OyunOyna()
        {
            

        }
        public void oyna(Boolean gameEnd)
        {
            int temp = 0;
            map.printMap();
            while (gameEnd == false)
            {
                int deger;
                if (temp%2 == 0) {
                    Console.WriteLine("Sıra sizde : O");
                    Console.WriteLine("1 ve 9 numaralı boşluklardan birini seçiniz : ");
                    deger = Convert.ToInt32(Console.ReadLine());
                    if (map.hamle(deger, "O")==true)
                    {
                        Console.Clear();
                        map.printMap();
                        gameEnd = gameCheck("O");
                    }
                    else
                    {
                        while (!map.hamle(deger, "O"))
                        {
                            Console.WriteLine("Bu indisdeki alan dolu veya yanlış içerik girdiniz. Lütfen tekrar sayı seçiniz.");
                            deger = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Clear();
                        map.printMap();
                        gameEnd = gameCheck("O");
                    }
                   
                    
                } 
                else
                {
                    Console.WriteLine("Sıra sizde : X");
                    Console.WriteLine("1 ve 9 numaralı boşluklardan birini seçiniz : ");
                    deger = Convert.ToInt32(Console.ReadLine());
                    if (map.hamle(deger, "X") == true)
                    {
                        Console.Clear();
                        map.printMap();
                        gameEnd = gameCheck("X");
                    }
                    else
                    {
                        while (!map.hamle(deger, "X"))
                        {
                            Console.WriteLine("Bu indisdeki alan dolu veya yanlış içerik girdiniz. Lütfen tekrar sayı seçiniz.");
                            deger = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.Clear();
                        map.printMap();
                        gameEnd = gameCheck("X");
                    }
                }
                temp++;
            }
        }

        public Boolean gameCheck(string str)
        {
            string[,] check;
            check =map.final();
            if(check[0,0] == str && check[0,2]==str && check[0, 4] == str)
            {
                Console.WriteLine("You win : " + str);
                return true;
            }
            else if(check[1, 0] == str && check[1, 2] == str && check[1, 4] == str)
            {
                Console.WriteLine("You win : " + str);
                return true;
            }
            else if (check[2, 0] == str && check[2, 2] == str && check[2, 4] == str)
            {
                Console.WriteLine("You win : " + str);
                return true;
            }
            else if (check[0, 0] == str && check[1, 0] == str && check[2, 0] == str)
            {
                Console.WriteLine("You win : " + str);
                return true;
            }
            else if (check[0, 2] == str && check[1, 2] == str && check[2, 2] == str)
            {
                Console.WriteLine("You win : " + str);
                return true;
            }
            else if (check[0, 4] == str && check[1, 4] == str && check[2, 4] == str)
            {
                Console.WriteLine("You win : " + str);
                return true;
            }
            else if (check[0, 0] == str && check[1, 2] == str && check[2, 4] == str)
            {
                Console.WriteLine("You win : " + str);
                return true;
            }
            else if (check[0, 4] == str && check[1, 2] == str && check[2, 0] == str)
            {
                Console.WriteLine("You win : " + str);
                return true;
            }
            int temp = 0;
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<5; j++)
                {
                    if(check[i,j]==" ")
                    {
                        temp++;
                    }
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("Round draw!!");
                return true;
            }
            
            return false;
            
        }

    }
}
