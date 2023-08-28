namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SaveButton saveButton = new SaveButton(this.Width, this.Height);


            this.Controls.Add(saveButton);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }

    public class SaveButton : Button
    {
        public SaveButton(int formWidth, int formHeight)
        {
            this.BackColor = Color.Green;
            this.ForeColor = Color.White;

            Font font1 = new Font(FontFamily.GenericSerif, 12);

            this.Font = font1;

            this.Height = 42;
            this.Text = "Kaydet";

            formWidth /= 3;
            this.Left = formWidth;
            formHeight /= 5;
            this.Top = formHeight * 4;


        }
    }
}