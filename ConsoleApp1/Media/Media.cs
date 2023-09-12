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
}