// See https://aka.ms/new-console-template for more information
using ExceptionTeste23;

Console.WriteLine("Test af exceptions!");


//try
//{

//    Console.WriteLine("Indtast tal1 (i intervallet fra 0 til 100)");
//    int tal1 = int.Parse(Console.ReadLine());
//    if (tal1 < 0 || tal1 > 100)
//        throw new NotInRangeException("Tallet skal være i intervallet fra 0 til 100");

//    Console.WriteLine("Indtast tal2");
//    int tal2 = int.Parse(Console.ReadLine());

//    int result = tal1 / tal2;

//    Console.WriteLine($"Resultatet er {result}");
//}
//catch (DivideByZeroException dex)
//{
//    Console.WriteLine($"Divison med o er ikke muligt!!!!");
//}
//catch(FormatException fex)
//{
//    Console.WriteLine($"Ulovligt input - {fex.Message}!!!!");
//}
//catch (OverflowException oex)
//{
//    Console.WriteLine($"Tallet er for stort - {oex.Message}!!!!");
//}
//catch(NotInRangeException nex)
//{
//    Console.WriteLine($"Tallet er ikke i intervallet - {nex.Message}!!!!");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Der skete en generel fejl {ex.Message}");
//}
//finally
//{
//    Console.WriteLine("Bliver altid udført");
//}

try
{
    //indtastning
    Car c = new Car("121212", "Toyota", 2023);
}
catch(ArgumentException aex)
{
    Console.WriteLine($"Fejl {aex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine("generel fejl");
}



Console.WriteLine("Her slutter programmet");

