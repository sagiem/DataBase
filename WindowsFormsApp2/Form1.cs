﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameBoxAdd.Text != "" || ContractBoxAdd.Text != "")
            {
                using (var context = new AgentContext())
                {

                    var agent = new Agent
                    {
                        Name = NameBoxAdd.Text,
                        Number = ContractBoxAdd.Text,
                        Data = DataBoxAdd.Text
                    };

                    context.Agents.Add(agent);
                    context.SaveChanges();
                    MessageBox.Show("Данные успешно сохранены");


                }
            }
            else
            {
                MessageBox.Show("Не ведены данные");
            }
        }
    }
}
