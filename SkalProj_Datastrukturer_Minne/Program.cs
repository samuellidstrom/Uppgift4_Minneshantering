using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
            //Jag lade hela huvudmenyn i en egen klass för att enkelt kunna hoppa tillbaka till den från andra klasser
            MainMenu mainMenu = new MainMenu();

            //
            //  Övning4 - Fråga 1-3: Finns på sida 1 i PDF-dokument.
            // 
            //-----------------------------------------------------
            //
            // Övning4 - Frågor på Övning 1: ExamineList()
            //
            // 2:   Listans kapacitet ökar när antalet element som lagts till
            //      nått upp till listans kapacitet.
            //
            // 3:   Listans kapacitet dubblas.
            //
            // 4:   Listor fungerar så att dom har bakomliggande arrays som
            //      lagrar element. När en array skapas måste kapaciteten sättas direkt.
            //      När man skapar en lista så skapas alltså en bakomliggande array med
            //      en liten, men fast, kapacitet. När antalet element uppnått listans
            //      kapacitet så skapas en ny array (med dubbel kapacitet) dit alla element
            //      automatiskt kopieras, så att man kan fortsätta lägga till element.
            //
            // 5:   Nej, en listas kapacitet minskar inte automatiskt när
            //      element tas bort från den. Det går dock att manuellt
            //       minska listsans kapacitet med 'TrimExcess()'
            //
            // 6:   Om du från början vet maxantalet för antalet element som ska lagras
            //      är det alltid bättre att använda en array.
            // 
            //-----------------------------------------------------
            //
            // Övning4 - Övning2: ExamineQueue()
            //
            // 1:   Sida 2 i PDF-dokument
            // 
            //-----------------------------------------------------
            //
            // Övning4 - Övning3: ExamineStack()
            //
            // 1:   Sida 3 i PDF-dokument
            //-----------------------------------------------------
            //
            // Övning4 - Övning4: CheckParenthesis()
            //
            // 1:   Sida 3 i PDF-dokument
        }
    }
}

