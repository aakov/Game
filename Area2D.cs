using Godot;
using System;

public class Area2D : Godot.Area2D
{
	bool hit = false;
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
			game.getScore();	
		}
		Hide();
		hit = true;
		 //var node = GetNode<CollisionShape2D>("CollisionShape2D");
		//de.Disabled = false;

		//eue_free();
	}
}
