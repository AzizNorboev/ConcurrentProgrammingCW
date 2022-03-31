namespace ClientSide
{
    partial class UserInterface
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTerminal = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.swipesRecordDataSet = new ClientSide.SwipesRecordDataSet();
            this.swipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swipesTableAdapter = new ClientSide.SwipesRecordDataSetTableAdapters.SwipesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sideDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTerminal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swipesRecordDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swipesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn,
            this.sideDataGridViewTextBoxColumn,
            this.ipDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.swipesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(773, 550);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTerminal
            // 
            this.dataGridViewTerminal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTerminal.Location = new System.Drawing.Point(850, 35);
            this.dataGridViewTerminal.Name = "dataGridViewTerminal";
            this.dataGridViewTerminal.RowHeadersWidth = 51;
            this.dataGridViewTerminal.RowTemplate.Height = 24;
            this.dataGridViewTerminal.Size = new System.Drawing.Size(386, 468);
            this.dataGridViewTerminal.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1003, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Swipe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // swipesRecordDataSet
            // 
            this.swipesRecordDataSet.DataSetName = "SwipesRecordDataSet";
            this.swipesRecordDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // swipesBindingSource
            // 
            this.swipesBindingSource.DataMember = "Swipes";
            this.swipesBindingSource.DataSource = this.swipesRecordDataSet;
            // 
            // swipesTableAdapter
            // 
            this.swipesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            this.dateTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // sideDataGridViewTextBoxColumn
            // 
            this.sideDataGridViewTextBoxColumn.DataPropertyName = "Side";
            this.sideDataGridViewTextBoxColumn.HeaderText = "Side";
            this.sideDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sideDataGridViewTextBoxColumn.Name = "sideDataGridViewTextBoxColumn";
            this.sideDataGridViewTextBoxColumn.Width = 125;
            // 
            // ipDataGridViewTextBoxColumn
            // 
            this.ipDataGridViewTextBoxColumn.DataPropertyName = "Ip";
            this.ipDataGridViewTextBoxColumn.HeaderText = "Ip";
            this.ipDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ipDataGridViewTextBoxColumn.Name = "ipDataGridViewTextBoxColumn";
            this.ipDataGridViewTextBoxColumn.Width = 125;
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 685);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewTerminal);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserInterface";
            this.Text = "UserInterface";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTerminal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swipesRecordDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swipesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridViewTerminal;
        private System.Windows.Forms.Button button1;
        private SwipesRecordDataSet swipesRecordDataSet;
        private System.Windows.Forms.BindingSource swipesBindingSource;
        private SwipesRecordDataSetTableAdapters.SwipesTableAdapter swipesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sideDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
    }
}