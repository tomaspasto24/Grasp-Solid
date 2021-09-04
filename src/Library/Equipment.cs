//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Equipment
    {
        public Equipment(string description, double hourlyCost)
        {
            this.Description = description;
            this.HourlyCost = hourlyCost;
        }

        public string Description { get; private set; }

        public double HourlyCost { get; private set; }

        /*Decidimos poner private a los sets ya que son seteados en el constructor y dejar publico el get
        ya que es lo que siempre pedimos desde las otras clases*/
    }
}