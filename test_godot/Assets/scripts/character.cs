using Godot;
using System;

public class character : Node2D
{
		public override void _Ready()
	{
		
	}
	[Export] public float speed = 1000;
	[Export] public float vie = 3;

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
		}
		if (Input.IsKeyPressed((int)KeyList.D))
		{
			movePlayer.x += player_speed;
		}
		this.Position += movePlayer.Normalized()*player_speed;
	}

}
