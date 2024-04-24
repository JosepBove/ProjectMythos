using System;
using Godot;

public partial class player : CharacterBody2D
{
	public const float Speed = 300.0f;

	private ShaderMaterial selectedMat = GD.Load<ShaderMaterial>("res://materials/selected.tres");
	//private AnimatedSprite2D animation;


	public override void _Ready()
	{
		//game_manager.player = player;
	}

	public override void _Process(double delta)
	{
		selectedMat.SetShaderParameter("globalMousePos", GetGlobalMousePosition());

		/*
		if(Input.IsActionPressed(MouseButton.Left))
		{
			GD.Print("CLICK");
		}*/
	}

	public override void _Input(InputEvent @event)
	{
		if (@event is InputEventMouseButton mouseEvent && mouseEvent.ButtonIndex == MouseButton.Left && mouseEvent.Pressed)
		{
			Vector2 viewport = GetViewport().GetMousePosition();
			// get tilemap here and then call setcell

			GD.Print("Clicked");
		}
  }

    public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		Vector2 direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
		
		if (direction != Vector2.Zero)
		{
			velocity.X = direction.X * Speed;
			velocity.Y = direction.Y * Speed;
		}
		else
		{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
			velocity.Y = Mathf.MoveToward(Velocity.Y, 0, Speed);
		}

		Velocity = velocity;
		MoveAndSlide();
	}
}
