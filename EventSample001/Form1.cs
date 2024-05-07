namespace EventSample001
{
    public partial class Form1 : Form
    {
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    public partial class Form1 : Form
    {
        private MyClass obj;
        public Form1()
        {
            InitializeComponent();
            obj = new MyClass();
            obj.XChanged += Obj_XChanged;
        }

        private void Obj_XChanged(object sender, EventArgs e)
        {
            MessageBox.Show("xªº­È§ïÅÜ");
        }

        private void button_Click(object sender, EventArgs e)
        {
            obj.x += 1;
        }

    }
}
