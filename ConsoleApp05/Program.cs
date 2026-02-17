using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp05
{
    internal class Program
    {
        //課題32-13
        //以下を挙列型で宣言し、foreachを使用してコンソールに出力してください。
        //「Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday」

        enum Days
        {
            Sunday = 0,
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6
        }
        class Sample
        {
            static void Main()
            {
                foreach (Days Value in Enum.GetValues(typeof(Days)))
                {
                    string name = Enum.GetName(typeof(Days), Value);

                    Console.WriteLine("{0}：{1}", name, (int)Value);
                }

                Console.ReadKey();

            }
        }
    }
}
