using System.Text.RegularExpressions;

// Doesn't work with 1101001110011010011101111101000001111010111010011101101001000101 (solved)

namespace PostClassDeterminer
{
    public partial class FormPostClassDeterminer : Form
    {
        public FormPostClassDeterminer()
        {
            InitializeComponent();
        }

        private void BtnDetermine_Click(object sender, EventArgs e)
        {
            // Start timer
            System.Diagnostics.Stopwatch watch = new();
            watch.Restart();

            int[] valuesVector = new int[RtboxInput.Text.Length];

            // Define the regular expression pattern to match '0' or '1'
            string pattern = "^[01]+$";
            // Create a regular expression object with the pattern
            Regex regex = new(pattern);
            // Use the IsMatch method to check whether the input string matches the pattern
            bool isZerosOnes = regex.IsMatch(RtboxInput.Text);

            if (FuncLib.IsPowerOfTwo(RtboxInput.Text.Length) && isZerosOnes)
            {

                for (int i = 0; i < RtboxInput.Text.Length; i++)
                {
                    valuesVector[i] = int.Parse(RtboxInput.Text.Substring(i, 1));
                }

                BooleanFunction booleanFunction = new(valuesVector);
                RtboxOutput.Text = "Reduced values vector corresponding to essential variables: " +
                    string.Join("", booleanFunction.ValuesVector) +
                    $"\nNarrowest Post's class that the function " +
                    "belongs to: " + booleanFunction.FindNarrowestClass();
                LblT0Out.Text = FuncLib.BoolToSymbol(booleanFunction.IsT0());
                LblT1Out.Text = FuncLib.BoolToSymbol(booleanFunction.IsT1());
                LblSOut.Text = FuncLib.BoolToSymbol(booleanFunction.IsS());
                LblLOut.Text = FuncLib.BoolToSymbol(booleanFunction.IsL());
                LblMOut.Text = FuncLib.BoolToSymbol(booleanFunction.IsM());

                // Stop timer
                watch.Stop();
                RtboxOutput.Text += $"\nExecution time: {TimeSpan.FromTicks((long)watch.Elapsed.Ticks)}";

            }

            else RtboxOutput.Text = "Error: data should consist of '0' or '1' and must be of length which is a power of 2";
        }

        // Read values vector from a file by clicking the button
        private void BtnChooseFilePath_Click(object sender, EventArgs e)
        {
            if (OpnfilediagChooseFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new(OpnfilediagChooseFile.FileName);
                RtboxInput.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RtboxInput_TextChanged(object sender, EventArgs e)
        {
            LblSymbolCountValue.Text = RtboxInput.Text.Count(x => Char.IsDigit(x)).ToString();
        }

        private void BtnClearText_Click(object sender, EventArgs e)
        {
            RtboxInput.Text = "";
        }
    }
}

// Some output

//RtboxOutput.Text = string.Join(" ", booleanFunction.ValuesVector);
//RtboxOutput.Text += "\nE0: " + booleanFunction.IsE0().ToString();
//RtboxOutput.Text += "\nE1: " + booleanFunction.IsE1().ToString();
//RtboxOutput.Text += "\nE: " + booleanFunction.IsE().ToString();
//RtboxOutput.Text += "\nO0: " + booleanFunction.IsO0().ToString();
//RtboxOutput.Text += "\nO1: " + booleanFunction.IsO1().ToString();
//RtboxOutput.Text += "\nO01: " + booleanFunction.IsO01().ToString();
//RtboxOutput.Text += "\nOS: " + booleanFunction.IsOS().ToString();
//RtboxOutput.Text += "\nOM: " + booleanFunction.IsOM().ToString();
//RtboxOutput.Text += "\nO: " + booleanFunction.IsO().ToString();
//RtboxOutput.Text += "\nL01: " + booleanFunction.IsL01().ToString();
//RtboxOutput.Text += "\nL1: " + booleanFunction.IsL1().ToString();
//RtboxOutput.Text += "\nL0: " + booleanFunction.IsL0().ToString();
//RtboxOutput.Text += "\nLS: " + booleanFunction.IsLS().ToString();
//RtboxOutput.Text += "\nL: " + booleanFunction.IsL().ToString();
//RtboxOutput.Text += "\nSM: " + booleanFunction.IsSM().ToString();
//RtboxOutput.Text += "\nS01: " + booleanFunction.IsS01().ToString();
//RtboxOutput.Text += "\nS: " + booleanFunction.IsS().ToString();
//RtboxOutput.Text += "\nM01: " + booleanFunction.IsM01().ToString();
//RtboxOutput.Text += "\nM0: " + booleanFunction.IsM0().ToString();
//RtboxOutput.Text += "\nM1: " + booleanFunction.IsM1().ToString();
//RtboxOutput.Text += "\nM: " + booleanFunction.IsM().ToString();
//RtboxOutput.Text += "\nT01: " + booleanFunction.IsT01().ToString();
//RtboxOutput.Text += "\nT0: " + booleanFunction.IsT0().ToString();
//RtboxOutput.Text += "\nT1: " + booleanFunction.IsT1().ToString();
//RtboxOutput.Text += "\nA_2: " + booleanFunction.IsA_k(2).ToString();
//RtboxOutput.Text += "\nMA_2: " + booleanFunction.IsMA_k(2).ToString();
//RtboxOutput.Text += "\nA1_2: " + booleanFunction.IsA1_k(2).ToString();
//RtboxOutput.Text += "\nMA1_1: " + booleanFunction.IsMA1_k(2).ToString();
//RtboxOutput.Text += "\na_2: " + booleanFunction.Is_a_k(2).ToString();
//RtboxOutput.Text += "\nMa_2: " + booleanFunction.IsMa_k(2).ToString();
//RtboxOutput.Text += "\na0_2: " + booleanFunction.Is_a0_k(2).ToString();
//RtboxOutput.Text += "\nMa0_2: " + booleanFunction.IsMa0_k(2).ToString();
//RtboxOutput.Text += "\nP01: " + booleanFunction.IsP01().ToString();
//RtboxOutput.Text += "\nP0: " + booleanFunction.IsP0().ToString();
//RtboxOutput.Text += "\nP1: " + booleanFunction.IsP1().ToString();
//RtboxOutput.Text += "\nP: " + booleanFunction.IsP().ToString();
//RtboxOutput.Text += "\nP01_d: " + booleanFunction.IsP01_d().ToString();
//RtboxOutput.Text += "\nP0_d: " + booleanFunction.IsP0_d().ToString();
//RtboxOutput.Text += "\nP1_d: " + booleanFunction.IsP1_d().ToString();
//RtboxOutput.Text += "\nP_d: " + booleanFunction.IsP_d().ToString();