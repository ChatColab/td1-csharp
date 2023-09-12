namespace ConsoleApp1;

public class Utilisateur
{
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public int NumeroAdherent { get; set; }

    public Utilisateur(string nom, string prenom, int numeroAdherent)
    {
        Nom = nom;
        Prenom = prenom;
        NumeroAdherent = numeroAdherent;
    }
}
