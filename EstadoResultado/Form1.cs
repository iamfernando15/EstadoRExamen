using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstadoResultado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcDeducc_Click(object sender, EventArgs e)
        {
            double a, b, c, f, suma, resta;  
            a = Double.Parse(txtVenta.Text);
            b = Double.Parse(txtDev.Text);
            c=Double.Parse(txtReb.Text);

            resta = b - c;
            txtTotalDsv.Text = resta.ToString();
            suma = a - resta;
            txtNetas.Text = suma.ToString();    

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, compra, m, n, res, cn, p, sum, i, su, k,z,resu; 
            x = Double.Parse(txtCompra.Text);
            y= Double.Parse(txtGas.Text);
            compra = x + y;
            txtCT.Text= compra.ToString();

            
            m = Double.Parse(txtcdevSC.Text);
            n = Double.Parse(txtrebSC.Text);

            res = m - n;
            txtTDSC.Text = res.ToString();
            cn = compra - res;
            txtCN.Text=cn.ToString();
            p=Double.Parse(txtInvIni.Text);
            sum = p + cn; 
            txtMdispo.Text = sum.ToString();
            i = Double.Parse(txtIV.Text);
            su= sum - i;
            txtcV.Text = su.ToString();

            k = Double.Parse(txtNetas.Text);
            z = Double.Parse(txtcV.Text);
            resu = k - z;
            txtUB.Text = resu.ToString();
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double s, d, f, g, h, sumita, t, i, w, q, sumemos, o, r, yes, b, v, pro, dato1, dato2, resu2,
                gas1, gas2, r1, uo1, uo2, ro1;
            s=Double.Parse(txtCM.Text);
            d= Double.Parse(txtPB.Text);
            f= Double.Parse(txtRT.Text);
            g= Double.Parse(txtTT.Text);
            h= Double.Parse(txtE.Text);
            sumita = s + d + f + g + h;
            txtTG.Text = sumita.ToString();

            t = Double.Parse(txtSG.Text);
            i = Double.Parse(txtPap.Text);
            w = Double.Parse(txtAO.Text);
            q = Double.Parse(txtOt.Text);
            sumemos = t + i + w + q;
            txtGADM.Text = sumemos.ToString();

            o=Double.Parse(txtIP.Text);
            r = Double.Parse(txtDesc.Text);
            yes = o + r;
            txtTGF.Text = yes.ToString();

            b= Double.Parse(txtDs.Text);
            v=Double.Parse(txtIntp.Text);
            pro = b + v;
            txtTF.Text= pro.ToString();

            dato1 = Double.Parse(txtTGF.Text);
            dato2 = Double.Parse(txtTF.Text);
            resu2 = dato1 + dato2;
            txtTotFinan.Text = resu2.ToString();

            gas1 = Double.Parse(txtTG.Text);
            gas2 = Double.Parse(txtGADM.Text);
            r1 = gas1 + gas2;
            txtGasO.Text = r1.ToString();

            uo1 = Double.Parse(txtUB.Text);
            uo2 = Double.Parse(txtGasO.Text);
            ro1 = uo1 - uo2;
            txtUO.Text=ro1.ToString();
        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double m1, n2, re3;
            m1 = Double.Parse(txtOtro.Text);
            n2 = Double.Parse(txtPCM.Text);
            re3 = m1 + n2;

            txtTOpro.Text = re3.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double gg1, gg2, ggre, op1, op2, to, ui1, ui2, uip, im, rip, un1, un2, unt;
            gg1 = Double.Parse(txtOtroGas.Text);
            gg2 = Double.Parse(txtPerMone.Text);
            ggre = gg1 + gg2;
            TotalOtrosGastos.Text = ggre.ToString();

            op1 = Double.Parse(txtTOpro.Text);
            op2 = Double.Parse(TotalOtrosGastos.Text);
            to = op1 - op2;
            txtTotalOtrosProductos.Text = to.ToString();

            ui1 = Double.Parse(txtUO.Text);
            ui2 = Double.Parse(txtTotalOtrosProductos.Text);
            uip = ui1 + ui2;
            txtUIA.Text = uip.ToString();

            im = Double.Parse(txtUIA.Text);
            rip = im * 0.3;
            txtImpuesto.Text = rip.ToString();

            un1 = Double.Parse(txtUIA.Text);
            un2 = Double.Parse(txtImpuesto.Text);
            unt = un1 - un2;
            txtUtiNeta.Text = unt.ToString();


        }

        private void txtOtroGas_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtVenta.Clear();
            txtDev.Clear();
            txtReb.Clear();
            txtTotalDsv.Clear();
            txtNetas.Clear();
            txtCompra.Clear();
            txtGas.Clear();
            txtCT.Clear();
            txtcdevSC.Clear();
            txtrebSC.Clear();
            txtTDSC.Clear();
            txtCN.Clear();
            txtInvIni.Clear();
            txtMdispo.Clear();
            txtIV.Clear();
            txtcV.Clear();
            txtUB.Clear();
            txtCM.Clear();
            txtPB.Clear();
            txtRT.Clear();
            txtTT.Clear();
            txtE.Clear();
            txtTG.Clear();
            txtSG.Clear();
            txtPap.Clear();
            txtAO.Clear();
            txtOt.Clear();
            txtGADM.Clear();
            txtIP.Clear();
            txtDesc.Clear();
            txtTGF.Clear();
            txtDs.Clear();
            txtIntp.Clear();
            txtTF.Clear();
            txtTotFinan.Clear();
            txtGasO.Clear();
            txtUO.Clear();
            txtOtro.Clear();
            txtPCM.Clear();
            txtTOpro.Clear();
            txtOtroGas.Clear();
            txtPerMone.Clear();
            TotalOtrosGastos.Clear();
            txtTotalOtrosProductos.Clear();
            txtUIA.Clear();
            txtImpuesto.Clear();
            txtUtiNeta.Clear();

        }
    }
}
