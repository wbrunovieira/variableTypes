using System;

namespace VariableTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string nameDog = "Teddy";
            int dogAge = 1;
            char firstLetter = 'T';
            bool likePlay = true;
            double toys = 12;
            decimal weigth = 70m;

                Console.WriteLine($"My dog name's is {nameDog}, he is {dogAge} old, the first letter'name is {firstLetter}. If you ask me he loves to play it is so {likePlay}. He has {toys} to play all day long and keep his {weigth} pounds");
        }
    }
}
