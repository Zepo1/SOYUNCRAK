using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOYUNCRAK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        VECTOR V1 = new VECTOR();
        VECTOR V2 = new VECTOR();
        VECTOR V3 = new VECTOR();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            V1.DIMENCIONAR(int.Parse(textBox1.Text));
        }

        private void cARGARANDOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int A = int.Parse(textBox2.Text);
            int B = int.Parse(textBox3.Text);
            V1.CARGARANDOM(A, B);
        }

        private void dESCARGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox4.Text = V1.DESCARGAR();
        }

        private void eLIMINARPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           V1.eliminar(int.Parse(textBox6.Text));
        }

        private void dESCARGARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox5.Text = V2.DESCARGAR();
        }

        private void eJ1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V2.EJ1(int.Parse(textBox6.Text));
        }

        private void eJ2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = V1.EJ2().ToString();
        }

        private void eJ3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = V1.EJ3(int.Parse(textBox7.Text)).ToString();
        }

        private void eJ4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int A = int.Parse(textBox7.Text);
            int B = int.Parse(textBox8.Text);
            textBox6.Text = V1.EJ4(A,B).ToString();
        }

        private void eJ5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int MULTIPLO = int.Parse(textBox7.Text);
            V1.EJ5(V2,V3, MULTIPLO);
        }

        private void dESCARGARToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox9.Text = V3.DESCARGAR();
        }

        private void mODELOEXAMNEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int A = int.Parse(textBox7.Text);
            int B = int.Parse(textBox8.Text);
            V1.ORDENARACEN(A, B);
        }

        private void dIMENCIONARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V2.DIMENCIONAR(int.Parse(textBox1.Text));
        }

        private void cARGARANDOMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int A = int.Parse(textBox2.Text);
            int B = int.Parse(textBox3.Text);
            V2.CARGARANDOM(A, B);
        }

        private void eSTASIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int A = int.Parse(textBox7.Text);
            int B = int.Parse(textBox8.Text);
            V1.ahorasi(A, B,V2);
        }

        private void uNOFIBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = V1.UNOFIB( int .Parse(textBox7.Text) ).ToString();
        }

        private void pRACIEJ2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int A = int.Parse(textBox7.Text);
            int B = int.Parse(textBox8.Text);
            V1.PARCI2(A, B, V2,V3);
            textBox5.Text = V2.DESCARGAR();
            textBox9.Text = V3.DESCARGAR();

        }

        private void oRDECENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int A = int.Parse(textBox7.Text);
            int B = int.Parse(textBox8.Text);
            V1.ORDENARDECEN(A, B);
            textBox5.Text = V1.DESCARGAR();
        }

        private void dELREPERANGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int A = int.Parse(textBox7.Text);
            int B = int.Parse(textBox8.Text);
            V1.DELREPETRANGO(A, B);
            textBox5.Text = V1.DESCARGAR();
        }

        private void fRECRANGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int A = int.Parse(textBox7.Text);
            int B = int.Parse(textBox8.Text);
            V1.FRECRANGO(A, B);
            textBox5.Text = V1.DESCARGAR();
        }
    }
}
