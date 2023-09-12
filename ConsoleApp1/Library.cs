namespace ConsoleApp1;

public class Library
{
    private List<Media> mediaCollection;
    private List<Emprunt> emprunts;

    public Library()
    {
        // Initialisez la collection de médias et la liste d'emprunts dans le constructeur
        mediaCollection = new List<Media>();
        emprunts = new List<Emprunt>();
    }

    // Méthode pour ajouter un média à la bibliothèque
    public void AjouterMedia(Media media)
    {
        mediaCollection.Add(media);
    }

    // Méthode pour retirer un média de la bibliothèque
    public void RetirerMedia(Media media)
    {
        mediaCollection.Remove(media);
    }

    // Méthode pour emprunter un média de la bibliothèque
    public void EmprunterMedia(Media media, Utilisateur utilisateur)
    {
        if (mediaCollection.Contains(media) && media.NombreExemplairesDisponibles > 0)
        {
            media.NombreExemplairesDisponibles--;
            emprunts.Add(new Emprunt(media, utilisateur));
        }
        else
        {
            Console.WriteLine("Le média n'est pas disponible pour l'emprunt.");
        }
    }

    // Méthode pour retourner un média emprunté à la bibliothèque
    public void RetournerMedia(Media media, Utilisateur utilisateur)
    {
        Emprunt emprunt = emprunts.Find(e => e.Media == media && e.Utilisateur == utilisateur);
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

    // Méthode pour rechercher des médias par titre ou auteur
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

    // Méthode pour lister les médias empruntés par un utilisateur spécifique
    public List<Emprunt> ListerEmprunts(Utilisateur utilisateur)
    {
        return emprunts.FindAll(e => e.Utilisateur == utilisateur);
    }

    // Méthode pour afficher les statistiques de la bibliothèque
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