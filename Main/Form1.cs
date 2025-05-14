#nullable disable

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
        int BoxNumber = 1;

        for (int BoxRow = 0; BoxRow < 3; BoxRow++)
        {
            for (int BoxCol = 0; BoxCol < 3; BoxCol++)
            {
                TableLayoutPanel CurrentBox = Controls.Find($"Box{BoxNumber}", true).FirstOrDefault() as TableLayoutPanel;
                if (CurrentBox == null) continue;

                CurrentBox.Controls.Clear();
                CurrentBox.RowCount = 3;
                CurrentBox.ColumnCount = 3;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        int GlobalRow = BoxRow * 3 + i;
                        int GlobalCol = BoxCol * 3 + j;

                        TextBox NumberInput = new TextBox()
                        {
                            MaxLength = 1,
                            TextAlign = HorizontalAlignment.Center,
                            Font = new Font("Segoe UI", 18F, FontStyle.Regular),
                            Size = new Size(40, 40),
                            AutoSize = false,
                            Margin = new Padding(0),
                            Name = $"TextBox_{GlobalRow}_{GlobalCol}_Box{BoxNumber}"
                        };

                        NumberInput.KeyPress += (s, e) =>
                        {
                            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar); // Allow only numbers
                        };

                        CurrentBox.Controls.Add(NumberInput, j, i);
                    }
                }

                BoxNumber++;
            }
        }
    }


    private void SolveButton_Click (object sender, EventArgs e)
    {

    }

    private void ResetButton_Click (object sender, EventArgs e)
    {
        
    }

/*
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
                    CheckRow(TextBoxNumber);
                    TextBox.Text = "1";
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
            var Position = tableLayoutPanel1.GetPositionFromControl(Control);
            var CellText = Convert.ToInt32(tableLayoutPanel1.GetControlFromPosition(ColNumber, RowNumber).Text);


            if (Position.Column == ColNumber && CellValue == CellText)
            {
                
            }
            else
            {
                for (int i = 1; i < 10; i++)
                {
                    CellValue = i;
                }
            }
        }
    }
*/
}