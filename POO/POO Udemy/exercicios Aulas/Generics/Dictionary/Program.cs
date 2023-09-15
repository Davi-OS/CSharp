using Dictionary.Entitie;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            string path = @"C:\Users\davio\OneDrive\Documentos\CloneGit\CSHARP\CSharp\POO\POO Udemy\exercicios Aulas\Generics\Dictionary\Entitie\TextFile1.txt";
            FileStream fileStream = null;
            StreamReader streamReader = null;
            try
            {
                fileStream = new FileStream(path, FileMode.Open);
                streamReader = new StreamReader(fileStream);

                while (!streamReader.EndOfStream)
                {
                    string[] line = streamReader.ReadLine().Split(',');
                    Candidate candidate = new Candidate(line[0], int.Parse(line[1]));
                    if (keyValuePairs.ContainsKey(candidate.Name))
                    {
                        keyValuePairs[candidate.Name] += candidate.Votes;
                    }
                    else
                    {
                        keyValuePairs.Add(candidate.Name, candidate.Votes);
                    }
                }
                foreach (var item in keyValuePairs)
                {
                    Console.WriteLine($"Total votes for {item.Key}: {item.Value}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error accurred! " + ex.Message);
            }
        }
    }
}