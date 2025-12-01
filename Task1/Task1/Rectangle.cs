namespace Task1
{
    public class Rectangle
    {
        private double length;
        private double breadth;

        // Properties
        public double Length
        {
            get => length;
            set => length = value;
        }

        public double Breadth
        {
            get => breadth;
            set => breadth = value;
        }

        // Method to calculate area 
        public double GetArea() => length * breadth;

        // Method to calculate perimeter
        public double GetPerimeter() => 2 * (length + breadth);

        // Method to show details
        public string ShowDetails() => $"Length: {length}, Breadth: {breadth}";
    }
}