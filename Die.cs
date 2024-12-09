using System;

namespace OOPAssessment2V2
{
    internal class Die
    {
        public int number { get; private set; }
        private static Random rnd;

        public Die()
        {
            rnd = new Random();
            number = rnd.Next(1, 7);
        }

        public int Roll()
        {
            number = rnd.Next(1, 7);
            return number;
        }
    }
}
