// See https://aka.ms/new-console-template for more information
/*using System;

class Program
{
    static void Main()
    {
        int[] chiffres = { 5, 10, 15, 20 };

        Console.WriteLine("Chiffres dans le tableau (ordonnés) :");
        AfficherTableau(chiffres);

        // Ajout d'un nouveau chiffre
        int nouveauChiffre = 12;
        chiffres = InsererDansTableauTrié(chiffres, nouveauChiffre);

        Console.WriteLine($"\nAprès l'ajout du chiffre {nouveauChiffre} :");
        AfficherTableau(chiffres);
    }

    static int[] InsererDansTableauTrié(int[] tableau, int element)
    {
        int[] nouveauTableau = new int[tableau.Length + 1];
        int i = 0, j = 0;

        while (i < tableau.Length && tableau[i] < element)
        {
            nouveauTableau[j++] = tableau[i++];
        }

        nouveauTableau[j++] = element;

        while (i < tableau.Length)
        {
            nouveauTableau[j++] = tableau[i++];
        }

        return nouveauTableau;
    }

    static void AfficherTableau(int[] tableau)
    {
        foreach (int chiffre in tableau)
        {
            Console.WriteLine(chiffre);
        }
    }
*/
//les livres 

using System;

class Livre
{
    public string Titre;

    public Livre(string titre)
    {
        Titre = titre;
    }
}

class Bibliotheque
{
    private Livre[] livres;
    private int nombreLivres;

    public Bibliotheque(int capacite)
    {
        livres = new Livre[capacite];
        nombreLivres = 0;
    }

    public void AjouterLivre(Livre livre)
    {
        int index = 0;
        while (index < nombreLivres && String.Compare(livres[index].Titre, livre.Titre) < 0)
        {
            index++;
        }


        for (int i = nombreLivres; i > index; i--)
        {
            livres[i] = livres[i - 1];
        }


        livres[index] = livre;
        nombreLivres++;
    }

    public void AfficherLivres()
    {
        for (int i = 0; i < nombreLivres; i++)
        {
            Console.WriteLine(livres[i].Titre);
        }
    }
}

class Program
{
    static void Main()
    {
        Bibliotheque bibliotheque = new Bibliotheque(10);

        bibliotheque.AjouterLivre(new Livre("1984"));
        bibliotheque.AjouterLivre(new Livre("Le Seigneur des Anneaux"));

        Console.WriteLine("Livres dans la bibliothèque (ordonnés par titre) :");
        bibliotheque.AfficherLivres();

        // Ajout d'un nouveau livre
        bibliotheque.AjouterLivre(new Livre("Le Petit Prince"));
        Console.WriteLine("\nAprès l'ajout d'un nouveau livre :");
        bibliotheque.AfficherLivres();
    }
}

