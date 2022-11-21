using Godot;
using System;

public class Character_Controller : Sprite
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.

	[Export] public float speed = 1000;
	PackedScene weapon_scene;


	public override void _Ready()
	{
		weapon_scene = GD.Load<PackedScene>("res://Weapons.tscn");
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta)
	{
		float player_speed = speed * delta;
	  Vector2 movePlayer = new Vector2(0,0);
		if (Input.IsKeyPressed((int)KeyList.Z))
		{
			movePlayer.y -= player_speed;
		}
		if (Input.IsKeyPressed((int)KeyList.S))
		{
			movePlayer.y += player_speed;
		}
		if (Input.IsKeyPressed((int)KeyList.Q))
		{
			movePlayer.x -= player_speed;
			this.FlipH = true;
		}
		if (Input.IsKeyPressed((int)KeyList.D))
		{
			movePlayer.x += player_speed;
			this.FlipH = false;
		}
		this.Position += movePlayer.Normalized()*player_speed;

		Weapons weapons = (Weapons)weapon_scene.Instance();
		weapons.Position = Position;
		weapons.Rotation = Rotation;
	}
}
