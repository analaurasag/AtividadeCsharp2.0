﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaLoginPMT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;   

            List<string> Usuario = new List<string>();

            Usuario.Add("analaura@gmail.com");
            Usuario.Add("miguelperez@gmail.com");
            Usuario.Add("isabelatakeada@gmail.com");

            List<string> Senha = new List<string>();

            Senha.Add("ana");
            Senha.Add("miguel");
            Senha.Add("isabela");


            if (Usuario.Contains (usuario) && Senha.Contains (senha))
            {
                MessageBox.Show("Login efetuado com sucesso!");
            } else
            {
                MessageBox.Show("Usuário ou Senha incorreto.");
            }         
        }
    }
}
                                     