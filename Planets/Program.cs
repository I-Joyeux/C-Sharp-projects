using static System.Console;
class DisplayPlanet
{
    enum Planets
    {
        Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune,

    }

    static void Main()
    {
     
        int PlanetsNum;
        Planets planetsName;
        WriteLine("Enter a planet number");
        PlanetsNum=Convert.ToInt32(Console.ReadLine());

        planetsName = (Planets)PlanetsNum-1;
        Console.WriteLine("{0} is Planets {1}",planetsName.ToString(),PlanetsNum.ToString());
    
    }

}