namespace Abstract_Task1
{
    internal class Triangle : Figure
    {
        private float SideA;
        private float SideB;
        private float SideC;

        protected Triangle() { }
        public Triangle(float SideA, float SideB, float SideC)
        {
            this.SideA = SideA;
            this.SideB = SideB;
            this.SideC = SideC;
        }

        public override float GetPerimeter() => SideA + SideB + SideC;

        public override float GetArea()
        {
            float perimeterHalf = (SideA + SideB + SideC) / 2;

            return Convert.ToSingle(
                        Math.Sqrt(perimeterHalf
                                * (perimeterHalf - SideA)
                                * (perimeterHalf - SideB)
                                * (perimeterHalf - SideC)));
        }
    }
}