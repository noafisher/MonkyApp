using MauiApp2;
using System.Runtime.CompilerServices;

namespace MonkysApp;

public partial class MonkeyPics2 : ContentPage
{
	int count = 0;
	List<Monkey> MonkeyList;

	public MonkeyPics2()
	{
		InitializeComponent();
		MonkeyList = Monkey.GetMonkeys();
		InitializeControl();


    }
	private void InitializeControl()
	{
		StackLayout stk = new StackLayout();
		stk.BackgroundColor = Colors.LightGreen;
		
		Button UpBtn = new Button();
		UpBtn.BackgroundColor = Colors.ForestGreen;
		UpBtn.Text = "UP";
		UpBtn.BorderColor = Colors.Black;
		UpBtn.BorderWidth = 2;

        Button DownBtn = new Button();
        DownBtn.BackgroundColor = Colors.ForestGreen;
        DownBtn.Text = "DOWN";
        DownBtn.BorderColor = Colors.Black;
		DownBtn.BorderWidth = 2;


        Image img = new Image();
		img.HeightRequest = 350;

		stk.Children.Add(UpBtn);
		stk.Children.Add(img);
		stk.Children.Add(DownBtn);
	}
	private void ClickedUp(Object sender, EventArgs e)
	{
		StackLayout stk = (StackLayout)this.Content;
        Button bt = (Button)sender;
		Image img = (Image)stk.Children[1];
        count++;
        img.Source = MonkeyList[count].Image;
        if (count == MonkeyList.Count - 1)
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
        StackLayout stk = (StackLayout)this.Content;
        Button bt = (Button)sender;
        Image img = (Image)stk.Children[1];
        count--;
        img.Source = MonkeyList[count].Image;
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