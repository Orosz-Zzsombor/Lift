using Hotellift;
using System.Reflection.Emit;
using System.Threading.Channels;

List<Lift>liftek = new List<Lift>();
File.ReadAllLines("lift.txt").ToList().ForEach(x =>liftek.Add(new Lift(x)));

Console.WriteLine($"3. feladat: Összes lifthasználat: {liftek.Count()}");
Console.WriteLine($"4.feladat: Időszak: {liftek.Min(x=>x.Datum)} - {liftek.Max(x=>x.Datum)}");
Console.WriteLine($"5. feladat: Célszint max: {liftek.Max(x=>x.Celszint)}");
Console.WriteLine($"6.Feladat: \nKártya száma:");
int kartyaSzama = 0;
int celszintSzama =0;

try
{
    kartyaSzama = int.Parse(Console.ReadLine());
}
catch (Exception)
{
	kartyaSzama = 5;
}
Console.WriteLine($"Célszint száma:");
try
{
	 celszintSzama = int.Parse(Console.ReadLine()); 
}
catch (Exception)
{
	celszintSzama = 5;

}
//liftek.Exists(x => x.KartyaSorszam == kartyaSzama && x.Celszint == celszintSzama) ? Console.WriteLine($"7.feladat: A(z){kartyaSzama}. kártyával utaztak a(z) {celszintSzama}. emeletre"):Console.WriteLine($"asd");
if (liftek.Exists(x => x.KartyaSorszam == kartyaSzama && x.Celszint == celszintSzama))
{
	Console.WriteLine($"7.feladat: A(z){kartyaSzama} kártyával utaztak a(z) {celszintSzama}. emeletre");
}
else { Console.WriteLine($"7.feladat: A(z){kartyaSzama} kártyával nem utaztak a(z) {celszintSzama}. emeletre"); }
Console.WriteLine("8. feladat statisztika");
liftek.GroupBy(x => x.Datum).ToList().ForEach(x => Console.WriteLine($"{x.Key}  {x.Count()}x"));