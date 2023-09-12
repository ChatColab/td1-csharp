namespace ConsoleApp1;

public class Library
{
    private List<Media> mediaCollection;

    public Library()
    {
        mediaCollection = new List<Media>();
    }
    
    public Library(List<Media> mediaCollection)
    {
        this.mediaCollection = mediaCollection;
    }

    public void AddMedia(Media media)
    {
        mediaCollection.Add(media);
    }

    public void RemoveMedia(Media media)
    {
        mediaCollection.Remove(media);
    }

    public List<Media> GetAllMedia()
    {
        return mediaCollection;
    }

    public Media this[int numeroReference]
    {
        get
        {
            Media media = mediaCollection.Find(m => m.NumeroReference == numeroReference);
            if (media == null)
            {
                throw new InvalidOperationException($"Aucun média trouvé avec le numéro de référence {numeroReference}");
            }
            return media;
        }
    }
}