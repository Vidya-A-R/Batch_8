class Program
{
    static void Main()
    {
        Subscriber sub1 = new Subscriber();
        Subscriber sub2 = new Subscriber();

        Youtuber youtuber = new Youtuber("Enal");
        Youtuber youtuber2 = new Youtuber("Hashim");
        Vlogger vlogger = new Vlogger("Adit");
        Vlogger vlogger2 = new Vlogger("Maulana");

        youtuber.mySubscriber += sub1.GetNotification;
        youtuber2.mySubscriber += sub2.GetNotification;
        vlogger.mySubscriber += sub1.GetNotification;
        vlogger2.mySubscriber += sub2.GetNotification;

        youtuber.UploadVideo();
        youtuber2.UploadVideo();
        vlogger.UploadVideo();
        vlogger2.UploadVideo();
    }
}

class Youtuber
{
    public string Name;
    public Youtuber(string name)
    {
        Name = name;
    }
    public Func<string, string> mySubscriber;

    public void UploadVideo()
    {
        Console.WriteLine("Upload video");
        var response = SendNotification("Video Baru lur");
        Console.WriteLine(response);
    }

    public string SendNotification(string message)
    {
        return mySubscriber?.Invoke(Name + ": " + message);
    }
}

class Vlogger
{
    public string Name;
    public Vlogger(string name)
    {
        Name = name;
    }
    public Func<string, string> mySubscriber;

    public void UploadVideo()
    {
        Console.WriteLine("Upload video nich");
        var response = SendNotification("Video anyar slur");
        Console.WriteLine(response);
    }

    public string SendNotification(string message)
    {
        return mySubscriber?.Invoke(Name + ": " + message);
    }
}

class Subscriber
{
    public string GetNotification(string message)
    {
        //Console.WriteLine("Received Notification: " + message);
        return "Received Notification: " + message;
    }
}
