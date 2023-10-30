// See https://aka.ms/new-console-template for more information
Console.WriteLine("Test af exceptions!");


try
{
    Console.WriteLine("Indtast tal1");
    int tal1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Indtast tal2");
    int tal2 = int.Parse(Console.ReadLine());

    int result = tal1 / tal2;

    Console.WriteLine($"Resultatet er {result}");
}
catch (DivideByZeroException dex)
{
    Console.WriteLine($"Divison med o er ikke muligt!!!!");
}
catch(FormatException fex)
{
    Console.WriteLine($"Ulovligt input - {fex.Message}!!!!");
}
catch (OverflowException oex)
{
    Console.WriteLine($"Tallet er for stort - {oex.Message}!!!!");
}
catch (Exception ex)
{
    Console.WriteLine($"Der skete en generel fejl {ex.Message}");
}
finally
{
    Console.WriteLine("Bliver altid udført");
}

Console.WriteLine("Her slutter programmet");

