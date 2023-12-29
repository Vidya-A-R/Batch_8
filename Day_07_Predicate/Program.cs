class Program
{
    static void Main()
    {
        Subscriber sub1 = new Subscriber();
        Subscriber sub2 = new Subscriber();

        Youtuber youtuber = new Youtuber("Enal", sub1.ShouldReceiveNotification);
        Youtuber youtuber2 = new Youtuber("Hashim", sub2.ShouldReceiveNotification);
        Vlogger vlogger = new Vlogger("Adit", sub1.ShouldReceiveNotification);
        Vlogger vlogger2 = new Vlogger("Maulana", sub2.ShouldReceiveNotification);

        youtuber.UploadVideo("Video baru lur");
        youtuber2.UploadVideo("video baru bre");
        vlogger.UploadVideo("Vlog baru nich");
        vlogger2.UploadVideo("Jangan lewatkan vlog terbaru");
    }
}

class Youtuber
{
    public string Name;
    private Predicate<string> shouldNotify;

    public Youtuber(string name, Predicate<string> shouldNotify)
    {
        Name = name;
        this.shouldNotify = shouldNotify;
    }

    public void UploadVideo(string message)
    {
        Console.WriteLine($"{Name} uploaded: {message}");
        if (shouldNotify(message))
        {
            Console.WriteLine($"Sending notification: {message}");
        }
    }
}

class Vlogger
{
    public string Name;
    private Predicate<string> shouldNotify;

    public Vlogger(string name, Predicate<string> shouldNotify)
    {
        Name = name;
        this.shouldNotify = shouldNotify;
    }

    public void UploadVideo(string message)
    {
        Console.WriteLine($"{Name} uploaded: {message}");
        if (shouldNotify(message))
        {
            Console.WriteLine($"Sending notification: {message}");
        }
    }
}

class Subscriber
{
    public bool ShouldReceiveNotification(string message)
    {
        // Kriteria untuk menerima notifikasi
        return message.Contains("baru"); // Contoh: hanya jika pesan mengandung kata 'baru'
    }
}
