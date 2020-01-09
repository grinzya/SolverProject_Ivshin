namespace OptimApp_Ivshin
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.t_A1 = new System.Windows.Forms.TextBox();
            this.t_A2 = new System.Windows.Forms.TextBox();
            this.t_A3 = new System.Windows.Forms.TextBox();
            this.t1_1 = new System.Windows.Forms.TextBox();
            this.t1_2 = new System.Windows.Forms.TextBox();
            this.t1_3 = new System.Windows.Forms.TextBox();
            this.t2_1 = new System.Windows.Forms.TextBox();
            this.t2_2 = new System.Windows.Forms.TextBox();
            this.t2_3 = new System.Windows.Forms.TextBox();
            this.t3_1 = new System.Windows.Forms.TextBox();
            this.t3_2 = new System.Windows.Forms.TextBox();
            this.t3_3 = new System.Windows.Forms.TextBox();
            this.t4_1 = new System.Windows.Forms.TextBox();
            this.t4_2 = new System.Windows.Forms.TextBox();
            this.t4_3 = new System.Windows.Forms.TextBox();
            this.t5_1 = new System.Windows.Forms.TextBox();
            this.t5_2 = new System.Windows.Forms.TextBox();
            this.t5_3 = new System.Windows.Forms.TextBox();
            this.t6_1 = new System.Windows.Forms.TextBox();
            this.t6_2 = new System.Windows.Forms.TextBox();
            this.t6_3 = new System.Windows.Forms.TextBox();
            this.tq_1 = new System.Windows.Forms.TextBox();
            this.tq_2 = new System.Windows.Forms.TextBox();
            this.tq_3 = new System.Windows.Forms.TextBox();
            this.Tc_Main = new System.Windows.Forms.TabControl();
            this.tp_Input = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_Need = new System.Windows.Forms.TextBox();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.L_A3 = new System.Windows.Forms.Label();
            this.L_A2 = new System.Windows.Forms.Label();
            this.L_A1 = new System.Windows.Forms.Label();
            this.tp_Output = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.Tc_Main.SuspendLayout();
            this.tp_Input.SuspendLayout();
            this.tp_Output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Calc
            // 
            this.btn_Calc.Location = new System.Drawing.Point(431, 315);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(75, 23);
            this.btn_Calc.TabIndex = 0;
            this.btn_Calc.Text = "Рассчитать";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_A1
            // 
            this.t_A1.Location = new System.Drawing.Point(141, 104);
            this.t_A1.Name = "t_A1";
            this.t_A1.Size = new System.Drawing.Size(53, 20);
            this.t_A1.TabIndex = 1;
            this.t_A1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // t_A2
            // 
            this.t_A2.Location = new System.Drawing.Point(141, 130);
            this.t_A2.Name = "t_A2";
            this.t_A2.Size = new System.Drawing.Size(53, 20);
            this.t_A2.TabIndex = 1;
            this.t_A2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // t_A3
            // 
            this.t_A3.Location = new System.Drawing.Point(141, 156);
            this.t_A3.Name = "t_A3";
            this.t_A3.Size = new System.Drawing.Size(53, 20);
            this.t_A3.TabIndex = 1;
            this.t_A3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // t1_1
            // 
            this.t1_1.Location = new System.Drawing.Point(200, 104);
            this.t1_1.Name = "t1_1";
            this.t1_1.Size = new System.Drawing.Size(53, 20);
            this.t1_1.TabIndex = 1;
            this.t1_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // t1_2
            // 
            this.t1_2.Location = new System.Drawing.Point(200, 130);
            this.t1_2.Name = "t1_2";
            this.t1_2.Size = new System.Drawing.Size(53, 20);
            this.t1_2.TabIndex = 1;
            this.t1_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // t1_3
            // 
            this.t1_3.Location = new System.Drawing.Point(200, 156);
            this.t1_3.Name = "t1_3";
            this.t1_3.Size = new System.Drawing.Size(53, 20);
            this.t1_3.TabIndex = 1;
            this.t1_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // t2_1
            // 
            this.t2_1.Location = new System.Drawing.Point(261, 104);
            this.t2_1.Name = "t2_1";
            this.t2_1.Size = new System.Drawing.Size(53, 20);
            this.t2_1.TabIndex = 1;
            this.t2_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // t2_2
            // 
            this.t2_2.Location = new System.Drawing.Point(261, 130);
            this.t2_2.Name = "t2_2";
            this.t2_2.Size = new System.Drawing.Size(53, 20);
            this.t2_2.TabIndex = 1;
            this.t2_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // t2_3
            // 
            this.t2_3.Location = new System.Drawing.Point(261, 156);
            this.t2_3.Name = "t2_3";
            this.t2_3.Size = new System.Drawing.Size(53, 20);
            this.t2_3.TabIndex = 1;
            this.t2_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // t3_1
            // 
            this.t3_1.Location = new System.Drawing.Point(320, 104);
            this.t3_1.Name = "t3_1";
            this.t3_1.Size = new System.Drawing.Size(53, 20);
            this.t3_1.TabIndex = 1;
            this.t3_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // t3_2
            // 
            this.t3_2.Location = new System.Drawing.Point(320, 130);
            this.t3_2.Name = "t3_2";
            this.t3_2.Size = new System.Drawing.Size(53, 20);
            this.t3_2.TabIndex = 1;
            this.t3_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // t3_3
            // 
            this.t3_3.Location = new System.Drawing.Point(320, 156);
            this.t3_3.Name = "t3_3";
            this.t3_3.Size = new System.Drawing.Size(53, 20);
            this.t3_3.TabIndex = 1;
            this.t3_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // t4_1
            // 
            this.t4_1.Location = new System.Drawing.Point(379, 104);
            this.t4_1.Name = "t4_1";
            this.t4_1.Size = new System.Drawing.Size(53, 20);
            this.t4_1.TabIndex = 1;
            this.t4_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // t4_2
            // 
            this.t4_2.Location = new System.Drawing.Point(379, 130);
            this.t4_2.Name = "t4_2";
            this.t4_2.Size = new System.Drawing.Size(53, 20);
            this.t4_2.TabIndex = 1;
            this.t4_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // t4_3
            // 
            this.t4_3.Location = new System.Drawing.Point(379, 156);
            this.t4_3.Name = "t4_3";
            this.t4_3.Size = new System.Drawing.Size(53, 20);
            this.t4_3.TabIndex = 1;
            this.t4_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // t5_1
            // 
            this.t5_1.Location = new System.Drawing.Point(438, 104);
            this.t5_1.Name = "t5_1";
            this.t5_1.Size = new System.Drawing.Size(53, 20);
            this.t5_1.TabIndex = 1;
            this.t5_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // t5_2
            // 
            this.t5_2.Location = new System.Drawing.Point(438, 130);
            this.t5_2.Name = "t5_2";
            this.t5_2.Size = new System.Drawing.Size(53, 20);
            this.t5_2.TabIndex = 1;
            this.t5_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // t5_3
            // 
            this.t5_3.Location = new System.Drawing.Point(438, 156);
            this.t5_3.Name = "t5_3";
            this.t5_3.Size = new System.Drawing.Size(53, 20);
            this.t5_3.TabIndex = 1;
            this.t5_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // t6_1
            // 
            this.t6_1.Location = new System.Drawing.Point(497, 104);
            this.t6_1.Name = "t6_1";
            this.t6_1.Size = new System.Drawing.Size(53, 20);
            this.t6_1.TabIndex = 1;
            this.t6_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // t6_2
            // 
            this.t6_2.Location = new System.Drawing.Point(497, 130);
            this.t6_2.Name = "t6_2";
            this.t6_2.Size = new System.Drawing.Size(53, 20);
            this.t6_2.TabIndex = 1;
            this.t6_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // t6_3
            // 
            this.t6_3.Location = new System.Drawing.Point(497, 156);
            this.t6_3.Name = "t6_3";
            this.t6_3.Size = new System.Drawing.Size(53, 20);
            this.t6_3.TabIndex = 1;
            this.t6_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // tq_1
            // 
            this.tq_1.Location = new System.Drawing.Point(556, 104);
            this.tq_1.Name = "tq_1";
            this.tq_1.Size = new System.Drawing.Size(53, 20);
            this.tq_1.TabIndex = 1;
            this.tq_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // tq_2
            // 
            this.tq_2.Location = new System.Drawing.Point(556, 130);
            this.tq_2.Name = "tq_2";
            this.tq_2.Size = new System.Drawing.Size(53, 20);
            this.tq_2.TabIndex = 1;
            this.tq_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // tq_3
            // 
            this.tq_3.Location = new System.Drawing.Point(556, 156);
            this.tq_3.Name = "tq_3";
            this.tq_3.Size = new System.Drawing.Size(53, 20);
            this.tq_3.TabIndex = 1;
            this.tq_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // Tc_Main
            // 
            this.Tc_Main.Controls.Add(this.tp_Input);
            this.Tc_Main.Controls.Add(this.tp_Output);
            this.Tc_Main.Location = new System.Drawing.Point(4, 12);
            this.Tc_Main.Name = "Tc_Main";
            this.Tc_Main.SelectedIndex = 0;
            this.Tc_Main.Size = new System.Drawing.Size(710, 426);
            this.Tc_Main.TabIndex = 2;
            // 
            // tp_Input
            // 
            this.tp_Input.Controls.Add(this.label11);
            this.tp_Input.Controls.Add(this.label10);
            this.tp_Input.Controls.Add(this.tb_Need);
            this.tp_Input.Controls.Add(this.tb_Quantity);
            this.tp_Input.Controls.Add(this.label9);
            this.tp_Input.Controls.Add(this.label8);
            this.tp_Input.Controls.Add(this.label7);
            this.tp_Input.Controls.Add(this.label6);
            this.tp_Input.Controls.Add(this.label5);
            this.tp_Input.Controls.Add(this.label4);
            this.tp_Input.Controls.Add(this.label3);
            this.tp_Input.Controls.Add(this.label2);
            this.tp_Input.Controls.Add(this.label1);
            this.tp_Input.Controls.Add(this.L_A3);
            this.tp_Input.Controls.Add(this.L_A2);
            this.tp_Input.Controls.Add(this.L_A1);
            this.tp_Input.Controls.Add(this.t_A1);
            this.tp_Input.Controls.Add(this.btn_Calc);
            this.tp_Input.Controls.Add(this.tq_3);
            this.tp_Input.Controls.Add(this.t_A2);
            this.tp_Input.Controls.Add(this.tq_2);
            this.tp_Input.Controls.Add(this.t1_1);
            this.tp_Input.Controls.Add(this.t6_3);
            this.tp_Input.Controls.Add(this.t_A3);
            this.tp_Input.Controls.Add(this.t6_2);
            this.tp_Input.Controls.Add(this.t2_1);
            this.tp_Input.Controls.Add(this.t5_3);
            this.tp_Input.Controls.Add(this.t1_2);
            this.tp_Input.Controls.Add(this.t5_2);
            this.tp_Input.Controls.Add(this.t3_1);
            this.tp_Input.Controls.Add(this.t4_3);
            this.tp_Input.Controls.Add(this.t1_3);
            this.tp_Input.Controls.Add(this.t4_2);
            this.tp_Input.Controls.Add(this.t4_1);
            this.tp_Input.Controls.Add(this.t3_3);
            this.tp_Input.Controls.Add(this.t2_2);
            this.tp_Input.Controls.Add(this.tq_1);
            this.tp_Input.Controls.Add(this.t5_1);
            this.tp_Input.Controls.Add(this.t3_2);
            this.tp_Input.Controls.Add(this.t2_3);
            this.tp_Input.Controls.Add(this.t6_1);
            this.tp_Input.Location = new System.Drawing.Point(4, 22);
            this.tp_Input.Name = "tp_Input";
            this.tp_Input.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Input.Size = new System.Drawing.Size(702, 357);
            this.tp_Input.TabIndex = 0;
            this.tp_Input.Text = "Входные данные";
            this.tp_Input.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Необходимо изготовить, шт.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Количество материала в рулоне, кв. м.";
            // 
            // tb_Need
            // 
            this.tb_Need.Location = new System.Drawing.Point(227, 281);
            this.tb_Need.Name = "tb_Need";
            this.tb_Need.Size = new System.Drawing.Size(100, 20);
            this.tb_Need.TabIndex = 6;
            this.tb_Need.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Location = new System.Drawing.Point(227, 243);
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(100, 20);
            this.tb_Quantity.TabIndex = 6;
            this.tb_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Need_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(553, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 39);
            this.label9.TabIndex = 5;
            this.label9.Text = "Количество\r\nзаготовок на\r\n1 изделие, шт.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(515, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество заготовок на 1 изделие по соответствующему способу раскроя, шт.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Площадь \r\nповерхности\r\n заготовки";
            // 
            // L_A3
            // 
            this.L_A3.AutoSize = true;
            this.L_A3.Location = new System.Drawing.Point(102, 159);
            this.L_A3.Name = "L_A3";
            this.L_A3.Size = new System.Drawing.Size(20, 13);
            this.L_A3.TabIndex = 2;
            this.L_A3.Text = "A3";
            // 
            // L_A2
            // 
            this.L_A2.AutoSize = true;
            this.L_A2.Location = new System.Drawing.Point(102, 133);
            this.L_A2.Name = "L_A2";
            this.L_A2.Size = new System.Drawing.Size(20, 13);
            this.L_A2.TabIndex = 2;
            this.L_A2.Text = "A2";
            // 
            // L_A1
            // 
            this.L_A1.AutoSize = true;
            this.L_A1.Location = new System.Drawing.Point(102, 107);
            this.L_A1.Name = "L_A1";
            this.L_A1.Size = new System.Drawing.Size(20, 13);
            this.L_A1.TabIndex = 2;
            this.L_A1.Text = "A1";
            // 
            // tp_Output
            // 
            this.tp_Output.Controls.Add(this.label12);
            this.tp_Output.Controls.Add(this.chart1);
            this.tp_Output.Controls.Add(this.dataGridView1);
            this.tp_Output.Location = new System.Drawing.Point(4, 22);
            this.tp_Output.Name = "tp_Output";
            this.tp_Output.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Output.Size = new System.Drawing.Size(702, 400);
            this.tp_Output.TabIndex = 1;
            this.tp_Output.Text = "Выходные данные";
            this.tp_Output.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 140);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "количество рулонов материала для каждого способа раскроя заготовки";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(690, 254);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X1,
            this.X2,
            this.X3,
            this.X4,
            this.X5,
            this.X6});
            this.dataGridView1.Location = new System.Drawing.Point(25, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 68);
            this.dataGridView1.TabIndex = 0;
            // 
            // X1
            // 
            this.X1.HeaderText = "X1";
            this.X1.Name = "X1";
            this.X1.ReadOnly = true;
            // 
            // X2
            // 
            this.X2.HeaderText = "X2";
            this.X2.Name = "X2";
            this.X2.ReadOnly = true;
            // 
            // X3
            // 
            this.X3.HeaderText = "X3";
            this.X3.Name = "X3";
            this.X3.ReadOnly = true;
            // 
            // X4
            // 
            this.X4.HeaderText = "X4";
            this.X4.Name = "X4";
            this.X4.ReadOnly = true;
            // 
            // X5
            // 
            this.X5.HeaderText = "X5";
            this.X5.Name = "X5";
            this.X5.ReadOnly = true;
            // 
            // X6
            // 
            this.X6.HeaderText = "X6";
            this.X6.Name = "X6";
            this.X6.ReadOnly = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(166, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(380, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Количество рулонов материала для каждого способа раскроя заготовки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.Tc_Main);
            this.Name = "Form1";
            this.Text = "Форма рассчёта";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Tc_Main.ResumeLayout(false);
            this.tp_Input.ResumeLayout(false);
            this.tp_Input.PerformLayout();
            this.tp_Output.ResumeLayout(false);
            this.tp_Output.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.TextBox t_A1;
        private System.Windows.Forms.TextBox t_A2;
        private System.Windows.Forms.TextBox t_A3;
        private System.Windows.Forms.TextBox t1_1;
        private System.Windows.Forms.TextBox t1_2;
        private System.Windows.Forms.TextBox t1_3;
        private System.Windows.Forms.TextBox t2_1;
        private System.Windows.Forms.TextBox t2_2;
        private System.Windows.Forms.TextBox t2_3;
        private System.Windows.Forms.TextBox t3_1;
        private System.Windows.Forms.TextBox t3_2;
        private System.Windows.Forms.TextBox t3_3;
        private System.Windows.Forms.TextBox t4_1;
        private System.Windows.Forms.TextBox t4_2;
        private System.Windows.Forms.TextBox t4_3;
        private System.Windows.Forms.TextBox t5_1;
        private System.Windows.Forms.TextBox t5_2;
        private System.Windows.Forms.TextBox t5_3;
        private System.Windows.Forms.TextBox t6_1;
        private System.Windows.Forms.TextBox t6_2;
        private System.Windows.Forms.TextBox t6_3;
        private System.Windows.Forms.TextBox tq_1;
        private System.Windows.Forms.TextBox tq_2;
        private System.Windows.Forms.TextBox tq_3;
        private System.Windows.Forms.TabControl Tc_Main;
        private System.Windows.Forms.TabPage tp_Input;
        private System.Windows.Forms.Label L_A3;
        private System.Windows.Forms.Label L_A2;
        private System.Windows.Forms.Label L_A1;
        private System.Windows.Forms.TabPage tp_Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_Need;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X2;
        private System.Windows.Forms.DataGridViewTextBoxColumn X3;
        private System.Windows.Forms.DataGridViewTextBoxColumn X4;
        private System.Windows.Forms.DataGridViewTextBoxColumn X5;
        private System.Windows.Forms.DataGridViewTextBoxColumn X6;
        private System.Windows.Forms.Label label12;
    }
}

