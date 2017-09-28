using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Menu
    {
        private University university;

        public Menu(University university)
        {
            this.university = university;
            this.showMenu();
            this.getMenu();
        }

        private void showMenu()
        {
            Console.WriteLine("Select the desired action: ");
            Console.WriteLine("1. Сalculate the average score on the subject");
            Console.WriteLine("2. Сalculate the average student score");
            Console.WriteLine("3. Сalculate the average group score");
            Console.WriteLine("4. Сalculate the average faculty score");
            Console.WriteLine("5. Сalculate the average university score");

        }

        private void getMenu()
        {
            String str = Console.ReadLine();
            switch (str)
            {
                case "1":
                    Console.WriteLine("ok1");
                    break;
                case "2":
                    Console.WriteLine("ok2");
                    break;
                case "3":
                    break;
                
            }
        }


    }
}
