namespace EmployeeOnboarding.Models;

public class Mitarbeiter
{
    public int MitarbeiterID{get;set;}
    public string Vorname{get;set;}
    public string Nachname{get;set;}
    public string Abteilung {get;set;}
    public string Email{get;set;}

    public string Benutzername { get; set; }
    public string Passwort { get; set; }

}
