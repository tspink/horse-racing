using Spink.HorseRacing.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spink.HorseRacing.Controller
{
    internal sealed class Controller : IController
    {
        private IModel model;

        public Controller(IModel model)
        {
            this.model = model;
        }
    }
}
