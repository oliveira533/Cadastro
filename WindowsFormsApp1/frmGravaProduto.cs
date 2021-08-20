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
    public partial class frmGravaProduto : Form
    {

        public frmGravaProduto()
        {
            InitializeComponent();
            
        }

        private void btnInsere_Click(object sender, EventArgs e)
        {
            MySqlCommand oComando = new MySqlCommand();
            oComando.Connection = Form1.oCon;
            oComando.CommandText = "INSER INTO PRODUTOS (PRDTITULO, PRDSUBTITULO, PRDDESCRICAO, PRDCATEGORIA, PRDVALOR) VALUES (@NOME, @SUBTITULO, @DESCRICAO, @CATEGORIA, @PRECO)";
            oComando.Parameters.AddWithValue("@NOME", txbNome.Text);
            oComando.Parameters.AddWithValue("@SUBTITULO", txbSubTitulo.Text);
            oComando.Parameters.AddWithValue("@DESCRICAO", txbDesc.Text);
            oComando.Parameters.AddWithValue("@CATEGORIA", cbmCategoria.SelectedValue);
            oComando.Parameters.AddWithValue("@PRECO", txbPreco.Value);

            oComando.ExecuteNonQuery();
        }
        private void fnCarregaCategorias()
        {
            MySqlDataAdapter oDados = new MySqlDataAdapter("SELECT * FROM CATEGORIAS", Form1.oCon);
            DataTable oAux = new DataTable();

            oDados.Fill(oAux);

            cbmCategoria.DataSource = oAux;

            cbmCategoria.DisplayMember = "CTGNOME";
            cbmCategoria.ValueMember = "CTGCODIGO";
        }

        private void fnCarregaUnidade()
        {
            MySqlDataAdapter oDados = new MySqlDataAdapter("SELECT * FROM MEDIDAS", Form1.oCon);
            DataTable oAux = new DataTable();

            oDados.Fill(oAux);

            cbmUniMed.DataSource = oAux;

            cbmUniMed.DisplayMember = "UNMNOME";
            cbmUniMed.ValueMember = "UNMCODIGO";
        }

        private void frmGravaProduto_Load(object sender, EventArgs e)
        {
            fnCarregaCategorias();
            fnCarregaUnidade();
        }
    }
}
