using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Run
    {
        private University university;
        private Menu menu;

        public Run()
        {
            this.menu = new Menu(this.university);
        }
    }
}
