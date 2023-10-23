namespace New_World_Armor_Weight_Calculator
{
    public partial class Form1 : Form
    {
        private readonly string[] ExpectedValues = { "Light", "Medium", "Heavy", "N/A" };
        private readonly double[] WeightClassThresholds = { 13, 22.9 };
        //Head,Chest,Gloves,Pants,Boots,Shield
        private readonly double[][] WeightValues = new double[][]
        {
            new double[] { 1.5, 3.5, 1.5, 2, 1.5, 2.7 },
            new double[] { 2.6, 6.2, 2.6, 3.5, 2.6, 5.4 },
            new double[] { 4.7, 11, 4.7, 6.3, 4.7, 11 },
            new double[] { 0,0,0,0,0,0},    //Prevents N/A from breaking stuff
        };
        public Form1()
        {
            InitializeComponent();
        }
        private void CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check for Data Miss Match
            if (!ExpectedValues.Contains(CBHelm.Text)
             || !ExpectedValues.Contains(CBChest.Text)
             || !ExpectedValues.Contains(CBGloves.Text)
             || !ExpectedValues.Contains(CBPants.Text)
             || !ExpectedValues.Contains(CBBoots.Text)
             || !ExpectedValues.Contains(CBShield.Text)
                )
            {
                if (sender is ComboBox cb)
                    cb.SelectedIndex = 0;
                MessageBox.Show("Invalid Data");
                return;
            }
            double FinalWeight = 0;
            FinalWeight += WeightValues[CBHelm.SelectedIndex][0];
            FinalWeight += WeightValues[CBChest.SelectedIndex][1];
            FinalWeight += WeightValues[CBGloves.SelectedIndex][2];
            FinalWeight += WeightValues[CBPants.SelectedIndex][3];
            FinalWeight += WeightValues[CBBoots.SelectedIndex][4];
            FinalWeight += WeightValues[CBShield.SelectedIndex][5];
            lblWeight.Text = $"Total Weight: {Math.Round(FinalWeight, 1)}";

            string WeightClass;
            if (FinalWeight < WeightClassThresholds[0])
                WeightClass = ExpectedValues[0];
            else if (FinalWeight > WeightClassThresholds[0] && FinalWeight < WeightClassThresholds[1])
                WeightClass = ExpectedValues[1];
            else
                WeightClass = ExpectedValues[2];
            lblClass.Text = $"Weight Class: {WeightClass}";
        }
    }
}