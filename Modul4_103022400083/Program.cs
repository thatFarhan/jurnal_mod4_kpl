// See https://aka.ms/new-console-template for more information
string[] namaPaketList = { "Basic", "Standard", "Premium", "Unlimited", "Gaming", "Streaming", "Family", "Business", "Student", "Traveler" };

KodePaket kodePaket = new KodePaket();

Console.WriteLine("Nama Paket\tKode Paket");
foreach (string s in namaPaketList)
{
    if (kodePaket.getKodePaket(s) != null)
    {
        Console.WriteLine($"{s}\t{kodePaket.getKodePaket(s)}");
    }
}
