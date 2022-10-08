/*
    AVISO IMPORTANTE SOBRE CONVERSÂO DE STRING:


No proximo video ira ser tratado sobre ENUMERAÇÔES. 
Na aula sera feita a conversão de STRING para ENUMERAÇÂO assim:

    OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

mas, dependendo da versão do compilador C#, isso pode dar problema. Se for o caso, por favor tente deste jeito:

    OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus),("Delivered"));

Se mesmo assim ainda tiver dando erro, há ainda uma terceira forma:

    OrderStatus os;
    Enum.TryParse("Delivered", out os);

Atenciosamente
 */