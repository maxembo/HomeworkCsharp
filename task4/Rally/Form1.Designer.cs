namespace RallyApp
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
            this.labelRally = new System.Windows.Forms.Label();
            this.panelRally = new System.Windows.Forms.Panel();
            this.labelResult = new System.Windows.Forms.Label();
            this.numIfSpeakerGroups = new System.Windows.Forms.NumericUpDown();
            this.numOfParticipants = new System.Windows.Forms.NumericUpDown();
            this.numOfSpeakers = new System.Windows.Forms.NumericUpDown();
            this.button = new System.Windows.Forms.Button();
            this.EventNameText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelValueOfSpeakers = new System.Windows.Forms.Label();
            this.labelEventName = new System.Windows.Forms.Label();
            this.panelRally.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIfSpeakerGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfSpeakers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRally
            // 
            this.labelRally.AutoSize = true;
            this.labelRally.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRally.Location = new System.Drawing.Point(20, 17);
            this.labelRally.Name = "labelRally";
            this.labelRally.Size = new System.Drawing.Size(94, 24);
            this.labelRally.TabIndex = 0;
            this.labelRally.Text = "Митинги:";
            // 
            // panelRally
            // 
            this.panelRally.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelRally.Controls.Add(this.labelResult);
            this.panelRally.Controls.Add(this.numIfSpeakerGroups);
            this.panelRally.Controls.Add(this.numOfParticipants);
            this.panelRally.Controls.Add(this.numOfSpeakers);
            this.panelRally.Controls.Add(this.button);
            this.panelRally.Controls.Add(this.EventNameText);
            this.panelRally.Controls.Add(this.label5);
            this.panelRally.Controls.Add(this.label3);
            this.panelRally.Controls.Add(this.labelValueOfSpeakers);
            this.panelRally.Controls.Add(this.labelEventName);
            this.panelRally.Controls.Add(this.labelRally);
            this.panelRally.Location = new System.Drawing.Point(26, 51);
            this.panelRally.Name = "panelRally";
            this.panelRally.Size = new System.Drawing.Size(737, 345);
            this.panelRally.TabIndex = 1;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(58, 284);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 24);
            this.labelResult.TabIndex = 15;
            // 
            // numIfSpeakerGroups
            // 
            this.numIfSpeakerGroups.Location = new System.Drawing.Point(614, 97);
            this.numIfSpeakerGroups.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numIfSpeakerGroups.Name = "numIfSpeakerGroups";
            this.numIfSpeakerGroups.Size = new System.Drawing.Size(86, 20);
            this.numIfSpeakerGroups.TabIndex = 14;
            // 
            // numOfParticipants
            // 
            this.numOfParticipants.Location = new System.Drawing.Point(239, 173);
            this.numOfParticipants.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numOfParticipants.Name = "numOfParticipants";
            this.numOfParticipants.Size = new System.Drawing.Size(86, 20);
            this.numOfParticipants.TabIndex = 13;
            // 
            // numOfSpeakers
            // 
            this.numOfSpeakers.Location = new System.Drawing.Point(239, 126);
            this.numOfSpeakers.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numOfSpeakers.Name = "numOfSpeakers";
            this.numOfSpeakers.Size = new System.Drawing.Size(86, 20);
            this.numOfSpeakers.TabIndex = 12;
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button.Location = new System.Drawing.Point(211, 257);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(269, 63);
            this.button.TabIndex = 11;
            this.button.Text = "Выполнить";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // EventNameText
            // 
            this.EventNameText.Location = new System.Drawing.Point(239, 81);
            this.EventNameText.Name = "EventNameText";
            this.EventNameText.Size = new System.Drawing.Size(86, 20);
            this.EventNameText.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(366, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 72);
            this.label5.TabIndex = 5;
            this.label5.Text = "число групп ораторов, \r\nкоторые высказывали \r\nодинаковые мысли ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(41, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "число участников";
            // 
            // labelValueOfSpeakers
            // 
            this.labelValueOfSpeakers.AutoSize = true;
            this.labelValueOfSpeakers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelValueOfSpeakers.Location = new System.Drawing.Point(41, 122);
            this.labelValueOfSpeakers.Name = "labelValueOfSpeakers";
            this.labelValueOfSpeakers.Size = new System.Drawing.Size(153, 24);
            this.labelValueOfSpeakers.TabIndex = 2;
            this.labelValueOfSpeakers.Text = "число ораторов";
            // 
            // labelEventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEventName.Location = new System.Drawing.Point(41, 77);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(178, 24);
            this.labelEventName.TabIndex = 1;
            this.labelEventName.Text = "Название события";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelRally);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelRally.ResumeLayout(false);
            this.panelRally.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIfSpeakerGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfSpeakers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelRally;
        private System.Windows.Forms.Panel panelRally;
        private System.Windows.Forms.TextBox EventNameText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelValueOfSpeakers;
        private System.Windows.Forms.Label labelEventName;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.NumericUpDown numIfSpeakerGroups;
        private System.Windows.Forms.NumericUpDown numOfParticipants;
        private System.Windows.Forms.NumericUpDown numOfSpeakers;
        private System.Windows.Forms.Label labelResult;
    }
}

