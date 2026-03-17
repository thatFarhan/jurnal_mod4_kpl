using System;
using System.Collections.Generic;

public class KodePaket
{
	public string getKodePaket(string namaPaket)
	{
		Dictionary<string, string> kode = new Dictionary<string, string>();

		kode.Add("Basic", "P201");
		kode.Add("Standard", "P202");
        kode.Add("Premium", "P203");
        kode.Add("Unlimited", "P204");
        kode.Add("Gaming", "P205");
        kode.Add("Streaming", "P206");
        kode.Add("Family", "P207");
        kode.Add("Business", "P208");
        kode.Add("Student", "P209");
        kode.Add("Traveler", "P210");

        if (kode.ContainsKey(namaPaket))
        {
            return kode[namaPaket];
        } else
        {
            return null;
        }
    }
}
