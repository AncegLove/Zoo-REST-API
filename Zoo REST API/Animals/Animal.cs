namespace Zoo_REST_API.Animals
{
    public abstract class Animal
    {
        private string _name;
        private int _id;
        private int _energy;
        public Animal(string name, int id, int energy)
        {
            _name = name;
            _id = id;
            _energy = energy;
        }
        public string Name { get { return _name; } }
        public int Id { get { return _id;} set { _id = value; } }
        public int Energy { get { return _energy; } set 
            {
                if ((_energy + value) > 100) _energy = 100; 
                else _energy = value;
            } 
        }
    }
}
