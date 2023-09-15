namespace ConsoleApp1;

public class Library
{
    private List<Media> mediaCollection;
    private List<Emprunt> emprunts;

    public Library()
    {
        mediaCollection = new List<Media>();
        emprunts = new List<Emprunt>();
    }

    public void AjouterMedia(Media media)
    {
        mediaCollection.Add(media);
    }

    public void RetirerMedia(Media media)
    {
        mediaCollection.Remove(media);
    }

    public void EmprunterMedia(Media media)
    {
        if (mediaCollection.Contains(media) && media.NombreExemplairesDisponibles > 0)
        {
            media.NombreExemplairesDisponibles--;
            Emprunt emprunt = new Emprunt(media);
            emprunts.Add(emprunt);
        }
        else
        {
            Console.WriteLine("Le média n'est pas disponible pour l'emprunt.");
        }
    }

    public void RetournerMedia(Media media)
    {
        Emprunt emprunt = emprunts.Find(e => e.Media == media);
        if (emprunt != null)
        {
            media.NombreExemplairesDisponibles++;
            emprunts.Remove(emprunt);
        }
        else
        {
            Console.WriteLine("Aucun enregistrement d'emprunt correspondant trouvé.");
        }
    }

    public List<Media> RechercherMedia(string critere)
    {
        List<Media> result = new List<Media>();
        foreach (Media media in mediaCollection)
        {
            if (media.Titre.Contains(critere) || (media is Livre livre && livre.Auteur.Contains(critere)))
            {
                result.Add(media);
            }
        }
        return result;
    }

    public void ListerEmprunts()
    {
        foreach (Emprunt emprunt in emprunts)
        {
            Console.WriteLine($"Emprunt de {emprunt.Media.Titre} par {emprunt.Media.Auteur} le {emprunt.DateEmprunt}");
        }
    }

    public void AfficherStatistiques()
    {
        int totalMedias = mediaCollection.Count;
        int exemplairesEmpruntes = emprunts.Count;
        int exemplairesDisponibles = mediaCollection.Sum(media => media.NombreExemplairesDisponibles);

        Console.WriteLine($"Nombre total de médias dans la bibliothèque : {totalMedias}");
        Console.WriteLine($"Nombre total d'exemplaires empruntés : {exemplairesEmpruntes}");
        Console.WriteLine($"Nombre total d'exemplaires disponibles : {exemplairesDisponibles}");
    }
}
