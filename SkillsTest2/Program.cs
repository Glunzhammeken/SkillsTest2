namespace SkillsTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Test af opgave 2
            Studerende s1 = new Studerende();
            s1.Name = "Bo";
            s1.Id = 1;
            s1.Adresse = "hejvej 4";
            s1.CprNummer = "2727272727";

            Studerende s2 = new Studerende();
            s2.Name = "Bob";
            s2.Id = 2;
            s2.Adresse = "hejvejsej 5";
            s2.CprNummer = "5050505050";

            Studerende s3 = new Studerende();
            s3.Name = "søren";
            s3.Id = 3;
            s3.Adresse = "Roskildevej 5";
            s3.CprNummer = "9191919199";


            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            
            Hold h1 = new Hold();

            h1.Type = "Datamatiker";
            h1.Lokation = "Næstved";
            h1.Betegnelse = "a";

            Hold h2 = new Hold();

            h2.Type = "Autoteknolog";
            h2.Lokation = "Roskilde";
            h2.Betegnelse = "c";

            Hold h3 = new Hold();

            h3.Type = "It-Teknolog";
            h3.Lokation = "Køge" ;
            h3.Betegnelse = "b";


            Console.WriteLine(h1);
            Console.WriteLine(h2);
            Console.WriteLine(h3);

            // Test af add og remove student
            h3.AdderStudent(s1);
            h3.AdderStudent(s2);
            h3.DeleteStudent(s1.Id);
            h3.AdderStudent(s3);
            h3.PrintStuderende();
            Console.WriteLine("\n");


            //Test af try catch
            Studerende s4 = new Studerende();
            try
            {
               
                s4.Name = "Bo";
                s4.Id = -1;
                s4.Adresse = "rosvej 4";
                s4.CprNummer = "2727272727";

            }
            catch (FormatException e) {Console.WriteLine(e.Message);}



            Studerende s5 = new Studerende();
            try
            {

                s5.Name = "D";
                s5.Id = -1;
                s5.Adresse = "campusvej 7";
                s5.CprNummer = "2727272727";

            }
            catch (FormatException e) { Console.WriteLine(e.Message); }

            Studerende s6 = new Studerende();
            try
            {

                s6.Name = "Daniel";
                s6.Id = 5;
                s6.Adresse = "hillervej  77";
                s6.CprNummer = "272727";

            }
            catch (FormatException e) { Console.WriteLine(e.Message); }

        }
    }
}
