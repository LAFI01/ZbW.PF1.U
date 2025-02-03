namespace MB09.VererbungBeispiel
{
    public class Medium
    {
        private string Titel { get; set; }
       
     

        public Medium(string titel)
        {
            Titel = titel;
        }

        public string Print()
        {
            return Titel;
        }
    }
}
