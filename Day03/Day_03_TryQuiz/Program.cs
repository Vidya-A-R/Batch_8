using System.Diagnostics;

class Car{
    public int price;
    public Car(int x){
        price = x;
    }
}

class Program{
    static void Main(){
        Car carA = new Car(3);
        //Oke jadi disini ternyata fungsi line dibawah adalah untuk mengambil
        //instance (?) not sure bahasa yang benar kaya gimana tapi ini bukan 
        //membuat instance baru tapi jadi instance yang sama
        Car carB = carA;
        carB.price = carB.price +2;
        Console.WriteLine(carA.price);
        Console.WriteLine(carB.price);
    }
}