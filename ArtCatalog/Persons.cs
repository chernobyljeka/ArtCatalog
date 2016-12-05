using System;

namespace ArtCatalog
{
    abstract class Persons
    {
        protected int id;
        protected string name;
        protected string surname;
        protected DateTime date;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
                      
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public Persons()
        {

        }

        public Persons(int id,
                       string name,
                       string surname,
                       DateTime date)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.date = date;
        }

    }

}
