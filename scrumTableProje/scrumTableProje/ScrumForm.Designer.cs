namespace scrumTableProje
{
    partial class ScrumForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDateAddStory = new System.Windows.Forms.DateTimePicker();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblDateAddStory = new System.Windows.Forms.Label();
            this.lblTittleAndTopicStory = new System.Windows.Forms.Label();
            this.lblStoryName = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.TxtTittleAndTopic = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddStory = new System.Windows.Forms.Button();
            this.txtDateAddTask = new System.Windows.Forms.DateTimePicker();
            this.lblTaskComment = new System.Windows.Forms.Label();
            this.lblDateAddTask = new System.Windows.Forms.Label();
            this.lblTittleandTopic = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtCommentTask = new System.Windows.Forms.TextBox();
            this.txtTittleAndTopicTask = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.storyLbl = new System.Windows.Forms.Label();
            this.taskLbl = new System.Windows.Forms.Label();
            this.cmbStoryChoice = new System.Windows.Forms.ComboBox();
            this.lblChoice = new System.Windows.Forms.Label();
            this.lblStories = new System.Windows.Forms.Label();
            this.lblNotStarted = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.pboxUst = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grBStory = new System.Windows.Forms.GroupBox();
            this.grBTask = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grBStory.SuspendLayout();
            this.grBTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDateAddStory
            // 
            this.txtDateAddStory.Location = new System.Drawing.Point(103, 96);
            this.txtDateAddStory.Margin = new System.Windows.Forms.Padding(2);
            this.txtDateAddStory.Name = "txtDateAddStory";
            this.txtDateAddStory.Size = new System.Drawing.Size(101, 20);
            this.txtDateAddStory.TabIndex = 3;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblComment.Location = new System.Drawing.Point(239, 102);
            this.lblComment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(51, 13);
            this.lblComment.TabIndex = 16;
            this.lblComment.Text = "Comment";
            // 
            // lblDateAddStory
            // 
            this.lblDateAddStory.AutoSize = true;
            this.lblDateAddStory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblDateAddStory.Location = new System.Drawing.Point(5, 102);
            this.lblDateAddStory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateAddStory.Name = "lblDateAddStory";
            this.lblDateAddStory.Size = new System.Drawing.Size(79, 13);
            this.lblDateAddStory.TabIndex = 15;
            this.lblDateAddStory.Text = "Date Add Story";
            this.lblDateAddStory.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // lblTittleAndTopicStory
            // 
            this.lblTittleAndTopicStory.AutoSize = true;
            this.lblTittleAndTopicStory.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblTittleAndTopicStory.Location = new System.Drawing.Point(230, 65);
            this.lblTittleAndTopicStory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTittleAndTopicStory.Name = "lblTittleAndTopicStory";
            this.lblTittleAndTopicStory.Size = new System.Drawing.Size(60, 13);
            this.lblTittleAndTopicStory.TabIndex = 14;
            this.lblTittleAndTopicStory.Text = "Tittle-Topic";
            // 
            // lblStoryName
            // 
            this.lblStoryName.AutoSize = true;
            this.lblStoryName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblStoryName.Location = new System.Drawing.Point(50, 65);
            this.lblStoryName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStoryName.Name = "lblStoryName";
            this.lblStoryName.Size = new System.Drawing.Size(35, 13);
            this.lblStoryName.TabIndex = 13;
            this.lblStoryName.Text = "Name";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(301, 102);
            this.txtComment.Margin = new System.Windows.Forms.Padding(2);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(101, 60);
            this.txtComment.TabIndex = 4;
            // 
            // TxtTittleAndTopic
            // 
            this.TxtTittleAndTopic.Location = new System.Drawing.Point(301, 62);
            this.TxtTittleAndTopic.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTittleAndTopic.Name = "TxtTittleAndTopic";
            this.TxtTittleAndTopic.Size = new System.Drawing.Size(101, 20);
            this.TxtTittleAndTopic.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 62);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(101, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnAddStory
            // 
            this.btnAddStory.BackColor = System.Drawing.Color.Red;
            this.btnAddStory.Location = new System.Drawing.Point(103, 149);
            this.btnAddStory.Name = "btnAddStory";
            this.btnAddStory.Size = new System.Drawing.Size(104, 44);
            this.btnAddStory.TabIndex = 5;
            this.btnAddStory.Text = "AddStory";
            this.btnAddStory.UseVisualStyleBackColor = true;
            this.btnAddStory.Click += new System.EventHandler(this.btnStory_Click);
            this.btnAddStory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnStory_MouseClick);
            // 
            // txtDateAddTask
            // 
            this.txtDateAddTask.Location = new System.Drawing.Point(303, 96);
            this.txtDateAddTask.Margin = new System.Windows.Forms.Padding(2);
            this.txtDateAddTask.Name = "txtDateAddTask";
            this.txtDateAddTask.Size = new System.Drawing.Size(100, 20);
            this.txtDateAddTask.TabIndex = 9;
            // 
            // lblTaskComment
            // 
            this.lblTaskComment.AutoSize = true;
            this.lblTaskComment.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblTaskComment.Location = new System.Drawing.Point(237, 133);
            this.lblTaskComment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaskComment.Name = "lblTaskComment";
            this.lblTaskComment.Size = new System.Drawing.Size(51, 13);
            this.lblTaskComment.TabIndex = 22;
            this.lblTaskComment.Text = "Comment";
            // 
            // lblDateAddTask
            // 
            this.lblDateAddTask.AutoSize = true;
            this.lblDateAddTask.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblDateAddTask.Location = new System.Drawing.Point(209, 102);
            this.lblDateAddTask.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateAddTask.Name = "lblDateAddTask";
            this.lblDateAddTask.Size = new System.Drawing.Size(79, 13);
            this.lblDateAddTask.TabIndex = 21;
            this.lblDateAddTask.Text = "Date Add Task";
            // 
            // lblTittleandTopic
            // 
            this.lblTittleandTopic.AutoSize = true;
            this.lblTittleandTopic.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblTittleandTopic.Location = new System.Drawing.Point(13, 102);
            this.lblTittleandTopic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTittleandTopic.Name = "lblTittleandTopic";
            this.lblTittleandTopic.Size = new System.Drawing.Size(60, 13);
            this.lblTittleandTopic.TabIndex = 19;
            this.lblTittleandTopic.Text = "Tittle-Topic";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblAuthor.Location = new System.Drawing.Point(35, 65);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 18;
            this.lblAuthor.Text = "Author";
            // 
            // txtCommentTask
            // 
            this.txtCommentTask.Location = new System.Drawing.Point(303, 133);
            this.txtCommentTask.Margin = new System.Windows.Forms.Padding(2);
            this.txtCommentTask.Multiline = true;
            this.txtCommentTask.Name = "txtCommentTask";
            this.txtCommentTask.Size = new System.Drawing.Size(100, 60);
            this.txtCommentTask.TabIndex = 10;
            // 
            // txtTittleAndTopicTask
            // 
            this.txtTittleAndTopicTask.Location = new System.Drawing.Point(96, 99);
            this.txtTittleAndTopicTask.Margin = new System.Windows.Forms.Padding(2);
            this.txtTittleAndTopicTask.Name = "txtTittleAndTopicTask";
            this.txtTittleAndTopicTask.Size = new System.Drawing.Size(101, 20);
            this.txtTittleAndTopicTask.TabIndex = 7;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(96, 58);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(101, 20);
            this.txtAuthor.TabIndex = 6;
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.Aquamarine;
            this.btnAddTask.Location = new System.Drawing.Point(96, 149);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(101, 44);
            this.btnAddTask.TabIndex = 11;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // storyLbl
            // 
            this.storyLbl.AutoSize = true;
            this.storyLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.storyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.storyLbl.Location = new System.Drawing.Point(-1, 0);
            this.storyLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.storyLbl.Name = "storyLbl";
            this.storyLbl.Size = new System.Drawing.Size(99, 25);
            this.storyLbl.TabIndex = 12;
            this.storyLbl.Text = "Add Story";
            // 
            // taskLbl
            // 
            this.taskLbl.AutoSize = true;
            this.taskLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.taskLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.taskLbl.Location = new System.Drawing.Point(1, 0);
            this.taskLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taskLbl.Name = "taskLbl";
            this.taskLbl.Size = new System.Drawing.Size(97, 25);
            this.taskLbl.TabIndex = 17;
            this.taskLbl.Text = "Add Task";
            this.taskLbl.Click += new System.EventHandler(this.lblTask_Click);
            // 
            // cmbStoryChoice
            // 
            this.cmbStoryChoice.FormattingEnabled = true;
            this.cmbStoryChoice.Location = new System.Drawing.Point(303, 57);
            this.cmbStoryChoice.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStoryChoice.Name = "cmbStoryChoice";
            this.cmbStoryChoice.Size = new System.Drawing.Size(100, 21);
            this.cmbStoryChoice.TabIndex = 8;
            this.cmbStoryChoice.SelectedIndexChanged += new System.EventHandler(this.cmbChoice_SelectedIndexChanged);
            // 
            // lblChoice
            // 
            this.lblChoice.AutoSize = true;
            this.lblChoice.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblChoice.Location = new System.Drawing.Point(221, 61);
            this.lblChoice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(67, 13);
            this.lblChoice.TabIndex = 20;
            this.lblChoice.Text = "Story Choice";
            // 
            // lblStories
            // 
            this.lblStories.AutoSize = true;
            this.lblStories.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStories.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStories.Location = new System.Drawing.Point(77, 260);
            this.lblStories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStories.Name = "lblStories";
            this.lblStories.Size = new System.Drawing.Size(106, 31);
            this.lblStories.TabIndex = 23;
            this.lblStories.Text = "Stories";
            // 
            // lblNotStarted
            // 
            this.lblNotStarted.AutoSize = true;
            this.lblNotStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNotStarted.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNotStarted.Location = new System.Drawing.Point(20, 336);
            this.lblNotStarted.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNotStarted.Name = "lblNotStarted";
            this.lblNotStarted.Size = new System.Drawing.Size(163, 31);
            this.lblNotStarted.TabIndex = 24;
            this.lblNotStarted.Text = "Not Started";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProgress.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblProgress.Location = new System.Drawing.Point(19, 438);
            this.lblProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(164, 31);
            this.lblProgress.TabIndex = 25;
            this.lblProgress.Text = "In Progress";
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDone.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDone.Location = new System.Drawing.Point(100, 513);
            this.lblDone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(83, 31);
            this.lblDone.TabIndex = 26;
            this.lblDone.Text = "Done";
            this.lblDone.Click += new System.EventHandler(this.lblDone_Click);
            // 
            // pboxUst
            // 
            this.pboxUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pboxUst.ErrorImage = null;
            this.pboxUst.Location = new System.Drawing.Point(5, 401);
            this.pboxUst.Margin = new System.Windows.Forms.Padding(2);
            this.pboxUst.Name = "pboxUst";
            this.pboxUst.Size = new System.Drawing.Size(913, 10);
            this.pboxUst.TabIndex = 40;
            this.pboxUst.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(5, 482);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(913, 11);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // grBStory
            // 
            this.grBStory.Controls.Add(this.storyLbl);
            this.grBStory.Controls.Add(this.txtName);
            this.grBStory.Controls.Add(this.lblStoryName);
            this.grBStory.Controls.Add(this.lblDateAddStory);
            this.grBStory.Controls.Add(this.txtDateAddStory);
            this.grBStory.Controls.Add(this.lblTittleAndTopicStory);
            this.grBStory.Controls.Add(this.TxtTittleAndTopic);
            this.grBStory.Controls.Add(this.lblComment);
            this.grBStory.Controls.Add(this.txtComment);
            this.grBStory.Controls.Add(this.btnAddStory);
            this.grBStory.Location = new System.Drawing.Point(12, 12);
            this.grBStory.Name = "grBStory";
            this.grBStory.Size = new System.Drawing.Size(430, 221);
            this.grBStory.TabIndex = 42;
            this.grBStory.TabStop = false;
            this.grBStory.Text = "ADD STORY";
            // 
            // grBTask
            // 
            this.grBTask.Controls.Add(this.lblAuthor);
            this.grBTask.Controls.Add(this.txtAuthor);
            this.grBTask.Controls.Add(this.lblTittleandTopic);
            this.grBTask.Controls.Add(this.txtTittleAndTopicTask);
            this.grBTask.Controls.Add(this.lblChoice);
            this.grBTask.Controls.Add(this.lblDateAddTask);
            this.grBTask.Controls.Add(this.lblTaskComment);
            this.grBTask.Controls.Add(this.taskLbl);
            this.grBTask.Controls.Add(this.txtCommentTask);
            this.grBTask.Controls.Add(this.btnAddTask);
            this.grBTask.Controls.Add(this.cmbStoryChoice);
            this.grBTask.Controls.Add(this.txtDateAddTask);
            this.grBTask.Location = new System.Drawing.Point(467, 12);
            this.grBTask.Name = "grBTask";
            this.grBTask.Size = new System.Drawing.Size(451, 221);
            this.grBTask.TabIndex = 17;
            this.grBTask.TabStop = false;
            this.grBTask.Text = "ADD TASK";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(5, 308);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(913, 10);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(5, 563);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(913, 11);
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // ScrumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1118, 585);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.grBStory);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.grBTask);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pboxUst);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblNotStarted);
            this.Controls.Add(this.lblStories);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ScrumForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.ScrumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grBStory.ResumeLayout(false);
            this.grBStory.PerformLayout();
            this.grBTask.ResumeLayout(false);
            this.grBTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtDateAddStory;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblDateAddStory;
        private System.Windows.Forms.Label lblTittleAndTopicStory;
        private System.Windows.Forms.Label lblStoryName;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox TxtTittleAndTopic;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddStory;
        private System.Windows.Forms.DateTimePicker txtDateAddTask;
        private System.Windows.Forms.Label lblTaskComment;
        private System.Windows.Forms.Label lblDateAddTask;
        private System.Windows.Forms.Label lblTittleandTopic;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtCommentTask;
        private System.Windows.Forms.TextBox txtTittleAndTopicTask;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label storyLbl;
        private System.Windows.Forms.Label taskLbl;
        private System.Windows.Forms.ComboBox cmbStoryChoice;
        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.Label lblStories;
        private System.Windows.Forms.Label lblNotStarted;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.PictureBox pboxUst;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grBStory;
        private System.Windows.Forms.GroupBox grBTask;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

