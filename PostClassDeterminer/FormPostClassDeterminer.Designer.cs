using System.Windows.Forms;

namespace PostClassDeterminer
{
    partial class FormPostClassDeterminer
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
            this.LblActionDescription = new System.Windows.Forms.Label();
            this.BtnDetermine = new System.Windows.Forms.Button();
            this.TxtInput = new System.Windows.Forms.TextBox();
            this.RtboxOutput = new System.Windows.Forms.RichTextBox();
            this.GrpboxPrecompleteClasses = new System.Windows.Forms.GroupBox();
            this.LblSOut = new System.Windows.Forms.Label();
            this.LblLOut = new System.Windows.Forms.Label();
            this.LblMOut = new System.Windows.Forms.Label();
            this.LblT1Out = new System.Windows.Forms.Label();
            this.LblT0Out = new System.Windows.Forms.Label();
            this.LblS = new System.Windows.Forms.Label();
            this.LblL = new System.Windows.Forms.Label();
            this.LblM = new System.Windows.Forms.Label();
            this.LblT1 = new System.Windows.Forms.Label();
            this.LblT0 = new System.Windows.Forms.Label();
            this.GrpboxPrecompleteClasses.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblActionDescription
            // 
            this.LblActionDescription.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblActionDescription.Location = new System.Drawing.Point(12, 29);
            this.LblActionDescription.Name = "LblActionDescription";
            this.LblActionDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblActionDescription.Size = new System.Drawing.Size(424, 43);
            this.LblActionDescription.TabIndex = 0;
            this.LblActionDescription.Text = "Enter boolean function vector of values:";
            this.LblActionDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnDetermine
            // 
            this.BtnDetermine.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDetermine.Location = new System.Drawing.Point(117, 131);
            this.BtnDetermine.Name = "BtnDetermine";
            this.BtnDetermine.Size = new System.Drawing.Size(186, 40);
            this.BtnDetermine.TabIndex = 1;
            this.BtnDetermine.Text = "Start";
            this.BtnDetermine.UseVisualStyleBackColor = true;
            this.BtnDetermine.Click += new System.EventHandler(this.BtnDetermine_Click);
            // 
            // TxtInput
            // 
            this.TxtInput.Location = new System.Drawing.Point(27, 83);
            this.TxtInput.Name = "TxtInput";
            this.TxtInput.Size = new System.Drawing.Size(377, 27);
            this.TxtInput.TabIndex = 3;
            // 
            // RtboxOutput
            // 
            this.RtboxOutput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtboxOutput.Location = new System.Drawing.Point(26, 204);
            this.RtboxOutput.Name = "RtboxOutput";
            this.RtboxOutput.Size = new System.Drawing.Size(751, 241);
            this.RtboxOutput.TabIndex = 4;
            this.RtboxOutput.Text = "";
            // 
            // GrpboxPrecompleteClasses
            // 
            this.GrpboxPrecompleteClasses.Controls.Add(this.LblSOut);
            this.GrpboxPrecompleteClasses.Controls.Add(this.LblLOut);
            this.GrpboxPrecompleteClasses.Controls.Add(this.LblMOut);
            this.GrpboxPrecompleteClasses.Controls.Add(this.LblT1Out);
            this.GrpboxPrecompleteClasses.Controls.Add(this.LblT0Out);
            this.GrpboxPrecompleteClasses.Controls.Add(this.LblS);
            this.GrpboxPrecompleteClasses.Controls.Add(this.LblL);
            this.GrpboxPrecompleteClasses.Controls.Add(this.LblM);
            this.GrpboxPrecompleteClasses.Controls.Add(this.LblT1);
            this.GrpboxPrecompleteClasses.Controls.Add(this.LblT0);
            this.GrpboxPrecompleteClasses.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GrpboxPrecompleteClasses.Location = new System.Drawing.Point(472, 29);
            this.GrpboxPrecompleteClasses.Name = "GrpboxPrecompleteClasses";
            this.GrpboxPrecompleteClasses.Size = new System.Drawing.Size(295, 142);
            this.GrpboxPrecompleteClasses.TabIndex = 5;
            this.GrpboxPrecompleteClasses.TabStop = false;
            this.GrpboxPrecompleteClasses.Text = "Precomplete classes";
            // 
            // LblSOut
            // 
            this.LblSOut.BackColor = System.Drawing.Color.White;
            this.LblSOut.CausesValidation = false;
            this.LblSOut.Location = new System.Drawing.Point(231, 81);
            this.LblSOut.Name = "LblSOut";
            this.LblSOut.Size = new System.Drawing.Size(47, 42);
            this.LblSOut.TabIndex = 9;
            this.LblSOut.Text = "-";
            this.LblSOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblLOut
            // 
            this.LblLOut.BackColor = System.Drawing.Color.White;
            this.LblLOut.CausesValidation = false;
            this.LblLOut.Location = new System.Drawing.Point(178, 81);
            this.LblLOut.Name = "LblLOut";
            this.LblLOut.Size = new System.Drawing.Size(47, 42);
            this.LblLOut.TabIndex = 8;
            this.LblLOut.Text = "-";
            this.LblLOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblMOut
            // 
            this.LblMOut.BackColor = System.Drawing.Color.White;
            this.LblMOut.CausesValidation = false;
            this.LblMOut.Location = new System.Drawing.Point(125, 81);
            this.LblMOut.Name = "LblMOut";
            this.LblMOut.Size = new System.Drawing.Size(47, 42);
            this.LblMOut.TabIndex = 7;
            this.LblMOut.Text = "-";
            this.LblMOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblT1Out
            // 
            this.LblT1Out.BackColor = System.Drawing.Color.White;
            this.LblT1Out.CausesValidation = false;
            this.LblT1Out.Location = new System.Drawing.Point(72, 81);
            this.LblT1Out.Name = "LblT1Out";
            this.LblT1Out.Size = new System.Drawing.Size(47, 42);
            this.LblT1Out.TabIndex = 6;
            this.LblT1Out.Text = "-";
            this.LblT1Out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblT0Out
            // 
            this.LblT0Out.BackColor = System.Drawing.Color.White;
            this.LblT0Out.CausesValidation = false;
            this.LblT0Out.Location = new System.Drawing.Point(19, 81);
            this.LblT0Out.Name = "LblT0Out";
            this.LblT0Out.Size = new System.Drawing.Size(47, 42);
            this.LblT0Out.TabIndex = 5;
            this.LblT0Out.Text = "-";
            this.LblT0Out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblS
            // 
            this.LblS.BackColor = System.Drawing.Color.White;
            this.LblS.CausesValidation = false;
            this.LblS.Location = new System.Drawing.Point(231, 34);
            this.LblS.Name = "LblS";
            this.LblS.Size = new System.Drawing.Size(47, 42);
            this.LblS.TabIndex = 4;
            this.LblS.Text = "S";
            this.LblS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblL
            // 
            this.LblL.BackColor = System.Drawing.Color.White;
            this.LblL.CausesValidation = false;
            this.LblL.Location = new System.Drawing.Point(178, 34);
            this.LblL.Name = "LblL";
            this.LblL.Size = new System.Drawing.Size(47, 42);
            this.LblL.TabIndex = 3;
            this.LblL.Text = "L";
            this.LblL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblM
            // 
            this.LblM.BackColor = System.Drawing.Color.White;
            this.LblM.CausesValidation = false;
            this.LblM.Location = new System.Drawing.Point(125, 34);
            this.LblM.Name = "LblM";
            this.LblM.Size = new System.Drawing.Size(47, 42);
            this.LblM.TabIndex = 2;
            this.LblM.Text = "M";
            this.LblM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblT1
            // 
            this.LblT1.BackColor = System.Drawing.Color.White;
            this.LblT1.CausesValidation = false;
            this.LblT1.Location = new System.Drawing.Point(72, 34);
            this.LblT1.Name = "LblT1";
            this.LblT1.Size = new System.Drawing.Size(47, 42);
            this.LblT1.TabIndex = 1;
            this.LblT1.Text = "T1";
            this.LblT1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblT0
            // 
            this.LblT0.BackColor = System.Drawing.Color.White;
            this.LblT0.CausesValidation = false;
            this.LblT0.Location = new System.Drawing.Point(19, 34);
            this.LblT0.Name = "LblT0";
            this.LblT0.Size = new System.Drawing.Size(47, 42);
            this.LblT0.TabIndex = 0;
            this.LblT0.Text = "T0";
            this.LblT0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPostClassDeterminer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 472);
            this.Controls.Add(this.GrpboxPrecompleteClasses);
            this.Controls.Add(this.RtboxOutput);
            this.Controls.Add(this.TxtInput);
            this.Controls.Add(this.BtnDetermine);
            this.Controls.Add(this.LblActionDescription);
            this.Name = "FormPostClassDeterminer";
            this.Text = "App";
            this.Load += new System.EventHandler(this.FormPostClassDeterminer_Load);
            this.GrpboxPrecompleteClasses.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblActionDescription;
        private Button BtnDetermine;
        private TextBox TxtInput;
        private RichTextBox RtboxOutput;
        private GroupBox GrpboxPrecompleteClasses;
        private Label LblT0;
        private Label LblSOut;
        private Label LblLOut;
        private Label LblMOut;
        private Label LblT1Out;
        private Label LblT0Out;
        private Label LblS;
        private Label LblL;
        private Label LblM;
        private Label LblT1;
    }
}