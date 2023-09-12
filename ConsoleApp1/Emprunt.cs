namespace ConsoleApp1;

public class Emprunt
{
    public Media MediaEmprunte { get; private set; }
    public Utilisateur UtilisateurEmprunteur { get; private set; }
    public DateTime DateEmprunt { get; private set; }

    public Emprunt(Media media, Utilisateur utilisateur)
    {
        MediaEmprunte = media;
        UtilisateurEmprunteur = utilisateur;
        DateEmprunt = DateTime.Now; // Date d'emprunt actuelle
    }
}
