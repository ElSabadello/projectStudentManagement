# 🎓 School Management System

Un'applicazione desktop in **C# (.NET WinForms)** con **MySQL** come database, progettata per gestire in modo semplice ed efficiente le informazioni degli studenti.

## 🧩 Funzionalità principali

* 📋 Visualizzazione elenco studenti
* ➕ Inserimento nuovi studenti
* ✏️ Modifica dei dati esistenti
* 🗑️ Cancellazione di uno studente selezionato
* 🔄 Aggiornamento automatico della griglia dati

## 🗃️ Struttura del database

**Database:** `student_information`
**Tabella:** `student`

| Campo     | Tipo           | Descrizione              |
| --------- | -------------- | ------------------------ |
| `id`      | `INT` (PK, AI) | Identificatore univoco   |
| `RegNo`   | `INT`          | Numero di registrazione  |
| `Student` | `VARCHAR(100)` | Nome dello studente      |
| `Address` | `VARCHAR(255)` | Indirizzo dello studente |

## ⚙️ Tecnologie utilizzate

* C# (WinForms)
* MySQL
* MySql.Data (NuGet)
* .NET Framework

## 🚀 Come avviare il progetto

1. **Clona la repo**

2. **Apri il progetto in Visual Studio**

3. **Installa i pacchetti NuGet**

   * `MySql.Data`

4. **Crea il database**

   ```sql
   CREATE DATABASE student_information;

   CREATE TABLE student (
       id INT AUTO_INCREMENT PRIMARY KEY,
       RegNo INT NOT NULL,
       Student VARCHAR(100) NOT NULL,
       Address VARCHAR(255) NOT NULL
   );
   ```

5. **Aggiorna la stringa di connessione se necessario**
   In `DbConnection.cs`:

   ```csharp
   private static readonly string _connectionString = "SERVER=localhost;DATABASE=student_information;UID=root;PASSWORD=;";
   ```

6. **Avvia l'applicazione**

## 🧑‍💻 Struttura del codice

* `HomeForm.cs`: UI principale con la griglia studenti
* `DbConnection.cs`: Gestione della connessione a MySQL
* `InsertForm.cs`: Aggiungi nuovo studente
* `UpdateForm.cs`: Aggiorna dati studente
* `DeleteForm.cs`: Cancella studente

## 📦 Possibili estensioni future

* Login amministratori/docenti
* Gestione corsi e classi
* Sezioni per voti, presenze, notifiche
* Dashboard con statistiche

## 📜 Licenza

Questo progetto è open-source. Puoi usarlo, modificarlo o integrarlo liberamente nel rispetto della licenza specificata (MIT/GPL/altro se desideri aggiungerla).

## 🤝 Contribuire

Pull request e suggerimenti sono benvenuti!
Per grandi modifiche, apri prima una issue per discutere cosa vuoi cambiare.
