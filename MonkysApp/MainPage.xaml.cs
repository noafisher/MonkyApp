using MauiApp2;
namespace MonkysApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        List <Monkey> monkeyList;
        public MainPage()
        {
            InitializeComponent();
            monkeyList = Monkey.GetMonkeys();
            MonkeyPic.Source = monkeyList[count].Image;
        }

        private void UpBtn(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            count++;
            MonkeyPic.Source = monkeyList[count].Image;
            if (count == monkeyList.Count - 1)
            {
                bt.IsEnabled = false;
            }
            else
            {
                bt.IsEnabled = true;
            }

        }

        private void DownBtn(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            count--;
            MonkeyPic.Source = monkeyList[count].Image;
            if (count == 0)
            {
                bt.IsEnabled = false;
            }
            else
            {
                bt.IsEnabled = true;
            }

        }
    }
}