namespace Singleton;

public class Singleton
{
    private static Singleton _instance = null;
    public string mensaje = "";
    protected Singleton()
    {
        mensaje = "Hola mundo";
    }
    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }

}
