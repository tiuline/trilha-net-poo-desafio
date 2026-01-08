using DesafioPOO.Models;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokia android = new Nokia("(48)98419-0863", "Tijolão", "sei la", 4);

            android.InstalarAplicativo("Chrome");

            
            Iphone iponei = new Iphone("(48)98419-0863", "Iphone 9000", "sei la", 9999);

            iponei.InstalarAplicativo("I'm rich");
        }
    }
}
