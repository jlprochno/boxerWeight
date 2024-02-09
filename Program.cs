namespace boxerWeight;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Olá, por gentileza digite o peso do boxeador: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        if(weight <= 50){
            System.Console.WriteLine("Peso Palha");
        }
        else if(weight < 60){
            System.Console.WriteLine("Peso Pluma");
        }
        else if(weight < 76){
            Console.WriteLine("Peso Leve");
        }
        else if(weight < 88){
           Console.WriteLine("Peso Pesado");
        }
        else{
            Console.WriteLine("Peso Super Pesado");
        }
    }
}




    