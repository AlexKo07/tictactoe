using System.Data;
using System.Security.Authentication;

class TicTacToe
{
    static int spieler = 1;
    static char[] feld = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };


    public static void Main(string[] args)
    {

        bool game = true;

        while (game)
        {
            TictacToeGame();
        }

    }





    static void FeldZeichnen()
    {


        //Spielfeld 

        Console.WriteLine(feld[0] + "|" + feld[1] + "|" + feld[2]);
        Console.WriteLine("-----");
        Console.WriteLine(feld[3] + "|" + feld[4] + "|" + feld[5]);
        Console.WriteLine("-----");
        Console.WriteLine(feld[6] + "|" + feld[7] + "|" + feld[8]);

    }
    static bool Siegervermittlung()
    {
        //horizontal
        if (feld[0] == feld[1] && feld[1] == feld[2])
        {
            return true;
        }
        else if (feld[3] == feld[4] && feld[4] == feld[5])
        {
            return true;
        }
        else if (feld[6] == feld[7] && feld[7] == feld[8])
        {
            return true;
        }
        // vertikal
        else if (feld[0] == feld[3] && feld[3] == feld[6])
        {
            return true;
        }
        else if (feld[1] == feld[4] && feld[4] == feld[7])
        {
            return true;
        }
        else if (feld[2] == feld[5] && feld[5] == feld[8])
        {
            return true;
        }
        // diagonal
        else if (feld[0] == feld[4] && feld[4] == feld[8])
        {
            return true;
        }
        else if (feld[2] == feld[5] && feld[5] == feld[8])
        {
            return true;
        }
        else if (feld[0] == '1' && feld[1] == '2' && feld[2] == '3' && feld[3] == '4' && feld[4] == '5' && feld[5] == '6' && feld[6] == '7' && feld[7] == '8' && feld[8] == '9')
        {
            Console.WriteLine("Unentschieden");
            Environment.Exit(0);

        }


        return false;



    }
    public static int Opponent_choice()
    {
        Random rnd = new Random();
        int aiChoice = rnd.Next(0, 9);
        return aiChoice;
    }
    public static void TictacToeGame()
    {
        
        bool spielende = false;
        do
        {
            FeldZeichnen();
            Console.WriteLine($"Du beginnst\n(1-9)");
            int choice = int.Parse(Console.ReadLine()) - 1; //die eingabe wird in einen Integer umgewandelt und verändert den Wert zu dem Wert. 
            if (choice >= 0 && choice < 9 && feld[choice] != 'X' && feld[choice] != 'O' && feld[Opponent_choice()] != 'X' && feld[Opponent_choice()] != 'O')  // eingabe muss zwischen 1 und 9 sein und das Feld darf nicht belegt sein mit 1 oder 2
            {
                feld[choice] = 'X';
                feld[Opponent_choice()] = 'O';
                spielende = Siegervermittlung();



            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte wählen Sie ein anderes Feld.");
            }

        }
        while (!spielende);
        {
            FeldZeichnen();
            Console.WriteLine($"Spieler {spieler} hat gewonnen");
            Environment.Exit(0);


          
        }
    }
}




















