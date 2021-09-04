//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; private set; }

        public double Quantity { get; private set; }

        public int Time { get; private set; }

        public Equipment Equipment { get; private set; }

        public double TotalStepCost()
        {
            return (this.Input.UnitCost + ((this.Time / 3600)*this.Equipment.HourlyCost));
            /*Convertimos el tiempo en segundos. (Un cafe con leche no podria demorar 120 horas en hacerse)*/
        }

        /*TotalStepCost() calcula el costo de cada paso de la forma:
        costo de la unidad sumado al costo del equipamiento multiplicado por el tiempo de uso*/
    }
}