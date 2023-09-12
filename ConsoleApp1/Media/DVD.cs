namespace ConsoleApp1;

public class DVD : Media
{
    public int Duree { get; set; }

    // Constructeur paramétré pour la classe DVD
    public DVD(string titre, int numeroReference, int nombreExemplairesDisponibles, int duree)
        : base(titre, numeroReference, nombreExemplairesDisponibles)
    {
        Duree = duree;
    }
    
    public void AfficherInfos()
    {
        Console.WriteLine($"Type de média: DVD");
        Console.WriteLine($"Titre: {Titre}");
        Console.WriteLine($"Numéro de référence: {NumeroReference}");
        Console.WriteLine($"Nombre d'exemplaires disponibles: {NombreExemplairesDisponibles}");
        Console.WriteLine($"Durée: {Duree} minutes");
    }
}