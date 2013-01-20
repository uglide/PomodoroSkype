namespace PomodoroSkype
{
    partial class TaskForm
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
            this.lbTaskAdd = new System.Windows.Forms.Label();
            this.lbList = new System.Windows.Forms.Label();
            this.cbTaskLists = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTasks = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudEstimation = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstimation)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTaskAdd
            // 
            this.lbTaskAdd.AutoSize = true;
            this.lbTaskAdd.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lbTaskAdd.Location = new System.Drawing.Point(16, 20);
            this.lbTaskAdd.Name = "lbTaskAdd";
            this.lbTaskAdd.Size = new System.Drawing.Size(224, 25);
            this.lbTaskAdd.TabIndex = 0;
            this.lbTaskAdd.Text = "Add Task From Wunderlist2:";
            // 
            // lbList
            // 
            this.lbList.AutoSize = true;
            this.lbList.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.lbList.Location = new System.Drawing.Point(18, 60);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(29, 20);
            this.lbList.TabIndex = 1;
            this.lbList.Text = "List";
            // 
            // cbTaskLists
            // 
            this.cbTaskLists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.cbTaskLists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTaskLists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTaskLists.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTaskLists.FormattingEnabled = true;
            this.cbTaskLists.Location = new System.Drawing.Point(96, 59);
            this.cbTaskLists.Name = "cbTaskLists";
            this.cbTaskLists.Size = new System.Drawing.Size(217, 25);
            this.cbTaskLists.TabIndex = 2;
            this.cbTaskLists.SelectedIndexChanged += new System.EventHandler(this.cbTaskLists_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label1.Location = new System.Drawing.Point(18, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Task";
            // 
            // cbTasks
            // 
            this.cbTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.cbTasks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTasks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTasks.FormattingEnabled = true;
            this.cbTasks.Location = new System.Drawing.Point(96, 96);
            this.cbTasks.Name = "cbTasks";
            this.cbTasks.Size = new System.Drawing.Size(217, 25);
            this.cbTasks.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label2.Location = new System.Drawing.Point(17, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estimation";
            // 
            // nudEstimation
            // 
            this.nudEstimation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.nudEstimation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudEstimation.Location = new System.Drawing.Point(96, 138);
            this.nudEstimation.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudEstimation.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEstimation.Name = "nudEstimation";
            this.nudEstimation.Size = new System.Drawing.Size(217, 25);
            this.nudEstimation.TabIndex = 6;
            this.nudEstimation.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(123)))), ((int)(((byte)(205)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(101)))), ((int)(((byte)(207)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(199, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add Task";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(123)))), ((int)(((byte)(205)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(101)))), ((int)(((byte)(207)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe WP", 11F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(297, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.cbTaskLists);
            this.panel1.Controls.Add(this.nudEstimation);
            this.panel1.Controls.Add(this.lbTaskAdd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbList);
            this.panel1.Controls.Add(this.cbTasks);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 235);
            this.panel1.TabIndex = 9;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(336, 235);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TaskForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudEstimation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTaskAdd;
        private System.Windows.Forms.Label lbList;
        private System.Windows.Forms.ComboBox cbTaskLists;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTasks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudEstimation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
    }
}