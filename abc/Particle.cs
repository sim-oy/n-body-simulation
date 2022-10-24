
namespace abc
{
    class Particle
    {
        public double x;
        public double y;
        public double vx;
        public double vy;
        public double mass;

        public Particle(double x, double y, double mass)
        {
            this.x = x;
            this.y = y;
            this.mass = mass;
        }
        
        public void Move()
        {
            this.x += vx;
            this.y += vy;
        }
    }
}
