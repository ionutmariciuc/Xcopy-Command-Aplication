namespace xcopyyyy
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.MaskedTextBox();
            this.btnBrowseSource = new System.Windows.Forms.Button();
            this.btnBrowseDestination = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.helpName = new System.Windows.Forms.Button();
            this.sourceName = new System.Windows.Forms.TextBox();
            this.destinationName = new System.Windows.Forms.TextBox();
            this.COMANDA = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btn_TreeCreation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(69, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "SOURCE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(66, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "DESTINATION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(66, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "OPTIONS";
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.Location = new System.Drawing.Point(564, 393);
            this.btnMove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(171, 75);
            this.btnMove.TabIndex = 3;
            this.btnMove.Text = "MOVE";
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(564, 252);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(171, 75);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "COPY";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(196, 664);
            this.A.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(865, 22);
            this.A.TabIndex = 15;
            // 
            // btnBrowseSource
            // 
            this.btnBrowseSource.Location = new System.Drawing.Point(951, 117);
            this.btnBrowseSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowseSource.Name = "btnBrowseSource";
            this.btnBrowseSource.Size = new System.Drawing.Size(87, 23);
            this.btnBrowseSource.TabIndex = 16;
            this.btnBrowseSource.Text = "browse";
            this.btnBrowseSource.UseVisualStyleBackColor = true;
            this.btnBrowseSource.Click += new System.EventHandler(this.btnBrowseSource_Click);
            // 
            // btnBrowseDestination
            // 
            this.btnBrowseDestination.Location = new System.Drawing.Point(951, 179);
            this.btnBrowseDestination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowseDestination.Name = "btnBrowseDestination";
            this.btnBrowseDestination.Size = new System.Drawing.Size(87, 23);
            this.btnBrowseDestination.TabIndex = 17;
            this.btnBrowseDestination.Text = "browse";
            this.btnBrowseDestination.UseVisualStyleBackColor = true;
            this.btnBrowseDestination.Click += new System.EventHandler(this.btnBrowseDestination_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "/w ",
            "/p",
            "/c",
            "/v",
            "/q",
            "/f",
            "/l",
            "/g",
            "/d",
            "/u",
            "/i",
            "/s",
            "/e",
            "/t",
            "/k",
            "/r",
            "/h",
            "/a",
            "/m",
            "/n",
            "/o",
            "/x",
            "/exclude",
            "/y",
            "/-y",
            "/z",
            "/b",
            "/j",
            "/?"});
            this.checkedListBox1.Location = new System.Drawing.Point(196, 252);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(334, 361);
            this.checkedListBox1.TabIndex = 18;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // helpName
            // 
            this.helpName.Location = new System.Drawing.Point(792, 395);
            this.helpName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.helpName.Name = "helpName";
            this.helpName.Size = new System.Drawing.Size(171, 76);
            this.helpName.TabIndex = 19;
            this.helpName.Text = "HELP(commands descriptions)";
            this.helpName.UseVisualStyleBackColor = true;
            this.helpName.Click += new System.EventHandler(this.helpName_Click);
            // 
            // sourceName
            // 
            this.sourceName.Location = new System.Drawing.Point(196, 117);
            this.sourceName.Margin = new System.Windows.Forms.Padding(4);
            this.sourceName.Name = "sourceName";
            this.sourceName.Size = new System.Drawing.Size(717, 22);
            this.sourceName.TabIndex = 20;
            // 
            // destinationName
            // 
            this.destinationName.Location = new System.Drawing.Point(196, 179);
            this.destinationName.Margin = new System.Windows.Forms.Padding(4);
            this.destinationName.Name = "destinationName";
            this.destinationName.Size = new System.Drawing.Size(717, 22);
            this.destinationName.TabIndex = 21;
            // 
            // COMANDA
            // 
            this.COMANDA.AutoSize = true;
            this.COMANDA.BackColor = System.Drawing.Color.AntiqueWhite;
            this.COMANDA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.COMANDA.Location = new System.Drawing.Point(66, 667);
            this.COMANDA.Name = "COMANDA";
            this.COMANDA.Size = new System.Drawing.Size(121, 17);
            this.COMANDA.TabIndex = 23;
            this.COMANDA.Text = "FINAL COMMAND";
            // 
            // btnBackup
            // 
            this.btnBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBackup.Location = new System.Drawing.Point(792, 538);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(171, 75);
            this.btnBackup.TabIndex = 24;
            this.btnBackup.Text = "BACK-UP";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btn_TreeCreation
            // 
            this.btn_TreeCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_TreeCreation.Location = new System.Drawing.Point(564, 538);
            this.btn_TreeCreation.Name = "btn_TreeCreation";
            this.btn_TreeCreation.Size = new System.Drawing.Size(171, 75);
            this.btn_TreeCreation.TabIndex = 25;
            this.btn_TreeCreation.Text = "TREE CREATION";
            this.btn_TreeCreation.UseVisualStyleBackColor = true;
            this.btn_TreeCreation.Click += new System.EventHandler(this.btn_TreeCreation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.btn_TreeCreation);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.COMANDA);
            this.Controls.Add(this.destinationName);
            this.Controls.Add(this.sourceName);
            this.Controls.Add(this.helpName);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnBrowseDestination);
            this.Controls.Add(this.btnBrowseSource);
            this.Controls.Add(this.A);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "XCOPY APPLICATION";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.MaskedTextBox A;
        private System.Windows.Forms.Button btnBrowseSource;
        private System.Windows.Forms.Button btnBrowseDestination;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button helpName;
        private System.Windows.Forms.TextBox sourceName;
        private System.Windows.Forms.TextBox destinationName;
        private System.Windows.Forms.Label COMANDA;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btn_TreeCreation;
    }
}

