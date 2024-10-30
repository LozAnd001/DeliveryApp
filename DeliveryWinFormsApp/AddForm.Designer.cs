namespace DeliveryWinFormsApp
{
    partial class AddForm
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
            label1 = new Label();
            weightTextBox = new TextBox();
            label2 = new Label();
            districtTextBox = new TextBox();
            label3 = new Label();
            dateDeliveryOrderPicker = new DateTimePicker();
            addButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 24);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "Вес заказа:";
            // 
            // weightTextBox
            // 
            weightTextBox.Location = new Point(127, 47);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(125, 27);
            weightTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 87);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Район заказа:";
            // 
            // districtTextBox
            // 
            districtTextBox.Location = new Point(127, 110);
            districtTextBox.Name = "districtTextBox";
            districtTextBox.Size = new Size(125, 27);
            districtTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 153);
            label3.Name = "label3";
            label3.Size = new Size(171, 20);
            label3.TabIndex = 4;
            label3.Text = "Дата и время доставки:";
            // 
            // dateDeliveryOrderPicker
            // 
            dateDeliveryOrderPicker.Location = new Point(108, 191);
            dateDeliveryOrderPicker.Name = "dateDeliveryOrderPicker";
            dateDeliveryOrderPicker.Size = new Size(250, 27);
            dateDeliveryOrderPicker.TabIndex = 6;
            dateDeliveryOrderPicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // addButton
            // 
            addButton.Location = new Point(127, 255);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 29);
            addButton.TabIndex = 7;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 363);
            Controls.Add(addButton);
            Controls.Add(dateDeliveryOrderPicker);
            Controls.Add(label3);
            Controls.Add(districtTextBox);
            Controls.Add(label2);
            Controls.Add(weightTextBox);
            Controls.Add(label1);
            Name = "AddForm";
            Text = "Add";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox weightTextBox;
        private Label label2;
        private TextBox districtTextBox;
        private Label label3;
        private DateTimePicker dateDeliveryOrderPicker;
        private Button addButton;
    }
}