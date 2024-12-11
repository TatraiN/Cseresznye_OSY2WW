using WinFormsAppColor.BookModels;

namespace WinFormsAppColor
{
    public partial class Form1 : Form
    {
        FunnyDatabaseContext context = new FunnyDatabaseContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDel fd = new FormDel();
            fd.Show();
            if (button1.DialogResult == DialogResult.OK)
            {
                colorsAndMeaningBindingSource.RemoveCurrent();
            }
            context.SaveChanges();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colorsAndMeaningBindingSource.DataSource = context.ColorsAndMeanings.ToList();
        }
    }
}