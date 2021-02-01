using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Map
    {
        public string[,] mapMat = new string[3, 5];
        public Map()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 1 || j == 3)
                    {
                        mapMat[i,j] = "|";
                    }
                    else
                    {
                        mapMat[i, j] = " ";
                    }
                }
            }
        }
        public Boolean hamle(int count , string X)
        {
            int temp = 1;
            for (int i=0; i<3; i++)
            {
                for(int j=0; j<5; j++)
                {
                    if(j==1 || j == 3)
                    {

                    }
                    else if (temp == count)
                    {
                        if(mapMat[i,j]==" ")
                        {
                            mapMat[i, j] = X;
                            temp = -100;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        temp++;
                    }
                }
            }
            return false;
        }
        public string printMap()
        {
            string str ="";
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<5; j++)
                {
                    str += mapMat[i, j];
                }
                str += "\n";
            }
            Console.WriteLine(str);
            return str;
        }

        public string[,] final()
        {
            string str = "";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    str += mapMat[i, j];
                }
                str += "\n";
            }
            return mapMat;
        }
    }
}
