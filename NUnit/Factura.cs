using System;
using System.Collections;
using System.Collections.Generic;

namespace NUnit
{
    public class Factura
    {
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public IList<Item> Items { get; set; }
        public string NombreCliente { get; set; }

        public Factura(int numero, string cliente)
        {
            if (cliente == null) throw new ArgumentNullException("El nombre del cliente no puede ser nulo");
            Numero = numero;
            Fecha = DateTime.Now;
            Items = new List<Item>();
            NombreCliente = cliente;

        }

        public void AddItem (Item item)
        {
            if (Items != null) Items.Add(item);
        }

    }


}
