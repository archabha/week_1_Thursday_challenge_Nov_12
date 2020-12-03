using System;

namespace komodoInsurance
{
    internal class ProgramUI
    {
        private bool keepRunning;

        // Method that runs/starts the application
        internal void Run()
        {
            Menu();
        }
        // Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                // Display the options to the user
                Console.WriteLine("select a menu option:\n" +
                    "1. creat new Team\n" +
                    "2. view all Team\n"_ +
                    "3. view Team by Title\n" +
                    "4. update Existing Team\n" +
                    "5. Delate Existing Team\n" +
                    "6. Exit");

                // Get the user's input
                string input = Console.ReadLine();
                // Evaluate the user's input act accordingly
                switch (input)
                {
                    case "1":
                        // Create new Team
                        CreatNewTeam();
                        break;
                    case "2":
                        // View All Team
                        displayAllTeam();
                        break;
                    case "3":
                        // View Team By Title
                        DisplayTeamBytitle();
                        break;
                    case "4":
                        // Update Existing Team
                        UpdateExistingTeam();
                        break;
                    case "5":
                        // Delate Existing Team
                        DelateExistingTeam();
                        break;
                    case "6":
                        // Exit
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;

                }
            }
        }
        // creat new DeveloperRepo
        private void CreatNewTeam()
        {
            DeveloperRepo newTeam = new DeveloperRepo();
            //Title
            Console Writeline("Enter the title for the Team:");
            NewTeam Title = Console Readline();
            // Description
            Console WriteLine("Enter the description for the Team:");
            newTeam Description = Console ReadLine();
            //Maturity Rating

            //Star Rating

            //IsFamilyFriendly

            //GenreType

        }

        private void Readline()
        {
            throw new NotImplementedException();
        }

        // view current DeveloperRepo that is saved
        private void displayAllTeam()
        {

        }
        // view existing Team by Title
        private void DisplayTeamBytitle()
        {

        }
        // Update Existing Team
        private void UpdateExistingTeam()
        {

        }
        // Delate Existing Team
        private void DelateExistingTeam()
        {

        }
    }
}