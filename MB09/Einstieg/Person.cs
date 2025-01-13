namespace MB09.Einstieg
{
    public   class Person
    {

        public Person()
        {
            Counter++;
        }


        public static int Counter
        {
            get;set;
        }

        public  string Name { get; set; }
        public  int Age { get; set; }
        public  string Firstname { get; set; }
    }
}
