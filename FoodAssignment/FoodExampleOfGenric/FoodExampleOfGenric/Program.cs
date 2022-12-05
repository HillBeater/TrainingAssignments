using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static FoodExampleOfGenric.Food;

namespace FoodExampleOfGenric
{
    
    

    class Program
    {
        static void Main(string[] args)
        {
            List<Food> foodList = new List<Food>();


            //India, Italic, Chinese, Spanish

            //Indian
            foodList.Add(new Food { Name = "Panner Tikka", FoodType = FoodType.Starter, Price = 250, Cuisine = Cuisine.Indian });
            foodList.Add(new Food { Name = "Chicken Tikkat", FoodType = FoodType.Starter, Price = 350, Cuisine = Cuisine.Indian });
            foodList.Add(new Food { Name = "Aloo Mater", FoodType = FoodType.MainCourse, Price = 250, Cuisine = Cuisine.Indian });
            foodList.Add(new Food { Name = "Butter Chicken", FoodType = FoodType.MainCourse, Price = 450, Cuisine = Cuisine.Indian });
            foodList.Add(new Food { Name = "Gulab Jamun", FoodType = FoodType.Dessert, Price = 120, Cuisine = Cuisine.Indian });
            foodList.Add(new Food { Name = "Rasmalai", FoodType = FoodType.Dessert, Price = 150, Cuisine = Cuisine.Indian });

            //Italic
            foodList.Add(new Food { Name = "Caprese Garli Bread", FoodType = FoodType.Starter, Price = 260, Cuisine = Cuisine.Italic });
            foodList.Add(new Food { Name = "Chesse Corn Balls", FoodType = FoodType.Starter, Price = 310, Cuisine = Cuisine.Italic });
            foodList.Add(new Food { Name = "Malfatti", FoodType = FoodType.MainCourse, Price = 350, Cuisine = Cuisine.Italic });
            foodList.Add(new Food { Name = "Chicken Osso Buco", FoodType = FoodType.MainCourse, Price = 600, Cuisine = Cuisine.Italic });
            foodList.Add(new Food { Name = "White Peach Tart", FoodType = FoodType.Dessert, Price = 140, Cuisine = Cuisine.Italic });
            foodList.Add(new Food { Name = "Torta Della Nonna", FoodType = FoodType.Dessert, Price = 170, Cuisine = Cuisine.Italic });

            //Chinese
            foodList.Add(new Food { Name = "Veggie Spring Rolls", FoodType = FoodType.Starter, Price = 280, Cuisine = Cuisine.Chinese });
            foodList.Add(new Food { Name = "Soy sauce eggs", FoodType = FoodType.Starter, Price = 300, Cuisine = Cuisine.Chinese });
            foodList.Add(new Food { Name = "Vegetarian Fried Rice", FoodType = FoodType.MainCourse, Price = 380, Cuisine = Cuisine.Chinese });
            foodList.Add(new Food { Name = "Stir-Fried Chilli Chicken", FoodType = FoodType.MainCourse, Price = 450, Cuisine = Cuisine.Chinese });
            foodList.Add(new Food { Name = "Red Been Bun", FoodType = FoodType.Dessert, Price = 150, Cuisine = Cuisine.Chinese });
            foodList.Add(new Food { Name = "Pumpkin pancakes", FoodType = FoodType.Dessert, Price = 180, Cuisine = Cuisine.Chinese });

            //Spanish
            foodList.Add(new Food { Name = "Patatas Bravas", FoodType = FoodType.Starter, Price = 180, Cuisine = Cuisine.Spanish });
            foodList.Add(new Food { Name = "Gambas a la Plancha", FoodType = FoodType.Starter, Price = 210, Cuisine = Cuisine.Spanish });
            foodList.Add(new Food { Name = "Espinacas con garbanzos", FoodType = FoodType.MainCourse, Price = 450, Cuisine = Cuisine.Spanish });
            foodList.Add(new Food { Name = "Arroz con huevo", FoodType = FoodType.MainCourse, Price = 680, Cuisine = Cuisine.Spanish });
            foodList.Add(new Food { Name = "Panellets", FoodType = FoodType.Dessert, Price = 210, Cuisine = Cuisine.Spanish });
            foodList.Add(new Food { Name = "Spanish Sponge Cake", FoodType = FoodType.Dessert, Price = 240, Cuisine = Cuisine.Spanish });

            //Display Function
            DisplayMenu(foodList);
          

            while (foodList.Count > 0)
            {

                try
                {
                    Console.WriteLine("Enter 1 To Sort The Menu Items on the Basis of Price");
                    Console.WriteLine("Enter 2 To Filter The Menu Items on the Basis of Cuisine");
                    Console.WriteLine("Enter 3 To Search a Item with Name");
                    Console.WriteLine("Enter 4 To Search Item with Cuisine Name");
                    Console.WriteLine();

                    Console.WriteLine("Enter Your Choice");
                    int Num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();



                    switch (Num)
                    {
                        case 1:

                            var SortedList = foodList.OrderBy(item => item.Price).ToList();

                            DisplaySortedList(SortedList);

                            Console.WriteLine();
                            break;

                        case 2:
                            Console.WriteLine("Press 1 For Indian Cuisine");
                            Console.WriteLine("Press 2 For Italic Cuisine");
                            Console.WriteLine("Press 3 For Chinese Cuisine");
                            Console.WriteLine("Press 4 For Spanish Cuisine");
                            Console.WriteLine();

                            Console.WriteLine("Enter Your Choice");
                            int ChoiceNum = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();                           

                            switch (ChoiceNum)
                            {
                                case 1:
                                    var resultIndiaCuisine = foodList.Where(obj => obj.Cuisine == Cuisine.Indian).ToList();

                                    DisplayMenu(resultIndiaCuisine);
                                  
                                    break;

                                case 2:
                                    var resultItalicCuisine = foodList.Where(obj => obj.Cuisine == Cuisine.Italic).ToList();

                                    DisplayMenu(resultItalicCuisine);

                                    break;

                                case 3:
                                    var resultChineseCuisine = foodList.Where(obj => obj.Cuisine == Cuisine.Chinese).ToList();

                                    DisplayMenu(resultChineseCuisine); 

                                    break;

                                case 4:
                                    var resultSpanishCuisine = foodList.Where(obj => obj.Cuisine == Cuisine.Spanish).ToList();

                                    DisplayMenu(resultSpanishCuisine);
                                   
                                    break;

                                default:
                                    Console.WriteLine("Wrong Choice");
                                    Console.WriteLine();
                                    break;

                            }
                            break;

                        case 3:
                            Console.WriteLine("Enter the Item Name");
                            string foodName = Console.ReadLine();
                            Console.WriteLine();

                          
                                if (foodName.Length >= 3)
                                {
                                    var resultfoodName = foodList.Where(item => item.Name.ToLower().Contains(foodName.ToLower())).ToList();
                                    if (resultfoodName.Count > 0)
                                    {
                                        DisplayMenu(resultfoodName);
                                    }
                                    else
                                    {
                                        Console.WriteLine("No Item Found");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Please Enter Minimum 3 char of item");
                                }

                                Console.WriteLine();
                            

                            break;
                        default:
                            Console.WriteLine("Wrong Choice");
                            Console.WriteLine();

                            break;
                        case 4:
                            Console.WriteLine("Enter the Cuisine Name");
                            string CuisineName = Console.ReadLine();
                            Console.WriteLine();

                            if (CuisineName.Length >= 4)
                            {
                                var resultCuisineName = foodList.Where(obj => obj.Cuisine.ToString().ToLower().Contains(CuisineName.ToLower())).ToList();
                                if (resultCuisineName.Count > 0)
                                {
                                    DisplayMenu(resultCuisineName);
                                }
                                else
                                {
                                    Console.WriteLine("No Item Found");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Please Enter Minimum 4 char of Cuisine");
                            }

                            Console.WriteLine();
                            break;

                      
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }

                Console.WriteLine("Press Enter For Continue");
                string num = Console.ReadLine(); 
                if(string.IsNullOrEmpty(num))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Exit");
                    break;             
                }
              
            }

            Console.WriteLine();

            Console.ReadLine();
        }

       

        private static void DisplaySortedList(List<Food> DisplaySortedListResult)
        {
            Console.WriteLine("===========================Food Menu===========================");
            Console.WriteLine();
            Console.WriteLine("Price   Items                         FoodType       Cuisine");
            Console.WriteLine();
            foreach (var menu in DisplaySortedListResult)
            {
                Console.WriteLine("{0} {1,-25} {2,-10} {3}", menu.Price, menu.Name, menu.FoodType, menu.Cuisine);
            }
        }

        private static void DisplayMenu(List<Food> DisplayfoodListResult)
        {
            Console.WriteLine("==========================Food Menu==========================");
            Console.WriteLine();
            Console.WriteLine("Items                         FoodType       Price   Cuisine");
            Console.WriteLine();
            foreach (var menu in DisplayfoodListResult)
            {

                Console.WriteLine("{0,-25} {1,-10} {2} {3}", menu.Name, menu.FoodType, menu.Price, menu.Cuisine);
            };
            Console.WriteLine();
        }


    }
}
