class Program
{
	static void Main()
	{
		Subscriber sub1 = new Subscriber();
		Subscriber sub2 = new Subscriber();
		
		Youtuber youtuber = new Youtuber();
		youtuber.AddSubscriber(sub1.GetNotification);
		youtuber.AddSubscriber(sub2.GetNotification);
		youtuber.UploadVideo();
	}
	
}

public delegate void MySubscriber(String message);
class Youtuber
{
    private event MySubscriber mySubscriber;
    public bool AddSubscriber(MySubscriber sub)
    {
        if (mySubscriber is null)
        {
            mySubscriber += sub;
            return true;
        }
        else if (mySubscriber.GetInvocationList().Contains(sub))
        {
            return false;
        }
        mySubscriber += sub;
        return true;
    }
    public void UploadVideo()
    {
        Console.WriteLine("Upload video");
        SendNotification("Video Baru lur");
    }
    public void SendNotification(string message)
    {
        mySubscriber.Invoke(message);
    }
}


class Subscriber
{
	public void GetNotification(string message)
	{
		Console.WriteLine("notification " + message);
	}
}