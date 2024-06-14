using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observable
{
    public partial class Form2 : Form, IColorObserver
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void subscribe_Click(object sender, EventArgs e)
        {
            Form1.Observable.Subscribe(this);
        }
        public void OnColorChanged(Color color)
        {
            this.BackColor = color;

        }

        private void unsubscribe_Click(object sender, EventArgs e)
        {
            Form1.Observable.Unsubscribe(this);
        }
    }
}

