using Godot;
using System;

public class Character_Controller : Sprite
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.

	public Vector2 ScreenSize;

	public override void _Ready()
	{
		ScreenSize = GetViewportRect().Size;
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(float delta)
	{
		float speed = 10;

		if (Input.IsActionPressed("move_up"))
		{
			this.Position += new Vector2(0,-speed);
		}
		if (Input.IsActionPressed("move_down"))
		{
			this.Position += new Vector2(0,speed);
		}
		if (Input.IsActionPressed("move_left"))
		{
			this.Position += new Vector2(-speed,0);
			this.FlipH = true;
		}
		if (Input.IsActionPressed("move_right"))
		{
			this.Position += new Vector2(speed,0);
			this.FlipH = false;
		}
		
	}
}
