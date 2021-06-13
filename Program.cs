using System;

namespace My_inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many item");
            int itemnum = int.Parse(Console.ReadLine());
            string[] itemname = new string[itemnum];
            for (int i = 1; i <= itemname.Length; i++)
            {
                string name = Console.ReadLine();
                string typeitem = Console.ReadLine();
                string finditem = Console.ReadLine();
                if (finditem == "ShowAll")
                {
                    Console.WriteLine(name, typeitem);
                    return;
                }
                else if (finditem == typeitem)
                {
                    Console.WriteLine(name);
                }
                else
                {
                    Console.WriteLine("End");
                }
                Console.ReadKey();

            }
            
            


        }
        
            
        
        
    }
}
