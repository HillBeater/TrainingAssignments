using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodExampleOfGenric
{
   
    class Food
    {
        public string Name { get; set; }
        public FoodType FoodType { get; set; }
        public float Price { get; set; }
        public Cuisine Cuisine { get; set; }


    }
    public enum Cuisine
    {

        Indian,
        Italic,
        Chinese,
        Spanish,
    }

    public enum FoodType
    {
        Starter,
        MainCourse,
        Dessert
    }


}





