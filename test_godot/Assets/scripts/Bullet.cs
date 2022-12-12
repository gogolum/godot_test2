using Godot;
using System;

public class Bullet : Node2D
{
	[Export]float speed = 1000;
	public float range = 1500;
	private float distanceTraveled = 0;
	
	public override void _Ready()
	{
		var area = GetNode<Area2D>("Area2D");
		area.Connect("area_entered", this,"OnCollision");
		area.Connect("body_entered", this,"OnCollision");
	}


 public override void _Process(float delta)
 {
	var chicken = GetTree().Root.GetNode("main").GetNode<Node2D>("chickenMob2").GetNode<KinematicBody2D>("KinematicBody2D");
	var enemy_pos = chicken.Position;
	LookAt(enemy_pos);
	 float MoveAmount = speed * delta;
	 GlobalPosition += Transform.x.Normalized() * MoveAmount;
	 distanceTraveled += MoveAmount;
	 if (distanceTraveled > range){
		QueueFree();
	 }
 }

 private void OnCollision(Node with){
 }
}
