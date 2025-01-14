# CREAZIONE CATALOGO DI UTENTI


```bash
dotnet add package System.Data.SQLite
```


## Obiettivo: 

creare un catalogo di utenti con funzionalita CRUD usando il pattern MVC e SQLite3


### Vantaggi:

- Speparazione della responsabilità
- Facilità di manutenzione
- Facilità di test
- Riusabilità del codice
- Scalabilità
- Facilità di sviluppo
- Facilità di sostituzione di una parte del programma

## Aggiunta di funzionalità al programma esistente

- [x] Creazione Utente
- [x] Visualizzazione Utenti
- [x] Eliminare Utente 
- [ ] Cercare Utente 
- [ ] Modificare Utente 
INPUT: List<User>
- [ ] Utilizzo di metodo di StampaTabella (Utilities) 
- [ ] Gestione input non validi (InputManager) 


## DELETE

CONTROLLER
Andrea nome branch **UserController_Delete**
- [x] aggiunta chiamata a DeleteUser e chiamata crud a DeleteUser

- Modifica implementate
```csharp
case "3":
    DeleteUser();
    return true;

private void DeleteUser()
    {
        _db.DeleteUser(_view.DeleteUser());
    }
```

```bash
git pull 
git add --all
git commit -m "CONTROLLER: aggiunta chiamata DeleteUser() e rispettiva operzione crud"
git push -u origin UserController_Delete
```

- [x] Approvato da host

- Merge dell'host
```bash
git checkout main
git merge UserController_Delete
git push origin main
```

---

VIEW
Felipe nome branch **view_user_delete**
- [x] stampa a terminale di lista Utenti prima di inserimento id (verrà passato a database)
- [x] aggiunta scelta di elimina utente su stampa di menù

- Modifica implementata
```csharp
 Console.WriteLine("3. Elimina user")

  public void DeleteUser()
    {
        MostraUsers(_db.GetUsers());
        string id = InputManager.Stringa("Inscerisci ID da eliminare");
        _db.DeleteUser(id);
    }
```
- faccio un push delle modifiche sul branch
```bash
git pull 
git add --all
git commit -m "VIEW: aggiunto alla vista elimina utente implementata chiamata al database"
git push -u origin view_user_delete
```

- [x] Approvato da host

- Merge dell'host
```bash
git checkout main
git merge view_user_delete
git push origin main
```

---

DATABASE
Giorgio nome branch **database**
- [x] Impostare comando per eliminare user da database
- [x] Chiamata funzione elimina utente 

- Modifica implementata
```csharp
 public void DeleteUser(string id) 
    {
        var command = new SQLiteCommand($"DELETE FROM users WHERE id  = '{id}'", _connection);
        command.ExecuteNonQuery();
    }
```

```bash
git add --all
git commit -m "database_delete_user"
git push -u origin database
```
- [x] Approvato da host

- Merge dell'host
```bash
git pull
git checkout main
git merge database
git push origin main
```

---

## Da completare

## MODIFICA

CONTROLLER
Giorgio nome branch **UserController_Edit**
- [x] aggiunta chiamata a ModificaUser e chiamata crud a ModificaUser
- Modifica implementate
```csharp
```
```bash
git pull 
git add --all
git commit -m " "
git push -u origin UserController_Edit
```
- [x] Approvato da host
- Merge dell'host
```bash
git checkout main
git merge UserController_Edit
git push origin main
```
---
VIEW
Diego nome branch **modifica_view_user**
- Modifica implementata
```csharp
 
```
- faccio un push delle modifiche sul branch
```bash
git pull 
git add --all
git commit -m " "
git push -u origin modifica_view_user
```
- [x] Approvato da host
- Merge dell'host
```bash
git checkout main
git merge modifica_view_user
git push origin main
```
---
DATABASE
Felipe nome branch **database/modifica-user**
- [x] Impostare comando per modificare user da database
- [x] Chiamata funzione modifica utente 
- Modifica implementata
```csharp
 
```
```bash
git add --all
git commit -m " "
git push -u origin database/modifica-user
```
- [x] Approvato da host
- Merge dell'host
```bash
git pull
git checkout main
git merge database/modifica-user
git push origin main
```
---
## Aggiunta campo bool 
Il campo chiamato IsActive
1. [x] Aggiungere campo al modello; (Andrea)
2. Modifica il Database.cs modificando la query sia di SELECT che di CREATE TABLE; (Diego)
3. Modifica il View.cs; (Giorgio)
4. Modifica il Controller.cs; (Felipe)
---

## Modifiche nella cartella Models

## user.cs

- Creo un nuovo branch `Model_Campo_IsActive`;
- Aggiungo un parametro Bool chiamato IsActive in user.cs:
    `Public bool IsActive {get; set;}`

- Viene fatto il push sul branch Model_Campo_IsActive:

```bash
git add --all
git commit -m "Aggiunta campo IsActive al modello user"
git push -u origin Model_Campo_IsActive
```

- [x] Approvato da host
- Merge dell'host
```bash
git pull
git checkout main
git merge Model_Campo_IsActive
git push origin main
```
---
## Database.cs

- Creo un nuovo branch `database_aggiunta_campo_utente`;
- Modifico la query di crezione di una tabella:

```csharp
 CREATE TABLE IF NOT EXISTS users (id INTEGER PRIMARY KEY, name TEXT, isactive BOOLEAN)
```
- Modifico AddUser:

```csharp
public void AddUser(string nome, bool isActive)
```

- Modifico la query di inserimento: 

```csharp
var command = new SQLiteCommand($"INSERT INTO users (name, isactive) VALUES ('{nome}', '{isActive}')", _connection);
``` 
- Modifico la chiamata `users.Add`:

```csharp
users.Add(new User
            {
                id = reader.GetInt32(0),
                nome = reader.GetString(1),
                isActive = reader.GetBoolean(2)
            });
``` 

- Viene fatto il push sul branch `database_aggiunta_campo_utente`:

```bash
git add --all
git commit -m "DATABASE: aggiunta nuovo campo isactive a tabella users"
git push -u origin database_aggiunta_campo_utente
```

- [x] Approvato da host
- Merge dell'host

```bash
git pull
git checkout main
git merge database_aggiunta_campo_utente
git push origin main
```
---

## Modifiche nella cartella View

- Creo un nuovo branch `View_aggiunta_campo_isactive`;

- Aggiunta in `ShowMainMenu()` il campo Modifica stato:

```csharp
Console.WriteLine("4. Modifica stato");
``` 
- Modifico il `Console.WriteLine` in `MostraUser(List<User> users)`:

```csharp
Console.WriteLine($"{user.nome.ToString()} - {user-IsActive.ToString()}");
``` 

- Creo GetState():

```csharp
public bool GetState()
{
    bool stato = InputManager.LeggiConferma("L'utente è attivo?");
    return stato;
}
```

- Viene fatto il push sul branch `database_aggiunta_campo_utente`:

```bash
git add --all
git commit -m "View aggiunto metodo GetState e aggiunto al menu"
git push -u origin View_aggiunta_campo_isactive
```

- [x] Approvato da host
- Merge dell'host

```bash
git pull
git checkout main
git merge View_aggiunta_campo_isactive
git push origin main
```
---

## Modifiche nella cartella Controller

- Creo un nuovo branch `controller_add_campo_isactive`;

- Aggiungo allo switch il case "4":

```csharp
 case "4":
        EditState();
        return true;
```

- Modifico AddUser():

```csharp
private void AddUser()
    {
        _db.AddUser(_view.AddUser(),_view.GetState());
    }
```

- Creo EditState():

```csharp
public void EditState()
{
    ShowUsers();
    var input = InputManager.LeggiStringa("Inserisci OD del quale vuoi cambiare lo stato");
    var listaTemp = _db.GetUsers();
    foreach ( var user in listaTemp)
    {
        if(user.id == input);
        {
            user.IsActive = _view.GetState();
        }
    }
}
```

- Viene fatto il push sul branch `controller_add_campo_isactive`:

```bash
git add --all
git commit -m "CONTROLLER: EditState inserito in case 4, servito stato come argomento ad AddUser"
git push -u origin controller_add_campo_isactive
```

- [x] Approvato da host
- Merge dell'host

```bash
git pull
git checkout main
git merge controller_add_campo_isactive
git push origin main
```
---

- [ ] Todo Aggiornare il DATABASE con la lista che c'è in runtime

--- 

## Correzione errori

- Creo un nuovo branch `bug_fixing`;

## Modifiche in Controller.cs

- Modifico l'if all'interno dell'EditState():

```csharp
if (user.id == int.Parse(input))
            {
                user.IsActive = bool.Parse(_view.GetState());
            }
```
---

## Modifiche in Database.db

- Modifico AddUser:

```csharp
public void AddUser(string nome, string isActive) 
```

- Correggo IsActive in GetUsers():

```csharp
 IsActive = bool.Parse(reader.GetString(2))
```
---

## Modifiche in View.db

- Modifico MostraUsers(List<User> users):

```csharp
public void MostraUsers(List<User> users)
    {
        Console.WriteLine();
        foreach (var user in users)
        {
            Console.WriteLine($"{user.id} - {user.nome} - {user.IsActive.ToString()}");
        }
        Console.WriteLine();
    }
```

- Cambio DeleteUser() da void a string e apporto altre modifiche:

```csharp
 public string DeleteUser()
    {
        MostraUsers(_db.GetUsers());
        return InputManager.LeggiStringa("Inscerisci ID da eliminare");
    }
```

- Cambio GetState() da void a string e apporto altre modifiche:

```csharp
 public string GetState()
    {
        string stato = InputManager.LeggiConferma("L'utente è attivo?").ToString();
        return stato;
    }
```

- Viene fatto il push sul branch `bug_fixing`:

```bash
git add --all
git commit -m "bug fix vari"
git push -u origin bug_fixing
```

- [x] Approvato da host
- Merge dell'host

```bash
git pull
git checkout main
git merge bug_fixing
git push origin main
```
---

> In attesa di spiegazione

- [ ] Utilizzo di parametri dei comandi SQL (Prevenire SQL Injection)

---

# crea un nuovo branch
git branch feature/user-management
# passa al branch appena creato
git checkout feature/user-management
# crea un nuovo branch e passa a esso
git checkout -b feature/user-management
# aggiungi i file modificati
git add . o git add --all
# esegui il commit delle modifiche
git commit -m "Implement user registration"
# esegui le modifiche sul branch principale
git push origin feature/user-management

