namespace midtermbonus;
//Human player class 
class HumanPlayer {
        private int points; // the points that the human player has
        // constructor used to set human player’s initial points
        public HumanPlayer(int initial){
            points = initial;
        } 
        // return the points of human player
        public int GetPoints(){
            return points;
        } 
        // human player increase 5 points
        public void WinRound(){
            points = points + 5;
        } 
        // human player decrease 5 points
        public void LoseRound(){
            points = points - 5;
        }
        /*human player select a shape from Rock, Paper, or 
        scissors to compare with computer’s shape.*/
        public string HumanDecision(){
            //While loop will keep going until it returns a shape from the switch case.
            while(true){
                //asking for shape input.
                Console.WriteLine("Please input your choice: rock, paper or scissors.");
                //switch case argument will be the text input.
                switch(Console.ReadLine()?.ToLower()){
                    case "rock":
                        return "rock";
                    case "paper":
                        return "paper";
                    case "scissors":
                        return "scissors";
                    default:
                        //If none of the input text is correct it will break the switch case and loop it all again
                        Console.WriteLine("Your input was invalid, Try again.");
                        break;
                }
            }
        } 
    }
//This class is for the cpu
class ComputerPlayer {
//Each time this method is called it will randomly choose a different shape using the Random object to randomize what shape it is.
    public string ComputerDecision(){
        Random rnd = new Random();

        int rnd_num = rnd.Next(0,3);
        //assingning the numbers to a shape.
        switch(rnd_num){
            case 0:
                return "rock";
            case 1:
                return "paper";
            case 2:
                return "scissors";
            default:
                return "default";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        //Creating objects from the classes I made.
        //Human player requires an initial value, so I assigned 5 to it.
        HumanPlayer player = new HumanPlayer(5);
        ComputerPlayer cpu = new ComputerPlayer();
        //Just for whenever I need to break the loop at any point.
        bool loop = true;

        //This loop is the game loop.
        while(loop) {
            //Starting introductory text
            Console.WriteLine("****Rock Paper Scissors, Start!!****");
            //Printing out the current points held by the player object
            Console.WriteLine($"You have {player.GetPoints()} points.");

            //creating variables to remenber the decision made by the player and cpu
            string playerChoice = player.HumanDecision();
            string cpuChoice = cpu.ComputerDecision();
            //Printing out the cpu and player's decision
            Console.WriteLine($"--> Your Decision: {playerChoice}");
            Console.WriteLine($"--> Computer Decision: {cpuChoice}");

            //First if statement will check if both the cpu and player gave the same answer and it will print it out, earning the player no points.
            if(playerChoice == cpuChoice){
                Console.WriteLine("It's a Tie");
            }
            //If it is not a tie this if statement will check if it is a winning scenario for the player and print they won and add 5 points to their current points.
            else if(playerChoice == "rock" && cpuChoice == "scissors" || playerChoice == "paper" && cpuChoice == "rock" || playerChoice == "scissors" && cpuChoice == "paper") {
                player.WinRound();
                Console.WriteLine("You win!");
            }
            //If it is not a win this if statement will check if it is a losing scenario for the player and print they lost and subtract 5 points to their current points.
            else if(cpuChoice == "rock" && playerChoice == "scissors" || cpuChoice == "paper" && playerChoice == "rock" || cpuChoice == "scissors" && playerChoice == "paper") {
                player.LoseRound();
                Console.WriteLine("You Lose!");
            }
            //Check if the players has 0 zero points if it's true it will end the game.
            if(player.GetPoints() == 0){
                Console.WriteLine("Sorry, you don't have enough points, thanks for playing.\nThank you for playing!");
                loop = false;
            }else {
                //While loop to make sure the player enters a valid input.
                while (true) {
                    //Ask the player if they want to continue
                    Console.WriteLine("--> Play again? Input y to continue, or n to exit");
                    //Read answer input.
                    string? play = Console.ReadLine()?.ToLower();
                    if(play == "y"){
                        //continue the game loop
                        break;
                    }
                    else if(play == "n"){
                        //end game
                        loop = false;
                        break;
                    }else {
                        //if the player enters an incorrect input.
                        Console.WriteLine("Invalid input, Try again.");
                    }
                }
            }
        }
    }
}
