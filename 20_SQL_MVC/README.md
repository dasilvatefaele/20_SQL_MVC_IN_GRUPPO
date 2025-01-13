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
git branch feature/modifica-utente
# passa al branch appena creato
git checkout feature/modifica-utente
# crea un nuovo branch e passa a esso
git checkout -b feature/modifica-utente
# aggiungi i file modificati
git add . o git add --all
# esegui il commit delle modifiche
git commit -m "feature/modifica-utente"
# esegui le modifiche sul branch principale
git push origin feature/modifica-utente

