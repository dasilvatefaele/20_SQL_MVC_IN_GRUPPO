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
                break;
            case "2":
                ShowUsers();
                return true;
                break;
            case "3":
                DeleteUser();
                return true;
                break;
            case "4":
                EditState();
                return true;
            case "0":
                _db.CloseConnection();
                return false;

                break;
            default:
                Console.WriteLine("\nErrore di input.");
                return true;
                break;
        }
    }

    // CRUD: ---------------------------------------
    private void AddUser()
    {
        _db.AddUser(_view.AddUser(),_view.GetState());
    }

    private void DeleteUser()
    {
        _db.DeleteUser(_view.DeleteUser());
    }

    private void ShowUsers()
    {
        var user = _db.GetUsers();
        _view.MostraUsers(user);
    }

    private void EditState()
    {
        ShowUsers();
        var input = InputManager.LeggiStringa("Inserisci ID del quale vuoi cambiare stato");
        var listaTemp = _db.GetUsers();
        foreach (var user in listaTemp)
        {
            if (user.id == input)
            {
                user.isActive = _view.GetState();
            }
        }
        //  todo AGGIORNARE IL DATABASE con la lista che c'è in runtime 
    }
}