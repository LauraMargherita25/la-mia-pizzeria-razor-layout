using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class EserciziRazor : Controller
    {
        public IActionResult Index()
        {
            string name = "Laura";
            string surname = "Margherita";
            ViewData["Message"] = name + " " + surname;

            int Sum(int maxNum)
            {
                int sum = 0;
                for (int i = 0; i <= maxNum; i++)
                {
                    sum += i;
                }
                return sum;
            }
            ViewData["SumResult"] = Sum(10);

            int CountA()
            {
                string text = "nel mezzo del cammin di nostra vita";
                char character = 'a';
                int freq = text.Count(f => (f == character));

                return freq;
            }
            ViewData["HowManyA"] = CountA();

            List<int> nums = new List<int>();
            for (int i = 0; i <= 20; i++)
            {
                int num = new Random().Next(1, 91);
                nums.Add(num);
            }

            List<int> validNums = new List<int>();
            foreach (int num in nums)
            {
                if (num>=20 && num<=70)
                {
                    validNums.Add(num);
                }
            }  
            string combinedString = string.Join(",", validNums.ToArray());
            ViewData["RndNum"] = combinedString;

            DateTime today = DateTime.Now;
            ViewData["Today"] = today;
            ViewData["OneWickAgo"] = today.AddDays(-7);
            ViewData["Day"] = today.DayOfWeek;
            ViewData["DayOneYear"] = today.AddYears(+1).DayOfWeek;
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

















