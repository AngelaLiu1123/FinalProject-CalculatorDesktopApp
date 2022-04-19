using System.Text;

namespace FinalProject_CalculatorDesktopApp
{
    public partial class Calculator : Form
    {
        string storedOperand = string.Empty;
        string storedOperation = string.Empty;
        string display = string.Empty;
        bool previousKeyIsOpertation = false;
        bool previousKeyIsBinOrDec = false;
        string binPattern = @"^[0-1]*$";
        string decPattern = @"^[0-9]*$";
        string locPattern = @"^[a-z]+$";
        Dictionary<int, string> decLocDict = new Dictionary<int, string>()
            {
                { 0 , "a"},
                { 1, "b"},
                { 2, "c"},
                { 3, "d"},
                { 4, "e"},
                { 5, "f"},
                { 6, "g"},
                { 7, "h"},
                { 8, "i"},
                { 9, "j"},
                { 10, "k"},
                { 11, "l"},
                { 12, "m"},
                { 13, "n"},
                { 14, "o"},
                { 15, "p"},
                { 16, "q"},
                { 17, "r"},
                { 18, "s"},
                { 19, "t"},
                { 20, "u"},
                { 21, "v"},
                { 22, "w"},
                { 23, "x"},
                { 24, "y"},
                { 25, "z"},
            };

        public Calculator()
        {
            InitializeComponent();
        }

        private void btnNumOne_Cilck(object sender, EventArgs e)
        {
            ClearDisplayText();
            txtDisplay.Text += btnNumOne.Text;
            
        }

        private void btnNumTwo_Cilck(object sender, EventArgs e)
        {
            ClearDisplayText();
            txtDisplay.Text += btnNumTwo.Text;
        }

        private void btnNumThree_Cilck(object sender, EventArgs e)
        {
            ClearDisplayText();
            txtDisplay.Text += btnNumThree.Text;
        }

        private void btnNumFour_Cilck(object sender, EventArgs e)
        {
            ClearDisplayText();
            txtDisplay.Text += btnNumFour.Text;
        }

        private void btnNumFive_Cilck(object sender, EventArgs e)
        {
            ClearDisplayText();
            txtDisplay.Text += btnNumFive.Text;
        }

        private void btnNumSix_Cilck(object sender, EventArgs e)
        {
            ClearDisplayText();
            txtDisplay.Text += btnNumSix.Text;
        }

        private void btnNumSeven_Cilck(object sender, EventArgs e)
        {
            ClearDisplayText();
            txtDisplay.Text += btnNumSeven.Text;
        }

        private void btnNumEight_Cilck(object sender, EventArgs e)
        {
            ClearDisplayText();
            txtDisplay.Text += btnNumEight.Text;
        }

        private void btnNumNine_Cilck(object sender, EventArgs e)
        {
            ClearDisplayText();
            txtDisplay.Text += btnNumNine.Text;
        }

        private void btnNumZero_Cilck(object sender, EventArgs e)
        {
            ClearDisplayText();
            txtDisplay.Text += btnNumZero.Text;
        }

        private void btnDecimal_Cilck(object sender, EventArgs e)
        {
            ClearDisplayText();
            txtDisplay.Text += btnDecimal.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
            storedOperation = string.Empty;
            storedOperand = string.Empty;
        }

        private void btnPluse_Click(object sender, EventArgs e)
        {
            if (!previousKeyIsOpertation)
            {
                GetTwoOperationsValue();
                CalculateEqualtion();
            }
            storedOperation = btnPluse.Text;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (!previousKeyIsOpertation)
            {
                GetTwoOperationsValue();
                CalculateEqualtion();
            }
            
            storedOperation = btnMinus.Text;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (!previousKeyIsOpertation)
            {
                GetTwoOperationsValue();
                CalculateEqualtion();
            }
            storedOperation = btnMultiply.Text;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (!previousKeyIsOpertation)
            {
                GetTwoOperationsValue();
                CalculateEqualtion();
            }
            storedOperation = btnDivide.Text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            float displayNum = float.Parse(txtDisplay.Text);
            float storedOperandNum = float.Parse(storedOperand);
            float result = 0;
            switch (storedOperation)
            {
                case "+":
                    result = storedOperandNum + displayNum;
                    txtDisplay.Text = result.ToString();
                    break;
                case "-":
                    result = storedOperandNum - displayNum;
                    txtDisplay.Text = result.ToString();
                    break;
                case "*":
                    result = storedOperandNum * displayNum;
                    txtDisplay.Text = result.ToString();
                    break;
                case "/":
                    result = storedOperandNum / displayNum;
                    txtDisplay.Text = result.ToString();
                    break;
            }

            storedOperand = result.ToString(); 
            storedOperation = string.Empty;
            
            
        }

        private void CalculateEqualtion()
        {
            if (storedOperand != string.Empty && storedOperation != string.Empty && display != string.Empty)
            {
                float result = 0;
                float displayNum = float.Parse(display);
                float storedOperandNum = float.Parse(storedOperand);

                switch (storedOperation)
                {
                    case "+":
                        result = storedOperandNum + displayNum;
                        txtDisplay.Text = result.ToString();
                        break;
                    case "-":
                        result = storedOperandNum - displayNum;
                        txtDisplay.Text = result.ToString();
                        break;
                    case "*":
                        result = storedOperandNum * displayNum;
                        txtDisplay.Text = result.ToString();
                        break;
                    case "/":
                        result = storedOperandNum / displayNum;
                        txtDisplay.Text = result.ToString();
                        break;
                }
                storedOperand = result.ToString();
            }
        }

        private void GetTwoOperationsValue()
        {
            display = txtDisplay.Text;
            if (storedOperand == string.Empty)
            {
                storedOperand = display;
                display = string.Empty;
            }
            previousKeyIsOpertation = true;
        }

        private void ClearDisplayText()
        {
            if (previousKeyIsOpertation || previousKeyIsBinOrDec)
            {
                txtDisplay.Text = string.Empty;
            }
            previousKeyIsOpertation = false;
            previousKeyIsBinOrDec = false;
        }

        private void btnDEC_Click(object sender, EventArgs e)
        {
            string inputStr = txtDisplay.Text;
            string pattern = @"^[0-1]*$";
            if (System.Text.RegularExpressions.Regex.IsMatch(inputStr, pattern))
            {
                int inputNum = int.Parse(txtDisplay.Text);
                int decStr = ConvertBinToDec(inputNum, false);
                txtDisplay.Text = decStr.ToString();
            }
            else
            {
                txtDisplay.Text = "ERROR";
            }
            previousKeyIsBinOrDec = true;
        }

        private void btnBIN_Click(object sender, EventArgs e)
        {
            string inputStr = txtDisplay.Text;
            string pattern = @"^[0-9]*$";
            if (System.Text.RegularExpressions.Regex.IsMatch(inputStr, pattern))
            {
                int inputNum = int.Parse(txtDisplay.Text);
                string binStr = ConvertDecToBin(inputNum, false);
                txtDisplay.Text = binStr;
            }
            else
            {
                txtDisplay.Text = "ERROR";
            }
            previousKeyIsBinOrDec = true;
        }

        private void btnLOC_Click(object sender, EventArgs e)
        {
            string inputStr = txtDisplay.Text;
            string pattern = @"^[0-9]*$";
            if (System.Text.RegularExpressions.Regex.IsMatch(inputStr, pattern))
            {
                int inputNum = int.Parse(txtDisplay.Text);
                string locStr = ConvertDecToLoc(inputNum);
                txtDisplay.Text = locStr;
            }
            else
            {
                txtDisplay.Text = "ERROR";
            }
            previousKeyIsBinOrDec = true;
        }

        //Convert Decimal to Binary
        string ConvertDecToBin(int decNum, bool isSigned)
        {
            string binNum = String.Empty;
            int remainder;
            int absDecNum = Math.Abs(decNum);
            while (absDecNum != 0)
            {
                remainder = absDecNum % 2;
                absDecNum /= 2;

                if (isSigned && decNum.ToString()[0] == '-')
                {
                    binNum = (1 - remainder).ToString() + binNum;
                }
                else
                {
                    binNum = remainder.ToString() + binNum;
                }
            }

            if (isSigned)
            {
                if (decNum > 0)
                    binNum = "0" + binNum.Reverse();
                else
                    binNum = "1" + binNum;
            }

            return binNum;
        }

        //Convert Binary to Decimal
        int ConvertBinToDec(int binNum, bool isSigned)
        {
            int decNum = 0;
            string binStr = binNum.ToString();
            string sign = String.Empty;
            if (isSigned)
            {
                string firstChar = binNum.ToString().Substring(0, 1);
                if (firstChar == "1")
                {
                    sign = "-";
                }
                binStr = binStr.Substring(1);
            }

            char[] binaryArr = binStr.ToCharArray();


            for (int i = 0; i < binaryArr.Length; i++)
            {
                if (isSigned)
                {
                    binaryArr[i] = binaryArr[i] == '0' ? '1' : '0';
                }
                int j = binaryArr.Length - 1 - i;
                if (binaryArr[i] == '1')
                {
                    decNum += (int)Math.Pow(2, j);
                }

            }

            if (sign != String.Empty)
            {
                decNum = int.Parse(sign + decNum.ToString());
            }

            return decNum;
        }

        //Conver Decimal to Locational Numeral
        string ConvertDecToLoc(int decNum)
        {
            string binStr = ConvertDecToBin(decNum, false);
            string locStr = ConvertBinToLoc(binStr);
            return locStr;
        }

        //Conver Decimal to Locational Numeral
        string ConvertLocToDec(string locNum)
        {
            string binStr = ConvertLocToBin(locNum);
            string decStr = ConvertBinToDec(int.Parse(binStr), false).ToString();

            return decStr;
        }

        //Conver Locational to  Binary
        string ConvertLocToBin(string locNum)
        {
            string binStr = string.Empty;
            int i = 0;
            while( decLocDict[i] != locNum[locNum.Length - 1].ToString())
            {
                if (locNum.Contains(decLocDict[i]))
                {
                    binStr = "1" + binStr;
                }
                else
                {
                    binStr = "0" + binStr;
                }
                i++;
            }
            binStr = "1" + binStr;
            return binStr;
        }

        //Conver Binary to Locational Numeral
        string ConvertBinToLoc(string binStr)
        {
            string locStr = string.Empty;

            for (int i = binStr.Length - 1; i >= 0; i--)
            {
                if (binStr[i] == '1')
                {
                    int index = binStr.Length - 1 - i;
                    locStr += decLocDict[index];
                }
            }

            return locStr;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //Check the pressed key whether is number or operation
            if((keyData >= Keys.D0 && keyData <= Keys.D9) 
                || (keyData >= Keys.NumPad0 && keyData <= Keys.NumPad9) 
                || keyData == Keys.Decimal || keyData == Keys.OemPeriod)
            {
                ClearDisplayText();

                if (keyData == Keys.D0 || keyData == Keys.NumPad0)
                {

                    txtDisplay.Text += btnNumZero.Text;
                    return true;
                }
                else if (keyData == Keys.D1 || keyData == Keys.NumPad1)
                {
                    txtDisplay.Text += btnNumOne.Text;
                    return true;
                }
                else if (keyData == Keys.D2 || keyData == Keys.NumPad2)
                {
                    txtDisplay.Text += btnNumTwo.Text;
                    return true;
                }
                else if (keyData == Keys.D3 || keyData == Keys.NumPad3)
                {
                    txtDisplay.Text += btnNumThree.Text;
                    return true;
                }
                else if (keyData == Keys.D4 || keyData == Keys.NumPad4)
                {
                    txtDisplay.Text += btnNumFour.Text;
                    return true;
                }
                else if (keyData == Keys.D5 || keyData == Keys.NumPad5)
                {
                    txtDisplay.Text += btnNumFive.Text;
                    return true;
                }
                else if (keyData == Keys.D6 || keyData == Keys.NumPad6)
                {
                    txtDisplay.Text += btnNumSix.Text;
                    return true;
                }
                else if (keyData == Keys.D7 || keyData == Keys.NumPad7)
                {
                    txtDisplay.Text += btnNumSeven.Text;
                    return true;
                }
                else if (keyData == Keys.D8 || keyData == Keys.NumPad8)
                {
                    txtDisplay.Text += btnNumEight.Text;
                    return true;
                }
                else if (keyData == Keys.D9 || keyData == Keys.NumPad9)
                {
                    txtDisplay.Text += btnNumNine.Text;
                    return true;
                }else if(keyData == Keys.Decimal || keyData == Keys.OemPeriod)
                {
                    txtDisplay.Text += btnDecimal.Text;
                    return true;
                }
            }else if(keyData == Keys.Add || keyData == (Keys.Shift | Keys.Oemplus) || keyData == Keys.Subtract || keyData == Keys.OemMinus 
                || keyData == Keys.Multiply || keyData == (Keys.Shift | Keys.D8)  || keyData == Keys.Divide || keyData == Keys.OemQuestion
                || keyData == Keys.Oemplus)
            {
                if (!previousKeyIsOpertation)
                {
                    GetTwoOperationsValue();
                    CalculateEqualtion();
                }

                if (keyData == Keys.Add || keyData == (Keys.Shift | Keys.Oemplus))
                {
                    storedOperation = btnPluse.Text;
                    return true;
                }
                else if (keyData == Keys.Subtract || keyData == Keys.OemMinus)
                {
                    storedOperation = btnMinus.Text;
                    return true;
                }
                else if (keyData == Keys.Multiply || keyData == (Keys.Shift | Keys.D8))
                {
                    storedOperation = btnMultiply.Text;
                    return true;
                }
                else if (keyData == Keys.Divide || keyData == Keys.OemQuestion)
                {
                    storedOperation = btnDivide.Text;
                    return true;
                }
                else if (keyData == Keys.Oemplus)
                {
                    float displayNum = float.Parse(txtDisplay.Text);
                    float storedOperandNum = float.Parse(storedOperand);
                    float result = 0;
                    switch (storedOperation)
                    {
                        case "+":
                            result = storedOperandNum + displayNum;
                            txtDisplay.Text = result.ToString();
                            break;
                        case "-":
                            result = storedOperandNum - displayNum;
                            txtDisplay.Text = result.ToString();
                            break;
                        case "*":
                            result = storedOperandNum * displayNum;
                            txtDisplay.Text = result.ToString();
                            break;
                        case "/":
                            result = storedOperandNum / displayNum;
                            txtDisplay.Text = result.ToString();
                            break;
                    }

                    storedOperand = result.ToString();
                    storedOperation = string.Empty;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SwitchToBinTab(string inputStr)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(inputStr, decPattern))
            {
                txtTabBinDisplay.Text = ConvertDecToBin(int.Parse(inputStr), false);
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(inputStr, binPattern))
            {
                txtTabBinDisplay.Text = inputStr;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(inputStr, locPattern))
            {
                txtTabBinDisplay.Text = ConvertLocToBin(inputStr);
            }
            
            
        }


        private void SwitchToDecTab(string inputStr)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(inputStr, decPattern))
            {
                txtTabDecDisplay.Text = inputStr;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(inputStr, binPattern))
            {
                txtTabDecDisplay.Text = ConvertBinToDec(int.Parse(inputStr), false).ToString();
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(inputStr, locPattern))
            {
                txtTabDecDisplay.Text = ConvertLocToDec(inputStr);
            }

        }

        private void SwitchToLocTab(string inputStr)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(inputStr, decPattern))
            {
                txtTabLocDisplay.Text = ConvertDecToLoc(int.Parse(inputStr));
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(inputStr, binPattern))
            {
                txtTabLocDisplay.Text = ConvertBinToLoc(inputStr);
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(inputStr, locPattern))
            {
                txtTabLocDisplay.Text = inputStr;
            }


        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

            string inputStr = txtDisplay.Text;
            if (string.IsNullOrEmpty(inputStr))
            {
                txtTabDecDisplay.Text = "Please input a number in Calculator";
                txtTabBinDisplay.Text = "Please input a number in Calculator";
                txtTabLocDisplay.Text = "Please input a number in Calculator";
            }
            else
            {
                switch (tabControl.SelectedIndex)
                {
                    case 1:
                        SwitchToDecTab(inputStr);
                        break;
                    case 2:
                        SwitchToBinTab(inputStr);
                        break;
                    case 3:
                        SwitchToLocTab(inputStr);
                        break;
                }

            }
            
        }
    }
}