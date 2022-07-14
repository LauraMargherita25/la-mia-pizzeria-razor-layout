﻿using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class EserciziRazor : Controller
    {
        public IActionResult Index()
        {
            string name = "Laura";
            string surname = "Margherita";
            ViewData["Message"] = name + " " + surname;
            return View();
        }
    }
}

//1.Dichiarare una variabile valorizzandola con il nostro nome.
//Dichiarare un'altra variabile valorizzandola con il nostro cognome.
//Stampare il nostro nome e cognome all'interno di un tag h2.
//2. Creare una funzione che stampa la somma dei numeri che vanno da 1 a n (con n passato come parametro - n incluso)
//Stampare dentro uno span il risultato.
//3. Contare quante volte la lettera a è presente nalla frase "nel mezzo del cammin di nostra vita" e stampare questo valore in pagina
//4. Creare una List<int> di 20 numeri interi (generati random da 1 a 90, 1 e 90 inclusi) e mostrare in pagina solo i numeri compresi tra 20 e 70
//5. Stampare in pagina la data e l'ora attuale (usando la classe DateTime) con il formato anno-mese-giorno ore:minuti:secondi
//6. Partendo dalla data di oggi (usando la classe DateTime) stampare in pagina
//a.la data di 7 giorni fa
//b.che giorno della settimana è oggi (il risultato dovrà essere il nome del giorno (Lunedì, Martedì, ...)
//c.che giorno della settimana sarà nello stesso giorno e mese di oggi ma tra un anno (il risultato dovrà essere il nome del giorno (Lunedì, Martedì, ...)
//Riduci















