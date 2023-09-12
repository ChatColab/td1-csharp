namespace ConsoleApp1;

public class Media
{
    public string Titre { get; set; }
    public int NumeroReference { get; set; }
    public int NombreExemplairesDisponibles { get; set; }

    public Media()
    {
        Titre = "Titre par défaut";
        NumeroReference = 0;
        NombreExemplairesDisponibles = 0;
    }

    public Media(string titre, int numeroReference, int nombreExemplairesDisponibles)
    {
        Titre = titre;
        NumeroReference = numeroReference;
        NombreExemplairesDisponibles = nombreExemplairesDisponibles;
    }
    
    public static Media operator +(Media media, int exemplairesAjoutes)
    {
        if (exemplairesAjoutes > 0)
        {
            media.NombreExemplairesDisponibles += exemplairesAjoutes;
        }
        else
        {
            Console.WriteLine("Erreur : Le nombre d'exemplaires ajoutés doit être positif.");
        }

        return media;
    }
    
    public static Media operator -(Media media, int exemplairesRetires)
    {
        // Vérifiez si le nombre d'exemplaires retirés est positif
        if (exemplairesRetires > 0)
        {
            // Vérifiez si le nombre d'exemplaires disponibles est suffisant
            if (media.NombreExemplairesDisponibles >= exemplairesRetires)
            {
                media.NombreExemplairesDisponibles -= exemplairesRetires;
            }
            else
            {
                throw new InvalidOperationException("Le nombre d'exemplaires disponibles est insuffisant.");
            }
        }
        else
        {
            throw new InvalidOperationException("Le nombre d'exemplaires retirés doit être positif.");
        }

        return media;
    }
}