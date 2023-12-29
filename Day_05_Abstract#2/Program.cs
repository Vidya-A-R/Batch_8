using System;

class MiconChecker
{
    public void CheckMicon(Micon micon)
    {
        Console.WriteLine(micon.Name());
    }   
}

abstract class Micon
{
    public abstract string Name();
}

class Arduino : Micon
{
    public override string Name()
    {
        return "Arduino Mega";
    }   
}

class ESP32 : Micon
{
    public override string Name()
    {
        return "ESP32 Nano";
    }
}

class Program
{
    static void Main()
    {
        MiconChecker checker = new MiconChecker();
        checker.CheckMicon(new Arduino());
        checker.CheckMicon(new ESP32()); // Jika Anda ingin mengecek ESP32 juga
    }
}
