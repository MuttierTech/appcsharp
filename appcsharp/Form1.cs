﻿using appcsharp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appcsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            
            // select * from agendaVisita where nome = txtnome;
            
        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            lstLista.Items.Clear();
            Agenda agenda = new Agenda();
            var lista = agenda.ListarAgenda();
            foreach (var item in lista) 
            {
                lstLista.Items.Add(item.Id + " | " + item.Nome + " | " +item.Empresa + " | " + item.Email + " | " + item.Telefone + " | " + item.DiaVisita + " | " + item.HorarioVisita + " | " + item.Assunto + " | " + item.Descricao);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnfech_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
