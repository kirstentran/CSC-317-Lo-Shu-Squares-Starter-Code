using System.ComponentModel.Design;

namespace Program_4_Idea_Lo_Shu_Squares.Pages;

public partial class MainMenuPage : ContentPage
{
	public MainMenuPage()
	{
		InitializeComponent();
	}

	private void StartGame(object sender, EventArgs e)
	{
		GameMode mode;

		if (rdoEasy.IsChecked)
			mode = GameMode.EASY;
		else if (rdoNormal.IsChecked)
			mode = GameMode.MEDIUM;
		else if (rdoHard.IsChecked)
			mode = GameMode.HARD;
		else
			mode = GameMode.EASY;

		App.Current.MainPage = new Pages.GamePage(mode);
	}

	private void EnableStartGame(object sender, CheckedChangedEventArgs e)
	{
		if (rdoEasy.IsChecked || rdoNormal.IsChecked || rdoHard.IsChecked)
			btnStartGame.IsEnabled = true;
		else
			btnStartGame.IsEnabled = false;
	}

	private void ExitGame(object sender, EventArgs e)
	{
		Application.Current.Quit();
	}

	private void ShowInstructions(object sender, EventArgs e)
	{
		App.Current.MainPage = new Pages.InstructionsPage();
	}

	private void ShowLeaderboards(object sender, EventArgs e)
	{
		App.Current.MainPage = new Pages.LeaderboardsPage();
	}
}