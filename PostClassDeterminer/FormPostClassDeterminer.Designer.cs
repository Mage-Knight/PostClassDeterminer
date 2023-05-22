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
            this.RtboxInput = new System.Windows.Forms.RichTextBox();
            this.LblOutput = new System.Windows.Forms.Label();
            this.OpnfilediagChooseFile = new System.Windows.Forms.OpenFileDialog();
            this.BtnChooseFilePath = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblSymbolCountValue = new System.Windows.Forms.Label();
            this.LblSymbolCountText = new System.Windows.Forms.Label();
            this.BtnClearText = new System.Windows.Forms.Button();
            this.GrpboxPrecompleteClasses.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblActionDescription
            // 
            this.LblActionDescription.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblActionDescription.Location = new System.Drawing.Point(26, 27);
            this.LblActionDescription.Name = "LblActionDescription";
            this.LblActionDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblActionDescription.Size = new System.Drawing.Size(383, 43);
            this.LblActionDescription.TabIndex = 0;
            this.LblActionDescription.Text = "Enter boolean function values vector:";
            this.LblActionDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnDetermine
            // 
            this.BtnDetermine.BackColor = System.Drawing.Color.Orange;
            this.BtnDetermine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDetermine.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnDetermine.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnDetermine.Location = new System.Drawing.Point(472, 186);
            this.BtnDetermine.Name = "BtnDetermine";
            this.BtnDetermine.Size = new System.Drawing.Size(295, 40);
            this.BtnDetermine.TabIndex = 1;
            this.BtnDetermine.Text = "Start";
            this.BtnDetermine.UseVisualStyleBackColor = false;
            this.BtnDetermine.Click += new System.EventHandler(this.BtnDetermine_Click);
            // 
            // RtboxOutput
            // 
            this.RtboxOutput.BackColor = System.Drawing.SystemColors.Window;
            this.RtboxOutput.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtboxOutput.Location = new System.Drawing.Point(26, 345);
            this.RtboxOutput.Name = "RtboxOutput";
            this.RtboxOutput.ReadOnly = true;
            this.RtboxOutput.Size = new System.Drawing.Size(741, 153);
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
            this.GrpboxPrecompleteClasses.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            // RtboxInput
            // 
            this.RtboxInput.Location = new System.Drawing.Point(26, 73);
            this.RtboxInput.Name = "RtboxInput";
            this.RtboxInput.Size = new System.Drawing.Size(417, 181);
            this.RtboxInput.TabIndex = 6;
            this.RtboxInput.Text = "";
            this.RtboxInput.TextChanged += new System.EventHandler(this.RtboxInput_TextChanged);
            // 
            // LblOutput
            // 
            this.LblOutput.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblOutput.Location = new System.Drawing.Point(26, 299);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblOutput.Size = new System.Drawing.Size(85, 43);
            this.LblOutput.TabIndex = 7;
            this.LblOutput.Text = "Output:";
            this.LblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OpnfilediagChooseFile
            // 
            this.OpnfilediagChooseFile.DefaultExt = "txt";
            this.OpnfilediagChooseFile.Filter = "txt files (*.txt)|*.txt";
            this.OpnfilediagChooseFile.InitialDirectory = "C:\\";
            this.OpnfilediagChooseFile.Title = "Choose file with values vector sequence:";
            // 
            // BtnChooseFilePath
            // 
            this.BtnChooseFilePath.BackColor = System.Drawing.Color.Orange;
            this.BtnChooseFilePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChooseFilePath.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnChooseFilePath.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnChooseFilePath.Location = new System.Drawing.Point(472, 232);
            this.BtnChooseFilePath.Name = "BtnChooseFilePath";
            this.BtnChooseFilePath.Size = new System.Drawing.Size(137, 43);
            this.BtnChooseFilePath.TabIndex = 8;
            this.BtnChooseFilePath.Text = "...";
            this.BtnChooseFilePath.UseVisualStyleBackColor = false;
            this.BtnChooseFilePath.Click += new System.EventHandler(this.BtnChooseFilePath_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Orange;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnClose.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnClose.Location = new System.Drawing.Point(630, 232);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(137, 43);
            this.BtnClose.TabIndex = 9;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblSymbolCountValue
            // 
            this.LblSymbolCountValue.BackColor = System.Drawing.Color.Orange;
            this.LblSymbolCountValue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSymbolCountValue.ForeColor = System.Drawing.SystemColors.Window;
            this.LblSymbolCountValue.Location = new System.Drawing.Point(176, 257);
            this.LblSymbolCountValue.Name = "LblSymbolCountValue";
            this.LblSymbolCountValue.Size = new System.Drawing.Size(267, 30);
            this.LblSymbolCountValue.TabIndex = 10;
            this.LblSymbolCountValue.Text = "0";
            this.LblSymbolCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblSymbolCountText
            // 
            this.LblSymbolCountText.BackColor = System.Drawing.Color.Orange;
            this.LblSymbolCountText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblSymbolCountText.ForeColor = System.Drawing.SystemColors.Window;
            this.LblSymbolCountText.Location = new System.Drawing.Point(26, 257);
            this.LblSymbolCountText.Name = "LblSymbolCountText";
            this.LblSymbolCountText.Size = new System.Drawing.Size(144, 30);
            this.LblSymbolCountText.TabIndex = 11;
            this.LblSymbolCountText.Text = "Values count:";
            this.LblSymbolCountText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnClearText
            // 
            this.BtnClearText.BackColor = System.Drawing.Color.Orange;
            this.BtnClearText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClearText.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnClearText.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnClearText.Location = new System.Drawing.Point(472, 281);
            this.BtnClearText.Name = "BtnClearText";
            this.BtnClearText.Size = new System.Drawing.Size(295, 40);
            this.BtnClearText.TabIndex = 12;
            this.BtnClearText.Text = "Clear text";
            this.BtnClearText.UseVisualStyleBackColor = false;
            this.BtnClearText.Click += new System.EventHandler(this.BtnClearText_Click);
            // 
            // FormPostClassDeterminer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(793, 521);
            this.Controls.Add(this.BtnClearText);
            this.Controls.Add(this.LblSymbolCountText);
            this.Controls.Add(this.LblSymbolCountValue);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnChooseFilePath);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.RtboxInput);
            this.Controls.Add(this.GrpboxPrecompleteClasses);
            this.Controls.Add(this.RtboxOutput);
            this.Controls.Add(this.BtnDetermine);
            this.Controls.Add(this.LblActionDescription);
            this.Name = "FormPostClassDeterminer";
            this.Text = "Narrowest Post\'s class";
            this.GrpboxPrecompleteClasses.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label LblActionDescription;
        private Button BtnDetermine;
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
        private RichTextBox RtboxInput;
        private Label LblOutput;
        private OpenFileDialog OpnfilediagChooseFile;
        private Button BtnChooseFilePath;
        private Button BtnClose;
        private Label LblSymbolCountValue;
        private Label LblSymbolCountText;
        private Button BtnClearText;
    }
}