using System;
using System.Windows.Forms;
using System.IO;
using static PasoParametrosPLC_PC_CSharp.ConexionPLC;

namespace PasoParametrosPLC_PC_CSharp
{

    public partial class Main : Form
    {
        ConexionPLC Conexion = new ConexionPLC();
        bool EstadoConexion = false;
        public Main()
        {
            InitializeComponent();
            if (Conexion.conectar(TbIP.Text.ToString(), 0, 1))
            {
                LedConexion.Image = Properties.Resources.verde;
                BtnConectar.Text = "Desconectar";
                EstadoConexion = true;
            }


        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
           if (!EstadoConexion)
            {
                if (Conexion.conectar(TbIP.Text.ToString(), 0, 1))
                {
                    LedConexion.Image = Properties.Resources.verde;
                    BtnConectar.Text = "Desconectar";
                    EstadoConexion = true;
                }
                else
                {
                    LedConexion.Image = Properties.Resources.rojo;
                    EstadoConexion = false;
                    LblAux.Text = "Error al conectar dentro de conecar()";
                }
            }
            else
            {
                if (Conexion.Desconexion())
                {
                    BtnConectar.Text = "Reconectar";
                    EstadoConexion = false;
                    LedConexion.Image = Properties.Resources.rojo;
                }
            }
            LblAux.Text = Conexion.consolaMsg();

        }

        private void btnLeerDB0_Click(object sender, EventArgs e)
        {
            StructDB0 estructura;
            
            estructura = Conexion.Lectura(1,0);
            TBx1.Text = estructura.SerialNumber.ToString();
            TBx2.Text = estructura.TestResult.ToString();
            TBx3.Text = estructura.RealDetector.ToString();
            TBx4.Text = estructura.byte20.ToString();
        }
        private void btnLeerDB2_Click(object sender, EventArgs e)
        {
            StructDB0 estructura;

            estructura = Conexion.Lectura2(2, 0); //(BDnumero,offset);
            tb5.Text = estructura.SerialNumber.ToString();
            tb6.Text = estructura.TestResult.ToString();
        }


    


        private void btnEscribirDB0_Click(object sender, EventArgs e)
        {
            StructDB0 estructura;

            estructura.SerialNumber = TBx1.Text;
            estructura.TestResult = short.Parse(TBx2.Text);
            estructura.RealDetector = float.Parse(TBx3.Text);
            estructura.byte20 = byte.Parse(TBx4.Text);

            Conexion.Escritura(1, 0, estructura);
        }

        private void btnEscribirDB2_Click(object sender, EventArgs e)
        {
            StructDB2 estructura2;

            estructura2.intword = Int16.Parse(tb5.Text);
            estructura2.word = Int32.Parse(tb6.Text);
            Conexion.Escritura2(2, 0, estructura2);
        }







        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Conexion.Desconexion();
            Application.Exit();
        }
    }
}
