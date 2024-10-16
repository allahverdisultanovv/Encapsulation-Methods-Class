namespace ClassEncapsuleMethods
{
    internal class Product
    {
        private string _id;
        private string _brandName;
        private string _model;
        private decimal _price;
        private decimal _cost;
        private decimal _income;
        private int _count;

        public string Id
        {
            get { return _id; }
            set
            {
                _brandName = _brandName.Length > 2 ? _brandName.Substring(0, 2) : _brandName;
                _model = _model.Length > 2 ? _model.Substring(0, 2) : _model;
                _id = _model + _brandName;
            }
        }
        public string BrandName
        {
            get { return _brandName; }
            set
            {
                _brandName = value;
            }
        }
        public string Model { get; set; }
        public decimal Price
        {
            get { return _price; }

            set { _price = value < 0 ? 0 : value; }

        }
        public decimal Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }
        public decimal Income
        {
            get { return _income; }
            set { _income = _price - _cost; }
        }
        public int Count
        {
            get { return _count; }
            set
            {

                _count = value > 0 ? value : 0;
            }
        }
        public Product(string brandName, string model, decimal price, decimal cost, int count)
        {
            BrandName = brandName;
            Model = model;
            Price = price;
            Cost = cost;
            Count = count;
        }
        public static void GetInfo()
        {
            Console.WriteLine("ty");
        }

    }
}
