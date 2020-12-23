namespace Shop2.Data.Models
{
    public class Car
    {
        public int id { set; get; }

        public string name { set; get; }

        public string desc { set; get; }

        public string img { set; get; }

        public ushort price { set; get; }

        public bool available { set; get; }

        public int categoryID { set; get; }

        public virtual Category Category { set; get; }
    }
}
