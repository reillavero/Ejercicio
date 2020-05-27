using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_24
{
    public partial class Form1 : Form
    {
        ToolTip errorTip = new ToolTip();
        CenasEmpresa cena;
        Cumpleaños cumple;
        public Form1()
        {
            InitializeComponent();
            // instancio obejtos
            cena = new CenasEmpresa();
            cumple = new Cumpleaños();

            // deshabilito opciones
            tBx_Cenas.ReadOnly = true;
            tBx_Cumple.ReadOnly = true;
            tBx_Cenas.Text = "0,0 €";
            tBx_Cumple.Text = "0,0 €";
            check_CenaLujo.Enabled = false;
            check_Salud.Enabled = false;
            check_CumpleLujo.Enabled = false;
            tBx_Tarta.Enabled = false;
        }

        // Opciones de Cenas
        private void numeric_Cenas_ValueChanged(object sender, EventArgs e)
        {
            check_CenaLujo.Enabled = true;
            check_Salud.Enabled = true;

            if(numeric_Cenas.Value > 0)
            {
                cena.NumPersonas = (int) numeric_Cenas.Value;
                cena.CalcularCosteDecoracion();
                tBx_Cenas.Text = cena.CalcularCoste().ToString() + " €";
            }
            else
            {
                check_CenaLujo.Enabled = false;
                check_Salud.Enabled = false;
                tBx_Cenas.Text = "0.0 €";
            }
        }

        private void check_CenaLujo_CheckedChanged(object sender, EventArgs e)
        {
            cena.DecoracionLujo = check_CenaLujo.Checked;
            cena.CalcularCosteDecoracion();
            tBx_Cenas.Text = cena.CalcularCoste().ToString() + " €";
        }

        private void check_Salud_CheckedChanged(object sender, EventArgs e)
        {
           cena.OpcionSaludable = check_Salud.Checked;
           tBx_Cenas.Text = cena.CalcularCoste().ToString() + " €";
        }

        //Opciones de cumpleaños
        private void numeric_Cumple_ValueChanged(object sender, EventArgs e)
        {
            check_CumpleLujo.Enabled = true;
            tBx_Tarta.Enabled = true;

            if (numeric_Cumple.Value > 0)
            {
                cumple.NumPersonas = (int) numeric_Cumple.Value;
                cumple.CalcularCosteDecoracion();
                tBx_Cumple.Text = cumple.CalcularCoste().ToString() + " €";

                if(numeric_Cumple.Value < 9)
                {
                    tBx_Tarta.MaxLength = 16;
                    if (tBx_Tarta.TextLength > 16)
                    {
                        tBx_Tarta.Clear();
                    }
                }
                else
                {
                    tBx_Tarta.MaxLength = 40;
                }
            }
            else
            {
                check_CumpleLujo.Enabled = false;
                tBx_Tarta.Enabled = false;
                tBx_Tarta.Clear();
                tBx_Cumple.Text = "0.0 €";
            }
        }

        private void check_CumpleLujo_CheckedChanged(object sender, EventArgs e)
        {
            cumple.DecoracionLujo = check_CumpleLujo.Checked;
            cumple.CalcularCosteDecoracion();
            tBx_Cumple.Text = cumple.CalcularCoste().ToString() + " €";
        }

        private void tBx_Tarta_TextChanged(object sender, EventArgs e)
        {
            if (numeric_Cumple.Value < 9)
            {
                errorTip.Show("Máximo 16 carácteres", tBx_Tarta, 150, -20, 5000);
                if (tBx_Tarta.TextLength == 16)
                {
                    errorTip.Show("Máximo de carácteres alcanzado", tBx_Tarta, 150, -20, 5000);
                }
            }
            else
            {
                errorTip.Show("Máximo 40 carácteres", tBx_Tarta, 150, -20, 5000);
                if (tBx_Tarta.TextLength == 40)
                {
                    errorTip.Show("Máximo de carácteres alcanzado", tBx_Tarta, 150, -20, 5000);
                }
            }
            cumple.TextoTarta = tBx_Tarta.Text;
            tBx_Cumple.Text = cumple.CalcularCoste().ToString() + " €";
        }
    }
}
