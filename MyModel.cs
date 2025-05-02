namespace MauiApp1;

public class MyModel : IMyInterface
{
    public MyModel(){

    }

    public MyModel(string mystring){
        MyString = mystring;
    }
    
    public string MyString { get; set; } = "if you see this, the binding did NOT work";
}

public interface IMyInterface
{
    string MyString { get; set; }
}