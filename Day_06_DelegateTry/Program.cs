
using System.Security.Cryptography.X509Certificates;

public  delegate int MyDelegate(int x);
class Program 
{
	
	static void Main()
	{
		Gate gate = new Gate();
        Add add = new Add();
        Mul mul = new Mul();
        gate.myDel = add.AddThis;
        //gate.myDel = Add;
        //gate.myDel += Mul;
		
		int result2 = myDel.Invoke(4);
		Console.WriteLine();
		Console.WriteLine(gate.myDel += Mul);
	}

}
class Gate{
    public MyDelegate myDel;
    public void ThisGate(){
        int gate = 3;
        myDel(gate);
    }
    
}

class Add{
    	
    public int AddThis(int x)
	{
		return x + 4;
	}
}
class Mul{
    	
    public int MulThis(int x)
	{
		return x * 4;
	}
}



