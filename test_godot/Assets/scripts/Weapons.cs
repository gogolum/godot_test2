using Godot;
using System;

public class Weapons : Node2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.

	PackedScene bulletScene;
	public override void _Ready()
	{
		bulletScene = GD.Load<PackedScene>("res://Bullet.tscn");
	}


	public override void _Process(float delta)
 {
	 
 }

	public override void _UnhandledInput(InputEvent @event)
	{
		if (@event is InputEventMouseButton mouseEvent){
			if (mouseEvent.ButtonIndex == (int)ButtonList.Left && mouseEvent.Pressed){
				Bullet bullet = (Bullet)bulletScene.Instance();
				bullet.Position = Position;
				bullet.Rotation = Rotation;
				GetParent().AddChild(bullet);
				SetAsToplevel(true);	
				GetTree().SetInputAsHandled();
			}
		}
	}
}
