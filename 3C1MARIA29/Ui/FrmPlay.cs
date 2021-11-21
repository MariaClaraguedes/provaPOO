using _3C1MARIA29.Code.BLL;
using _3C1MARIA29.Code.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3C1MARIA29.Ui
{
    public partial class FrmPlay : Form
    {
        JogosBLL medbll = new JogosBLL();
        JogosDTO meddto = new JogosDTO();
        public FrmPlay()
        {
            InitializeComponent();
            dataGridView1.DataSource = medbll.Listar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPreco.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtQuantidade.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            meddto.Nome = txtNome.Text;
            meddto.Preco = txtPreco.Text;
            meddto.Quantidade = txtQuantidade.Text;

            medbll.Inserir(meddto);
            MessageBox.Show("Cadastrado com sucesso!", "sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = medbll.Listar();
            //limpar campos
            txtID.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            meddto.Id = int.Parse(txtID.Text);
            meddto.Nome = txtNome.Text;
            meddto.Preco = txtPreco.Text;
            meddto.Quantidade = txtQuantidade.Text;

            medbll.Editar(meddto);
            MessageBox.Show("Editar com sucesso!", "sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = medbll.Listar();
            //limpar campos
            txtID.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            meddto.Id = int.Parse(txtID.Text);
            meddto.Nome = txtNome.Text;
            meddto.Preco = txtPreco.Text;
            meddto.Quantidade = txtQuantidade.Text;

            medbll.Excluir(meddto);
            MessageBox.Show("Excluir com sucesso!", "sorvetes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = medbll.Listar();
            //limpar campos
            txtID.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
        }
    }
}
