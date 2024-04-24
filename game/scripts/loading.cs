using Godot;
using System;

public partial class loading : Control
{

	private double timer = 0;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		timer += delta;

		if(timer >= 3) {
			timer = 0;
			GetTree().ChangeSceneToFile("res://scenes/village.tscn");
		}
	}
}
