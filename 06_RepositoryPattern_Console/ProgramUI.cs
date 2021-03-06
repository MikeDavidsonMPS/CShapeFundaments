﻿using _06_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Console
{
    class ProgramUI
    {
        private StreamingContentRepository _contentRepo = new StreamingContentRepository();

        //Method that runs/starts the application
        public void Run()
        {
            SeedContentList();
            Menu();
        }

        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display our option to the user
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Exisitng Content\n" +
                    "5. Delete Exisitng Content\n" +
                    "6. Exit");

                //Get the users input
                string input = Console.ReadLine();

                //Evaluste the user's input and act accordingly
                switch (input)
                {
                    case "1":
                        //Create new content
                        CreateNewContent();
                        break;
                    case "2":
                        // View All Content
                        DisplayAllContent();
                        break;
                    case "3":
                        //View Content
                        DisplayContentByTitle();
                        break;
                    case "4":
                        //Update Existing Content
                        UpdateExistingContent();
                        break;
                    case "5":
                        // Delete Existing
                        DeleteExisitngContent();
                        break;
                    case "6":
                        // Exit
                        Console.WriteLine("Goodbye");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }

                Console.WriteLine("Please press any key to continue");
                Console.ReadLine();
                Console.Clear();
            }
        }

        // Create new StreamingContent
        private void CreateNewContent()
        {
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("Enter the Title for the content");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description for the content:");
            newContent.Description = Console.ReadLine();

            //Maturity Rating
            Console.WriteLine("Enter the rating for the content (G, PG, PG-13, ect):");
            newContent.MaturityRating = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter the star count for the content (5.8, a0, 1.5, ect):");
            string starAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starAsString);

            //IsFamilyFriendly
            Console.WriteLine("Is this Content famliy friendly?");
            string familyFriendlyString = Console.ReadLine().ToLower();

            if(familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }

            //GenreType
            Console.WriteLine("Enter the Genre Number:\n" +
                "1. Horror\n" +
                "2. ROmCom\n" +
                "3. Scfi\n" +
                "4. Documentary\n" +
                "5. Bromance\n" +
                "6. Drama\n" +
                "7. Action");

            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            _contentRepo.AddContentToList(newContent);
        }

        //View Current StreamingContent that is saved
        private void DisplayAllContent()
        {
            Console.Clear();

            List<StreamingContent> listOfContent = _contentRepo.GetContentList();

            foreach (StreamingContent content in listOfContent)
            {
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Description: {content.Description}";

            }

        //View existing Content by title
        private void DisplayContentByTitle()
        {
                Console.Clear();
                //Prompt the user to give me a title
                Console.WriteLine("Enter the title of the content you'd like to see:");

                // get the user's input
                string title = Console.ReadLine();

                //Find the content by that title
                StreamingContent content = _contentRepo.GetContentByTitle(title);

                // display said content if it isn't null
                if(content != null)
                {
                    Console.WriteLine($"Title: {content.Title}\n" +
                        $"Description: {content.Description}\n" +
                        $"Maturity Rating: {content.MaturityRating}\n" +
                        $"Stars: {content.StarRating}\n" +
                        $"Is Family Friendly: {content.IsFamilyFriendly}\n" +
                        $"Genre: {content.TypeOfGenre}");
                }
                else
                {
                    Console.WriteLine("No content by that ");
                }
        }

        //Update existing Content
        private void UpdateExistingContent()
        {

        }
        //Delete Exisitng Content
        private void DeleteExisitngContent()
        {
               
                DisplayAllContent();

                // get the title they want to remove
                Console.WriteLine("Enter the title of the content you'd like to remove:");

                string input = Console.ReadLine();

                // Call the delete method
                bool wasDeleted = _contentRepo.RemoveContentFromList(input);

                // If the content was deleted, say so
                if (wasDeleted)
                {
                    Console.WriteLine("The content was successfully deleted.");
                }
                else
                {
                    Console.WriteLine("The content could not be deleted.");
                }

                // Otherwise state it could not be deleted


        }

        //See method
        private void SeedContentList()
        {
                StreamingContent sharknado = new StreamingContent("Sharknado", "Tornados, but with sharks.", "TV-14", 3.3, true, GenreType.Action);
                StreamingContent theRoom = new StreamingContent("The Room", "banker's life gets turned upside down.", "R", 3.7, false, GenreType.Drama);
                StreamingContent rubber = new StreamingContent("Rubber", "Car tire comes to life and goes on killing spree.", "R", 5.8, false, GenreType.Documentary);

                _contentRepo.AddContentToList(sharknado);
                _contentRepo.AddContentToList(theRoom);
                _contentRepo.AddContentToList(rubber);

        }

    }
}
