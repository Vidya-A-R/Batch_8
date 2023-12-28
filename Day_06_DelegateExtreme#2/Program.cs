public delegate void MyDelegate(string message);
class GameController{
    public MyDelegate mySubscriber;
    //public GameController(){

    //}
    public void UpdateGameStatus(){
        string status = "game Running";
        mySubscriber(status);
    }
}
class SMS{
    public void SendSMS(string message){
        Console.WriteLine("SMS " + message);
    }
}
class API{
    public void InputDatabase(string message){
        Console.WriteLine("Database " + message);
    }

}

class Program{
    static void Main(){
        GameController game = new GameController();
        SMS sms = new SMS();
        API database = new API();

        game.mySubscriber = sms.SendSMS;
        game.mySubscriber += database.InputDatabase;
        game.UpdateGameStatus();
    }
}
