namespace Main;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    public struct BoxData
    {
        public int RowNumber { get; set; }
        public int ColNumber { get; set; }
        public int CellValue { get; set; }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        // Generate Rows and Columns
        for (int Row = 0; Row < 9; Row++)
        {
            for (int Col = 0; Col < 9; Col++)
            {
                TextBox NumberInput = new TextBox()
                {
                    MaxLength = 1,
                    TextAlign = HorizontalAlignment.Center,
                    Size = new Size(40, 40),
                    Name = $"textBox_{Row}_{Col}"
                };
                tableLayoutPanel1.Controls.Add(NumberInput, Col, Row);
            }
        }
    }

    private void SolveButton_Click (object sender, EventArgs e)
    {
        List<int> CurrentNumbers = new List<int>();
        CurrentNumbers.Clear();
        foreach (Control Control in tableLayoutPanel1.Controls)
        {
            if (Control is TextBox TextBox)
            {
                var TextBoxNumber = TextBox.Name.Split("_");
                
                if (TextBox.Text != "") // If theres a number in a textbox
                {
                    // MessageBox.Show($"A number is here in box {TextBoxNumber[2]}, the number in the box is {TextBox.Text}");
                }
                else
                {
                    TextBox.Text = "1";
                    CheckRow(TextBoxNumber);
                }
            }
        }
    }

    private void ResetButton_Click (object sender, EventArgs e)
    {

    }

    private void SolveRow (bool NumberAvaliable)
    {
        if (NumberAvaliable)
        {

        }
    }
    
    private void CheckRow (string[] TextBoxNumber)
    {
        foreach (Control Controls in tableLayoutPanel1.Controls)
        {
            if (Controls is TextBox TextBoxs)
            {
                if (Convert.ToInt32(TextBoxNumber[1]) == 0) // if the current row is 0
                {
                    CheckCell(TextBoxNumber);
                }
            }
        }
    }

    private void CheckCell (string[] TextBoxNumber)
    {
        List<BoxData> BoxData = new List<BoxData>();

        foreach (Control Control in tableLayoutPanel1.Controls)
        {
            int RowNumber = Convert.ToInt32(TextBoxNumber[2]);
            int ColNumber = Convert.ToInt32(TextBoxNumber[1]);
            int CellValue = Convert.ToInt32(Control.Text); // how to fix this
            BoxData.Add(new BoxData { RowNumber = RowNumber, ColNumber = ColNumber, CellValue = CellValue, });
        }
    }  
}