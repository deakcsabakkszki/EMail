namespace EMail
{
    internal class Program
    {
        //adatszerkezet
        

        static void Main(string[] args)
        {
            List<String> e_mailok = new List<String>();
            e_mailok.Add("alma1@kört.hu");
            e_mailok.Add("alma2.dfdfdf.hu");
            e_mailok.Add("alma3@ssdsds.hu");
            e_mailok.Add("deak.csaba@kkszki.hu");
            e_mailok.Add("alma.korte@alma.hu");
            //menüvezérlés
            while (true) {
                Console.Clear();
                Console.WriteLine("0. Kilépés");
                Console.WriteLine("1. e-mailek listázása");
                Console.WriteLine("2. új e-mail");
                Console.WriteLine("3. e-mail törlése");
                Console.WriteLine("4. érvényes e-mailok listázása");

                string valasztas=Console.ReadLine();
                switch (valasztas) {
                    case "0" : return;
                    case "1" : Console.WriteLine("e-mailek listázása"); break;
                    case "2" : Console.WriteLine("új e-mailek"); break;
                    case "3" : Console.WriteLine("e-mail törlés"); break;
                    case "4" : Console.WriteLine("évényesek listázás"); break;
                    default : Console.Clear(); Console.WriteLine("rossz parancs");break;
                }
                Console.ReadKey();  
            }
        }
    }
}
