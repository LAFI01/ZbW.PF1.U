using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MB04.Hund
{
    public class Dog
    {
        private int _age;

        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Dog()
        {

        }

        public string Name { get; set; }

        public int Age
        {
            get { return _age; }
            set
            {
                //variant 1
                if (value < 0 || value > 35)
                {
                    _age = -1;
                }
                else
                {
                    _age = value;
                }
            }
        }

        public string PlayBall (Ball ball)
        {
            var nameBall = ball.Name;
            return nameBall;
        }

        public bool DogEquals (Dog oldDog, Dog newDog)
        {
            string oldDogName = oldDog.Name;
            int oldDogAge = oldDog.Age;

            string newDogName = newDog.Name;
            int newDogAge = newDog.Age;

            if(oldDogName == newDogName) { return true; }
            else { return false; }
            if(oldDogAge == newDogAge) {  return true; }
            else { return false; }
        }
    }
}
