using LibraryData;

namespace Library;

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

    public void AfficherMedias()
    {
        Console.WriteLine("Médias dans la bibliothèque :");
        foreach (var media in mediaCollection)
        {
            Console.WriteLine(media.Titre);
        }
    }
    
    public Media this[int numeroReference]
    {
        get
        {
            return mediaCollection.Find(media => media.NumeroReference == numeroReference);
        }
    }

    public void EmprunterMedia(Media media, string utilisateur)
    {
        if (media.NombreExemplairesDisponibles > 0)
        {
            media.NombreExemplairesDisponibles--;
            Emprunt emprunt = new Emprunt ( media, utilisateur );
            emprunts.Add(emprunt);
            Console.WriteLine($"Le média '{media.Titre}' a été emprunté par {utilisateur}.");
        }
        else
        {
            Console.WriteLine($"Le média '{media.Titre}' n'est pas disponible.");
        }
    }

    public void RetournerMedia(Media media, string utilisateur)
    {
        Emprunt emprunt = emprunts.Find(e => e.Media == media && e.Utilisateur == utilisateur);
        if (emprunt != null)
        {
            media.NombreExemplairesDisponibles++;
            emprunts.Remove(emprunt);
            Console.WriteLine($"Le média '{media.Titre}' a été retourné par {utilisateur}.");
        }
        else
        {
            Console.WriteLine($"Le média '{media.Titre}' n'a pas été emprunté par {utilisateur}.");
        }
    }
    
    public void RechercherMedia(string critere)
    {
        var resultats = mediaCollection.Where(media => 
            media.Titre.Contains(critere) || 
            (media is Livre livre && livre.Auteur.Contains(critere))
        ).ToList();
            
        if (resultats.Any())
        {
            Console.WriteLine($"Médias trouvés pour le critère '{critere}':");
            foreach (var media in resultats)
            {
                media.AfficherInfos();
            }
        }
        else
        {
            Console.WriteLine($"Aucun média trouvé pour le critère '{critere}'.");
        }
    }
        
    public void ListerMediasEmpruntes(string utilisateur)
    {
        var empruntsUtilisateur = emprunts.Where(e => e.Utilisateur == utilisateur).ToList();
            
        if (empruntsUtilisateur.Any())
        {
            Console.WriteLine($"Médias empruntés par {utilisateur}:");
            foreach (var emprunt in empruntsUtilisateur)
            {
                Console.WriteLine(emprunt.Media.Titre);
            }
        }
        else
        {
            Console.WriteLine($"{utilisateur} n'a emprunté aucun média.");
        }
    }
        
    public void AfficherStatistiques()
    {
        int totalMedias = mediaCollection.Count;
        int totalExemplaires = mediaCollection.Sum(m => m.NombreExemplairesDisponibles);
        int totalEmpruntes = emprunts.Count;

        Console.WriteLine("Statistiques de la bibliothèque:");
        Console.WriteLine($"Nombre total de médias: {totalMedias}");
        Console.WriteLine($"Nombre total d'exemplaires disponibles: {totalExemplaires}");
        Console.WriteLine($"Nombre total d'exemplaires empruntés: {totalEmpruntes}");
    }
}
