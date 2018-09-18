using PrimerParcial2018.BLL;
using PrimerParcial2018.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial2018.UI.Registros
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        

        private bool Validar()
        {
            bool errores = false;

            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                VendedoreserrorProvider.SetError(NombretextBox, "Llenar el nombre");
                errores = true;
            }

            if (SueldonumericUpDown.Value == 0 || PorRetencionnumericUpDown.Value == 0)
            {
                VendedoreserrorProvider.SetError(SueldonumericUpDown, "Llenar el Sueldo, si esta en 0");
                VendedoreserrorProvider.SetError(PorRetencionnumericUpDown, "Llenar Porciento, si esta en 0");
                errores = true;
            }
            if (RetencionnumericUpDown.Value == 0)
            {

                VendedoreserrorProvider.SetError(RetencionnumericUpDown, "Si los campos de sueldo y porciento estan llenos, debe dar click en la flecha de retencion para llenarla");
            }



            return errores;
        }

        private void Limpiar()
        {

            VendedornumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            SueldonumericUpDown.Value = 0;
            PorRetencionnumericUpDown.Value = 0;
            RetencionnumericUpDown.Value = 0;

            VendedoreserrorProvider.Clear();
        }

        private Vendedores Llenaclase()
        {
            Vendedores vendedores = new Vendedores();
            vendedores.Vendedorid = Convert.ToInt32(VendedornumericUpDown.Value);
            vendedores.Nombres = NombretextBox.Text;
            vendedores.Sueldo = SueldonumericUpDown.Value;
            vendedores.Retencion = RetencionnumericUpDown.Value;
            vendedores.PorRetencion = PorRetencionnumericUpDown.Value;

            return vendedores;
        }


        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                MessageBox.Show("llenar el campo vacio", "trate de guardar de nuevo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Vendedores vendedores = Llenaclase();
                bool paso = false;

                if (VendedornumericUpDown.Value == 0)
                {
                    paso = VendedoresBLL.Guardar(vendedores);
                }
                else
                {
                    paso = VendedoresBLL.Modificar(vendedores);
                }

                if (paso)
                {
                    MessageBox.Show("Se ha guardado", "aceptado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha modificado", "error",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void RetencionnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (Validar())
            {
                MessageBox.Show("llenar el campo vacio", "trate de guardar de nuevo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            if (SueldonumericUpDown.Value != 0 && PorRetencionnumericUpDown.Value != 0)
            {
                RetencionnumericUpDown.Value = VendedoresBLL.CalculoRetencion(SueldonumericUpDown.Value, PorRetencionnumericUpDown.Value);
                

            }
            else
            {
                MessageBox.Show("algun campo no esta lleno correctamente", "trate de nuevo",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(VendedornumericUpDown.Value);
            if (VendedoresBLL.Eliminar(id))

            {
                MessageBox.Show("eliminado", "exitosamente",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                VendedornumericUpDown.Value = 0;
                NombretextBox.Clear();
                SueldonumericUpDown.Value = 0;
                PorRetencionnumericUpDown.Value = 0;
            }
            else
            {
                MessageBox.Show("no fue eliminado", "trate de nuevo",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            VendedoreserrorProvider.Clear();
           
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void VendedornumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(VendedornumericUpDown.Value);
            Vendedores vendedores = VendedoresBLL.Buscar(id);

            if (vendedores != null)
            {                
                NombretextBox.Text = vendedores.Nombres;
                SueldonumericUpDown.Value = vendedores.Sueldo;
                PorRetencionnumericUpDown.Value = vendedores.PorRetencion;
                RetencionnumericUpDown.Value = vendedores.Retencion;
            }
            else
            {
                MessageBox.Show("no se encontro", "buscar de nuevo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SueldonumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }



}





