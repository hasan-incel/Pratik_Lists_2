//5 elemanlı kahve dizisi oluşturdum.
string[] kahve = new string[5];

for (int i = 0; i < kahve.Length; i++)
{
    Console.WriteLine("Kahve seçiminizi yapın.");
    string coffe = Console.ReadLine();
    kahve[i] = coffe;
}
//Girilen kahve seçimlerini konolda yazdırıyprum.
Console.WriteLine("\n-----Kahve Seçimleriniz-----");
for (int i = 0;i < kahve.Length;i++)
{
    Console.WriteLine(kahve[i]);
}
