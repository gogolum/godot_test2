using Godot;
using System;

public class character : Node2D
{
	PackedScene bulletScene;
	PackedScene chikenMobFollow;
	Position2D enemy_pos;
	public override void _Ready()
	{
		bulletScene = GD.Load<PackedScene>("res://Bullet.tscn");
		chikenMobFollow = GD.Load<PackedScene>("res://chickenMob.tscn");
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

	public override void _UnhandledInput(InputEvent @event)
	{
		if (@event is InputEventMouseButton mouseEvent){
			if (mouseEvent.ButtonIndex == (int)ButtonList.Left && mouseEvent.Pressed){
				Bullet bullet = (Bullet)bulletScene.Instance();
				bullet.Position = Position + new Vector2(50,20);
				GetParent().AddChild(bullet);
				GetTree().SetInputAsHandled();
			}
		}
	}
}
