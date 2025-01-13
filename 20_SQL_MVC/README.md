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

CONTROLLER
---
- [ ] Cercare Utente (DIEGO)

- [ ] Modificare Utente (ANDREA)  
- [ ] Eliminare Utente (ANDREA)
---

VIEW
---
INPUT: List<User>
- [ ] Utilizzo di metodo di StampaTabella (Utilities) (FELIPE) (GIORGIO)
---

UTILITIES
---
- [ ] Gestione input non validi (InputManager) (DIEGO)
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

