namespace FinalProject_CalculatorDesktopApp
{
    partial class Calculator
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCalculator = new System.Windows.Forms.TabPage();
            this.btnLOC = new System.Windows.Forms.Button();
            this.btnBIN = new System.Windows.Forms.Button();
            this.btnDEC = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPluse = new System.Windows.Forms.Button();
            this.btnNumZero = new System.Windows.Forms.Button();
            this.btnNumNine = new System.Windows.Forms.Button();
            this.btnNumEight = new System.Windows.Forms.Button();
            this.btnNumSeven = new System.Windows.Forms.Button();
            this.btnNumSix = new System.Windows.Forms.Button();
            this.btnNumFive = new System.Windows.Forms.Button();
            this.btnNumFour = new System.Windows.Forms.Button();
            this.btnNumThree = new System.Windows.Forms.Button();
            this.btnNumTwo = new System.Windows.Forms.Button();
            this.btnNumOne = new System.Windows.Forms.Button();
            this.tabDecimal = new System.Windows.Forms.TabPage();
            this.txtTabDecDisplay = new System.Windows.Forms.TextBox();
            this.tabBinary = new System.Windows.Forms.TabPage();
            this.txtTabBinDisplay = new System.Windows.Forms.TextBox();
            this.tabLoc = new System.Windows.Forms.TabPage();
            this.txtTabLocDisplay = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabCalculator.SuspendLayout();
            this.tabDecimal.SuspendLayout();
            this.tabBinary.SuspendLayout();
            this.tabLoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.AccessibleDescription = "Switch Decimal, Binary, Locational";
            this.tabControl.AccessibleName = "Switch Decimal, Binary, Locational";
            this.tabControl.Controls.Add(this.tabCalculator);
            this.tabControl.Controls.Add(this.tabDecimal);
            this.tabControl.Controls.Add(this.tabBinary);
            this.tabControl.Controls.Add(this.tabLoc);
            this.tabControl.Location = new System.Drawing.Point(-1, -2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(476, 465);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabCalculator
            // 
            this.tabCalculator.AccessibleDescription = "Tab of Calculator";
            this.tabCalculator.AccessibleName = "Tab of Calculator";
            this.tabCalculator.Controls.Add(this.btnLOC);
            this.tabCalculator.Controls.Add(this.btnBIN);
            this.tabCalculator.Controls.Add(this.btnDEC);
            this.tabCalculator.Controls.Add(this.btnClear);
            this.tabCalculator.Controls.Add(this.txtDisplay);
            this.tabCalculator.Controls.Add(this.btnDecimal);
            this.tabCalculator.Controls.Add(this.btnEqual);
            this.tabCalculator.Controls.Add(this.btnDivide);
            this.tabCalculator.Controls.Add(this.btnMultiply);
            this.tabCalculator.Controls.Add(this.btnMinus);
            this.tabCalculator.Controls.Add(this.btnPluse);
            this.tabCalculator.Controls.Add(this.btnNumZero);
            this.tabCalculator.Controls.Add(this.btnNumNine);
            this.tabCalculator.Controls.Add(this.btnNumEight);
            this.tabCalculator.Controls.Add(this.btnNumSeven);
            this.tabCalculator.Controls.Add(this.btnNumSix);
            this.tabCalculator.Controls.Add(this.btnNumFive);
            this.tabCalculator.Controls.Add(this.btnNumFour);
            this.tabCalculator.Controls.Add(this.btnNumThree);
            this.tabCalculator.Controls.Add(this.btnNumTwo);
            this.tabCalculator.Controls.Add(this.btnNumOne);
            this.tabCalculator.Location = new System.Drawing.Point(4, 29);
            this.tabCalculator.Name = "tabCalculator";
            this.tabCalculator.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalculator.Size = new System.Drawing.Size(468, 432);
            this.tabCalculator.TabIndex = 0;
            this.tabCalculator.Text = "Calculator";
            this.tabCalculator.UseVisualStyleBackColor = true;
            // 
            // btnLOC
            // 
            this.btnLOC.AccessibleDescription = "Button of converting Decimal to Locational Numeral";
            this.btnLOC.AccessibleName = "Button of Locational Numeral";
            this.btnLOC.Location = new System.Drawing.Point(54, 125);
            this.btnLOC.Name = "btnLOC";
            this.btnLOC.Size = new System.Drawing.Size(67, 26);
            this.btnLOC.TabIndex = 42;
            this.btnLOC.Text = "LOC";
            this.btnLOC.UseVisualStyleBackColor = true;
            this.btnLOC.Click += new System.EventHandler(this.btnLOC_Click);
            // 
            // btnBIN
            // 
            this.btnBIN.AccessibleDescription = "Button of converting Decimal to Binary";
            this.btnBIN.AccessibleName = "Button of Clear";
            this.btnBIN.Location = new System.Drawing.Point(144, 127);
            this.btnBIN.Name = "btnBIN";
            this.btnBIN.Size = new System.Drawing.Size(70, 24);
            this.btnBIN.TabIndex = 41;
            this.btnBIN.Text = "BIN";
            this.btnBIN.UseVisualStyleBackColor = true;
            this.btnBIN.Click += new System.EventHandler(this.btnBIN_Click);
            // 
            // btnDEC
            // 
            this.btnDEC.AccessibleDescription = "Button of converting Binary to Decimal";
            this.btnDEC.AccessibleName = "Button of Decimal";
            this.btnDEC.Location = new System.Drawing.Point(237, 127);
            this.btnDEC.Name = "btnDEC";
            this.btnDEC.Size = new System.Drawing.Size(70, 24);
            this.btnDEC.TabIndex = 40;
            this.btnDEC.Text = "DEC";
            this.btnDEC.UseVisualStyleBackColor = true;
            this.btnDEC.Click += new System.EventHandler(this.btnDEC_Click);
            // 
            // btnClear
            // 
            this.btnClear.AccessibleDescription = "Button of Clear of Calculator";
            this.btnClear.AccessibleName = "Button of Clear";
            this.btnClear.Location = new System.Drawing.Point(345, 127);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 24);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.AccessibleDescription = "Display the number of calculator";
            this.txtDisplay.AccessibleName = "Display the number";
            this.txtDisplay.Location = new System.Drawing.Point(54, 78);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(361, 27);
            this.txtDisplay.TabIndex = 23;
            // 
            // btnDecimal
            // 
            this.btnDecimal.AccessibleDescription = "Decimal of Calculator";
            this.btnDecimal.AccessibleName = "Decimal";
            this.btnDecimal.Location = new System.Drawing.Point(144, 325);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(67, 29);
            this.btnDecimal.TabIndex = 38;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Cilck);
            // 
            // btnEqual
            // 
            this.btnEqual.AccessibleDescription = "Operator Equality of Calculator";
            this.btnEqual.AccessibleName = "Operator Equality";
            this.btnEqual.Location = new System.Drawing.Point(240, 325);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(67, 29);
            this.btnEqual.TabIndex = 37;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.AccessibleDescription = "Operator Divide of Calculator";
            this.btnDivide.AccessibleName = "Operator Divide";
            this.btnDivide.Location = new System.Drawing.Point(345, 329);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(70, 25);
            this.btnDivide.TabIndex = 36;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.AccessibleDescription = "Operator Multiply of Calculator";
            this.btnMultiply.AccessibleName = "Operator Multiply";
            this.btnMultiply.Location = new System.Drawing.Point(345, 271);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(70, 24);
            this.btnMultiply.TabIndex = 35;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.AccessibleDescription = "Operator Minus of Calculator";
            this.btnMinus.AccessibleName = "Operator Minus";
            this.btnMinus.Location = new System.Drawing.Point(345, 222);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(70, 24);
            this.btnMinus.TabIndex = 34;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPluse
            // 
            this.btnPluse.AccessibleDescription = "Operator Pluse of Calculator";
            this.btnPluse.AccessibleName = "Operator Pluse";
            this.btnPluse.Location = new System.Drawing.Point(345, 173);
            this.btnPluse.Name = "btnPluse";
            this.btnPluse.Size = new System.Drawing.Size(70, 24);
            this.btnPluse.TabIndex = 33;
            this.btnPluse.Text = "+";
            this.btnPluse.UseVisualStyleBackColor = true;
            this.btnPluse.Click += new System.EventHandler(this.btnPluse_Click);
            // 
            // btnNumZero
            // 
            this.btnNumZero.AccessibleDescription = "Number zero of calculator";
            this.btnNumZero.AccessibleName = "Number zero";
            this.btnNumZero.Location = new System.Drawing.Point(54, 325);
            this.btnNumZero.Name = "btnNumZero";
            this.btnNumZero.Size = new System.Drawing.Size(67, 25);
            this.btnNumZero.TabIndex = 32;
            this.btnNumZero.Text = "0";
            this.btnNumZero.UseVisualStyleBackColor = true;
            this.btnNumZero.Click += new System.EventHandler(this.btnNumZero_Cilck);
            // 
            // btnNumNine
            // 
            this.btnNumNine.AccessibleDescription = "Number nine of calculator";
            this.btnNumNine.AccessibleName = "Number nine";
            this.btnNumNine.Location = new System.Drawing.Point(240, 271);
            this.btnNumNine.Name = "btnNumNine";
            this.btnNumNine.Size = new System.Drawing.Size(67, 24);
            this.btnNumNine.TabIndex = 31;
            this.btnNumNine.Text = "9";
            this.btnNumNine.UseVisualStyleBackColor = true;
            this.btnNumNine.Click += new System.EventHandler(this.btnNumNine_Cilck);
            // 
            // btnNumEight
            // 
            this.btnNumEight.AccessibleDescription = "Number eight of calculator";
            this.btnNumEight.AccessibleName = "Number eight";
            this.btnNumEight.Location = new System.Drawing.Point(144, 271);
            this.btnNumEight.Name = "btnNumEight";
            this.btnNumEight.Size = new System.Drawing.Size(67, 24);
            this.btnNumEight.TabIndex = 30;
            this.btnNumEight.Text = "8";
            this.btnNumEight.UseVisualStyleBackColor = true;
            this.btnNumEight.Click += new System.EventHandler(this.btnNumEight_Cilck);
            // 
            // btnNumSeven
            // 
            this.btnNumSeven.AccessibleDescription = "Number seven of calculator";
            this.btnNumSeven.AccessibleName = "Number seven";
            this.btnNumSeven.Location = new System.Drawing.Point(54, 271);
            this.btnNumSeven.Name = "btnNumSeven";
            this.btnNumSeven.Size = new System.Drawing.Size(67, 24);
            this.btnNumSeven.TabIndex = 29;
            this.btnNumSeven.Text = "7";
            this.btnNumSeven.UseVisualStyleBackColor = true;
            this.btnNumSeven.Click += new System.EventHandler(this.btnNumSeven_Cilck);
            // 
            // btnNumSix
            // 
            this.btnNumSix.AccessibleDescription = "Number six of calculator";
            this.btnNumSix.AccessibleName = "Number six";
            this.btnNumSix.Location = new System.Drawing.Point(240, 222);
            this.btnNumSix.Name = "btnNumSix";
            this.btnNumSix.Size = new System.Drawing.Size(67, 25);
            this.btnNumSix.TabIndex = 28;
            this.btnNumSix.Text = "6";
            this.btnNumSix.UseVisualStyleBackColor = true;
            this.btnNumSix.Click += new System.EventHandler(this.btnNumSix_Cilck);
            // 
            // btnNumFive
            // 
            this.btnNumFive.AccessibleDescription = "Number five of calculator";
            this.btnNumFive.AccessibleName = "Number five";
            this.btnNumFive.Location = new System.Drawing.Point(144, 222);
            this.btnNumFive.Name = "btnNumFive";
            this.btnNumFive.Size = new System.Drawing.Size(67, 24);
            this.btnNumFive.TabIndex = 27;
            this.btnNumFive.Text = "5";
            this.btnNumFive.UseVisualStyleBackColor = true;
            this.btnNumFive.Click += new System.EventHandler(this.btnNumFive_Cilck);
            // 
            // btnNumFour
            // 
            this.btnNumFour.AccessibleDescription = "Number four of calculator";
            this.btnNumFour.AccessibleName = "Number four";
            this.btnNumFour.Location = new System.Drawing.Point(54, 222);
            this.btnNumFour.Name = "btnNumFour";
            this.btnNumFour.Size = new System.Drawing.Size(67, 24);
            this.btnNumFour.TabIndex = 26;
            this.btnNumFour.Text = "4";
            this.btnNumFour.UseVisualStyleBackColor = true;
            this.btnNumFour.Click += new System.EventHandler(this.btnNumFour_Cilck);
            // 
            // btnNumThree
            // 
            this.btnNumThree.AccessibleDescription = "Number three of calculator";
            this.btnNumThree.AccessibleName = "Number three";
            this.btnNumThree.Location = new System.Drawing.Point(240, 173);
            this.btnNumThree.Name = "btnNumThree";
            this.btnNumThree.Size = new System.Drawing.Size(67, 25);
            this.btnNumThree.TabIndex = 25;
            this.btnNumThree.Text = "3";
            this.btnNumThree.UseVisualStyleBackColor = true;
            this.btnNumThree.Click += new System.EventHandler(this.btnNumThree_Cilck);
            // 
            // btnNumTwo
            // 
            this.btnNumTwo.AccessibleDescription = "Number two of calculator";
            this.btnNumTwo.AccessibleName = "Number two";
            this.btnNumTwo.Location = new System.Drawing.Point(144, 173);
            this.btnNumTwo.Name = "btnNumTwo";
            this.btnNumTwo.Size = new System.Drawing.Size(67, 25);
            this.btnNumTwo.TabIndex = 24;
            this.btnNumTwo.Text = "2";
            this.btnNumTwo.UseVisualStyleBackColor = true;
            this.btnNumTwo.Click += new System.EventHandler(this.btnNumTwo_Cilck);
            // 
            // btnNumOne
            // 
            this.btnNumOne.AccessibleDescription = "Number one of calculator";
            this.btnNumOne.AccessibleName = "Number one";
            this.btnNumOne.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNumOne.Location = new System.Drawing.Point(54, 173);
            this.btnNumOne.Name = "btnNumOne";
            this.btnNumOne.Size = new System.Drawing.Size(67, 25);
            this.btnNumOne.TabIndex = 22;
            this.btnNumOne.Text = "1";
            this.btnNumOne.UseVisualStyleBackColor = true;
            this.btnNumOne.Click += new System.EventHandler(this.btnNumOne_Cilck);
            // 
            // tabDecimal
            // 
            this.tabDecimal.AccessibleDescription = "Tab of coverting to Decimal";
            this.tabDecimal.AccessibleName = "Tab of coverting to Decimal";
            this.tabDecimal.Controls.Add(this.txtTabDecDisplay);
            this.tabDecimal.Location = new System.Drawing.Point(4, 29);
            this.tabDecimal.Name = "tabDecimal";
            this.tabDecimal.Padding = new System.Windows.Forms.Padding(3);
            this.tabDecimal.Size = new System.Drawing.Size(468, 432);
            this.tabDecimal.TabIndex = 1;
            this.tabDecimal.Text = "Decimal";
            this.tabDecimal.UseVisualStyleBackColor = true;
            // 
            // txtTabDecDisplay
            // 
            this.txtTabDecDisplay.AccessibleDescription = "result of decimal of tab control";
            this.txtTabDecDisplay.AccessibleName = "result of decimal of tab control";
            this.txtTabDecDisplay.Location = new System.Drawing.Point(57, 75);
            this.txtTabDecDisplay.Name = "txtTabDecDisplay";
            this.txtTabDecDisplay.Size = new System.Drawing.Size(341, 27);
            this.txtTabDecDisplay.TabIndex = 0;
            // 
            // tabBinary
            // 
            this.tabBinary.AccessibleDescription = "Tab of coverting to Binary";
            this.tabBinary.AccessibleName = "Tab of coverting to Binary";
            this.tabBinary.Controls.Add(this.txtTabBinDisplay);
            this.tabBinary.Location = new System.Drawing.Point(4, 29);
            this.tabBinary.Name = "tabBinary";
            this.tabBinary.Padding = new System.Windows.Forms.Padding(3);
            this.tabBinary.Size = new System.Drawing.Size(468, 432);
            this.tabBinary.TabIndex = 2;
            this.tabBinary.Text = "Binary";
            this.tabBinary.UseVisualStyleBackColor = true;
            // 
            // txtTabBinDisplay
            // 
            this.txtTabBinDisplay.AccessibleDescription = "result of Binary of tab control";
            this.txtTabBinDisplay.AccessibleName = "result of Binary of tab control";
            this.txtTabBinDisplay.Location = new System.Drawing.Point(66, 69);
            this.txtTabBinDisplay.Name = "txtTabBinDisplay";
            this.txtTabBinDisplay.Size = new System.Drawing.Size(334, 27);
            this.txtTabBinDisplay.TabIndex = 0;
            // 
            // tabLoc
            // 
            this.tabLoc.AccessibleDescription = "Tab of coverting to Locational";
            this.tabLoc.AccessibleName = "Tab of coverting to Locational";
            this.tabLoc.Controls.Add(this.txtTabLocDisplay);
            this.tabLoc.Location = new System.Drawing.Point(4, 29);
            this.tabLoc.Name = "tabLoc";
            this.tabLoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabLoc.Size = new System.Drawing.Size(468, 432);
            this.tabLoc.TabIndex = 3;
            this.tabLoc.Text = "Locational";
            this.tabLoc.UseVisualStyleBackColor = true;
            // 
            // txtTabLocDisplay
            // 
            this.txtTabLocDisplay.AccessibleDescription = "result of Locational of tab control";
            this.txtTabLocDisplay.AccessibleName = "result of Locational of tab control";
            this.txtTabLocDisplay.Location = new System.Drawing.Point(69, 60);
            this.txtTabLocDisplay.Name = "txtTabLocDisplay";
            this.txtTabLocDisplay.Size = new System.Drawing.Size(334, 27);
            this.txtTabLocDisplay.TabIndex = 0;
            // 
            // Calculator
            // 
            this.AccessibleDescription = "Calculator Form";
            this.AccessibleName = "Calculator Form";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 460);
            this.Controls.Add(this.tabControl);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.tabControl.ResumeLayout(false);
            this.tabCalculator.ResumeLayout(false);
            this.tabCalculator.PerformLayout();
            this.tabDecimal.ResumeLayout(false);
            this.tabDecimal.PerformLayout();
            this.tabBinary.ResumeLayout(false);
            this.tabBinary.PerformLayout();
            this.tabLoc.ResumeLayout(false);
            this.tabLoc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabBin;
        private TabPage tabCalculator;
        private Button btnLOC;
        private Button btnBIN;
        private Button btnDEC;
        private Button btnClear;
        private TextBox txtDisplay;
        private Button btnDecimal;
        private Button btnEqual;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnMinus;
        private Button btnPluse;
        private Button btnNumZero;
        private Button btnNumNine;
        private Button btnNumEight;
        private Button btnNumSeven;
        private Button btnNumSix;
        private Button btnNumFive;
        private Button btnNumFour;
        private Button btnNumThree;
        private Button btnNumTwo;
        private Button btnNumOne;
        private TabPage tabDecimal;
        private TabPage tabBinary;
        private TabPage tabLoc;
        private TextBox txtTabDecDisplay;
        private TextBox txtTabBinDisplay;
        private TextBox txtTabLocDisplay;
        private TabControl tabControl;
    }
}