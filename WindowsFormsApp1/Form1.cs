using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static MySqlConnection oCon = new MySqlConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oCon.ConnectionString = "server=192.168.0.12; uid=Aluno2DS; pwd=SenhaBD2; database=BANCOCOMUM";
            oCon.Open();

            fnCarrega();
        }

        private void fnCarrega()
        {
            MySqlDataAdapter oDados = new MySqlDataAdapter("SELECT PRDCODIGO Codigo, PRDTITULO Nome, PRDDESCRICAO Descrição, CTGNOME Categoria, PRDUNIDMED UnidadeMedida, PRDVALOR Preço FROM PRODUTOS LEFT JOIN CATEGORIAS ON PRDCATEGORIA = CTGCODIGO", oCon);
            DataTable oAux = new DataTable();

            oDados.Fill(oAux);
            grdDados.DataSource = oAux;
        }

        private void btnGravarCategoria_Click(object sender, EventArgs e)
        {
            new frmCateg().ShowDialog();
        }

        private void btnGravarProd_Click(object sender, EventArgs e)
        {
            new frmGravaProduto().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmUniMed().ShowDialog();
        }

        private void grdDados_KeyUp(object sender, KeyEventArgs e)
        {
            MySqlCommand oDeletar = new MySqlCommand();

            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                if (MessageBox.Show("Você deseja realmente excluir esse registro?\n essa operação não pode ser desfeita", "Atenção", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    oDeletar.Connection = oCon;
                    oDeletar.CommandText = "DELETE FROM PRODUTOS WHERE PRDCODIGO = @CODIGO";
                    oDeletar.Parameters.AddWithValue("@CODIGO", grdDados.SelectedRows[0].Cells[0].Value);

                    oDeletar.ExecuteNonQuery();
                    MessageBox.Show("Cadastro deletado com sucesso");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fnCarrega();
        }
    }
}
