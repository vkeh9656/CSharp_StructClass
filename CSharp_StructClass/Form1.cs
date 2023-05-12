using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_StructClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Car
        {
            int cycle;
            int window;
            int door;
            string name;
        }

        class cCar
        {
            int cycle;
            int window;
            int door;
            string name;
        }

    }
}
