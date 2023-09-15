namespace LibraryData;

public class CD : Media
{
    public string Artiste { get; set; }

    public CD(string titre, int numeroReference, int nombreExemplairesDisponibles, string artiste)
        : base(titre, numeroReference, nombreExemplairesDisponibles)
    {
        Artiste = artiste;
    }

    public override void AfficherInfos()
    {
        Console.WriteLine("Type de média : CD");
        base.AfficherInfos();
        Console.WriteLine($"Artiste: {Artiste}");
    }
}

