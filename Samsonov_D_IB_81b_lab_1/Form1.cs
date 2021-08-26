using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samsonov_D_IB_81b_lab_1
{  


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public int a = 1;
        int num1;

        private void ToolStripButton1_Click(object sender, EventArgs e)//Прямой код
        {
            a = 1;
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)//Обратный код
        {
            a = 2;
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)//Доп код
        {
            a = 3;
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)//Сброс текстбоксов
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();

        }

        private void ToolStripButton5_Click(object sender, EventArgs e)//Выход
        {
            this.Close();
        }



        //Функция суммы
        static long Sum(long val1, long val2)
        {
            long i = 0, rem = 0, res = 0;
            long[] sum = new long[40];

            while (val1 != 0 || val2 != 0)
            {
                sum[i++] = (val1 % 10 + val2 % 10 + rem) % 2;
                rem = (val1 % 10 + val2 % 10 + rem) / 2;
                val1 = val1 / 10;
                val2 = val2 / 10;
            }
            if (rem != 0)
                sum[i++] = rem;

            i = i - 1;

            while (i >= 0)
                res = res * 10 + sum[i--];
            return res;
        }

        //Функция перевода в обратный код
        static string Obratniy_Kod(string num1, string n)
        {
            int minus = n.IndexOf('-');
            string obkod = "";
            if (minus == 0)
            {
                char[] a = num1.ToCharArray();
                int[] b = new int[a.Length];
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == '0')
                    {
                        b[i] = 1;
                    }
                    if (a[i] == '1')
                    {
                        b[i] = 0;
                    }
                    obkod += Convert.ToString(b[i]);
                }
                return obkod;
            }
            else
            {
                return num1;
            }

        }

        //Функция первода в дополнительный код
        static string Dop_Kod(string num, string s)
        {
            int minus = s.IndexOf('-');
            if (minus == 0)
            {
                string dopkod = "";
                dopkod = Convert.ToString(Sum(Convert.ToInt64(Obratniy_Kod(num, s)), 1));
                return dopkod;
            }
            else
                return num;
        }

        //Функция перевода в 10ую
        static int BinaryToDecimal(string binaryNumber)
        {
            int exponent = 0;
            int result = 0;
            for (var i = binaryNumber.Length - 1; i >= 0; i--)
            {
                if (binaryNumber[i] == '1')
                {
                    result += Convert.ToInt32(Math.Pow(2, exponent));
                }
                exponent++;
            }

            return result;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int A10 = Convert.ToInt32(textBox1.Text);


            int B10 = Convert.ToInt32(textBox3.Text);


            if (A10 + B10 > 32768 || A10 + B10 <-32768)
            {
                MessageBox.Show("Произошло переполнение разрядной сетки. Сумма или разность чисел не должна превышать 32768!");

            }
            else
            {

            //if (a == 1)
            if (a == 1)
                    {

                if (A10 >= 0)
                {
                    string A2 = Convert.ToString(A10, 2);
                    int lenth_1 = A2.Length;
                    for (; lenth_1 < 16; lenth_1++)
                    {
                        A2 = A2.Insert(0, "0");
                    }
                    textBox2.Text = ("0." + A2);
                }
                else
                {
                    string A2 = Convert.ToString(-A10, 2);
                    int lenth_1 = A2.Length;
                    for (; lenth_1 < 16; lenth_1++)
                    {
                        A2 = A2.Insert(0, "0");
                    }
                    textBox2.Text = ("1." + A2);
                }

                if (B10 >= 0)
                {
                    string B2 = Convert.ToString(B10, 2);
                    int lenth_2 = B2.Length;
                    for (; lenth_2 < 16; lenth_2++)
                    {
                        B2 = B2.Insert(0, "0");
                    }
                    textBox4.Text = ("0." + B2);
                }
                else
                {
                    string B2 = Convert.ToString(-B10, 2);
                    int lenth_2 = B2.Length;
                    for (; lenth_2 < 16; lenth_2++)
                    {
                        B2 = B2.Insert(0, "0");
                    }
                    textBox4.Text = ("1." + B2);
                }

                int C10 = A10 + B10;

                if (C10 >= 0)
                {
                    string C2 = Convert.ToString(C10, 2);
                    textBox5.Text = ("0." + C2);
                    textBox6.Text = Convert.ToString(C10);
                }
                else
                {
                    string C2 = Convert.ToString(-C10, 2);
                    textBox5.Text = ("1." + C2);
                    textBox6.Text = Convert.ToString(C10);
                }


            }
            else if (a == 2)
            {
                long C2;
                string A2;
                string B2;
                string C2_RESULT;
                string RESULT;
                string C2_S;
                string edinica;
                int ed = 1;
                int long_ed;
                long r;

                if (A10 >= 0)
                {
                    A2 = Convert.ToString(A10, 2);
                    int lenth_1 = A2.Length;
                    for (; lenth_1 < 16; lenth_1++)
                    {
                        A2 = A2.Insert(0, "0");
                    }

                    textBox7.Text = ("0." + A2);
                }
                else
                {
                    A2 = Convert.ToString(-A10, 2);
                    int lenth_1 = A2.Length;
                    for (; lenth_1 < 16; lenth_1++)
                    {
                        A2 = A2.Insert(0, "0");
                    }

                    A2 = Obratniy_Kod(A2, "-");

                    textBox7.Text = ("1." + A2);
                }

                if (B10 >= 0)
                {
                    B2 = Convert.ToString(B10, 2);
                    int lenth_2 = B2.Length;
                    for (; lenth_2 < 16; lenth_2++)
                    {
                        B2 = B2.Insert(0, "0");
                    }
                    textBox8.Text = ("0." + B2);
                }
                else
                {
                    B2 = Convert.ToString(-B10, 2);
                    int lenth_2 = B2.Length;
                    for (; lenth_2 < 16; lenth_2++)
                    {
                        B2 = B2.Insert(0, "0");
                    }

                    B2 = Obratniy_Kod(B2, "-");

                    textBox8.Text = ("1." + B2);
                }

                if (A10 < 0 && B10 < 0 && A10 + B10 < 0)
                {
                    C2 = Sum(Convert.ToInt64(A2), Convert.ToInt64(B2));
                    C2_S = Convert.ToString(C2);
                    C2_RESULT = C2_S.Substring(1, C2_S.Length - 1);
                    //RESULT = Obratniy_Kod(C2_RESULT, "-");

                    edinica = Convert.ToString(ed, 2);
                    long_ed = edinica.Length;
                    for (; long_ed < 16; long_ed++)
                    {
                        edinica = edinica.Insert(0, "0");
                    }

                    r = Sum(Convert.ToInt64(C2_RESULT), Convert.ToInt64(edinica));
                    RESULT = Convert.ToString(r);
                    RESULT = Obratniy_Kod(RESULT, "-");

                    textBox5.Text = Convert.ToString("1." + RESULT);
                    textBox6.Text = Convert.ToString("-" + BinaryToDecimal(Convert.ToString(RESULT)));
                }
                    else if (A10 == 0 && B10 == 0)
                    {
                        C2 = Sum(Convert.ToInt64(A2), Convert.ToInt64(B2));
                        //RESULT = Dop_Kod(Convert.ToString(C2), "-");
                        C2_RESULT = "0";
                        textBox5.Text = Convert.ToString("0." + C2_RESULT);
                        textBox6.Text = Convert.ToString(BinaryToDecimal(Convert.ToString(C2_RESULT)));

                    }
                    else if (A10 > 0 && B10 < 0 && A10 + B10 < 0)
                {
                    C2 = Sum(Convert.ToInt64(A2), Convert.ToInt64(B2));
                    C2_S = Convert.ToString(C2);
                    C2_RESULT = C2_S.Substring(1, C2_S.Length - 1);

                    RESULT = Obratniy_Kod(C2_RESULT, "-");

                    textBox5.Text = Convert.ToString("1." + RESULT);
                    textBox6.Text = Convert.ToString("-" + BinaryToDecimal(Convert.ToString(RESULT)));
                }
                else if (A10 < 0 && B10 > 0 && A10 + B10 < 0)
                {
                    C2 = Sum(Convert.ToInt64(A2), Convert.ToInt64(B2));
                    C2_S = Convert.ToString(C2);
                    C2_RESULT = C2_S.Substring(1, C2_S.Length - 1);

                    RESULT = Obratniy_Kod(C2_RESULT, "-");

                    textBox5.Text = Convert.ToString("1." + RESULT);
                    textBox6.Text = Convert.ToString("-" + BinaryToDecimal(Convert.ToString(RESULT)));
                }
                else
                {

                    C2 = Sum(Convert.ToInt64(A2), Convert.ToInt64(B2));



                    C2_S = Convert.ToString(C2);
                    if (C2_S.Length > 16)
                    {
                        C2_RESULT = C2_S.Substring(1, C2_S.Length - 1);
                        textBox6.Text = Convert.ToString(BinaryToDecimal(Convert.ToString(C2_RESULT)) + 1);
                        RESULT = Convert.ToString(Convert.ToInt32(textBox6.Text), 2);
                        textBox5.Text = RESULT;
                    }
                    else
                    {
                        RESULT = Convert.ToString(C2);
                        textBox6.Text = Convert.ToString(BinaryToDecimal(Convert.ToString(RESULT)));
                    }

                    if (A10 + B10 > 0)
                    {
                        textBox5.Text = ("0." + RESULT);
                    }
                    else
                    {
                        textBox5.Text = ("1." + RESULT);
                    }

                }



            }
            else if (a == 3)
            {

                long C2;
                string A2;
                string B2;
                string C2_RESULT;
                string RESULT;
                long A2_dop;
                long B2_dop;
                string edinica;
                int ed = 1;
                int long_ed;
                string res;
                long r;


                if (A10 >= 0)
                {
                    A2 = Convert.ToString(A10, 2);
                    int lenth_1 = A2.Length;
                    for (; lenth_1 < 16; lenth_1++)
                    {
                        A2 = A2.Insert(0, "0");
                    }

                    textBox9.Text = ("0." + A2);
                }
                else
                {
                    A2 = Convert.ToString(-A10, 2);
                    int lenth_1 = A2.Length;
                    for (; lenth_1 < 16; lenth_1++)
                    {
                        A2 = A2.Insert(0, "0");
                    }

                    A2 = Obratniy_Kod(A2, "-");

                    edinica = Convert.ToString(ed, 2);
                    long_ed = edinica.Length;
                    for (; long_ed < 16; long_ed++)
                    {
                        edinica = edinica.Insert(0, "0");
                    }
                    A2_dop = Sum(Convert.ToInt64(A2), Convert.ToInt64(edinica));
                    A2 = Convert.ToString(A2_dop);

                    textBox9.Text = ("1." + Convert.ToString(A2_dop));
                }

                if (B10 >= 0)
                {
                    B2 = Convert.ToString(B10, 2);
                    int lenth_2 = B2.Length;
                    for (; lenth_2 < 16; lenth_2++)
                    {
                        B2 = B2.Insert(0, "0");
                    }
                    textBox10.Text = ("0." + B2);
                }
                else
                {
                    B2 = Convert.ToString(-B10, 2);
                    int lenth_2 = B2.Length;
                    for (; lenth_2 < 16; lenth_2++)
                    {
                        B2 = B2.Insert(0, "0");
                    }

                    B2 = Obratniy_Kod(B2, "-");


                    edinica = Convert.ToString(ed, 2);
                    long_ed = edinica.Length;
                    for (; long_ed < 16; long_ed++)
                    {
                        edinica = edinica.Insert(0, "0");
                    }
                    B2_dop = Sum(Convert.ToInt64(B2), Convert.ToInt64(edinica));
                    B2 = Convert.ToString(B2_dop);

                    textBox10.Text = ("1." + Convert.ToString(B2_dop));

                }

                C2 = Sum(Convert.ToInt64(A2), Convert.ToInt64(B2));


                if (A10 > 0 && B10 > 0)
                {
                    r = Sum(Convert.ToInt64(A2), Convert.ToInt64(B2));
                    textBox5.Text = Convert.ToString(r);
                    textBox6.Text = Convert.ToString(BinaryToDecimal(Convert.ToString(r)));

                }
                else if (A10 == 0 && B10 == 0)
                    {
                        C2 = Sum(Convert.ToInt64(A2), Convert.ToInt64(B2));
                        //RESULT = Dop_Kod(Convert.ToString(C2), "-");
                        C2_RESULT = "0";
                        textBox5.Text = Convert.ToString("0." + C2_RESULT);
                        textBox6.Text = Convert.ToString(BinaryToDecimal(Convert.ToString(C2_RESULT)));

                }
                    else if (A10 > 0 && B10 < 0 && A10 + B10 > 0)
                {
                        C2 = Sum(Convert.ToInt64(A2), Convert.ToInt64(B2));
                        //RESULT = Dop_Kod(Convert.ToString(C2), "-");
                        C2_RESULT = Convert.ToString(C2).Substring(1, Convert.ToString(C2).Length - 1);
                        textBox5.Text = Convert.ToString("0." + C2_RESULT);
                        textBox6.Text = Convert.ToString(BinaryToDecimal(Convert.ToString(C2_RESULT)));

                }
                    else if (A10 < 0 && B10 > 0 && A10 + B10 > 0)
                {
                    C2 = Sum(Convert.ToInt64(A2), Convert.ToInt64(B2));
                    //RESULT = Dop_Kod(Convert.ToString(C2), "-");
                    C2_RESULT = Convert.ToString(C2).Substring(1, Convert.ToString(C2).Length - 1);
                    textBox5.Text = Convert.ToString("0." + C2_RESULT);
                    textBox6.Text = Convert.ToString(BinaryToDecimal(Convert.ToString(C2_RESULT)));

                }
                else if (A10 < 0 && B10 > 0 && A10 + B10 < 0)
                {
                    C2 = Sum(Convert.ToInt64(A2), Convert.ToInt64(B2));
                    //RESULT = Dop_Kod(Convert.ToString(C2), "-");
                    C2_RESULT = Convert.ToString(C2).Substring(1, Convert.ToString(C2).Length - 1);
                    RESULT = Dop_Kod(C2_RESULT, "-");
                    textBox5.Text = Convert.ToString("1." + RESULT);
                    textBox6.Text = Convert.ToString("-" + BinaryToDecimal(Convert.ToString(RESULT)));

                }
                else
                {
                    string C2_S = Convert.ToString(C2);
                    if (C2_S.Length > 16)
                    {
                        C2_RESULT = C2_S.Substring(1, C2_S.Length - 1);
                        //res = Convert.ToString(BinaryToDecimal(Convert.ToString(C2_RESULT)));
                        // RESULT = Convert.ToString(Convert.ToInt32(res), 2);
                        RESULT = Dop_Kod(C2_RESULT, "-");
                        textBox5.Text = RESULT;
                        textBox6.Text = Convert.ToString(BinaryToDecimal(Convert.ToString(RESULT)));
                    }
                    else
                    {
                        RESULT = Convert.ToString(C2);
                        RESULT = Dop_Kod(RESULT, "-");
                        textBox6.Text = Convert.ToString(BinaryToDecimal(Convert.ToString(RESULT)));
                    }






                    if (A10 + B10 > 0)
                    {
                        textBox5.Text = ("0." + RESULT);
                    }
                    else
                    {
                        textBox5.Text = ("1." + RESULT);
                        textBox6.Text = Convert.ToString("-" + BinaryToDecimal(Convert.ToString(RESULT)));
                    }
                }



            }
        }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
