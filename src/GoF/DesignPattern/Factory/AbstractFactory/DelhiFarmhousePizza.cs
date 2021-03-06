﻿using System;

namespace GoF.DesignPattern.Factory.AbstractFactory
{
    internal class DelhiFarmhousePizza : Pizza
    {
        public DelhiFarmhousePizza()
        {
            PizzaIngredients = new DelhiPizzaIngredients();
            Name = "Farm House Pizza";
            Crust = PizzaIngredients.CreateCrust().GetCrust();
            Sauce = PizzaIngredients.CreateSauce().GetSauce();
            Topping = PizzaIngredients.CreateTopping().GetTopping();
        }

        public override void Bake()
        {
            Console.WriteLine("Delhi : Bake for 45 min");
        }

        public override void Cut()
        {
            Console.WriteLine("Delhi : Cut into 8 pics");
        }
    }
}
