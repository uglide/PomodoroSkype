namespace PomodoroSkype.Forms
{
    partial class SettingsForm
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
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.dgvOptions = new System.Windows.Forms.DataGridView();
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new PomodoroSkype.dataDataSet();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.tpTemplates = new System.Windows.Forms.TabPage();
            this.settingsTableAdapter = new PomodoroSkype.dataDataSetTableAdapters.settingsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSettings.SuspendLayout();
            this.tpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tpSettings);
            this.tabSettings.Controls.Add(this.tpTemplates);
            this.tabSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabSettings.Location = new System.Drawing.Point(0, 0);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(534, 370);
            this.tabSettings.TabIndex = 0;
            // 
            // tpSettings
            // 
            this.tpSettings.BackColor = System.Drawing.Color.White;
            this.tpSettings.Controls.Add(this.dgvOptions);
            this.tpSettings.Controls.Add(this.btnAddTask);
            this.tpSettings.Location = new System.Drawing.Point(4, 26);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(526, 340);
            this.tpSettings.TabIndex = 0;
            this.tpSettings.Text = "Main Settings";
            // 
            // dgvOptions
            // 
            this.dgvOptions.AllowUserToAddRows = false;
            this.dgvOptions.AllowUserToDeleteRows = false;
            this.dgvOptions.AutoGenerateColumns = false;
            this.dgvOptions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dgvOptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOptions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvOptions.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.settingsBindingSource, "value", true));
            this.dgvOptions.DataSource = this.settingsBindingSource;
            this.dgvOptions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dgvOptions.Location = new System.Drawing.Point(3, 3);
            this.dgvOptions.MultiSelect = false;
            this.dgvOptions.Name = "dgvOptions";
            this.dgvOptions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOptions.Size = new System.Drawing.Size(520, 301);
            this.dgvOptions.TabIndex = 8;
            // 
            // settingsBindingSource
            // 
            this.settingsBindingSource.DataMember = "settings";
            this.settingsBindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "dataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(123)))), ((int)(((byte)(205)))));
            this.btnAddTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(101)))), ((int)(((byte)(207)))));
            this.btnAddTask.FlatAppearance.BorderSize = 0;
            this.btnAddTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(409, 310);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(114, 27);
            this.btnAddTask.TabIndex = 7;
            this.btnAddTask.Text = "Save";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // tpTemplates
            // 
            this.tpTemplates.Location = new System.Drawing.Point(4, 26);
            this.tpTemplates.Name = "tpTemplates";
            this.tpTemplates.Padding = new System.Windows.Forms.Padding(3);
            this.tpTemplates.Size = new System.Drawing.Size(526, 340);
            this.tpTemplates.TabIndex = 1;
            this.tpTemplates.Text = "Message Templates";
            this.tpTemplates.UseVisualStyleBackColor = true;
            // 
            // settingsTableAdapter
            // 
            this.settingsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "value";
            this.dataGridViewTextBoxColumn2.HeaderText = "value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 370);
            this.Controls.Add(this.tabSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabSettings.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.TabPage tpTemplates;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.DataGridView dgvOptions;
        private dataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource settingsBindingSource;
        private dataDataSetTableAdapters.settingsTableAdapter settingsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}