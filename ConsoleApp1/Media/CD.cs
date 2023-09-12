namespace ConsoleApp1;

public class CD : Media
{
    public string Artiste { get; set; }

    // Constructeur paramétré pour la classe CD
    public CD(string titre, int numeroReference, int nombreExemplairesDisponibles, string artiste)
        : base(titre, numeroReference, nombreExemplairesDisponibles)
    {
        Artiste = artiste;
    }
    
    public void AfficherInfos()
    {
        Console.WriteLine($"Type de média: CD");
        Console.WriteLine($"Titre: {Titre}");
        Console.WriteLine($"Numéro de référence: {NumeroReference}");
        Console.WriteLine($"Nombre d'exemplaires disponibles: {NombreExemplairesDisponibles}");
        Console.WriteLine($"Artiste: {Artiste}");
    }
}