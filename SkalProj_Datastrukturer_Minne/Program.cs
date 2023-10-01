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
            // 1:   Jag använde mig av en lista.
            //
            //      *   Varje gång en öppnande ( { eller [
            //          hittas i en sträng läggs den till i listan.
            //
            //      *   Så fort en stängande ( { eller [ hittas
            //          så kontrolleras vilket tecken som senast
            //          lades till i listan.
            //
            //          -   Om kontrollen visar att det är tillhörande 
            //              öppnande tecken så tas det sista tecknet 
            //              bort från listan och strängen är (hittills) välformulerad.
            //
            //          -   Om kontrollen visar att det INTE är tillhörande
            //              öppnande tecken så är strängen inte välformulerad.
            //
            //      *   Eftersom de öppnande tecknen läggs till i den
            //          ordningen dom skrivits in i strängen så måste
            //          alltid det senast öppnade tecknet stängas innan
            //          något annat kan stängas.
            //
            //      *   När hela strängen kontrollerats blir det "Success" om antalet
            //          specialtecken i listan == 0. Det görs även en extrakontroll med en
            //          success-bool som är true eller false beroende på hur kontrollerna gått.



        }
    }
}

