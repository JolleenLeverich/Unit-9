﻿namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            g = new Label();
            EmployeeRB = new RadioButton();
            CustomersRB = new RadioButton();
            OrdersRB = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(119, 88);
            button1.Name = "button1";
            button1.Size = new Size(142, 67);
            button1.TabIndex = 0;
            button1.Text = "View Database";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(392, 90);
            button2.Name = "button2";
            button2.Size = new Size(123, 65);
            button2.TabIndex = 1;
            button2.Text = "Show Records Count";
            button2.TextImageRelation = TextImageRelation.TextBeforeImage;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(613, 150);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // g
            // 
            g.AutoSize = true;
            g.BackColor = SystemColors.ActiveCaption;
            g.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            g.Location = new Point(244, 27);
            g.Name = "g";
            g.Size = new Size(173, 25);
            g.TabIndex = 3;
            g.Text = "Northwind Database";
            // 
            // EmployeeRB
            // 
            EmployeeRB.AutoSize = true;
            EmployeeRB.Enabled = false;
            EmployeeRB.Location = new Point(186, 176);
            EmployeeRB.Name = "EmployeeRB";
            EmployeeRB.Size = new Size(77, 19);
            EmployeeRB.TabIndex = 8;
            EmployeeRB.TabStop = true;
            EmployeeRB.Text = "Employee";
            EmployeeRB.UseVisualStyleBackColor = true;
            // 
            // CustomersRB
            // 
            CustomersRB.AutoSize = true;
            CustomersRB.Enabled = false;
            CustomersRB.Location = new Point(311, 176);
            CustomersRB.Name = "CustomersRB";
            CustomersRB.Size = new Size(82, 19);
            CustomersRB.TabIndex = 9;
            CustomersRB.TabStop = true;
            CustomersRB.Text = "Customers";
            CustomersRB.UseVisualStyleBackColor = true;
            // 
            // OrdersRB
            // 
            OrdersRB.AutoSize = true;
            OrdersRB.Enabled = false;
            OrdersRB.Location = new Point(440, 176);
            OrdersRB.Name = "OrdersRB";
            OrdersRB.Size = new Size(60, 19);
            OrdersRB.TabIndex = 10;
            OrdersRB.TabStop = true;
            OrdersRB.Text = "Orders";
            OrdersRB.UseVisualStyleBackColor = true;
            OrdersRB.CheckedChanged += OrdersRB_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OrdersRB);
            Controls.Add(CustomersRB);
            Controls.Add(EmployeeRB);
            Controls.Add(g);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Label g;
        private RadioButton radioButton1;
        private RadioButton EmployeeRB;
        private RadioButton CustomersRB;
        private RadioButton OrdersRB;
    }
}
