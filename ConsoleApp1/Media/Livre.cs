namespace ConsoleApp1;

public class Livre : Media
{
    public string Auteur { get; set; }

    // Constructeur paramétré pour la classe Livre
    public Livre(string titre, int numeroReference, int nombreExemplairesDisponibles, string auteur)
        : base(titre, numeroReference, nombreExemplairesDisponibles)
    {
        Auteur = auteur;
    }
    
    public void AfficherInfos()
    {
        Console.WriteLine($"Type de média: Livre");
        Console.WriteLine($"Titre: {Titre}");
        Console.WriteLine($"Numéro de référence: {NumeroReference}");
        Console.WriteLine($"Nombre d'exemplaires disponibles: {NombreExemplairesDisponibles}");
        Console.WriteLine($"Auteur: {Auteur}");
    }
}