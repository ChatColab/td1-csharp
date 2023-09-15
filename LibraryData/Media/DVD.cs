namespace LibraryData;

public class DVD : Media
{
    public int Duree { get; set; }

    public DVD(string titre, int numeroReference, int nombreExemplairesDisponibles, int duree)
        : base(titre, numeroReference, nombreExemplairesDisponibles)
    {
        Duree = duree;
    }

    public override void AfficherInfos()
    {
        Console.WriteLine("Type de média : DVD");
        base.AfficherInfos();
        Console.WriteLine($"Durée: {Duree} minutes");
    }
}

