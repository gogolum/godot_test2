using Godot;
using System;

public class chickenMob : Node2D
{
	//PackedScene characterScene;
	public override void _Ready()
	{
		//characterScene = GD.Load<PackedScene>("res://character.tscn");
	}


	public override void _Process(float delta)
	{
	  //character Character = (character)characterScene.Instance();
	   var character = GetNode<character>("../character");
	  float speed = 100;
	  float moveAmount = speed*delta;
	  Vector2 moveDirection = (character.Position - Position).Normalized();
	  Position += moveDirection*moveAmount;
	}
}
