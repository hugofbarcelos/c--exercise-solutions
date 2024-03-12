using System;
using Exercises.Models;
namespace Exercises
{
    public class Exercise002
    {
        // 👉 Remember to delete all unnecessary comments (like this one) when you're done! 

        public bool IsFromManchester(Person person)
        {
            if(person == null) return false;
            return person.City == "Manchester" ? true : false;
        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            return person.Age <= ageLimit ? false : true;
        }
    }
}
