/*
    // Funções interessantes para strings:

            // Formatar: ToLower(), ToUpper(), Trim();

            // Buscar: indexOf, LastIndexOf;

            // Recortar: Subtring(inicio),Substring(inicio,tamanho);

            // Substituir: Replace(char, char), Replace(string, string);

            // String.IsNullOrEmpty(str), String.IsNullOrWhiteSpace(str);

            // str.Split(' '); // recorte de string com base no caractere

            // Conversão para numero: int x = int.Parse(str), int x = Convert.ToInt32(str); converte de string para numero

            // Conversão de numero: str = x.ToString(), str = x.ToString("C"), str = x.ToString("C3"), str = x.ToString("F2")
                    converte de numero para string
//===============================================================================================================
string original = "abcde FGHIJ ABC abc DEFG   ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Substring(3, 5);

            string s6 = original.Replace('a','x');
            string s7 = original.Replace("abc", "XY");

            bool b1 = String.IsNullOrEmpty(original);// nula ou vazia
            bool b2 = String.IsNullOrWhiteSpace(original); // nula ou espaço em branco

            Console.WriteLine();
            Console.WriteLine("Original: -" + original+"-");
            Console.WriteLine();
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine();
            Console.WriteLine("IndexOf (bc): " + n1);
            Console.WriteLine("LastIndexOf (bc): " + n2);
            Console.WriteLine();
            Console.WriteLine("Substring(3): " + s4);
            Console.WriteLine("Substring(3, 5): " + s5);
            Console.WriteLine();
            Console.WriteLine("Replace('a','x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'XY'): -" + s7 + "-");
            Console.WriteLine();
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
 */