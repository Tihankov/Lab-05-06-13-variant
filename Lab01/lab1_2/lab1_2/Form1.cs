using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_2
{
    public partial class Threads : Form
    {
        public Threads()
        {
            InitializeComponent();
        }

        private void Max(object mas)
        {
            int[] arr = (int[])mas;
            txtThread1.Invoke((MethodInvoker)delegate {
                prBar1.Maximum = arr.Length;
            });

            int result = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (result < arr[i])
                {
                    result = arr[i];
                }
                txtThread1.Invoke((MethodInvoker)delegate {
                    prBar1.PerformStep();
                    Thread.Sleep(200);
                });
            }
            txtThread1.Invoke((MethodInvoker)delegate { txtThread1.Text = Convert.ToString(result); });

        }

        private void Min(object mas)
        {
            int[] arr = (int[])mas;
            txtThread2.Invoke((MethodInvoker)delegate
            {
                prBar2.Maximum = arr.Length;
            });
            int result = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (result > arr[i])
                {
                    result = arr[i];
                }
                txtThread2.Invoke((MethodInvoker)delegate
                {
                    Thread.Sleep(200);
                    prBar2.PerformStep();

                });
            }
            txtThread2.Invoke((MethodInvoker)delegate { txtThread2.Text = Convert.ToString(result); });
        }

        private void Avg(object mas)
        {
            int[] arr = (int[])mas;
            txtThread3.Invoke((MethodInvoker)delegate {
                prBar3.Maximum = arr.Length;
        });
        int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
                txtThread3.Invoke((MethodInvoker)delegate {
                    prBar3.PerformStep();
                    Thread.Sleep(200);
                });
            }
            result = result / arr.Length;
            txtThread3.Invoke((MethodInvoker)delegate { txtThread3.Text = Convert.ToString(result); });
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBoxButtons msb = MessageBoxButtons.YesNo;
            String message = "Do you really want to exit?";
            String caption = "Exit";
            if (MessageBox.Show(message, caption, msb) == DialogResult.Yes)
                this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int[] arr = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-1000, 1000);
            }
            if (CheckMax.Checked)
            {
                Thread t1 = new Thread(new ParameterizedThreadStart(Max));
                t1.Start(arr);
            }
            else
            {
                txtThread1.Text = "";
                prBar1.Value = 0;
            }

            if (CheckMin.Checked)
            {
                Thread t2 = new Thread(new ParameterizedThreadStart(Min));
                t2.Start(arr);
            }
            else
            {
                txtThread2.Text = "";
                prBar2.Value = 0;
            }

            if (CheckAvg.Checked)
            {
                Thread t3 = new Thread(new ParameterizedThreadStart(Avg));
                t3.Start(arr);
            }
            else
            {
                txtThread3.Text = "";
                prBar3.Value = 0;
            }
        }
    }
}
