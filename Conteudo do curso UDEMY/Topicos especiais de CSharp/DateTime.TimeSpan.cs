/*
    0// DATETIME
                * Representa um INSTANTE = pode ser uma data ou uma data e hora;
                * É um tipo valor (STRUCT)
            // Agenda:
                * Represenatção interna;
                    * armazena internamente o numero de "ticks"(100 nanosegundos) desde a meia noite 
                      do dia 1 de janeiro do ano 1 da era comum;
                                
                                DateTime d1 = DateTime.Now;
                                Console.WriteLine(d1);
                                Console.WriteLine(d1.Year);

                * Instanciação: construtores, builders / conversão String -> DateTime
                    *  
                * Formatação: DateTime -> string
            
            DateTime d1 = new DateTime(2018, 11, 25);
            DateTime d2 = new DateTime(2018, 11, 25, 20,45,3);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3, 500);


            DateTime d4 = DateTime.Now;// (horario do brasil é -3)
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;// (horario gmt+3)

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            DateTime convert.Parse:

            DateTime d1 = DateTime.Parse("2000-08-15");
            DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");

            DateTime d3 = DateTime.Parse("15/08/2020 13:05:58");

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            

            DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);

            DateTime d2 = DateTime.ParseExact("15/08/2020 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d1);
            Console.WriteLine(d2);
*/
/*
    // Propriedades e operações com DateTime

               * Date (DateTime); // data do dateTime
               * Day (int) // somente o dia
               * DayOfWeek (DayOfWeek) // dia da semana = tipo enumerado - definir um conjunto de constantes(dom, seg,ter)
               * DayOfYear (int) // dia do ano
               * Hour (int) // hora 
               * Kind (DateTimeKind)
               * Millisecond (int)
               * Minute (int)
               * Month (int)
               * Second (int)
               * Ticks (long = L)
               * TimeOfDay (TimeSpan)
               * Year (int)

           //DateTime d = new DateTime(2022, 10, 05, 13, 45, 58, 275);
           DateTime d = DateTime.Now;

           Console.WriteLine(d);
           Console.WriteLine("1) Date: "+ d.Date);
           Console.WriteLine("2) Day: " + d.Day);
           Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
           Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
           Console.WriteLine("5) Hour: " + d.Hour);
           Console.WriteLine("6) Kind: " + d.Kind);
           Console.WriteLine("7) Millisecond: " + d.Millisecond);
           Console.WriteLine("8) Minute: " + d.Minute);
           Console.WriteLine("9) Month: " + d.Month);
           Console.WriteLine("10) Second: " + d.Second);
           Console.WriteLine("11) Ticks: " + d.Ticks);
           Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
           Console.WriteLine("13) Year: " + d.Year);


            DateTime d = new DateTime(2022, 10, 05);
           //DateTime d = DateTime.Now;
           DateTime dif = new DateTime(2022, 10, 12);

           Console.WriteLine(d.ToLongDateString());
           Console.WriteLine(d.ToLongTimeString());
           Console.WriteLine(d.ToShortDateString());
           Console.WriteLine(d.ToShortTimeString());
           Console.WriteLine(d.ToString());
           Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss"));
           Console.WriteLine(d.ToString("yyyy-MM-dd HH:mm:ss.fff"));

           // Operações com DateTime

           DateTime y1 = d.AddHours(2);
           DateTime y2 = d.AddMinutes(2);

           DateTime y3 = d.AddDays(7);

           TimeSpan t = dif.Subtract(d);


           Console.WriteLine();
           Console.WriteLine(y1);
           Console.WriteLine(y2);
           Console.WriteLine(y3);

           Console.WriteLine(t);
*/
/*
  // TimeSpan
            * Representa uma DURAÇÂO: 
                * um objeto TimeSpan internamente armazena uma duração na forma de ticks(100 nanosegundos)
                            TimeSpan ti = new TimeSpan(0, 0, 10);
                            Console.WriteLine(ti); // 00;00:10 ====> impressão
                            Console.WriteLine(ti.Ticks); // 100000000 ====> Contagem de nanosegundos
                            
            * É um tipo valor (STRUCT):
                 
                * Agenda:
                    * Representação interna;
                    * Instanciação: construtores, fields, métodos From, Parse;
                     
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);
            TimeSpan t3 = new TimeSpan(2, 11, 21);
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 500);

            // instanciando com *FROM
            TimeSpan f1 = TimeSpan.FromDays(1.5);
            TimeSpan f2 = TimeSpan.FromHours(1.5);
            TimeSpan f3 = TimeSpan.FromMinutes(1.5);
            TimeSpan f4 = TimeSpan.FromSeconds(1.5);
            TimeSpan f5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan f6 = TimeSpan.FromTicks(900000000l);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);

            // Impressão com *FROM
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(f3);
            Console.WriteLine(f4);
            Console.WriteLine(f5);
            Console.WriteLine(f6);

*/
/*
    // Propriedades e operações com TimeSpan


           TimeSpan t1 = TimeSpan.MaxValue;
           TimeSpan t2 = TimeSpan.MinValue;
           TimeSpan t3 = TimeSpan.Zero;

           Console.WriteLine(t1);
           Console.WriteLine(t2);
           Console.WriteLine(t3);

           TimeSpan t = new TimeSpan(1, 00, 0, 0, 00);

           Console.WriteLine(t);
           Console.WriteLine("Days: "+ t.Days);
           Console.WriteLine("Hours: " + t.Hours);
           Console.WriteLine("Minutes: " + t.Minutes);
           Console.WriteLine("Seconds: " + t.Seconds);
           Console.WriteLine("Milliseconds: " + t.Milliseconds);
           Console.WriteLine("Ticks: " + t.Ticks);

           Console.WriteLine("TotalDays: " + t.TotalDays);
           Console.WriteLine("TotalHours: " + t.TotalHours);
           Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
           Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);
           Console.WriteLine("TotalSeconds: " + t.TotalSeconds);

           // operações calculadas
           TimeSpan t1 = new TimeSpan(1, 30, 10);
           TimeSpan t2 = new TimeSpan(0, 10, 5);

           TimeSpan sum = t1.Add(t2);
           TimeSpan dif = t1.Subtract(t2);
           TimeSpan multi = t2.Multiply(2.0);
           TimeSpan div = t2.Divide(2.0);

           Console.WriteLine(sum);
           Console.WriteLine(dif);
           Console.WriteLine(multi);
           Console.WriteLine(div);
*/
/*
    // DateTimeKind e padrão ISO 8601
            // DateTimeKind = tipo enumerado que define três valores possiveis para a localidade da data:
                *   Local (Fuso horario do sistema em exercico: "São Paulo = GMT -3 / no horario de verão vira GMT -2);
                *   UTC (Fuso horario GMT (Green Mean Time);
                *   Unspecified
             
            Boa Pratica:
                *   armazenar formato sempre em UTC (text: BD / Json/ XML);
                *   Instanciar e mostrar em formato local;
            
            Para converter um DateTime para local ou UTC, voce deve usar:
                *   myDate.ToLocalTime();
                *   myDate.ToUniversalTime();

            // formatos de conversão de horario:

            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("D1: " + d1);
            Console.WriteLine("D1 kind " + d1.Kind);
            Console.WriteLine("D1 to Local " + d1.ToLocalTime());
            Console.WriteLine("D1 to Utc " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("D2: " + d2);
            Console.WriteLine("D2 kind " + d2.Kind);
            Console.WriteLine("D2 to Local " + d2.ToLocalTime());
            Console.WriteLine("D2 to Utc " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("D3: " + d3);
            Console.WriteLine("D3 kind " + d3.Kind);
            Console.WriteLine("D3 to Local " + d3.ToLocalTime());
            Console.WriteLine("D3 to Utc " + d3.ToUniversalTime());

            //Padrão ISO 8601:

            Formato:
                "yyyy-MM-ddTHH:mm:ssZ" = Z => indica que a data/hora esta em Utc.

            DateTime d1 = DateTime.Parse("2022-10-08 16:01:58");
            DateTime d2 = DateTime.Parse("2022-10-08T16:01:58Z");

            Console.WriteLine("d1 " + d1);
            Console.WriteLine("d1 Kind " + d1.Kind);
            Console.WriteLine("d1 To Local " + d1.ToLocalTime());
            Console.WriteLine("d1 To Utc " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2 " + d2);
            Console.WriteLine("d2 Kind " + d2.Kind);
            Console.WriteLine("d2 To Local " + d2.ToLocalTime());
            Console.WriteLine("d2 To Utc " + d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssZ"));// cuidado!
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));// cuidado!

*/