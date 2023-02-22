namespace Cs_Conf2;
class ChatBot
{
    public static string? text;
    static bool VStart(params string[] txt){
        for (int i = 0; i < txt.Length; i++)
        {
            if (text.ToLower().StartsWith(txt[i]))
            return true;
        }
        return false;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Write a text");

        while(true){

        text = Console.ReadLine();
        if (text.Contains("+") || text.Contains("-") && text.Any(char.IsDigit)){
        Console.WriteLine("Si quieres soy un  calculadora vale, pero no hoy gracias"); Console.WriteLine("Bye"); return;}

        if (VStart("hola","que bola", "que vuelta", "aloh"))
        Console.WriteLine("Hola que tal estas ");
        
        else if (VStart("me gusta el tomate","me gusta el limon","me gustan las zanahorias","me gusta la remolacha"))
        Console.WriteLine("Y te gusta el arroz con pollo?");
        
        else if (VStart("bien "))
        Console.WriteLine("Que guay que estes bien, yo de lujo siendo tu asistente xd");

        else if (VStart("si me gusta "))
        Console.WriteLine("Oh que guay, comamos");

        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        else
        Console.WriteLine("Bye");



        }






        Console.ReadKey();
    
    }
}

