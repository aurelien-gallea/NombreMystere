Console.Write("Entrez votre prénom : ");
string? name = Console.ReadLine();
int count = 0;

void play() {

    Random randNumber = new Random();
    int mysteryNumber = randNumber.Next(1,11); //Génère un entier compris entre 1 et 10
    int? playerNumber = 0;

    do
    {
        Console.Write("------------------- Devinez le nombre entre 1 et 10 : ");
        
        try{

            playerNumber = int.Parse(Console.ReadLine());
            count++;

            if (playerNumber < mysteryNumber) {
                        Console.WriteLine($"Le chiffre mystère est plus grand que {playerNumber}");
                    } else if (playerNumber > mysteryNumber) {
                        Console.WriteLine($"Le chiffre mystère est plus petit que {playerNumber}");   
                    } else {
                        Console.WriteLine($"Bravo \"{name}\" vous avez gagné en {count} coup(s) !");
                    }
        } catch {
            Console.WriteLine("Entrez un Nombre entre 1 et 10 !");
        }
    
    } while (playerNumber != mysteryNumber);

    Console.Write("Voulez-vous rejouer ? o / n : ");
    var again = Console.ReadLine();
    
    if (again != "n" && again != "o") {
        Console.WriteLine("Appuyez sur \"o\" pour continuer ou \"n\" pour mettre fin à la partie : ");
        again = Console.ReadLine();
    } 
    else if (again == "o") {
        count = 0;
        play();
    } else {
        Console.WriteLine("Partie Terminé !");
    }
}

play();
