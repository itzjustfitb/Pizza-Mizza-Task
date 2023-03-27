using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaMizza.Services;
using PizzaMIzza.Core.Models;

namespace PizzaMizza.Interfaces
{
    public interface IPizza
    {
        public void CreatePizza(Pizza pizza);
        public void ShowPizza(Pizza pizza);
    }
}
