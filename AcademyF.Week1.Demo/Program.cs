// See https://aka.ms/new-console-template for more information
using AcademyF.Week1.Demo;

Console.WriteLine("Hello, World!");

int a;// dichiarazione
a= 3; //assegnazione
int b = 1; //inizializzazione

double c = 3.45;
float d = 5.6f;
bool e = true; //o false;

int? f = null;
int i=1; //default 0
Console.WriteLine($"La variabile i vale: {i}");
Console.WriteLine("La variabile i vale: " + i);
Console.WriteLine("La variabile i vale: {0} - La variabile a vale: {1} ", i, a);

DateTime data = new DateTime(2022, 04, 26);
DateTime dataOggi = DateTime.Now;
Console.WriteLine(data);
Console.WriteLine(data.ToString());
Console.WriteLine(data.ToShortDateString());

Console.WriteLine(dataOggi.ToString());

//enum
GiorniDellaSettimana g = GiorniDellaSettimana.Lunedi;

int primo = 22;
int secondo = primo;
Console.WriteLine(primo); 
Console.WriteLine(secondo);
secondo = 10;
Console.WriteLine("------");
Console.WriteLine(primo);
Console.WriteLine(secondo);


Person persona = new Person();
persona.FirstName = "Mario";
persona.LastName = "Rossi";
persona.BirthDay = new DateTime(1980, 5, 4);

Console.WriteLine($"Nome: {persona.FirstName} Cognome: {persona.LastName} Data di nascita: {persona.BirthDay.ToShortDateString()}");
Person persona2 = persona;
Console.WriteLine($"Nome: {persona2.FirstName} Cognome: {persona2.LastName} Data di nascita: {persona2.BirthDay.ToShortDateString()}");

persona2.FirstName = "Giuseppe";
Console.WriteLine($"Nome: {persona.FirstName} Cognome: {persona.LastName} Data di nascita: {persona.BirthDay.ToShortDateString()}");
Console.WriteLine($"Nome: {persona2.FirstName} Cognome: {persona2.LastName} Data di nascita: {persona2.BirthDay.ToShortDateString()}");

Console.WriteLine(persona);
Console.WriteLine(persona.ToString());


Person p3 = null;
Person p4 = new Person() { FirstName = "Renata", LastName = "Carriero", BirthDay= new DateTime(1987, 04, 01) };
Console.WriteLine(p4.ToString());
Console.WriteLine(p4.CodiceFiscale);
Console.WriteLine("--------------------------");
Console.WriteLine(p4.GetInfoPersona());
Console.WriteLine(p4.GetInfoPersona("Sposata"));


Employee impiegato1 = new Employee();
impiegato1.FirstName = "Giuseppe";
impiegato1.LastName = "Verdi";
Console.WriteLine(impiegato1);



enum GiorniDellaSettimana
{
    Lunedi=1,
    Martedi=2,
    Mercoledì,
    Giovedì
}
