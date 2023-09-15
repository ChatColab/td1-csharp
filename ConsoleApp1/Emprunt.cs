namespace ConsoleApp1;

public class Emprunt
{
    public Media Media { get; set; }
    public string Utilisateur { get; set; }

    public Emprunt(Media media, string utilisateur)
    {
        Media = media;
        Utilisateur = utilisateur;
    }
}
