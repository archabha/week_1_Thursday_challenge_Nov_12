using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace chalenge_1_console
{
    internal class programUI
    {
        private MenuItemRepo_menuItemRepo =' new MenuItemRepo'
        public void Run()
        {

            // Seed
            Seed();
            // Menu
            Menu();
        }

        private void Menu()
        {
            throw new NotImplementedException();
        }

        private void Seed()
        {
            throw new NotImplementedException();
        }

        // Main Menu
        private void programUIMenu()
        {
            do
            {
                // Display Menu
                Console.WriteLine("Select an option; \n" +
                    "1. View Menu\n" +
                    "2. Add a Menu Item\n" +
                    "3. Edit a Menu Item\n +" +
                    "4. Delate a Menu Item\n +" +
                    "5. Exit");

                // Get User Input
                string input = Console.ReadLine();

                // Read Input and Invoke Appropriate Method(s)
                switch (input)
                {

                }
            }
        }
    }
}
