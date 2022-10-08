using System; //importação de dependências

namespace Course //NameSpace da classe
{
     class Triangulo // nome da classe
    {
        public double A;// public - prefixo que indica que o atributo pode ser acessado por outros arquivos
        public double B;// A,B,C - atributos da classe
        public double C;//


        public double Area()// double - tipo de dados do metodo a ser usado/ Area - nome do metodo/ () - lista de parametros(nesse caso vazio)
        { // se caso o metodo não retornasse nada seria trocado no lugar de DOUBLE por VOID
            double p = (A + B + C) / 2.0;// corpo do método - parte 1
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));//corpo do método - parte 2(forma de retorno 1)

            // double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C)); // corpo do método - parte 2(forma de retorno 2)
            // return raiz; // corpo do método - parte 3(forma de retorno 2)
        }
    }
}
