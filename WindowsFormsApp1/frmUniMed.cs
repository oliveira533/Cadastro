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
    public partial class frmUniMed : Form
    {
        public frmUniMed()
        {
            InitializeComponent();
        }

        private void btnInsere_Click(object sender, EventArgs e)
        {
            MySqlCommand oComando = new MySqlCommand();
            oComando.Connection = Form1.oCon;
            oComando.CommandText = "INSERT INTO MEDIDAS (UNMNOME, UNMCODIGO) VALUES (@nome, @codigo);";
            oComando.Parameters.AddWithValue("@nome", txbNome.Text);
            oComando.Parameters.AddWithValue("@nome", txbCodigo.Text);

            oComando.ExecuteNonQuery();
        }
    }
}
