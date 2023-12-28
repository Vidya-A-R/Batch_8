using System.Reflection.Metadata.Ecma335;

class Program
{
	//start
	static void Main()
	{
		//membuat instance baru untuk sunscriber
		
		Subscriber sub1 = new Subscriber();
		Subscriber sub2 = new Subscriber();
		
		//membuat instance baru untuk youtuber dan vlogger
		
		Youtuber youtuber = new Youtuber("enal ");
		Youtuber youtuber2 = new Youtuber("Hashim ");
		Vlogger vlogger = new Vlogger("adit ");
		Vlogger vlogger2 = new Vlogger("maulana ");
		
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
	public EventHandler<MyEventArgs> mySubscriber;
	
	public void UploadVideo()
	{
		Console.WriteLine("Upload video ");
		SendNotification("Video Baru lur ");
	}
	public void SendNotification(string message)
	{
		mySubscriber?.Invoke(this + message,new  MyEventArgs(){data = "joss"});
	}
	public override string ToString()
	{
		return Name;
	}
}

class Vlogger
{
	public string Name;
	public Vlogger(string name)
	{
		Name = name;
	}
	public EventHandler<MyEventArgs> mySubscriber;
	
	public void UploadVideo()
	{
		Console.WriteLine("Upload video nich ");
		SendNotification("Video anyar slur ");
	}
	public void SendNotification(string message)
	{
		mySubscriber?.Invoke(this + message, new MyEventArgs(){data2 = "well"});
	}
	public override string ToString()
	{
		return Name;
	}
}

class Subscriber
{
	public void GetNotification(object sender, MyEventArgs e)
	{
		Console.WriteLine("notification " + sender + e.data + e.data2);
	}
}

class MyEventArgs : EventArgs
{
	public string data;
	public string data2;
	
}