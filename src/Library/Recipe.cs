//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            Console.WriteLine($"Costo total receta: {this.GetProductionCost()}");
        }

        public double GetProductionCost()
        {
            double total = 0;
            foreach (Step step in this.steps)
            {
                total += step.TotalStepCost();
            }
            return total;
        }
        /*Agregamos el GetProductionCost() que era el metodo que pedia la consigna.
        Basicamente con el metodo TotalStepCost(), calcula el total de cada paso y lo suma al total de la receta.*/

        /*Usamos el Patrón Expert, asignándole la responsabilidad a la clase Recipe que es donde terminan todos los objetos Step
        para poder iterar y capturar la información necesaria para calcular el costo de producción.*/
    }
}