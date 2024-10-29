using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventCorp
{
    public abstract class Productos
    {
        private string nombre;
        private int existencias;
        private string tipoProducto;
        private decimal precio;
        private decimal peso;

        protected Productos(string nombre, int existencias, string tipoProducto, decimal precio, decimal peso)
        {
            this.nombre = nombre;
            this.existencias = existencias;
            this.tipoProducto = tipoProducto;
            this.precio = precio;
            this.peso = peso;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string value)
        {
            nombre = value;
        }

        public int GetExistencias()
        {
            return existencias;
        }

        public void SetExistencias(int value)
        {
            existencias = value;
        }
        public string GetTipoProducto()
        {
            return tipoProducto;
        }

        public void SetTipoProducto(string value)
        {
            tipoProducto = value;
        }

        public decimal Getprecio()
        {
            return precio;
        }

        public void Setprecio(decimal value)
        {
            precio = value;
        }
        public decimal GetPeso()
        {
            return peso;
        }

        public void SetPeso(decimal value)
        {
            peso = value;
        }
    }
}
