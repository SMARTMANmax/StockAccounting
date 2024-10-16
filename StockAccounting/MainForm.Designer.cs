namespace StockAccounting
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pbCreateDB = new Button();
            tabPage2 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            TradeDate = new DataGridViewTextBoxColumn();
            BorS = new DataGridViewTextBoxColumn();
            StockNo = new DataGridViewTextBoxColumn();
            StockName = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            BuyUnit = new DataGridViewTextBoxColumn();
            BuyAmt = new DataGridViewTextBoxColumn();
            SellUnit = new DataGridViewTextBoxColumn();
            SellAmt = new DataGridViewTextBoxColumn();
            RealAmt = new DataGridViewTextBoxColumn();
            Charge = new DataGridViewTextBoxColumn();
            ChargeDown = new DataGridViewTextBoxColumn();
            Tax = new DataGridViewTextBoxColumn();
            Tprice = new DataGridViewTextBoxColumn();
            Tcost = new DataGridViewTextBoxColumn();
            Expenditure = new DataGridViewTextBoxColumn();
            Income = new DataGridViewTextBoxColumn();
            Remark = new DataGridViewTextBoxColumn();
            Taxdiscount = new DataGridViewTextBoxColumn();
            Rowid = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            tabPage3 = new TabPage();
            dataGridView2 = new DataGridView();
            StockName2 = new DataGridViewTextBoxColumn();
            Stockunit2 = new DataGridViewTextBoxColumn();
            Buyprice2 = new DataGridViewTextBoxColumn();
            Costs2 = new DataGridViewTextBoxColumn();
            Expenditure2 = new DataGridViewTextBoxColumn();
            Income2 = new DataGridViewTextBoxColumn();
            RealGL2 = new DataGridViewTextBoxColumn();
            RealGLradio2 = new DataGridViewTextBoxColumn();
            CurrentAmt2 = new DataGridViewTextBoxColumn();
            Marketprice2 = new DataGridViewTextBoxColumn();
            UnGL2 = new DataGridViewTextBoxColumn();
            UnGLradio2 = new DataGridViewTextBoxColumn();
            tabPage4 = new TabPage();
            dataGridViewOutput = new DataGridView();
            StockID3 = new DataGridViewTextBoxColumn();
            StockName3 = new DataGridViewTextBoxColumn();
            StockTraded3 = new DataGridViewTextBoxColumn();
            StockAmount3 = new DataGridViewTextBoxColumn();
            StartAmount3 = new DataGridViewTextBoxColumn();
            HighestAmount3 = new DataGridViewTextBoxColumn();
            LowestAmount3 = new DataGridViewTextBoxColumn();
            FinalTradedAmount3 = new DataGridViewTextBoxColumn();
            AmountChanged3 = new DataGridViewTextBoxColumn();
            TradeCount3 = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button4 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            button5 = new Button();
            button6 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1297, 634);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(button6);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(pbCreateDB);
            tabPage1.Location = new Point(4, 28);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1289, 602);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "參數設定";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pbCreateDB
            // 
            pbCreateDB.BackColor = Color.PaleTurquoise;
            pbCreateDB.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            pbCreateDB.Location = new Point(45, 26);
            pbCreateDB.Name = "pbCreateDB";
            pbCreateDB.Size = new Size(177, 56);
            pbCreateDB.TabIndex = 0;
            pbCreateDB.Text = "重製資料";
            pbCreateDB.UseVisualStyleBackColor = false;
            pbCreateDB.Click += pbCreateDB_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Location = new Point(4, 28);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1289, 602);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "交易紀錄";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1283, 596);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TradeDate, BorS, StockNo, StockName, Type, BuyUnit, BuyAmt, SellUnit, SellAmt, RealAmt, Charge, ChargeDown, Tax, Tprice, Tcost, Expenditure, Income, Remark, Taxdiscount, Rowid });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1277, 540);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TradeDate
            // 
            TradeDate.HeaderText = "交易日期";
            TradeDate.MaxInputLength = 10;
            TradeDate.MinimumWidth = 6;
            TradeDate.Name = "TradeDate";
            TradeDate.Width = 125;
            // 
            // BorS
            // 
            BorS.HeaderText = "買/賣";
            BorS.MinimumWidth = 6;
            BorS.Name = "BorS";
            BorS.Width = 60;
            // 
            // StockNo
            // 
            StockNo.HeaderText = "代號";
            StockNo.MinimumWidth = 6;
            StockNo.Name = "StockNo";
            StockNo.Width = 60;
            // 
            // StockName
            // 
            StockName.HeaderText = "股票名稱";
            StockName.MinimumWidth = 6;
            StockName.Name = "StockName";
            StockName.Width = 125;
            // 
            // Type
            // 
            Type.HeaderText = "交易類別";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.Width = 60;
            // 
            // BuyUnit
            // 
            BuyUnit.HeaderText = "買入股數";
            BuyUnit.MinimumWidth = 6;
            BuyUnit.Name = "BuyUnit";
            BuyUnit.Width = 80;
            // 
            // BuyAmt
            // 
            BuyAmt.HeaderText = "買入價位";
            BuyAmt.MinimumWidth = 6;
            BuyAmt.Name = "BuyAmt";
            BuyAmt.Width = 80;
            // 
            // SellUnit
            // 
            SellUnit.HeaderText = "賣出股數";
            SellUnit.MinimumWidth = 6;
            SellUnit.Name = "SellUnit";
            SellUnit.Width = 80;
            // 
            // SellAmt
            // 
            SellAmt.HeaderText = "賣出價位";
            SellAmt.MinimumWidth = 6;
            SellAmt.Name = "SellAmt";
            SellAmt.Width = 80;
            // 
            // RealAmt
            // 
            RealAmt.HeaderText = "現價";
            RealAmt.MinimumWidth = 6;
            RealAmt.Name = "RealAmt";
            RealAmt.Width = 80;
            // 
            // Charge
            // 
            Charge.HeaderText = "手續費";
            Charge.MinimumWidth = 6;
            Charge.Name = "Charge";
            Charge.Width = 80;
            // 
            // ChargeDown
            // 
            ChargeDown.HeaderText = "折讓後手續費";
            ChargeDown.MinimumWidth = 6;
            ChargeDown.Name = "ChargeDown";
            ChargeDown.Width = 80;
            // 
            // Tax
            // 
            Tax.HeaderText = "稅";
            Tax.MinimumWidth = 6;
            Tax.Name = "Tax";
            Tax.Width = 80;
            // 
            // Tprice
            // 
            Tprice.HeaderText = "成交價金";
            Tprice.MinimumWidth = 6;
            Tprice.Name = "Tprice";
            Tprice.Width = 80;
            // 
            // Tcost
            // 
            Tcost.HeaderText = "交易成本";
            Tcost.MinimumWidth = 6;
            Tcost.Name = "Tcost";
            Tcost.Width = 80;
            // 
            // Expenditure
            // 
            Expenditure.HeaderText = "支出";
            Expenditure.MinimumWidth = 6;
            Expenditure.Name = "Expenditure";
            Expenditure.Width = 80;
            // 
            // Income
            // 
            Income.HeaderText = "收入";
            Income.MinimumWidth = 6;
            Income.Name = "Income";
            Income.Width = 80;
            // 
            // Remark
            // 
            Remark.HeaderText = "決策原因";
            Remark.MinimumWidth = 6;
            Remark.Name = "Remark";
            Remark.Width = 125;
            // 
            // Taxdiscount
            // 
            Taxdiscount.HeaderText = "手續費折數";
            Taxdiscount.MinimumWidth = 6;
            Taxdiscount.Name = "Taxdiscount";
            Taxdiscount.Width = 80;
            // 
            // Rowid
            // 
            Rowid.HeaderText = "流水號";
            Rowid.MinimumWidth = 6;
            Rowid.Name = "Rowid";
            Rowid.Width = 125;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1277, 44);
            panel1.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleTurquoise;
            button2.Location = new Point(127, 3);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "刪除";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Location = new Point(13, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "新增";
            button1.UseVisualStyleBackColor = false;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tableLayoutPanel2);
            tabPage3.Location = new Point(4, 28);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1289, 602);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "持股狀況";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { StockName2, Stockunit2, Buyprice2, Costs2, Expenditure2, Income2, RealGL2, RealGLradio2, CurrentAmt2, Marketprice2, UnGL2, UnGLradio2 });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 69);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1283, 530);
            dataGridView2.TabIndex = 0;
            // 
            // StockName2
            // 
            StockName2.HeaderText = "股票";
            StockName2.MinimumWidth = 6;
            StockName2.Name = "StockName2";
            StockName2.Width = 125;
            // 
            // Stockunit2
            // 
            Stockunit2.HeaderText = "股數";
            Stockunit2.MinimumWidth = 6;
            Stockunit2.Name = "Stockunit2";
            Stockunit2.Width = 125;
            // 
            // Buyprice2
            // 
            Buyprice2.HeaderText = "買入均價";
            Buyprice2.MinimumWidth = 6;
            Buyprice2.Name = "Buyprice2";
            Buyprice2.Width = 125;
            // 
            // Costs2
            // 
            Costs2.HeaderText = "交易成本";
            Costs2.MinimumWidth = 6;
            Costs2.Name = "Costs2";
            Costs2.Width = 125;
            // 
            // Expenditure2
            // 
            Expenditure2.HeaderText = "支出";
            Expenditure2.MinimumWidth = 6;
            Expenditure2.Name = "Expenditure2";
            Expenditure2.Width = 125;
            // 
            // Income2
            // 
            Income2.HeaderText = "收入";
            Income2.MinimumWidth = 6;
            Income2.Name = "Income2";
            Income2.Width = 125;
            // 
            // RealGL2
            // 
            RealGL2.HeaderText = "已實現損益";
            RealGL2.MinimumWidth = 6;
            RealGL2.Name = "RealGL2";
            RealGL2.Width = 125;
            // 
            // RealGLradio2
            // 
            RealGLradio2.HeaderText = "已實現損益率";
            RealGLradio2.MinimumWidth = 6;
            RealGLradio2.Name = "RealGLradio2";
            RealGLradio2.Width = 125;
            // 
            // CurrentAmt2
            // 
            CurrentAmt2.HeaderText = "現價";
            CurrentAmt2.MinimumWidth = 6;
            CurrentAmt2.Name = "CurrentAmt2";
            CurrentAmt2.Width = 125;
            // 
            // Marketprice2
            // 
            Marketprice2.HeaderText = "市值";
            Marketprice2.MinimumWidth = 6;
            Marketprice2.Name = "Marketprice2";
            Marketprice2.Width = 125;
            // 
            // UnGL2
            // 
            UnGL2.HeaderText = "未實現損益";
            UnGL2.MinimumWidth = 6;
            UnGL2.Name = "UnGL2";
            UnGL2.Width = 125;
            // 
            // UnGLradio2
            // 
            UnGLradio2.HeaderText = "未實現損益率";
            UnGLradio2.MinimumWidth = 6;
            UnGLradio2.Name = "UnGLradio2";
            UnGLradio2.Width = 125;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dataGridViewOutput);
            tabPage4.Location = new Point(4, 28);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1289, 602);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "股價";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOutput
            // 
            dataGridViewOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput.Columns.AddRange(new DataGridViewColumn[] { StockID3, StockName3, StockTraded3, StockAmount3, StartAmount3, HighestAmount3, LowestAmount3, FinalTradedAmount3, AmountChanged3, TradeCount3 });
            dataGridViewOutput.Dock = DockStyle.Fill;
            dataGridViewOutput.Location = new Point(0, 0);
            dataGridViewOutput.Margin = new Padding(4);
            dataGridViewOutput.Name = "dataGridViewOutput";
            dataGridViewOutput.RowHeadersWidth = 51;
            dataGridViewOutput.Size = new Size(1289, 602);
            dataGridViewOutput.TabIndex = 15;
            // 
            // StockID3
            // 
            StockID3.HeaderText = "證券代號";
            StockID3.MinimumWidth = 6;
            StockID3.Name = "StockID3";
            StockID3.Width = 125;
            // 
            // StockName3
            // 
            StockName3.HeaderText = "證券名稱";
            StockName3.MinimumWidth = 6;
            StockName3.Name = "StockName3";
            StockName3.Width = 125;
            // 
            // StockTraded3
            // 
            StockTraded3.HeaderText = "成交股數";
            StockTraded3.MinimumWidth = 6;
            StockTraded3.Name = "StockTraded3";
            StockTraded3.Width = 125;
            // 
            // StockAmount3
            // 
            StockAmount3.HeaderText = "成交金額";
            StockAmount3.MinimumWidth = 6;
            StockAmount3.Name = "StockAmount3";
            StockAmount3.Width = 125;
            // 
            // StartAmount3
            // 
            StartAmount3.HeaderText = "開盤價";
            StartAmount3.MinimumWidth = 6;
            StartAmount3.Name = "StartAmount3";
            StartAmount3.Width = 125;
            // 
            // HighestAmount3
            // 
            HighestAmount3.HeaderText = "最高價";
            HighestAmount3.MinimumWidth = 6;
            HighestAmount3.Name = "HighestAmount3";
            HighestAmount3.Width = 125;
            // 
            // LowestAmount3
            // 
            LowestAmount3.HeaderText = "最低價";
            LowestAmount3.MinimumWidth = 6;
            LowestAmount3.Name = "LowestAmount3";
            LowestAmount3.Width = 125;
            // 
            // FinalTradedAmount3
            // 
            FinalTradedAmount3.HeaderText = "收盤價";
            FinalTradedAmount3.MinimumWidth = 6;
            FinalTradedAmount3.Name = "FinalTradedAmount3";
            FinalTradedAmount3.Width = 125;
            // 
            // AmountChanged3
            // 
            AmountChanged3.HeaderText = "漲跌價差";
            AmountChanged3.MinimumWidth = 6;
            AmountChanged3.Name = "AmountChanged3";
            AmountChanged3.Width = 125;
            // 
            // TradeCount3
            // 
            TradeCount3.HeaderText = "成交筆數";
            TradeCount3.MinimumWidth = 6;
            TradeCount3.Name = "TradeCount3";
            TradeCount3.Width = 125;
            // 
            // button3
            // 
            button3.BackColor = Color.PaleTurquoise;
            button3.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button3.Location = new Point(45, 101);
            button3.Name = "button3";
            button3.Size = new Size(177, 56);
            button3.TabIndex = 1;
            button3.Text = "股價匯入日期";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.PaleTurquoise;
            button4.Location = new Point(245, 3);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 2;
            button4.Text = "重新計算";
            button4.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dataGridView2, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9634552F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 89.0365448F));
            tableLayoutPanel2.Size = new Size(1289, 602);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(button5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1283, 60);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = Color.PaleTurquoise;
            button5.Location = new Point(16, 15);
            button5.Name = "button5";
            button5.Size = new Size(134, 29);
            button5.TabIndex = 3;
            button5.Text = "統計";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.PaleTurquoise;
            button6.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button6.Location = new Point(45, 181);
            button6.Name = "button6";
            button6.Size = new Size(177, 56);
            button6.TabIndex = 2;
            button6.Text = "手續費折數";
            button6.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBox2.Location = new Point(264, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 38);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 136);
            textBox1.Location = new Point(264, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 38);
            textBox1.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1297, 634);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button pbCreateDB;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView2;
        private DataGridView dataGridViewOutput;
        private DataGridViewTextBoxColumn TradeDate;
        private DataGridViewTextBoxColumn BorS;
        private DataGridViewTextBoxColumn StockNo;
        private DataGridViewTextBoxColumn StockName;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn BuyUnit;
        private DataGridViewTextBoxColumn BuyAmt;
        private DataGridViewTextBoxColumn SellUnit;
        private DataGridViewTextBoxColumn SellAmt;
        private DataGridViewTextBoxColumn RealAmt;
        private DataGridViewTextBoxColumn Charge;
        private DataGridViewTextBoxColumn ChargeDown;
        private DataGridViewTextBoxColumn Tax;
        private DataGridViewTextBoxColumn Tprice;
        private DataGridViewTextBoxColumn Tcost;
        private DataGridViewTextBoxColumn Expenditure;
        private DataGridViewTextBoxColumn Income;
        private DataGridViewTextBoxColumn Remark;
        private DataGridViewTextBoxColumn Taxdiscount;
        private DataGridViewTextBoxColumn Rowid;
        private DataGridViewTextBoxColumn StockName2;
        private DataGridViewTextBoxColumn Stockunit2;
        private DataGridViewTextBoxColumn Buyprice2;
        private DataGridViewTextBoxColumn Costs2;
        private DataGridViewTextBoxColumn Expenditure2;
        private DataGridViewTextBoxColumn Income2;
        private DataGridViewTextBoxColumn RealGL2;
        private DataGridViewTextBoxColumn RealGLradio2;
        private DataGridViewTextBoxColumn CurrentAmt2;
        private DataGridViewTextBoxColumn Marketprice2;
        private DataGridViewTextBoxColumn UnGL2;
        private DataGridViewTextBoxColumn UnGLradio2;
        private DataGridViewTextBoxColumn StockID3;
        private DataGridViewTextBoxColumn StockName3;
        private DataGridViewTextBoxColumn StockTraded3;
        private DataGridViewTextBoxColumn StockAmount3;
        private DataGridViewTextBoxColumn StartAmount3;
        private DataGridViewTextBoxColumn HighestAmount3;
        private DataGridViewTextBoxColumn LowestAmount3;
        private DataGridViewTextBoxColumn FinalTradedAmount3;
        private DataGridViewTextBoxColumn AmountChanged3;
        private DataGridViewTextBoxColumn TradeCount3;
        private Button button3;
        private Button button4;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Button button5;
        private Button button6;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}