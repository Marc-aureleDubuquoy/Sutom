namespace Sutom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mots = { "falsifier", "fabricant", "tableau", "variable", "constante", "console",
                  "manette", "clavier", "serveur", "boucle", "indice", "element", "programme" };
            Random alea = new Random();
            int index = alea.Next(mots.Length);
            string motATrouver = mots[index];
            Console.WriteLine("Bienvenue dans le jeu Sutom,tente ta chance pour trouvez le mot mystère !");
            Console.WriteLine();
            for (int i = 1; i <= motATrouver.Length; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            Console.Write(motATrouver[0]);
            string proposition = (Console.ReadLine() ?? string.Empty).ToLowerInvariant();

            while (proposition.Length != motATrouver.Length || proposition[0] != motATrouver[0])
            {
                if (proposition.Length != motATrouver.Length &&
                    (proposition.Length == 0 || proposition[0] != motATrouver[0]))
                {
                    Console.WriteLine($"Le mot doit commencer par {motATrouver[0]} et faire {motATrouver.Length} lettres.");
                }
                else if (proposition.Length != motATrouver.Length)
                {
                    Console.WriteLine($"Le mot doit faire {motATrouver.Length} lettres !");
                }
                else
                {
                    Console.WriteLine($"Le mot doit commencer par {motATrouver[0]}.");
                }

                proposition = (Console.ReadLine() ?? string.Empty).ToLowerInvariant();
            }
        }
    }
}
