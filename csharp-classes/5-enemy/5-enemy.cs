using System;

namespace Enemies
{
    /// <summary>
    ///  Enemies class containing Zombie method
    /// </summary>
    class Zombie
    {
        private int health;
        private string name = "(No name)";

        public Zombie()
        {
            health = 0;
        }
        
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        public int GetHealth()
        {
            return health;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return $"Zombie Name: {name} / Total Health: {health}";
        }
    }
}
