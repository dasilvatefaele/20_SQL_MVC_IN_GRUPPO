using System.Data.SQLite;

class UserController
{

    private Database _db; // riferimento al modello
    private View _view; // riferimento alla vista

    public UserController(Database db, View view) // costruttore con inizializzazione riferimenti
    {
        _db = db;
        _view = view;
    }

    // Menu
    public bool MainMenu()
    {
        _view.ShowMainMenu();
        var input = _view.GetInput();

        switch (input)
        {
            case "1":
                AddUser();
                return true;
            case "2":
                ShowUsers();
                return true;
            case "3":
                SearchUsers();
                return true;
            case "0":
                _db.CloseConnection();
                return false;
                break;
            default:
                Console.WriteLine("\nErrore di input.");
                return true;
        }
    }

    // CRUD: ---------------------------------------
    private void AddUser()
    {
        _db.AddUser(_view.AddUser());
    }

    private void ShowUsers()
    {
        var user = _db.GetUsers();
        _view.MostraUsers(user);
    }

    private void SearchUsers()
    {
        var user = _db.GetUsers();
        _view.FoundUser(_db.SearchUser(user, _view.SearchUser()));
    }
}