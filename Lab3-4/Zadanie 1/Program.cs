using Lab3_4;
using System;

public class Program
{
    public static void Main(string[] args)
    {
       

        Snake snake = new Snake();

        snake.Species = "Snake";
        snake.Pattern = "striped lengthwise";
        snake.IsVenomous = true;
        snake.Length = "12 m";
        snake.Name = "Bob";
        snake.Age = 5;
        snake.Habitat = "swamps";



        snake.DisplayPattern();
        snake.Move();
        snake.animal_sound();
        snake.sleep();



    }

}

