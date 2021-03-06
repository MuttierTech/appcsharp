﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appcsharp.Classes;

namespace appcsharp.Classes
{
    public class Agenda
    { //Metodo Construtor
       
        public Agenda(int id = 0, string nome = null, string email = null, string telefone = null, string empresa = null, String diaVisita = null, string horarioVisita = null, string assunto = null, string descricao = null)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Empresa = empresa;
            DiaVisita = diaVisita;
            HorarioVisita = horarioVisita;
            Assunto = assunto;
            Descricao = descricao;
        }
        //Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Empresa { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string DiaVisita { get; set; }
        public string HorarioVisita { get; set; }
        public string Assunto { get; set; }
        public string Descricao { get; set; }
        public List<Agenda> ListarAgenda()
        {
            List<Agenda> lista = new List<Agenda>();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "Select * from agendaVisita";
            var dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                lista.Add(new Agenda(
                    Convert.ToInt32(dr.GetValue(0)),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7)
                    ));
            }
            return lista;

        }
    }

}
