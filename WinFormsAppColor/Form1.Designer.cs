namespace WinFormsAppColor
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            colorIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            colorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cultureDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            meaningDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isPositiveDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            colorsAndMeaningBindingSource = new BindingSource(components);
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)colorsAndMeaningBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colorIdDataGridViewTextBoxColumn, colorDataGridViewTextBoxColumn, cultureDataGridViewTextBoxColumn, meaningDataGridViewTextBoxColumn, isPositiveDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = colorsAndMeaningBindingSource;
            dataGridView1.Location = new Point(188, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(446, 368);
            dataGridView1.TabIndex = 0;
            // 
            // colorIdDataGridViewTextBoxColumn
            // 
            colorIdDataGridViewTextBoxColumn.DataPropertyName = "ColorId";
            colorIdDataGridViewTextBoxColumn.HeaderText = "ColorId";
            colorIdDataGridViewTextBoxColumn.Name = "colorIdDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            colorDataGridViewTextBoxColumn.HeaderText = "Color";
            colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // cultureDataGridViewTextBoxColumn
            // 
            cultureDataGridViewTextBoxColumn.DataPropertyName = "Culture";
            cultureDataGridViewTextBoxColumn.HeaderText = "Culture";
            cultureDataGridViewTextBoxColumn.Name = "cultureDataGridViewTextBoxColumn";
            // 
            // meaningDataGridViewTextBoxColumn
            // 
            meaningDataGridViewTextBoxColumn.DataPropertyName = "Meaning";
            meaningDataGridViewTextBoxColumn.HeaderText = "Meaning";
            meaningDataGridViewTextBoxColumn.Name = "meaningDataGridViewTextBoxColumn";
            // 
            // isPositiveDataGridViewCheckBoxColumn
            // 
            isPositiveDataGridViewCheckBoxColumn.DataPropertyName = "IsPositive";
            isPositiveDataGridViewCheckBoxColumn.HeaderText = "IsPositive";
            isPositiveDataGridViewCheckBoxColumn.Name = "isPositiveDataGridViewCheckBoxColumn";
            // 
            // colorsAndMeaningBindingSource
            // 
            colorsAndMeaningBindingSource.DataSource = typeof(BookModels.ColorsAndMeaning);
            // 
            // listBox1
            // 
            listBox1.DataSource = colorsAndMeaningBindingSource;
            listBox1.DisplayMember = "Color";
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 56);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(156, 364);
            listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", colorsAndMeaningBindingSource, "Color", true));
            textBox1.Location = new Point(640, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", colorsAndMeaningBindingSource, "Culture", true));
            textBox2.Location = new Point(640, 189);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(148, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", colorsAndMeaningBindingSource, "Meaning", true));
            textBox3.Location = new Point(640, 254);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(148, 23);
            textBox3.TabIndex = 4;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(640, 401);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Töröl";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.DataBindings.Add(new Binding("Checked", colorsAndMeaningBindingSource, "IsPositive", true));
            checkBox1.Location = new Point(640, 302);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(61, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Pozitív";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)colorsAndMeaningBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ListBox listBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private DataGridViewTextBoxColumn colorIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cultureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn meaningDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isPositiveDataGridViewCheckBoxColumn;
        private BindingSource colorsAndMeaningBindingSource;
        private CheckBox checkBox1;
    }
}