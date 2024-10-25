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
            startDateTimePicker = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            finishDateTimePicker = new DateTimePicker();
            label3 = new Label();
            districtTextBox = new TextBox();
            sortButton = new Button();
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
            // startDateTimePicker
            // 
            startDateTimePicker.Location = new Point(479, 30);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(250, 27);
            startDateTimePicker.TabIndex = 1;
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
            // finishDateTimePicker
            // 
            finishDateTimePicker.Location = new Point(479, 111);
            finishDateTimePicker.Name = "finishDateTimePicker";
            finishDateTimePicker.Size = new Size(250, 27);
            finishDateTimePicker.TabIndex = 4;
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
            // districtTextBox
            // 
            districtTextBox.Location = new Point(478, 197);
            districtTextBox.Name = "districtTextBox";
            districtTextBox.Size = new Size(125, 27);
            districtTextBox.TabIndex = 6;
            districtTextBox.Text = "Все";
            // 
            // sortButton
            // 
            sortButton.Location = new Point(479, 252);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(124, 34);
            sortButton.TabIndex = 7;
            sortButton.Text = "Сортировать";
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click;
            // 
            // SortForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 397);
            Controls.Add(sortButton);
            Controls.Add(districtTextBox);
            Controls.Add(label3);
            Controls.Add(finishDateTimePicker);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(startDateTimePicker);
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
        private DateTimePicker startDateTimePicker;
        private Label label1;
        private Label label2;
        private DateTimePicker finishDateTimePicker;
        private Label label3;
        private TextBox districtTextBox;
        private Button sortButton;
        private DataGridViewTextBoxColumn weight;
        private DataGridViewTextBoxColumn district;
        private DataGridViewTextBoxColumn deliveryDate;
    }
}