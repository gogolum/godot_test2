using Godot;
using System;

public class Weapons : Node2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.

	PackedScene bullet_scene;
	public override void _Ready()
	{
		bullet_scene = GD.Load<PackedScene>("res://Bullet.tscn");
	}

	//  // Called every frame. 'delta' is the elapsed time since the previous frame.
	//  public override void _Process(float delta)
	//  {
	//      
	//  }

	public override void _UnhandledInput(InputEvent @event)
	{
		if (@event is InputEventMouseButton mouseEvent){
			if (mouseEvent.ButtonIndex == (int)ButtonList.Left && mouseEvent.Pressed){
				GD.Print("left button press");
			}
		}
	}
}
