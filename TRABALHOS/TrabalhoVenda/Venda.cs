using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

 public class Venda 
    {
        public Comprador _comprador  { get; set; }
        public Vendedor  _Vendedor { get; set; }
        public Produto _Produto { get; set; }
        
      
        
        public void Mostrar()
        {
            Console.WriteLine("Nome: " + Comprador + "\tCpf: "
            + _Vendedor + "\tRg: " + Produto);
            
        }
    }