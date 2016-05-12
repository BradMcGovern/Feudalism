namespace Feudalism
{
    partial class Interface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interface));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLordName = new System.Windows.Forms.Label();
            this.btnTerr3 = new System.Windows.Forms.Button();
            this.btnTerr6 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpKingdomInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTerName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlayerTerritory = new System.Windows.Forms.Label();
            this.btnTerr5 = new System.Windows.Forms.Button();
            this.btnTerr4 = new System.Windows.Forms.Button();
            this.btnTerr1 = new System.Windows.Forms.Button();
            this.btnTerr7 = new System.Windows.Forms.Button();
            this.btnTerr8 = new System.Windows.Forms.Button();
            this.btnTerr0 = new System.Windows.Forms.Button();
            this.btnTerr2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLavish = new System.Windows.Forms.Label();
            this.lblAdventurous = new System.Windows.Forms.Label();
            this.lblGregarious = new System.Windows.Forms.Label();
            this.lblPious = new System.Windows.Forms.Label();
            this.lblHonorable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAffinity = new System.Windows.Forms.Label();
            this.btnMatricies = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpKingdomInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 443);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblLordName
            // 
            this.lblLordName.BackColor = System.Drawing.Color.White;
            this.lblLordName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLordName.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLordName.Location = new System.Drawing.Point(65, 56);
            this.lblLordName.Name = "lblLordName";
            this.lblLordName.Size = new System.Drawing.Size(246, 22);
            this.lblLordName.TabIndex = 1;
            // 
            // btnTerr3
            // 
            this.btnTerr3.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerr3.Location = new System.Drawing.Point(50, 249);
            this.btnTerr3.Name = "btnTerr3";
            this.btnTerr3.Size = new System.Drawing.Size(75, 36);
            this.btnTerr3.TabIndex = 2;
            this.btnTerr3.Tag = "3";
            this.btnTerr3.Text = "Terr 3";
            this.btnTerr3.UseVisualStyleBackColor = true;
            this.btnTerr3.Click += new System.EventHandler(this.territoryButton_Click);
            // 
            // btnTerr6
            // 
            this.btnTerr6.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerr6.Location = new System.Drawing.Point(163, 424);
            this.btnTerr6.Name = "btnTerr6";
            this.btnTerr6.Size = new System.Drawing.Size(75, 36);
            this.btnTerr6.TabIndex = 3;
            this.btnTerr6.Tag = "6";
            this.btnTerr6.Text = "Terr 6";
            this.btnTerr6.UseVisualStyleBackColor = true;
            this.btnTerr6.Click += new System.EventHandler(this.territoryButton_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(689, 492);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 43);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpKingdomInfo
            // 
            this.grpKingdomInfo.Controls.Add(this.lblAffinity);
            this.grpKingdomInfo.Controls.Add(this.label8);
            this.grpKingdomInfo.Controls.Add(this.lblHonorable);
            this.grpKingdomInfo.Controls.Add(this.lblPious);
            this.grpKingdomInfo.Controls.Add(this.lblGregarious);
            this.grpKingdomInfo.Controls.Add(this.lblAdventurous);
            this.grpKingdomInfo.Controls.Add(this.lblLavish);
            this.grpKingdomInfo.Controls.Add(this.label7);
            this.grpKingdomInfo.Controls.Add(this.label6);
            this.grpKingdomInfo.Controls.Add(this.label5);
            this.grpKingdomInfo.Controls.Add(this.label2);
            this.grpKingdomInfo.Controls.Add(this.label1);
            this.grpKingdomInfo.Controls.Add(this.label3);
            this.grpKingdomInfo.Controls.Add(this.lblTerName);
            this.grpKingdomInfo.Controls.Add(this.lblLordName);
            this.grpKingdomInfo.Location = new System.Drawing.Point(486, 46);
            this.grpKingdomInfo.Name = "grpKingdomInfo";
            this.grpKingdomInfo.Size = new System.Drawing.Size(344, 414);
            this.grpKingdomInfo.TabIndex = 5;
            this.grpKingdomInfo.TabStop = false;
            this.grpKingdomInfo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lord";
            // 
            // lblTerName
            // 
            this.lblTerName.BackColor = System.Drawing.Color.White;
            this.lblTerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTerName.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerName.Location = new System.Drawing.Point(19, 19);
            this.lblTerName.Name = "lblTerName";
            this.lblTerName.Size = new System.Drawing.Size(246, 22);
            this.lblTerName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Celtic Gaelige", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label4.Location = new System.Drawing.Point(481, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kingdom Of";
            // 
            // lblPlayerTerritory
            // 
            this.lblPlayerTerritory.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblPlayerTerritory.Font = new System.Drawing.Font("Celtic Gaelige", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblPlayerTerritory.Location = new System.Drawing.Point(618, 17);
            this.lblPlayerTerritory.Name = "lblPlayerTerritory";
            this.lblPlayerTerritory.Size = new System.Drawing.Size(127, 22);
            this.lblPlayerTerritory.TabIndex = 7;
            this.lblPlayerTerritory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTerr5
            // 
            this.btnTerr5.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerr5.Location = new System.Drawing.Point(375, 214);
            this.btnTerr5.Name = "btnTerr5";
            this.btnTerr5.Size = new System.Drawing.Size(75, 36);
            this.btnTerr5.TabIndex = 8;
            this.btnTerr5.Tag = "5";
            this.btnTerr5.Text = "Terr 5";
            this.btnTerr5.UseVisualStyleBackColor = true;
            this.btnTerr5.Click += new System.EventHandler(this.territoryButton_Click);
            // 
            // btnTerr4
            // 
            this.btnTerr4.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerr4.Location = new System.Drawing.Point(375, 310);
            this.btnTerr4.Name = "btnTerr4";
            this.btnTerr4.Size = new System.Drawing.Size(75, 36);
            this.btnTerr4.TabIndex = 9;
            this.btnTerr4.Tag = "4";
            this.btnTerr4.Text = "Terr 4";
            this.btnTerr4.UseVisualStyleBackColor = true;
            this.btnTerr4.Click += new System.EventHandler(this.territoryButton_Click);
            // 
            // btnTerr1
            // 
            this.btnTerr1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerr1.Location = new System.Drawing.Point(375, 162);
            this.btnTerr1.Name = "btnTerr1";
            this.btnTerr1.Size = new System.Drawing.Size(75, 36);
            this.btnTerr1.TabIndex = 10;
            this.btnTerr1.Tag = "1";
            this.btnTerr1.Text = "Terr 1";
            this.btnTerr1.UseVisualStyleBackColor = true;
            this.btnTerr1.Click += new System.EventHandler(this.territoryButton_Click);
            // 
            // btnTerr7
            // 
            this.btnTerr7.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerr7.Location = new System.Drawing.Point(313, 366);
            this.btnTerr7.Name = "btnTerr7";
            this.btnTerr7.Size = new System.Drawing.Size(75, 36);
            this.btnTerr7.TabIndex = 11;
            this.btnTerr7.Tag = "7";
            this.btnTerr7.Text = "Terr 7";
            this.btnTerr7.UseVisualStyleBackColor = true;
            this.btnTerr7.Click += new System.EventHandler(this.territoryButton_Click);
            // 
            // btnTerr8
            // 
            this.btnTerr8.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerr8.Location = new System.Drawing.Point(375, 34);
            this.btnTerr8.Name = "btnTerr8";
            this.btnTerr8.Size = new System.Drawing.Size(75, 36);
            this.btnTerr8.TabIndex = 12;
            this.btnTerr8.Tag = "8";
            this.btnTerr8.Text = "Terr 8";
            this.btnTerr8.UseVisualStyleBackColor = true;
            this.btnTerr8.Click += new System.EventHandler(this.territoryButton_Click);
            // 
            // btnTerr0
            // 
            this.btnTerr0.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerr0.Location = new System.Drawing.Point(120, 59);
            this.btnTerr0.Name = "btnTerr0";
            this.btnTerr0.Size = new System.Drawing.Size(75, 36);
            this.btnTerr0.TabIndex = 13;
            this.btnTerr0.Tag = "0";
            this.btnTerr0.Text = "Terr 0";
            this.btnTerr0.UseVisualStyleBackColor = true;
            this.btnTerr0.Click += new System.EventHandler(this.territoryButton_Click);
            // 
            // btnTerr2
            // 
            this.btnTerr2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerr2.Location = new System.Drawing.Point(120, 119);
            this.btnTerr2.Name = "btnTerr2";
            this.btnTerr2.Size = new System.Drawing.Size(75, 36);
            this.btnTerr2.TabIndex = 14;
            this.btnTerr2.Tag = "2";
            this.btnTerr2.Text = "Terr 2";
            this.btnTerr2.UseVisualStyleBackColor = true;
            this.btnTerr2.Click += new System.EventHandler(this.territoryButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lavish";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adventurous";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gregarious";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Pious";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Honorable";
            // 
            // lblLavish
            // 
            this.lblLavish.BackColor = System.Drawing.Color.White;
            this.lblLavish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLavish.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLavish.Location = new System.Drawing.Point(122, 242);
            this.lblLavish.Name = "lblLavish";
            this.lblLavish.Size = new System.Drawing.Size(117, 22);
            this.lblLavish.TabIndex = 11;
            // 
            // lblAdventurous
            // 
            this.lblAdventurous.BackColor = System.Drawing.Color.White;
            this.lblAdventurous.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAdventurous.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdventurous.Location = new System.Drawing.Point(122, 203);
            this.lblAdventurous.Name = "lblAdventurous";
            this.lblAdventurous.Size = new System.Drawing.Size(117, 22);
            this.lblAdventurous.TabIndex = 12;
            // 
            // lblGregarious
            // 
            this.lblGregarious.BackColor = System.Drawing.Color.White;
            this.lblGregarious.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGregarious.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGregarious.Location = new System.Drawing.Point(122, 168);
            this.lblGregarious.Name = "lblGregarious";
            this.lblGregarious.Size = new System.Drawing.Size(117, 22);
            this.lblGregarious.TabIndex = 13;
            // 
            // lblPious
            // 
            this.lblPious.BackColor = System.Drawing.Color.White;
            this.lblPious.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPious.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPious.Location = new System.Drawing.Point(122, 132);
            this.lblPious.Name = "lblPious";
            this.lblPious.Size = new System.Drawing.Size(117, 22);
            this.lblPious.TabIndex = 14;
            // 
            // lblHonorable
            // 
            this.lblHonorable.BackColor = System.Drawing.Color.White;
            this.lblHonorable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHonorable.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHonorable.Location = new System.Drawing.Point(122, 98);
            this.lblHonorable.Name = "lblHonorable";
            this.lblHonorable.Size = new System.Drawing.Size(117, 22);
            this.lblHonorable.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Affinity";
            // 
            // lblAffinity
            // 
            this.lblAffinity.BackColor = System.Drawing.Color.White;
            this.lblAffinity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAffinity.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffinity.Location = new System.Drawing.Point(122, 287);
            this.lblAffinity.Name = "lblAffinity";
            this.lblAffinity.Size = new System.Drawing.Size(117, 22);
            this.lblAffinity.TabIndex = 17;
            // 
            // btnMatricies
            // 
            this.btnMatricies.Location = new System.Drawing.Point(24, 480);
            this.btnMatricies.Name = "btnMatricies";
            this.btnMatricies.Size = new System.Drawing.Size(101, 50);
            this.btnMatricies.TabIndex = 15;
            this.btnMatricies.Text = "Show Relationship Matricies";
            this.btnMatricies.UseVisualStyleBackColor = true;
            this.btnMatricies.Click += new System.EventHandler(this.btnMatricies_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(855, 542);
            this.Controls.Add(this.btnMatricies);
            this.Controls.Add(this.btnTerr2);
            this.Controls.Add(this.btnTerr0);
            this.Controls.Add(this.btnTerr8);
            this.Controls.Add(this.btnTerr7);
            this.Controls.Add(this.btnTerr1);
            this.Controls.Add(this.btnTerr4);
            this.Controls.Add(this.btnTerr5);
            this.Controls.Add(this.lblPlayerTerritory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpKingdomInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTerr6);
            this.Controls.Add(this.btnTerr3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Interface";
            this.Text = "Feudalism: Ireland";
            this.Load += new System.EventHandler(this.Interface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpKingdomInfo.ResumeLayout(false);
            this.grpKingdomInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLordName;
        private System.Windows.Forms.Button btnTerr3;
        private System.Windows.Forms.Button btnTerr6;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpKingdomInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlayerTerritory;
        private System.Windows.Forms.Button btnTerr5;
        private System.Windows.Forms.Button btnTerr4;
        private System.Windows.Forms.Button btnTerr1;
        private System.Windows.Forms.Button btnTerr7;
        private System.Windows.Forms.Button btnTerr8;
        private System.Windows.Forms.Button btnTerr0;
        private System.Windows.Forms.Button btnTerr2;
        private System.Windows.Forms.Label lblHonorable;
        private System.Windows.Forms.Label lblPious;
        private System.Windows.Forms.Label lblGregarious;
        private System.Windows.Forms.Label lblAdventurous;
        private System.Windows.Forms.Label lblLavish;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAffinity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMatricies;
    }
}

