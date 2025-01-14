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
- [x] Cercare Utente (DIEGO)

- [x] Modificare Utente (ANDREA)  
- [x] Eliminare Utente (ANDREA)
---

VIEW
---
INPUT: List<User>
- [x] Utilizzo di metodo di StampaTabella (Utilities) (FELIPE) (GIORGIO)
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

---

Per ora abbiamo intuito che la procedura per unire i branch si compone come segue: 

> (IN TEORIA - DA VERIFICARE)

1. Ognuno crea un proprio branch, fa un pull dell'`origin`, poi fa le modifiche
2. Esegue commit frequenti e una volta verificato che il codice funziona fa il `git push -u origin update/nome-branch`
3. Chi finisce la propria task fa una Pull Request agli altri sviluppatori affinche individualmente risolvino i conflitti col proprio branch (anche se in corso d'opera)
4. Quindi ognuno fa un `git pull feature/nome-branch` (?)
5. Una volta terminato e verificato che tutto funzioni su ogni branch si esegue il merge con il main
6. `git branch --all` per avere la versione più aggiornata del repository
7. ci si sposta sul main, si fa il `git pull origin main`
8. `git merge feature/nome-branch`
9. si risolvono gli eventuali conflitti
10. `git add --all`, `git commit -m "merge completato"`, `git push origin main`
11. per nuove modifiche, aggiornare il proprio main locale andando sul main, `git pull origin main`, nuovo branch, e implementare sul nuovo branch partendo dalla versione più aggiornata del main