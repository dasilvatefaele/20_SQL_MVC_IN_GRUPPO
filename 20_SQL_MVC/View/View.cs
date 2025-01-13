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
        Console.WriteLine("3. Cerca users");
        Console.WriteLine("4. Elimina users");
        Console.WriteLine("5. Modifica users");
        Console.WriteLine("0. Esci");
    }

    // View Users
    public void MostraUsers(List<User> users)
    {
        foreach (var user in users)
        {
            Console.WriteLine($"{user.nome.ToString()}");
            //StampaTabella.VisualizzaUser(user);

        }
    }


    // acquisizione
    public string GetInput()
    {
        return Console.ReadLine(); // Lettura dell'input dell'utente
    }

    // legge e restituisce
    public string AddUser()
    {
        Console.WriteLine("Leggi nome utente:");
        string nome = GetInput();
        return nome;
    }

    public void FoundUser(User user)
    {
        Console.WriteLine($"{user.id} - {user.nome}");
    }

    public int SearchUser()
    {
        int id = InputManager.LeggiIntero("inserisci l'id ");
    }
    public string DeleteUser ()
    {
        Console.WriteLine("Inserisci l'id dell'utente da eliminare:");
        var id = GetInput();
        return id;
    }

}