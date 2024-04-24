using Godot;

public partial class village : Node2D
{
	private Area2D teleporter;
	private Area2D playerArea;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		CharacterBody2D player = GetNode<CharacterBody2D>("Player");
		teleporter = GetNode<Area2D>("Teleporter");

		playerArea = player.GetChild<Area2D>(0);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void Hello() {

	}
	public void OnTeleporterAreaEntered(Area2D area)
	{
		if(area == playerArea) GetTree().ChangeSceneToFile("res://scenes/loading.tscn");
	}
}
