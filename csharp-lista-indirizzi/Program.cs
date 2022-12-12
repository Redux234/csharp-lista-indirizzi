
using csharp_lista_indirizzi;
using System;
using System.Linq.Expressions;

List<Indirizzo> listaindirizzi = new List<Indirizzo>();

try
{
    StreamReader file =
    File.OpenText("C:\\Users\\loren\\OneDrive\\Desktop\\VS 22\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\addresses.csv");
        
    file.ReadLine();
        
    while (!file.EndOfStream)
    {
        string riga = file.ReadLine();

        string[] infoindirizzo = riga.Split(",");

        string name = infoindirizzo[0];
        string surname = infoindirizzo[1];
        string street = infoindirizzo[2];
        string city = infoindirizzo[3];
        string province = infoindirizzo[4];
        string zip = infoindirizzo[5];

        Indirizzo indirizzoestratto = new Indirizzo(name, surname, street, city, province, zip);
        listaindirizzi.Add(indirizzoestratto);

    }

    file.Close();
} catch(Exception e)
{
    Console.WriteLine(e.Message);
}

foreach(Indirizzo indirizzoestratto in listaindirizzi)
{
    Console.WriteLine("-------Indirizzo-------");
    indirizzoestratto.StampaIndirizzo();
    Console.WriteLine();
}

