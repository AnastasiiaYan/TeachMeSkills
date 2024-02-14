namespace Abstract_Task1
{
    internal class Rectangle : Triangle
    {
        private float SideA;
        private float SideB;

        protected Rectangle() { }
        public Rectangle(float SideA, float SideB)
        {
            this.SideA = SideA;
            this.SideB = SideB;
        }

        public override float GetPerimeter() => 2 * SideA + 2 * SideB;

        public override float GetArea() => SideA * SideB;
    }
}