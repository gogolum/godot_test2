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
		float speed = 10;
<<<<<<< Updated upstream:test_godot/scripts/Character_Controller.cs

=======
	  	Vector2 movePlayer = new Vector2(0,0);
>>>>>>> Stashed changes:test_godot/Assets/scripts/Character_Controller.cs
		if (Input.IsKeyPressed((int)KeyList.Z))
		{
			this.Position += new Vector2(0,-speed);
		}
		if (Input.IsKeyPressed((int)KeyList.S))
		{
			this.Position += new Vector2(0,speed);
		}
		if (Input.IsKeyPressed((int)KeyList.Q))
		{
			this.Position += new Vector2(-speed,0);
			this.FlipH = true;
		}
		if (Input.IsKeyPressed((int)KeyList.D))
		{
			this.Position += new Vector2(speed,0);
			this.FlipH = false;
		}
		
	}
}
