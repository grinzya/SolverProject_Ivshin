using Microsoft.SolverFoundation.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptimApp_Ivshin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (t_A1.Text == "" || t_A2.Text == "" || t_A3.Text == "" || t1_1.Text == "" || t1_2.Text == "" || t1_3.Text == "" ||
                t2_1.Text == "" || t2_2.Text == "" || t2_3.Text == "" || t3_1.Text == "" || t3_2.Text == "" || t3_3.Text == "" ||
                t4_1.Text == "" || t4_2.Text == "" || t4_3.Text == "" || t5_1.Text == "" || t5_2.Text == "" || t5_3.Text == "" ||
                t6_1.Text == "" || t6_2.Text == "" || t6_3.Text == "" || tq_1.Text == "" || tq_2.Text == "" || tq_3.Text == "" ||
                tb_Need.Text == "" || tb_Quantity.Text == ""
                )
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка");
                return;
            }
            else
            {
                
                chart1.Series[0].Points.Clear();
                double Material_Quantity = Double.Parse(tb_Quantity.Text);
                double All_Quantity = Double.Parse(tb_Need.Text);
                double S_A1 = Double.Parse(t_A1.Text);
                double S_A2 = Double.Parse(t_A2.Text);
                double S_A3 = Double.Parse(t_A3.Text);
                //double[,] r = { { 2, 0, 1 }, { 1, 1, 1}, {1, 0, 2 },{0, 2, 1},{2, 1, 0 },{0, 0, 3 } };
                double[,] r = new double[6, 3];

                r[0, 0] = Double.Parse(t1_1.Text);
                r[0, 1] = Double.Parse(t1_2.Text);
                r[0, 2] = Double.Parse(t1_3.Text);

                r[1, 0] = Double.Parse(t2_1.Text);
                r[1, 1] = Double.Parse(t2_2.Text);
                r[1, 2] = Double.Parse(t2_3.Text);


                r[2, 0] = Double.Parse(t3_1.Text);
                r[2, 1] = Double.Parse(t3_2.Text);
                r[2, 2] = Double.Parse(t3_3.Text);

                r[3, 0] = Double.Parse(t4_1.Text);
                r[3, 1] = Double.Parse(t4_2.Text);
                r[3, 2] = Double.Parse(t4_3.Text);

                r[4, 0] = Double.Parse(t5_1.Text);
                r[4, 1] = Double.Parse(t5_2.Text);
                r[4, 2] = Double.Parse(t5_3.Text);

                r[5, 0] = Double.Parse(t6_1.Text);
                r[5, 1] = Double.Parse(t6_2.Text);
                r[5, 2] = Double.Parse(t6_3.Text);

                //double[] Quantity_zagotovki_1_type = { 6, 2, 7 };
                double[] Quantity_zagotovki_1_type = new double[3];

                Quantity_zagotovki_1_type[0] = Double.Parse(tq_1.Text);
                Quantity_zagotovki_1_type[1] = Double.Parse(tq_2.Text);
                Quantity_zagotovki_1_type[2] = Double.Parse(tq_3.Text);
                double[] All_zagotovky = new double[3];
                All_zagotovky[0] = Quantity_zagotovki_1_type[0] * All_Quantity;
                All_zagotovky[1] = Quantity_zagotovki_1_type[1] * All_Quantity;
                All_zagotovky[2] = Quantity_zagotovki_1_type[2] * All_Quantity;
                List<SolverRow> solverList = new List<SolverRow>();
                solverList.Add(new SolverRow { xId = 1, A1 = r[0, 0], A2 = r[0, 1], A3 = r[0, 2], Koef = (Material_Quantity - ((r[0, 0] * S_A1) + (r[0, 1] * S_A2) + (r[0, 2] * S_A3))) });
                solverList.Add(new SolverRow { xId = 2, A1 = r[1, 0], A2 = r[1, 1], A3 = r[1, 2], Koef = (Material_Quantity - ((r[1, 0] * S_A1) + (r[1, 1] * S_A2) + (r[1, 2] * S_A3))) });
                solverList.Add(new SolverRow { xId = 3, A1 = r[2, 0], A2 = r[2, 1], A3 = r[2, 2], Koef = (Material_Quantity - ((r[2, 0] * S_A1) + (r[2, 1] * S_A2) + (r[2, 2] * S_A3))) });
                solverList.Add(new SolverRow { xId = 4, A1 = r[3, 0], A2 = r[3, 1], A3 = r[3, 2], Koef = (Material_Quantity - ((r[3, 0] * S_A1) + (r[3, 1] * S_A2) + (r[3, 2] * S_A3))) });
                solverList.Add(new SolverRow { xId = 5, A1 = r[4, 0], A2 = r[4, 1], A3 = r[4, 2], Koef = (Material_Quantity - ((r[4, 0] * S_A1) + (r[4, 1] * S_A2) + (r[4, 2] * S_A3))) });
                solverList.Add(new SolverRow { xId = 6, A1 = r[5, 0], A2 = r[5, 1], A3 = r[5, 2], Koef = (Material_Quantity - ((r[5, 0] * S_A1) + (r[5, 1] * S_A2) + (r[5, 2] * S_A3))) });

                SolverContext cntxt = SolverContext.GetContext();
                Model model = cntxt.CreateModel();
                Set users = new Set(Domain.Any, "users");

                Parameter A1 = new Parameter(Domain.Real, "A1", users);
                A1.SetBinding(solverList, "A1", "xId");
                Parameter A2 = new Parameter(Domain.Real, "A2", users);
                A2.SetBinding(solverList, "A2", "xId");
                Parameter A3 = new Parameter(Domain.Real, "A3", users);
                A3.SetBinding(solverList, "A3", "xId");
                Parameter Koef = new Parameter(Domain.Real, "Koef", users);
                Koef.SetBinding(solverList, "Koef", "xId");

                model.AddParameters(A1, A2, A3, Koef);
                Decision choose = new Decision(Domain.RealNonnegative, "choose", users);
                model.AddDecisions(choose);
                model.AddGoal("goal", GoalKind.Minimize, Model.Sum(Model.ForEach(users, xId => choose[xId] * Koef[xId])));

                model.AddConstraint("X1", choose[1] >= 0);
                model.AddConstraint("X2", choose[2] >= 0);
                model.AddConstraint("X3", choose[3] >= 0);
                model.AddConstraint("X4", choose[4] >= 0);
                model.AddConstraint("X5", choose[5] >= 0);
                model.AddConstraint("X6", choose[6] >= 0);
                model.AddConstraint("SA1", Model.Sum(Model.ForEach(users, xId => choose[xId] * A1[xId])) == All_zagotovky[0]);
                model.AddConstraint("SA2", Model.Sum(Model.ForEach(users, xId => choose[xId] * A2[xId])) == All_zagotovky[1]);
                model.AddConstraint("SA3", Model.Sum(Model.ForEach(users, xId => choose[xId] * A3[xId])) == All_zagotovky[2]);

                try
                {
                    Solution solution = cntxt.Solve();
                    Report report = solution.GetReport();

                    String reportStr = "";
                    double[] x = new double[6];
                    for (int i = 0; i < solverList.Count; i++)
                    {
                        //reportStr += "Значение X" + (i + 1).ToString() + ": " + choose.GetDouble(solverList[i].xId) + "\n";
                        x[i] = choose.GetDouble(solverList[i].xId);
                        
                    }
                    reportStr += "\n" + report.ToString();
                    if (dataGridView1.RowCount == 2)
                    {
                        dataGridView1.SelectedRows[1].Cells[0].Value = x[0];
                        dataGridView1.SelectedRows[1].Cells[1].Value = x[1];
                        dataGridView1.SelectedRows[1].Cells[2].Value = x[2];
                        dataGridView1.SelectedRows[1].Cells[3].Value = x[3];
                        dataGridView1.SelectedRows[1].Cells[4].Value = x[4];
                        dataGridView1.SelectedRows[1].Cells[5].Value = x[5];
                    }
                    else
                    {
                        dataGridView1.Rows.Add(x[0], x[1], x[2], x[3], x[4], x[5]);
                    }

                    this.chart1.Series[0].Points.AddXY("x1", x[0]);
                    this.chart1.Series[0].Points.AddXY("x2", x[1]);
                    this.chart1.Series[0].Points.AddXY("x3", x[2]);
                    this.chart1.Series[0].Points.AddXY("x4", x[3]);
                    this.chart1.Series[0].Points.AddXY("x5", x[4]);
                    this.chart1.Series[0].Points.AddXY("x6", x[5]);
                    tp_Output.Parent = Tc_Main;
                    //MessageBox.Show(reportStr);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("При решении задачи оптимизации возникла исключительная ситуация.");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tp_Output.Parent = null;
            t_A1.Text = "3,4";
            t_A2.Text = "4,4";
            t_A3.Text = "3";

            t1_1.Text = "2";
            t1_2.Text = "0";
            t1_3.Text = "1";

            t2_1.Text = "1";
            t2_2.Text = "1";
            t2_3.Text = "1";

            t3_1.Text = "1";
            t3_2.Text = "0";
            t3_3.Text = "2";

            t4_1.Text = "0";
            t4_2.Text = "2";
            t4_3.Text = "1";

            t5_1.Text = "2";
            t5_2.Text = "1";
            t5_3.Text = "0";

            t6_1.Text = "0";
            t6_2.Text = "0";
            t6_3.Text = "3";

            tq_1.Text = "6";
            tq_2.Text = "2";
            tq_3.Text = "7";

            tb_Quantity.Text = "12";
            tb_Need.Text = "80";
        }

        private void tb_Need_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
    }
}
