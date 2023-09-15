namespace LibraryData;
public class Livre : Media
{
    public string Auteur { get; set; }

    public Livre(string titre, int numeroReference, int nombreExemplairesDisponibles, string auteur)
        : base(titre, numeroReference, nombreExemplairesDisponibles)
    {
        Auteur = auteur;
    }

    public override void AfficherInfos()
    {
        Console.WriteLine("Type de média : Livre");
        base.AfficherInfos();
        Console.WriteLine($"Auteur: {Auteur}");
    }
}
