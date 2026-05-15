namespace TaskWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            TodayDatePicker.Value = DateTime.Now;
            TodayDatePicker.MaxDate = TodayDatePicker.Value;
        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {
            //Вы *Ваша фамилия*
            string outputInfo;

            string lastName = string.IsNullOrEmpty(LastNameBox.Text) ? "Смурова" /*Меняй на свою фамилию!*/ : LastNameBox.Text;
            outputInfo = "Вы " + lastName + ".";
            OutputBox.Items.Add(outputInfo);

            //Вы прожили *Дни вашей жизни* дней
            DateTime birthDate = BirthDatePicker.Value;
            DateTime todayDate = TodayDatePicker.Value;
            int days = (todayDate.Year - birthDate.Year) * 365;
            outputInfo = "Вы прожили " + days + " дней.";
            OutputBox.Items.Add(outputInfo);

            //Вы хотите учиться ещё *Кол-во желаемых для учёбы дней* дней
            int wantedDays = int.Parse(StudyingDaysBox.Text);
            outputInfo = "Вы хотите учиться ещё " + wantedDays + " дней.";
            OutputBox.Items.Add(outputInfo);

            //Вы станете очень умными *Когда-то*
            todayDate.AddDays(wantedDays);
            outputInfo = "Вы станете очень умным " + todayDate + ".";
            OutputBox.Items.Add(outputInfo);

            //Это будет в *Когда-то*
            outputInfo = "Это будет в " + todayDate.DayOfWeek + ".";
            OutputBox.Items.Add(outputInfo);

            //Если не все поняли, то...! Делайте че хотите, господи :(
            outputInfo = "Если не всё поняли, то откройте словарик :)";
            OutputBox.Items.Add(outputInfo);
        }
    }
}
