using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProgram
{
    public partial class FrmProdutos : Form
    {
        //Definir a Collection (Coleção)
        ICollection<Produtos> lista;
        public FrmProdutos()
        {
            InitializeComponent();
            //Carregar a grade
            lista = new List<Produtos>();
            dataGridProdutos.DataSource = lista;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var produto = new Produtos();
            produto.Id = int.Parse(txtId.Text);
            produto.Descricao = txtDescricao.Text;
            produto.Valor = double.Parse(txtValor.Text);
            produto.QtdEstoque = int.Parse(txtQtdEstoque.Text);
            lista.Add(produto);
            dataGridProdutos.DataSource = null;
            dataGridProdutos.DataSource = lista;
            //Limpar a tela
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox texto = (TextBox)item;
                    texto.Text = "";
                }
            }
        }
    }
}
