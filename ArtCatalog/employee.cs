namespace ArtCatalog
{
    class employee : Person
    {
        private string login;
        private string pas_hash;
        private string position;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Pas_hash
        {
            get { return pas_hash; }
            set { pas_hash = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }


        public employee()
        {

        }
    }
}
