﻿using PrimerParcial2018.UI.Registros;
using PrimerParcial2018.UI.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial2018
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        private void registro1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
        }

        private void consultaDeVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CVendedores vendedores = new CVendedores();
            vendedores.Show();

        }

        private void registroDeMetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rmetas registro = new Rmetas();
            registro.Show();
        }
    }
}
