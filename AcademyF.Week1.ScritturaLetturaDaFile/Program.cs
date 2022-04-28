// See https://aka.ms/new-console-template for more information
Console.WriteLine("Demo Lettura Scrittura File");

string path = @"C:\Users\RenataCarriero\source\repos\AcademyF.Week1\AcademyF.Week1.ScritturaLetturaDaFile\FileProva.txt";
//string path1 = "NuovoFileProva.txt";

//Scrittura su file con chiusura manuale
StreamWriter sw = new StreamWriter(path);
sw.WriteLine("Ciao a tutti");
sw.Close();

//Scrittura su file con chiusura automatica -> using

//Scrittura su file sovrascrivendo il contenuto precedente
using (StreamWriter sw1 = new StreamWriter(path))
{
    sw1.WriteLine("Buongiorno!");
}

//Scrittura su file mantenendo il contenuto precedente
using (StreamWriter sw1 = new StreamWriter(path, true))
{
    sw1.WriteLine("come state?");
}


//Lettura di tutto il file
using (StreamReader sr = new StreamReader(path))
{
    string contenutoFile = sr.ReadToEnd();
}

//lettura di una riga del file

using (StreamReader sr2 = new StreamReader(path))
{
    string contenutoRiga = sr2.ReadLine();
}

//Lettura di tutto il file e divisione del file in righe
using (StreamReader sr3 = new StreamReader(path))
{
    string contenutoFile = sr3.ReadToEnd();
    var arrayRighe = contenutoFile.Split("\r\n");
}