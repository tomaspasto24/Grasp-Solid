//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Product
    {
        public Product(string description, double unitCost)
        {
            this.Description = description;
            this.UnitCost = unitCost;
        }

        public string Description { get; private set; }

        public double UnitCost { get; private set; }

        /*Decidimos poner private a los sets ya que son seteados en el constructor y dejar publico el get
        ya que es lo que siempre pedimos desde las otras clases*/
    }
}