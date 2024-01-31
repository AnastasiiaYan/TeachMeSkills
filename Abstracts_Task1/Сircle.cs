namespace Abstract_Task1
{
    internal class Сircle : Rectangle
    {
        private float Radius;
        public Сircle(float radius)
        {
            this.Radius = radius;
        }
        

        public override float GetPerimeter() => 2 * (float)Math.PI * Radius;

        public override float GetArea() => (float)Math.PI * Radius * Radius;
    }
}