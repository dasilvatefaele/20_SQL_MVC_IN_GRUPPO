using System.Data;
using System.Data.SQLite;

class View
{
    // Acquisizione e visualizzazione viene gestito dal View
    //? Quindi nell'archettura MVC il View serve per la visualizzazione. 
    //? in questo caso avendo anche il metodo GetInput si occupa anche dell'acquisizione 
    //? Quindi si può dire che il View si occupa di stampa e acquisizione?

    private Database _db;

    public View(Database db) // costruttore che prende in input il modello del database
    {
        _db = db; // inizializiamo il riferimento del modello

    }

    // View Menu
    public void ShowMainMenu()
    {
        Console.WriteLine("1. Aggiungi user");
        Console.WriteLine("2. Leggi users");
        Console.WriteLine("3. Elimina user");
        Console.WriteLine("4. Modifica stato");
        Console.WriteLine("0. Esci");
    }

    // View Users
    public void MostraUsers(List<User> users)
    {
        Console.WriteLine();
        foreach (var user in users)
        {
            Console.WriteLine($"{user.id} - {user.nome} - {user.IsActive.ToString()}");
        }
        Console.WriteLine();
    }

    // acquisizione
    public string GetInput()
    {
        return Console.ReadLine(); // Lettura dell'input dell'utente
    }

    // legge e restituisce
    public string AddUser ()
    {
        Console.WriteLine("Leggi nome utente:");
        var nome = GetInput();
        return nome;
    }

    // elimina user
    public string DeleteUser()
    {
        MostraUsers(_db.GetUsers());
        return InputManager.LeggiStringa("Inscerisci ID da eliminare");
    }

    public string GetState()
    {
        string stato = InputManager.LeggiConferma("L'utente è attivo?").ToString();
        return stato;
    }
}