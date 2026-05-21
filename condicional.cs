Console.WriteLine("Inserta tu edad:");
int edad = Convert.ToInt32(Console.ReadLine());
if (edad >= 18){
    Console.WriteLine("Eres mayor de edad.";
}
else{
    if (edad >= 12){
        Console.WriteLine("Eres Adolecente");
    }
    else{
        Console.WriteLine("Eres menor de edad.");
    }
}
