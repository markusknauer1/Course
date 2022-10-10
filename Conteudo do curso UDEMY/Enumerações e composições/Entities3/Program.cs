/*
        EXERCICIO RESOLVIDO 2:
            demo StringBuilder


                using Course.Entities;

                Comment c1 = new Comment("Have a nice trip!");
                Comment c2 = new Comment("woww, that's awesome!");
                Post p1 = new Post(
                        DateTime.Parse("21/06/2022 13:05:44"),
                        "Travelling to New Zealand!",
                        "I'm going to visit this wonderful country!",
                        12
                    );

                p1.AddComment(c1);
                p1.AddComment(c2);

                Comment c3 = new Comment("Good night!");
                Comment c4 = new Comment("May the force be width you");
                Post p2 = new Post(
                        DateTime.Parse("22/08/2022 13:05:44"),
                        "Good night guys",
                        "see you tomorrow",
                        5
                    );

                p2.AddComment(c3);
                p2.AddComment(c4);

                Console.WriteLine(p1);
                Console.WriteLine(p2);
       
            */