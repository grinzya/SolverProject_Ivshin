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
            double Material_Quantity = 12d;
            double All_Quantity = 80d;
            
            double S_A1 = 3.4;
            double S_A2 = 4.4;
            double S_A3 = 3d;
            double[,] r = { { 2, 0, 1 }, { 1, 1, 1}, {1, 0, 2 },{0, 2, 1},{2, 1, 0 },{0, 0, 3 } };
            double[] Quantity_zagotovki_1_type = { 6, 2, 7 };
            double[] All_zagotovky = new double[3];
            All_zagotovky[0] = Quantity_zagotovki_1_type[0] * All_Quantity;
            All_zagotovky[1] = Quantity_zagotovki_1_type[1] * All_Quantity;
            All_zagotovky[2] = Quantity_zagotovki_1_type[2] * All_Quantity;
            List<SolverRow> solverList = new List<SolverRow>();
            solverList.Add(new SolverRow { xId = 1, A1 =  r[0,0], A2 = r[0,1], A3 = r[0,2], Koef = (Material_Quantity - ((r[0,0] * S_A1) + (r[0,1] * S_A2) + (r[0,2] * S_A3)))});
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

                for (int i = 0; i < solverList.Count; i++)
                {
                    reportStr += "Значение X" + (i + 1).ToString() + ": " + choose.GetDouble(solverList[i].xId) + "\n";
                }
                reportStr += "\n" + report.ToString();

                MessageBox.Show(reportStr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("При решении задачи оптимизации возникла исключительная ситуация.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
