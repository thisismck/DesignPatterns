namespace Observable
{
    public partial class Form1 : Form
    {
        public static IObservable Observable = new ColorObservable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonNet_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int red = random.Next(0, 255);
            int green = random.Next(0, 255);
            int blue = random.Next(0, 255);

            Color color = Color.FromArgb(red, green, blue);


            Form2 form2 = new Form2();
            form2.Show();

            Observable.Subscribe(form2);
            Observable.Notify(color);
            //wait 1 second
            Observable.Unsubscribe(form2);

            //buttonColor_Click(sender, e);


        }
    }
}
