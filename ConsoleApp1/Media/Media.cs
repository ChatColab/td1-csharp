namespace ConsoleApp1;

public class Media
{
    public string Titre { get; set; }
    public int NumeroReference { get; set; }
    public int NombreExemplairesDisponibles { get; set; }

    public Media()
    {
        Titre = string.Empty;
        NumeroReference = 0;
        NombreExemplairesDisponibles = 0;
    }

    public Media(string titre, int numeroReference, int nombreExemplairesDisponibles)
    {
        Titre = titre;
        NumeroReference = numeroReference;
        NombreExemplairesDisponibles = nombreExemplairesDisponibles;
    }

    public static Media operator +(Media media, int nombreAjout)
    {
        // Vérifiez que le nombre d'ajout est positif
        if (nombreAjout < 0)
        {
            throw new ArgumentException("Le nombre d'ajout doit être positif ou nul.");
        }

        // Mettez à jour le nombre d'exemplaires disponibles
        media.NombreExemplairesDisponibles += nombreAjout;

        return media;
    }

    public static Media operator -(Media media, int nombreRetrait)
    {
        // Vérifiez que le nombre de retrait est positif
        if (nombreRetrait < 0)
        {
            throw new ArgumentException("Le nombre de retrait doit être positif ou nul.");
        }

        // Vérifiez si le nombre de retrait est supérieur au nombre d'exemplaires disponibles
        if (nombreRetrait > media.NombreExemplairesDisponibles)
        {
            throw new InvalidOperationException(
                "Le nombre de retrait est supérieur au nombre d'exemplaires disponibles.");
        }

        // Mettez à jour le nombre d'exemplaires disponibles
        media.NombreExemplairesDisponibles -= nombreRetrait;

        return media;
    }

    // Méthode polymorphique pour afficher les informations spécifiques au média
    public virtual void AfficherInfos()
    {
        Console.WriteLine($"Titre: {Titre}");
        Console.WriteLine($"Numéro de référence: {NumeroReference}");
        Console.WriteLine($"Nombre d'exemplaires disponibles: {NombreExemplairesDisponibles}");
    }
}