using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Escalonador
{
    public partial class FrmEscalonador : Form
    {
        public FrmEscalonador()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbQuantum.Visible = false;
            numQuantum.Visible = false;
            lbPrioridade.Visible = false;
            numPrioridade.Visible = false;
            btnExecutar.Enabled = false;

            txtTipoEscalonador.DisplayMember = "Text";
            txtTipoEscalonador.ValueMember = "Value";
            txtTipoEscalonador.DataSource = new[]
            {
                new {Text = "FCFS - First Come First Served"      , Value = "FCFS"},
                new {Text = "SJF - Shortest Job First"            , Value = "SJF"},
                new {Text = "SRTF - Shortest Remaining Time First", Value = "SRTF"},
                new {Text = "RR - Round Robin"                    , Value = "RR"},
                new {Text = "PRIOc - Prioridade Cooperativo"      , Value = "PRIOc"},
                new {Text = "PRIOp - Prioridade Preemptivo", Value = "PRIOp"}
            };
            txtTipoEscalonador.SelectedIndex = -1;
        }

        private void txtTipoEscalonador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtTipoEscalonador.SelectedValue == null)
            {
                lbQuantum.Visible = false;
                numQuantum.Visible = false;
                lbPrioridade.Visible = false;
                numPrioridade.Visible = false;
                btnExecutar.Enabled = false;
            }
            else if (txtTipoEscalonador.SelectedValue == "RR")
            {
                lbQuantum.Visible = true;
                numQuantum.Visible = true;
                lbPrioridade.Visible = false;
                numPrioridade.Visible = false;
            }
            else if ((txtTipoEscalonador.SelectedValue == "PRIOc") || (txtTipoEscalonador.SelectedValue == "PRIOp"))
            {
                lbQuantum.Visible = false;
                numQuantum.Visible = false;
                lbPrioridade.Visible = true;
                numPrioridade.Visible = true;
            }
            else
            {
                lbQuantum.Visible = false;
                numQuantum.Visible = false;
                lbPrioridade.Visible = false;
                numPrioridade.Visible = false;
            }
        }

        private void btnAdicionarProcesso_Click(object sender, EventArgs e)
        {
            switch (txtTipoEscalonador.SelectedValue)
            {
                case "FCFS":
                case "SJF":
                case "SRTF":
                    if(numTempoServico.Value > 0) btnExecutar.Enabled = true;
                    break;
                case "RR":
                    if (numTempoServico.Value > 0 && numQuantum.Value > 0) btnExecutar.Enabled = true;
                    break;
                case "PRIOc":
                case "PRIOp":
                    if (numTempoServico.Value > 0 && numPrioridade.Value > 0) btnExecutar.Enabled = true;
                    break;
                default:
                    btnExecutar.Enabled = false;
                    break;
            }


        }
    }
}
