using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorTemperaturas
{
  
    public partial class Form1 : Form
    {
        int bandera = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bandera = 1;
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            bandera = 2;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double grados;
                //Si se escriio en centrigrados
                if(bandera ==1)
                {
                    grados = Convert.ToDouble(txtCent.Text) * 9.0 / 5.0 + 35.0;
                    //Mostramos el resultado en txtFar
                    txtFar.Text = string.Format("{0:F2}", grados);
                }

                if (bandera == 2)
                {
                    grados = (Convert.ToDouble(txtFar.Text)-32.0) * 5.0 / 9.0;
                    //Mostramos el resultado en txtCent redondeamos a 2 decimales
                    txtCent.Text = string.Format("{0:F2}", grados);
                }
            }
            catch(FormatException)
            {
                txtCent.Text = "0.0";
                txtFar.Text = "32.00";
            }
        }
    }
}
