namespace Program_4_Idea_Lo_Shu_Squares.Pages;

//Used to setup types of modes.
public enum GameMode { EASY, MEDIUM, HARD};

public partial class GamePage : ContentPage
{
	GameMode mode;

	public GamePage(GameMode mode = GameMode.EASY)
	{
		InitializeComponent();
		//This passes the game mode selection from the main menu to the game page. 
		this.mode = mode;
	}
}