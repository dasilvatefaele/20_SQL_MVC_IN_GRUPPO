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

