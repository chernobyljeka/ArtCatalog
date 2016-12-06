using System.Drawing;

namespace ArtCatalog
{
    class Product
    {
        private int id;
        private string name;
        private string discription;
        private int count;
        private int price;
        private Image img;
 
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

        public string Discription
        {
            get { return discription; }
            set { discription = value; }
        }

        public int Cont
        {
            get { return count; }
            set { count = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public Image Img
        {
            get { return img; }
            set { img = value; }
        }

        public Product()
        {

        }

        public Product(int id,
                       string name,
                       string discription,
                       int count,
                       int price)
        {
            this.id = id;
            this.name = name;
            this.discription = discription;
            this.count = count;
        }

        public Product(int id,
                      string name,
                      string discription,
                      int count,
                      int price,
                      Image img)
        {
            this.id = id;
            this.name = name;
            this.discription = discription;
            this.count = count;
            this.img = img;
        }
    }

}

