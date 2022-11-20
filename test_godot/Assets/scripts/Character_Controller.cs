using Godot;
using System;

public class Character_Controller : Sprite
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.

	

	public override void _Ready()
	{
		
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta)
	{
		float speed = 1000 * delta;
	 int vie = 1;
	  Vector2 movePlayer = new Vector2(0,0);
		if (Input.IsKeyPressed((int)KeyList.Z))
		{
			movePlayer.y -= speed;
		}
		if (Input.IsKeyPressed((int)KeyList.S))
		{
			movePlayer.y += speed;
		}
		if (Input.IsKeyPressed((int)KeyList.Q))
		{
			movePlayer.x -= speed;
			this.FlipH = true;
		}
		if (Input.IsKeyPressed((int)KeyList.D))
		{
			movePlayer.x += speed;
			this.FlipH = false;
		}
		this.Position += movePlayer.Normalized()*speed;
	}
}
