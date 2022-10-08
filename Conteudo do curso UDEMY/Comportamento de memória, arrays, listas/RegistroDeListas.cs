// listas - part1
        // Conceito de lista = Homogenea, Ordenada, Inicia vazia e seus
        // elemento alocados por demanda,cada elemento ocupa um "nó"
        // class List
        // nameSpace: system.collections.generics;

        //Vantagens:
        // tamanho variavel;
        // facilidade de inserção e deleção;

        //Desvantagem:
        // Acesso sequencial aos elemntos;* é possivel otimizar a lista para acesso rapido aos nodos.

        // Tipo List - Declaração, instaciação;
        // Assuntos pendentes:
        // generics:
        // predicados (lambda):
/*
        List<string> list = new List<string>();

        list.Add("Maria");
        list.Add("Alex");
        list.Add("Bob");
        list.Add("Laura");
        list.Insert(2, "Marco");

        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }

        Console.WriteLine("List cout: " + list.Count);
            
        Console.WriteLine("==========primeiro e ultimo nome dentro da lista que inicia com 'M' ====");
        string s1 = list.Find(x => x[0] == 'M');// expressão lambda
        //string s1 = list.Find(Test);predicado verdadeiro ou falso no valor lambda
        Console.WriteLine("first M: "+ s1);

        string s2 = list.FindLast(x => x[0] == 'M');// expressão lambda
        //string s1 = list.Find(Test);predicado verdadeiro ou falso no valor lambda
        Console.WriteLine("last M: " + s2);

        Console.WriteLine("=============posição do primeiro e do ultimo 'M' da lista================");
        int pos1 = list.FindIndex(x => x[0] == 'M');// expressão lambda
        //string s1 = list.Find(Test);predicado verdadeiro ou falso no valor lambda
        Console.WriteLine("first posição M: " + pos1);

        int pos2 = list.FindLastIndex(x => x[0] == 'M');// expressão lambda
        //string s1 = list.Find(Test);predicado verdadeiro ou falso no valor lambda
        Console.WriteLine("last posição M: " + pos2);

        Console.WriteLine("========== filtro por quantidade de letras no nome (no caso: 5) =========");
        List<string> list2 = list.FindAll(x => x.Length == 5);
        foreach(string obj in list2)
        {
            Console.WriteLine(obj);
        }
            Console.WriteLine("========== remoção de items da lista (no caso remoção apenas de Alex) =========");
        list.Remove("Alex");
        Console.WriteLine();
        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }


        Console.WriteLine("========== remoção de items da lista (no caso remoção dos 'M')=========");
        list.RemoveAll(x => x[0] == 'M');
        Console.WriteLine();
        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }
        Console.WriteLine("========== remoção de items da lista (no caso remoção pela posição(2))=========");
        list.RemoveAt(3);
        Console.WriteLine();
        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }
            
        Console.WriteLine("========== remoção de items da lista (no caso remoção por quantida apartir da posição(2))=========");
        list.RemoveRange(2, 2);
        Console.WriteLine();
        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }
            */
        
        /*
        static bool Test(string s)
        {
            return s[0] == 'A';
        }*/