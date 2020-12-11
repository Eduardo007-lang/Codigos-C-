namespace ArraysCourse
{
    class Product
    {
        //Atibutos autoimplementado
        public string Name { get; set; }
        public double Price { get; set; }

        //Construtor de 2 parametros 
        public Product (string Name, double Price){
            
            this.Name = Name;
            this.Price = Price;
        
        }
    }
}
