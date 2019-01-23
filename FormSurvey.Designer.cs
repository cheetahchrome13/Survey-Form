namespace Project7SurveyForm
{
    partial class FormSurvey
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
            this.groupService = new System.Windows.Forms.GroupBox();
            this.radDinner = new System.Windows.Forms.RadioButton();
            this.radLunch = new System.Windows.Forms.RadioButton();
            this.radBreakfast = new System.Windows.Forms.RadioButton();
            this.greeting = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.numRating = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxComment = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupMenuItems = new System.Windows.Forms.GroupBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtBxResults = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.groupService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).BeginInit();
            this.groupMenuItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupService
            // 
            this.groupService.Controls.Add(this.radDinner);
            this.groupService.Controls.Add(this.radLunch);
            this.groupService.Controls.Add(this.radBreakfast);
            this.groupService.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupService.ForeColor = System.Drawing.Color.Bisque;
            this.groupService.Location = new System.Drawing.Point(15, 278);
            this.groupService.Name = "groupService";
            this.groupService.Size = new System.Drawing.Size(109, 93);
            this.groupService.TabIndex = 5;
            this.groupService.TabStop = false;
            this.groupService.Text = "Meal";
            // 
            // radDinner
            // 
            this.radDinner.AutoSize = true;
            this.radDinner.Location = new System.Drawing.Point(7, 66);
            this.radDinner.Name = "radDinner";
            this.radDinner.Size = new System.Drawing.Size(60, 16);
            this.radDinner.TabIndex = 5;
            this.radDinner.TabStop = true;
            this.radDinner.Text = "Dinner";
            this.radDinner.UseVisualStyleBackColor = true;
            // 
            // radLunch
            // 
            this.radLunch.AutoSize = true;
            this.radLunch.Location = new System.Drawing.Point(7, 43);
            this.radLunch.Name = "radLunch";
            this.radLunch.Size = new System.Drawing.Size(58, 16);
            this.radLunch.TabIndex = 4;
            this.radLunch.TabStop = true;
            this.radLunch.Text = "Lunch";
            this.radLunch.UseVisualStyleBackColor = true;
            // 
            // radBreakfast
            // 
            this.radBreakfast.AutoSize = true;
            this.radBreakfast.ForeColor = System.Drawing.Color.Linen;
            this.radBreakfast.Location = new System.Drawing.Point(7, 20);
            this.radBreakfast.Name = "radBreakfast";
            this.radBreakfast.Size = new System.Drawing.Size(77, 16);
            this.radBreakfast.TabIndex = 3;
            this.radBreakfast.TabStop = true;
            this.radBreakfast.Text = "Breakfast";
            this.radBreakfast.UseVisualStyleBackColor = true;
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greeting.ForeColor = System.Drawing.Color.Linen;
            this.greeting.Location = new System.Drawing.Point(12, 9);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(341, 18);
            this.greeting.TabIndex = 1;
            this.greeting.Text = "Please take a moment to give us feedback";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Which meal service did you have?";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(12, 89);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select the date of your dining experience";
            // 
            // numRating
            // 
            this.numRating.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRating.Location = new System.Drawing.Point(15, 551);
            this.numRating.Name = "numRating";
            this.numRating.ReadOnly = true;
            this.numRating.Size = new System.Drawing.Size(120, 26);
            this.numRating.TabIndex = 15;
            this.numRating.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Which of the following menu items were part of your meal?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 533);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rate your meal from 1 to 5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 595);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Comments or suggestions";
            // 
            // txtBxComment
            // 
            this.txtBxComment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxComment.Location = new System.Drawing.Point(12, 613);
            this.txtBxComment.Multiline = true;
            this.txtBxComment.Name = "txtBxComment";
            this.txtBxComment.Size = new System.Drawing.Size(459, 72);
            this.txtBxComment.TabIndex = 16;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Peru;
            this.btnSubmit.Location = new System.Drawing.Point(148, 694);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 37);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Peru;
            this.btnClear.Location = new System.Drawing.Point(254, 694);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 37);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupMenuItems
            // 
            this.groupMenuItems.Controls.Add(this.checkBox9);
            this.groupMenuItems.Controls.Add(this.checkBox8);
            this.groupMenuItems.Controls.Add(this.checkBox7);
            this.groupMenuItems.Controls.Add(this.checkBox6);
            this.groupMenuItems.Controls.Add(this.checkBox5);
            this.groupMenuItems.Controls.Add(this.checkBox4);
            this.groupMenuItems.Controls.Add(this.checkBox3);
            this.groupMenuItems.Controls.Add(this.checkBox2);
            this.groupMenuItems.Controls.Add(this.checkBox1);
            this.groupMenuItems.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMenuItems.ForeColor = System.Drawing.Color.Bisque;
            this.groupMenuItems.Location = new System.Drawing.Point(15, 405);
            this.groupMenuItems.Name = "groupMenuItems";
            this.groupMenuItems.Size = new System.Drawing.Size(268, 112);
            this.groupMenuItems.TabIndex = 14;
            this.groupMenuItems.TabStop = false;
            this.groupMenuItems.Text = "Items";
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(204, 18);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(51, 16);
            this.checkBox9.TabIndex = 14;
            this.checkBox9.Text = "Grits";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(100, 87);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(67, 16);
            this.checkBox8.TabIndex = 13;
            this.checkBox8.Text = "Dessert";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(100, 66);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(48, 16);
            this.checkBox7.TabIndex = 12;
            this.checkBox7.Text = "Chili";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(100, 41);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(55, 16);
            this.checkBox6.TabIndex = 11;
            this.checkBox6.Text = "Salad";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(100, 18);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(78, 16);
            this.checkBox5.TabIndex = 10;
            this.checkBox5.Text = "Appetizer";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(7, 89);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(61, 16);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Text = "Entree";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 66);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(78, 16);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Sandwich";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 43);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(52, 16);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Soup";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 16);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Drink";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtBxResults
            // 
            this.txtBxResults.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxResults.Location = new System.Drawing.Point(12, 769);
            this.txtBxResults.Multiline = true;
            this.txtBxResults.Name = "txtBxResults";
            this.txtBxResults.ReadOnly = true;
            this.txtBxResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxResults.Size = new System.Drawing.Size(459, 80);
            this.txtBxResults.TabIndex = 20;
            this.txtBxResults.TabStop = false;
            this.txtBxResults.Visible = false;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(164, 751);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(147, 15);
            this.lblResults.TabIndex = 16;
            this.lblResults.Text = "Your survey submittal";
            this.lblResults.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(147, 15);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Enter Name(optional)";
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(167, 37);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(304, 20);
            this.txtBxName.TabIndex = 1;
            // 
            // FormSurvey
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(484, 861);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.txtBxResults);
            this.Controls.Add(this.groupMenuItems);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBxComment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numRating);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.greeting);
            this.Controls.Add(this.groupService);
            this.ForeColor = System.Drawing.Color.Bisque;
            this.Name = "FormSurvey";
            this.Text = "Mel\'s Diner Survey";
            this.Load += new System.EventHandler(this.FormSurvey_Load);
            this.groupService.ResumeLayout(false);
            this.groupService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRating)).EndInit();
            this.groupMenuItems.ResumeLayout(false);
            this.groupMenuItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupService;
        private System.Windows.Forms.RadioButton radDinner;
        private System.Windows.Forms.RadioButton radLunch;
        private System.Windows.Forms.RadioButton radBreakfast;
        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxComment;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupMenuItems;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtBxResults;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBxName;
    }
}

