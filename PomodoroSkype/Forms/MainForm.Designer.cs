namespace PomodoroSkype.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnRun = new System.Windows.Forms.Button();
            this.lbTimer = new System.Windows.Forms.Label();
            this.tsTop = new System.Windows.Forms.ToolStrip();
            this.tsbtnUnplanned = new System.Windows.Forms.ToolStripButton();
            this.tsbtnInterruption = new System.Windows.Forms.ToolStripButton();
            this.tsbtnStats = new System.Windows.Forms.ToolStripButton();
            this.tsBtnTaskList = new System.Windows.Forms.ToolStripButton();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.olvTasks = new BrightIdeasSoftware.ObjectListView();
            this.colTask = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colEstimated = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colCompleted = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colUnplanned = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colInterruptions = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lbCurrentTask = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.tsTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(123)))), ((int)(((byte)(205)))));
            this.btnRun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(123)))), ((int)(((byte)(205)))));
            this.btnRun.FlatAppearance.BorderSize = 0;
            this.btnRun.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Location = new System.Drawing.Point(191, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(114, 43);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.StartTimer);
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Segoe UI", 35F);
            this.lbTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.lbTimer.Location = new System.Drawing.Point(-1, 0);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(137, 62);
            this.lbTimer.TabIndex = 2;
            this.lbTimer.Text = "25:00";
            this.lbTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsTop
            // 
            this.tsTop.AutoSize = false;
            this.tsTop.BackColor = System.Drawing.Color.White;
            this.tsTop.CanOverflow = false;
            this.tsTop.Dock = System.Windows.Forms.DockStyle.None;
            this.tsTop.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tsTop.GripMargin = new System.Windows.Forms.Padding(0);
            this.tsTop.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnUnplanned,
            this.tsbtnInterruption,
            this.tsbtnStats});
            this.tsTop.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsTop.Location = new System.Drawing.Point(-3, 78);
            this.tsTop.Name = "tsTop";
            this.tsTop.Padding = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.tsTop.Size = new System.Drawing.Size(324, 27);
            this.tsTop.TabIndex = 3;
            this.tsTop.Text = "toolStrip1";
            // 
            // tsbtnUnplanned
            // 
            this.tsbtnUnplanned.AutoSize = false;
            this.tsbtnUnplanned.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnUnplanned.Enabled = false;
            this.tsbtnUnplanned.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUnplanned.Image")));
            this.tsbtnUnplanned.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUnplanned.Name = "tsbtnUnplanned";
            this.tsbtnUnplanned.Size = new System.Drawing.Size(118, 24);
            this.tsbtnUnplanned.Text = "Unplanned Task";
            // 
            // tsbtnInterruption
            // 
            this.tsbtnInterruption.AutoSize = false;
            this.tsbtnInterruption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnInterruption.Enabled = false;
            this.tsbtnInterruption.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnInterruption.Image")));
            this.tsbtnInterruption.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnInterruption.Name = "tsbtnInterruption";
            this.tsbtnInterruption.Size = new System.Drawing.Size(110, 24);
            this.tsbtnInterruption.Text = "Interruption";
            // 
            // tsbtnStats
            // 
            this.tsbtnStats.AutoSize = false;
            this.tsbtnStats.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnStats.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnStats.Image")));
            this.tsbtnStats.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStats.Name = "tsbtnStats";
            this.tsbtnStats.Size = new System.Drawing.Size(70, 24);
            this.tsbtnStats.Text = "Stats";
            // 
            // tsBtnTaskList
            // 
            this.tsBtnTaskList.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnTaskList.Image")));
            this.tsBtnTaskList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnTaskList.Name = "tsBtnTaskList";
            this.tsBtnTaskList.Size = new System.Drawing.Size(72, 24);
            this.tsBtnTaskList.Text = "Task List";
            // 
            // colName
            // 
            this.colName.Text = "Task";
            // 
            // olvTasks
            // 
            this.olvTasks.AllColumns.Add(this.colTask);
            this.olvTasks.AllColumns.Add(this.colEstimated);
            this.olvTasks.AllColumns.Add(this.colCompleted);
            this.olvTasks.AllColumns.Add(this.colUnplanned);
            this.olvTasks.AllColumns.Add(this.colInterruptions);
            this.olvTasks.AutoArrange = false;
            this.olvTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.olvTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.olvTasks.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.olvTasks.CheckedAspectName = "";
            this.olvTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTask,
            this.colEstimated,
            this.colCompleted,
            this.colUnplanned,
            this.colInterruptions});
            this.olvTasks.EmptyListMsg = "";
            this.olvTasks.EmptyListMsgFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.olvTasks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.olvTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.olvTasks.FullRowSelect = true;
            this.olvTasks.GridLines = true;
            this.olvTasks.HasCollapsibleGroups = false;
            this.olvTasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.olvTasks.Location = new System.Drawing.Point(0, 106);
            this.olvTasks.Name = "olvTasks";
            this.olvTasks.ShowCommandMenuOnRightClick = true;
            this.olvTasks.ShowGroups = false;
            this.olvTasks.Size = new System.Drawing.Size(315, 279);
            this.olvTasks.TabIndex = 4;
            this.olvTasks.UseCompatibleStateImageBehavior = false;
            this.olvTasks.View = System.Windows.Forms.View.Details;
            // 
            // colTask
            // 
            this.colTask.AspectName = "Name";
            this.colTask.CellPadding = new System.Drawing.Rectangle(15, 2, 3, 4);
            this.colTask.CellVerticalAlignment = System.Drawing.StringAlignment.Center;
            this.colTask.Groupable = false;
            this.colTask.Hideable = false;
            this.colTask.IsEditable = false;
            this.colTask.Text = "Task";
            this.colTask.Width = 194;
            // 
            // colEstimated
            // 
            this.colEstimated.AspectName = "EstimatedPomodorosCount";
            this.colEstimated.CellPadding = null;
            this.colEstimated.CellVerticalAlignment = System.Drawing.StringAlignment.Center;
            this.colEstimated.Groupable = false;
            this.colEstimated.Text = "E";
            this.colEstimated.ToolTipText = "Estimated Pomodoros";
            this.colEstimated.Width = 25;
            // 
            // colCompleted
            // 
            this.colCompleted.AspectName = "CompletedPomodorosCount";
            this.colCompleted.CellPadding = null;
            this.colCompleted.CellVerticalAlignment = System.Drawing.StringAlignment.Center;
            this.colCompleted.Groupable = false;
            this.colCompleted.IsEditable = false;
            this.colCompleted.Text = "C";
            this.colCompleted.ToolTipText = "Completed Pomodoros";
            this.colCompleted.Width = 25;
            // 
            // colUnplanned
            // 
            this.colUnplanned.AspectName = "UnplannedTasksCount";
            this.colUnplanned.CellPadding = null;
            this.colUnplanned.CellVerticalAlignment = System.Drawing.StringAlignment.Center;
            this.colUnplanned.Groupable = false;
            this.colUnplanned.IsEditable = false;
            this.colUnplanned.Text = "U";
            this.colUnplanned.ToolTipText = "Unplanned Tasks Count";
            this.colUnplanned.Width = 25;
            // 
            // colInterruptions
            // 
            this.colInterruptions.AspectName = "InterruptionsCount";
            this.colInterruptions.CellPadding = null;
            this.colInterruptions.CellVerticalAlignment = System.Drawing.StringAlignment.Center;
            this.colInterruptions.Groupable = false;
            this.colInterruptions.IsEditable = false;
            this.colInterruptions.Text = "I";
            this.colInterruptions.ToolTipText = "Interruptions Count";
            this.colInterruptions.Width = 25;
            // 
            // lbCurrentTask
            // 
            this.lbCurrentTask.AutoSize = true;
            this.lbCurrentTask.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCurrentTask.ForeColor = System.Drawing.Color.Silver;
            this.lbCurrentTask.Location = new System.Drawing.Point(9, 62);
            this.lbCurrentTask.Name = "lbCurrentTask";
            this.lbCurrentTask.Size = new System.Drawing.Size(140, 13);
            this.lbCurrentTask.TabIndex = 5;
            this.lbCurrentTask.Text = "Chose task and press Run";
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
            this.btnAddTask.Location = new System.Drawing.Point(191, 392);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(114, 27);
            this.btnAddTask.TabIndex = 6;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Image = global::PomodoroSkype.Properties.Resources.config;
            this.btnConfig.Location = new System.Drawing.Point(10, 391);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(33, 28);
            this.btnConfig.TabIndex = 7;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnRun;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(317, 424);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.lbCurrentTask);
            this.Controls.Add(this.olvTasks);
            this.Controls.Add(this.tsTop);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.btnRun);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PomodoroSkype";
            this.tsTop.ResumeLayout(false);
            this.tsTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.ToolStrip tsTop;
        private System.Windows.Forms.ToolStripButton tsBtnTaskList;
        private System.Windows.Forms.ColumnHeader colName;
        private BrightIdeasSoftware.ObjectListView olvTasks;
        private BrightIdeasSoftware.OLVColumn colTask;
        private BrightIdeasSoftware.OLVColumn colEstimated;
        private BrightIdeasSoftware.OLVColumn colCompleted;
        private BrightIdeasSoftware.OLVColumn colUnplanned;
        private BrightIdeasSoftware.OLVColumn colInterruptions;
        private System.Windows.Forms.ToolStripButton tsbtnUnplanned;
        private System.Windows.Forms.ToolStripButton tsbtnInterruption;
        private System.Windows.Forms.Label lbCurrentTask;
        private System.Windows.Forms.ToolStripButton tsbtnStats;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnConfig;
    }
}

