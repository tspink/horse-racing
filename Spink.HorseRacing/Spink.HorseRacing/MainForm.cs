using Spink.HorseRacing.Controller;
using Spink.HorseRacing.Model;
using Spink.HorseRacing.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spink.HorseRacing
{
    public partial class MainForm : Form, IView
    {
        private IController controller;
        private IModel model;

        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(IController controller, IModel model)
        {
            this.controller = controller;
            this.model = model;

            InitializeComponent();
        }
    }
}
