using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma
{
    public partial class MyForms : Form
    {
        Label message = new Label();
        Button[] btn = new Button[4];
        string[] texts = new string[4];
        TableLayoutPanel tlp = new TableLayoutPanel();
        Button btn_tabel, btn_w, btn_h;

        public MyForms()
        { }
        public MyForms(string title, string body, string button1, string button2, string button3, string button4)
        {
            texts[0] = button1;
            texts[1] = button2;
            texts[2] = button3;
            texts[3] = button4;
            this.ClientSize = new System.Drawing.Size(400, 100);
            this.Text = title;
            int x = 10;
            int i, j;
            for (int i = 0; i < 4; i++)
            {
                btn[i] = new Button
                {
                    Location = new System.Drawing.Point(x, 50),
                    Size = new System.Drawing.Size(80, 25),
                    Text = texts[i]
                };
                btn[i].Click += MyForm_Click;
                x += 100;
                this.Controls.Add(btn[i]);

            }
            message.Location = new System.Drawing.Point(10, 10);
            message.Text = body;
        }
        public MyForms(int read, int kohad)
        {
            this.tlp.ColumnCount = kohad;
            this.tlp.RowCount = read;
            this.tlp.ColumnStyles.Clear();
            this.tlp.RowStyles.Clear();
            int i, j;

            for (int i = 0; i < read; i++)
            {
                this.tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / read));
                this.tlp.RowStyles[i].Height = 100 / read;
            }
            for (int i = 0; i < kohad; j++)
            {
                this.tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / kohad));
                this.tlp.ColumnStyles[j].Width = 100 / kohad;

            }
            for (int i = 0; i < read; i++)
            {
                for (int j = 0; j < kohad; j++)
                {
                    var btn_tabel = new Button
                    {
                        Text = string.Format("{0}{1}", i, j),
                        Name = string.Format("btn_{0}{1}", i, j)
                    };
                    this.tlp.Controls.Add(btn_tabel, i, j);
                }

            }
            btn_w = (int)(100 / kohad);
            btn_h = (int)(100 / read);
            this.tlp.Dock = DockStyle.Fill;
            this.Controls.Add(tlp);
        }

        private void MyForm_Click(object sender, EventArgs e)
        {
            Button btn_click = (Button)sender;
            MessageBox.Show("Oli valitud " + btn_click.Text + " nupp");
        }
    }
}