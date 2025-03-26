class Program
{
    static void Main(string[] args)
    {
        // StreamReader s = new StreamReader();
        // StreamWriter w = new StreamWriter();

        string[] diretorios = Directory.GetDirectories(@"C:\");

        string[] arquivos = Directory.GetFiles(@"C:\_pasta","*.*",SearchOption.AllDirectories);


        if(File.Exists("\\_pasta\\altera\\output.txt"))
        {
            FileInfo inforarquivo = new FileInfo(@"\_pasta\altera\output.txt");
            Console.WriteLine($"Nome Completo: {inforarquivo.FullName}");
            Console.WriteLine($"Data de Criação: {inforarquivo.CreationTime}");
            Console.WriteLine($"Tamanho do Arquivo: {inforarquivo.Length}");
        }

        string novoDiretorio = @"C:\MeuDiretorio";

        Directory.CreateDirectory(novoDiretorio);

        string nomeArquivo = "MeuArquivo.txt";

        string caminhoArquivo = Path.Combine(novoDiretorio, nomeArquivo);

        using (var fluxoArquivo = File.Create(caminhoArquivo)) 
        {
            for(byte i = 0; i < 10; i++)
            {
                fluxoArquivo.WriteByte(i);
            }

        }

        // USANDO STREAMWRITER

        using (var fluxoArquivo = new StreamWriter(caminhoArquivo))
        {
            string conteudo = "Texto legível";

            for(int i = 0; i< 10; i++)
            {
                fluxoArquivo.WriteLine($"{i} - {conteudo}");
            }

            fluxoArquivo.WriteLine(conteudo);
        }

        Console.ReadKey();
    }
}