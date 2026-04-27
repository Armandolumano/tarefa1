using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestao_escolar.modelos;

namespace gestao_escolar
{
    public partial class ALUNO : Form
    {

        private List<double> notasTemporarias = new List<double>();

       
         private void LimparFormulario()
        {
    
    TXTNOME.Clear();
    TXTTELEFONE.Clear();
    TXTCURSO.Clear();
    TXTDATANASCI.Clear();
    TXTNUMERO.Clear();
    TXTNOTA.Clear();


    listBox1.Items.Clear();

    
    notasTemporarias.Clear();

    
    lBLMEDIA.Text = "MEDIA: ";
    LBLESTADO.Text = "ESTADO: ";

    
    TXTNOME.Focus();
}

        public ALUNO()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ALUNO_Load(object sender, EventArgs e)
        {

        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = TXTNOME.Text;
                string curso = TXTCURSO.Text;
                string tel = TXTTELEFONE.Text;
                string data = TXTDATANASCI.Text;
                int num = int.Parse(TXTNUMERO.Text);

                Aluno novo = new Aluno(nome, data, tel, num, curso);

                foreach (double n in notasTemporarias)
                {
                    novo.adicionarNota(n);
                }

                
                Form1.listaAlunos.Add(novo);

                MessageBox.Show("Aluno guardado com sucesso!");

               
                LimparFormulario();
                notasTemporarias.Clear();
                listBox1.Items.Clear();
                
            }
            catch
            {
                MessageBox.Show("Erro nos dados. Verifique o número e os textos.");
            }
        }

        private void BTNCALCULAR_Click(object sender, EventArgs e)
        {
            if (notasTemporarias.Count > 0)
            {
              
                Aluno temp = new Aluno("", "", "", 0, "");
                foreach (double n in notasTemporarias) temp.adicionarNota(n);

                double media = temp.calcularMedia();
                string estado = temp.obterSituacao();

                lBLMEDIA.Text = "MEDIA: " + media.ToString("");
                LBLESTADO.Text = "ESTADO: " + estado;
            }
            else
            {
                MessageBox.Show("Adicione pelo menos uma nota antes de calcular.");
            }
        }

        private void BTNLISTA_Click(object sender, EventArgs e)
        {
         
    if (Form1.listaAlunos.Count == 0)
    {
        MessageBox.Show("A lista está vazia. Guarde um aluno primeiro!");
        return;
    }

    
    var listaFormatada = new List<object>();

    foreach (var a in Form1.listaAlunos)
    {
        listaFormatada.Add(new {
       
            Nome = a.getNome(),
            Curso = a.curso ,
            Numero = a.numero,
            Telefone = a.telefone,
         
            Media = a.calcularMedia().ToString(""),
            Estado = a.obterSituacao()

        });
    }
  
    dataGridView1.DataSource = null; 
    dataGridView1.DataSource = listaFormatada;
        }

        private void BTNADICIONARNOTA_Click(object sender, EventArgs e)
        {

            double nota;
            if (double.TryParse(TXTNOTA.Text, out nota))
            {
                notasTemporarias.Add(nota);
                listBox1.Items.Add(nota.ToString("")); 
                TXTNOTA.Clear();
                TXTNOTA.Focus();
            }
            else
            {
                MessageBox.Show("Insira uma nota válida.");
            }
        }

        private void BTNVOLTAR_Click(object sender, EventArgs e)
        {
        
  
    this.Close();
}

        private void lBLMEDIA_Click(object sender, EventArgs e)
        {

        }
        }
    }

