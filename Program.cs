using System;
using System.IO;
using EmployeeOnboarding.Models;

string dateiPfad = "data/employees.csv";
List<Mitarbeiter> mitarbeiterListe = new List<Mitarbeiter>();

if (File.Exists(dateiPfad))
{
    string[] zeilen = File.ReadAllLines(dateiPfad);
    Random random = new Random();

    string zeichen =
        "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
        "abcdefghijklmnopqrstuvwxyz" +
        "0123456789";

    foreach (string zeile in zeilen.Skip(1))
    {
        string[] teile = zeile.Split(',');
        
        Mitarbeiter mitarbeiter = new Mitarbeiter();

        mitarbeiter.MitarbeiterID = int.Parse(teile[0]);
        mitarbeiter.Vorname = teile[1];
        mitarbeiter.Nachname = teile[2];
        mitarbeiter.Abteilung = teile[3];
        mitarbeiter.Email = teile[4];
        mitarbeiter.Benutzername =teile[1][0].ToString().ToLower()+teile[2].ToLower();
        string passwort = "";

        for (int i = 0; i < 8; i++)
        {
        int index = random.Next(0, zeichen.Length);
        passwort += zeichen[index];
        }

        mitarbeiter.Passwort = passwort;
        mitarbeiterListe.Add(mitarbeiter);

        Console.WriteLine($"{mitarbeiter.MitarbeiterID} - {mitarbeiter.Vorname} {mitarbeiter.Nachname} - {mitarbeiter.Abteilung}");
        Console.WriteLine($"Benutzername: {mitarbeiter.Benutzername}");
        Console.WriteLine($"Passwort: {mitarbeiter.Passwort}");
    }
}
else
{
    Console.WriteLine("Datei nicht gefunden!");
}