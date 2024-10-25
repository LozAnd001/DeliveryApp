namespace DeliveryWinFormsApp
{
    partial class SortForm
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
            ordersDataGridView = new DataGridView();
            weight = new DataGridViewTextBoxColumn();
            district = new DataGridViewTextBoxColumn();
            deliveryDate = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ordersDataGridView
            // 
            ordersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDataGridView.Columns.AddRange(new DataGridViewColumn[] { weight, district, deliveryDate });
            ordersDataGridView.Location = new Point(12, 30);
            ordersDataGridView.Name = "ordersDataGridView";
            ordersDataGridView.RowHeadersWidth = 51;
            ordersDataGridView.Size = new Size(429, 188);
            ordersDataGridView.TabIndex = 0;
            // 
            // weight
            // 
            weight.HeaderText = "Вес, кг";
            weight.MinimumWidth = 6;
            weight.Name = "weight";
            weight.Width = 125;
            // 
            // district
            // 
            district.HeaderText = "Район";
            district.MinimumWidth = 6;
            district.Name = "district";
            district.Width = 125;
            // 
            // deliveryDate
            // 
            deliveryDate.HeaderText = "Время доставки";
            deliveryDate.MinimumWidth = 6;
            deliveryDate.Name = "deliveryDate";
            deliveryDate.Width = 125;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(479, 30);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(478, 7);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 2;
            label1.Text = "С";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(478, 88);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 3;
            label2.Text = "По";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(479, 111);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(478, 160);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 5;
            label3.Text = "Район";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(478, 197);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            textBox1.Text = "Все";
            // 
            // button1
            // 
            button1.Location = new Point(479, 252);
            button1.Name = "button1";
            button1.Size = new Size(124, 34);
            button1.TabIndex = 7;
            button1.Text = "Сортировать";
            button1.UseVisualStyleBackColor = true;
            // 
            // SortForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 397);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(ordersDataGridView);
            Name = "SortForm";
            Text = "SortForm";
            Load += SortForm_Load;
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ordersDataGridView;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private DataGridViewTextBoxColumn weight;
        private DataGridViewTextBoxColumn district;
        private DataGridViewTextBoxColumn deliveryDate;
    }
}