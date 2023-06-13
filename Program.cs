const int mysteryNumber = 7;
var playerNumber = 0;
do
{
    Console.Write("Devinez le nombre entre 1 et 10 : ");
    playerNumber = int.Parse(Console.ReadLine());
    Console.WriteLine(playerNumber < mysteryNumber ? $"Le chiffre mystère est plus grand que {playerNumber}" : $"Le chiffre mystère est plus petit que {playerNumber}");   
} while (playerNumber != mysteryNumber);

Console.WriteLine("Bravo vous avez gagné !");