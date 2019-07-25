using System;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool go = true;
            bool validResponse = false;
            string response = "";
            double input = 0;
            int counter = 0;

            //start running the program
            //mark the beginning to return to if the user so chooses
            while (go)
            {
                //increase the counter by 1 for each time the loop is run
                counter++;
                //set validResponse to false so we can enter our loop
                validResponse = false;
                while (!validResponse)
                {
                    //get a fresh screen
                    Console.Clear();
                    //ask for user input and set it to response
                    response = GetUserInput("Enter the Radius of a circle. Please only use numbers. Feel free to use decimals.");
                    //verify the response is a double. If it's not, refresh the screen and ask for another response
                    validResponse = Validator.Double(response);
                }
                //create a new circle
                Circle circle = new Circle();
                //set input equal to the respose converted to a double.
                input = double.Parse(response);
                //set the circle's radius to the input
                circle.Radius = input;

                //call the methods to do math and print the result
                Console.WriteLine($"A circle with the radius of {input} has the" +
                    $"circumference of {circle.CalculateFormattedCircumference()} and the area of {circle.CalculateFormattedArea()}.");

                //ask the user if they want to run again.
                response = GetUserInput("would you like to run again?");
                //set validresponse to false so we can enter our loop
                validResponse = false;
                while (!validResponse)
                {
                    //validate our input to make sure it's a yes or a no
                    validResponse = Validator.YesNo(response);
                    //if a yes or no is returned, it's a valid response.
                    if (validResponse)
                    {
                        //if they return yes, go again.
                        if (response == "yes" || response == "y")
                        {
                            go = true;
                        }
                        //if they return no, stop.
                        else
                        {
                            go = false;
                        }
                    }
                    //if neither a yes or no is returned, prompt the user for a yes or no again.
                    else
                    {
                        validResponse = false;
                        response = GetUserInput("that was a yes or no question. Try again.");
                    }
                }
                Console.WriteLine($"thanks for running with me. We mathed out {counter} circles.");
            }
        }
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }
}
