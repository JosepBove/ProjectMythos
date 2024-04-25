using Godot;
using System;

public partial class HealthComponent : Node
{

 [Export]
	private double MaxHealth;
	private double Health;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Health = MaxHealth;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		GD.Print(Health);
	}

	public void Damage(double amount) {
		Health -= amount;
	}

	public void Heal(double amount) {

	}
}
