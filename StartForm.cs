using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma
{
    class StartForm : System.Windows.Forms.Form
    {
        public StartForm()
        {
            Button sf_btn = new Button
            {
                Text = "Mu aken",
                Location = new System.Drawing.Point(10, 10)
            };
            sf_btn.Click += Sf_btn_Click;
            this.Controls.Add(sf_btn);
            Button sf_btn2 = new Button()
            {
                Text = "Veel aken",
                Location = new System.Drawing.Point(100, 10)
            };
            sf_btn2.Click += Sf_btn_Click1; ;
            this.Controls.Add(sf_btn2);

        }

        private void Sf_btn_Click1(object sender, EventArgs e)
        {
            MyForms uusaken = new MyForms(4, 4);
            uusaken.StartPosition = FormStartPosition.CenterScreen;
            uusaken.ShowDialog();
        }

        private void Sf_btn_Click(object sender, EventArgs e)
        {
            MyForms uusaken = new MyForms("Mina olen ilus aken", "Vali midagi", "Üks", "Kaks", "Kolm", "Neli");
            uusaken.StartPosition = FormStartPosition.CenterScreen;
            uusaken.ShowDialog();
        }
    }
}