/*
// SINTAXE:
    // ( CONDIÇÂO ) ? VALOR_SE_VERDADEIRO : VALOR_SE_FALSO

    // ( CONDIÇÂO ) ? AÇÂO_A_CUMPRIR_SE_VERDADEIRO{if reduzido} : AÇÂO_A_CUMPRIR_SE_FALSO{else reduzido}

    // ( 2 > 4 )    ?   50   :   80 = impressão 80, porque a condição é falsa(ou seja pega o valor depois dos ponto (:)

    // ( 10 != 03)  ?   "Maria"  :   "Alex" = impressão "Maria", porque a condição é verdadeira(ou seja pega o valor
                                                depois da interrogação (?) e antes dos pontos (:).

EXEMPLO:
    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05; ==> condição ternaria
           
            // condição IF : ELSE
            double desconto = 

            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }
            Console.WriteLine(desconto);
 */