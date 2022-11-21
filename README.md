# Math Problem Generator

**This is a multiple choice math game for children.**



Bij dit spel moet je zo veel mogelijk goede antwoorden kiezen binnen een bepaalde tijd. De tijd kan zelf gekozen worden voordat het spel start. Je kan kiezen tussen 20 sec, 1 min, 2 min of 5 min. De problemen die de gebruiker kan krijgen zijn optelsommen, minsommen, keersommen en deelsommen.

Voor elk soort som is er een andere methode gemaakt in de code. De soort som die de gebruiker krijgt wordt willekeurig gekozen door het programma met de Random class en in een switch statement. In de optelsom methode worden 2 willekeurig gekozen getallen tussen de 100 en 999 gebruikt. In de minsommen methode worden ook 2 willekeurig gekozen getallen tussen de 100 en 999 gebruikt, maar het antwoord mag niet onder de 100 zijn. In de keersommen methode worden 2 willekeurig gekozen getallen tussen de 5 en 15 gebruikt. In de deelsommen methode worden ook 2 willekeurig gekozen getallen tussen de 5 en 15 vermenigvuldigd, maar het antwoord daarvan wordt gebruikt en ook het kleinste getal van de eerste 2 gekozen getallen wordt gebruikt.

Naast de juiste antwoorden zijn er per probleem ook 4 random gegenereerde foute antwoorden. Die worden op dezelfde manier berekend, maar ze moeten niet meer dan 33% kleiner zijn dan het goede antwoord en ze moeten ook niet meer dan 33% groter zijn. De antwoorden worden in de array ‘antwoorden’ gestopt. Later wordt een foute antwoord vervangen door de juiste antwoord in een random index in de array.

De return van de methode wordt opgeslagen in de ‘antwoorden’ array buiten de methode. Deze array is de parameter van een andere methode. In deze methode worden de antwoorden in de radiobuttons geplaatst.

Het antwoord van de gebruiker kan ik controleren door te kijken of de tekst in de label boven de gedrukte radiobutton hetzelfde is als antwoord[0]. Als het goed is, ‘goed++’ en het genereert een nieuwe som en als het fout is, ‘fout++’ en als er niet meer dan 2 foute antwoorden gedrukt zijn, mag de gebruiker nog verder gaan.

Per tijdsmode wordt er een list gemaakt om alle scores van de speler op te slaan. Het hoogste getal ‘highscore’ per tijd wordt laten zien op de pagina voordat het spel start. Ook wordt er laten zien wat de gemiddelde score is per tijd.
