using Godot;
using System;

public class Sword : Area2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	bool hit = false;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}
	
	
	public void _on_Area2D_body_entered(PhysicsBody2D body)
	{
		//Console.Write("hit");
		var game = GetTree().GetRoot().GetNode<Game>("Game");
		//hud.UpdateScore(1);
		//var hud = GetTree().GetRoot().GetNode<CanvasLayer>("CanvasLayer");
		//hud.Game.score = 3;
				//Hide();
		if(hit == false){
			game.updateAttackPower();	
		}
		Hide();
		hit = true;
		 //var node = GetNode<CollisionShape2D>("CollisionShape2D");
		//de.Disabled = false;

		//eue_free();
	}
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
