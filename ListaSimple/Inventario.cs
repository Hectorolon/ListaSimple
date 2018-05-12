using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaSimple
{
    class Inventario
    {
        private Producto[] _producto;
        private int _contador;

        Producto inicio = null;

        public Inventario(int tamaño)
        {
            _producto = new Producto[tamaño];
            _contador = 0;
        }

        public void agregar(Producto nuevo)
        {
            if (inicio == null)
                inicio = nuevo;
            else
            {
                agregar(nuevo, inicio);
            }
        }
        private void agregar(Producto nuevo, Producto quien)
        {
            if (quien._siguiente != null)
                agregar(nuevo, quien._siguiente);
            else
                quien._siguiente = nuevo;
        }

        public string eliminar(int posicion)
        {
            for (int i = posicion; i < _contador - 1; i++)
            {
                _producto[i] = _producto[i + 1];
            }
            if (_contador - 1 > 0)
            {
                _producto[_contador - 1] = null;
                _contador--;
            }
            return "Producto eliminado";
        }

        public Producto buscar(int codigo)
        {
            for (int i = 0; i < _contador; i++)
            {
                if (_producto[i] != null)
                {
                    if (_producto[i]._codigo == codigo)
                        return _producto[i];
                }
            }
            return null;
        }

        public string listar()
        {
            string res = "";
            Producto t = inicio;
            while (t != null)
            {
                res += t.ToString() + Environment.NewLine;
                t = t._siguiente;
            }
            return res;
        }

        public void agregarInicio(Producto nuevo)
        {
            if (inicio == null)
                inicio = nuevo;
            else
            {
                nuevo._siguiente = inicio;
                inicio = nuevo;
            }
        }

        public void eliminarPrimero()
        {
            if (inicio._siguiente == null)
                inicio = null;
            else
            {
                inicio = inicio._siguiente;
            }
        }

        public void eliminarUltimo()
        {
            if (inicio._siguiente == null)
                inicio = null;
            else
            {
                eliminar(inicio);
            }
        }
        private void eliminar(Producto quien)
        {
            if (quien._siguiente._siguiente != null)
                eliminar(quien._siguiente);
            else
                quien._siguiente = null;
        }

        public string invertirListar()
        {
            string res = "";
            Producto t = inicio;
            while (t != null)
            {
                res = t.ToString() + Environment.NewLine + res + Environment.NewLine;
                t = t._siguiente;
            }
            return res;
        }
    }
}
