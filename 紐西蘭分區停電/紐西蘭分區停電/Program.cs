using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 紐西蘭分區停電
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] po = new int[17];
            int a = 0;
            foreach (int i in po)
            { po[i] = 0; }

            for (int i = 1; i <= 17; i++)
            {  //一共停17次，每次區域皆不一樣 

                Console.WriteLine(a + 1);
                po[a] = 1;
                if (a == 16) // 預防之後陣列爆索引值
                {
                    a = 0;
                }
                for (int x = 1; x <= 5; x++)
                {  //計算未停過的區域 
                    a = a + 1;

                    for (int y = 1; y <= 17; y++)
                    { //計算已停過電的區域 
                        while (po[a] == 1)
                        {
                            a = a + 1;
                            if (a > 16)//預防陣列索引爆掉
                            {
                                a = 0;
                            }
                        }
                        if (a == 16)
                        {
                            a = 0;
                            break;
                        }
                    }
                }
                if (a == 0) //剛好+5之後是 a=16的情況 會在上面被變成0 所以要先改回來才能存
                {
                    a = 16;
                }

            }
        }
    }
}
