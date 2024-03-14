using System.Data;
using System.Security.Authentication;

class TicTacToe
{
    static int spieler = 1;
    static char[] feld = { '1', '2','3','4','5','6','7','8','9'};
    
    
    public static void Main(string[] args)
    {
        
        bool spielende = false;
        do
        {
            FeldZeichnen();
            Console.WriteLine($"Spieler {spieler} beginnt\n(1-9)");
            int choice = int.Parse(Console.ReadLine()) - 1; //die eingabe wird in einen Integer umgewandelt und 
            if (choice >= 0 && choice < 9 && feld[choice] != 'X' && feld[choice] != 'O') // eingabe muss zwischen 1 und 9 sein und das Feld darf nicht belegt sein mit 1 oder 2
            {
                if (spieler == 1)
                {
                    feld[choice] = 'X';

                }
                else
                {
                    feld[choice] = 'O';
                }
                spielende = Siegervermittlung();
                if (!spielende) // Spielerwechsel
                {
                    if (spieler == 1)
                    {
                        spieler = 2;
                    }
                    else
                    {
                        spieler = 1;
                    }
                }
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
            // horizontal
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

    }
}

