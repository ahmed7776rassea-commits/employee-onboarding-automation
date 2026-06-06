using System;
using System.IO;
using EmployeeOnboarding.Models;

string dateiPfad = "data/employees.csv";
List<Mitarbeiter> mitarbeiterListe = new List<Mitarbeiter>();

if (File.Exists(dateiPfad))
{
    string[] zeilen = File.ReadAllLines(dateiPfad);

    foreach (string zeile in zeilen.Skip(1))
    {
        string[] teile = zeile.Split(',');
        
        Mitarbeiter mitarbeiter = new Mitarbeiter();

        mitarbeiter.MitarbeiterID = int.Parse(teile[0]);
        mitarbeiter.Vorname = teile[1];
        mitarbeiter.Nachname = teile[2];
        mitarbeiter.Abteilung = teile[3];
        mitarbeiter.Email = teile[4];
        mitarbeiterListe.Add(mitarbeiter);

        Console.WriteLine($"{mitarbeiter.MitarbeiterID} - {mitarbeiter.Vorname} {mitarbeiter.Nachname} - {mitarbeiter.Abteilung}");
    }
}
else
{
    Console.WriteLine("Datei nicht gefunden!");
}