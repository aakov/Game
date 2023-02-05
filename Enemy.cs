using Godot;
using System;

public class Enemy : Area2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	//public int d = 0;
	public bool hit = false;
	public bool damaged = false;
	public int enemyHealth = 10;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}
	
	public bool getDamaged(){
		return damaged;
	}
	
	public bool setDamaged(){
		damaged = false;
		return damaged;
	}
	
	public void respond(){
		if(enemyHealth <=0){
			Hide();
			damaged = false;
		}
		
	}
	
	public void _on_Area2D_body_entered(PhysicsBody2D body)
	{
		damaged = true;
		//Console.Write("hit");
		var game = GetTree().GetRoot().GetNode<Game>("Game");
		//hud.UpdateScore(1);
		//var hud = GetTree().GetRoot().GetNode<CanvasLayer>("CanvasLayer");
		//hud.Game.score = 3;
				//Hide();
		if(hit == false){
			//game.getScore();
			if(game.score > 1){
				//game.getScore();
				//Hide();
			}
			else {
				//return 0;
				 //GetTree().Quit(); 
			}	
		}
		//Hide();
		hit = true;
		
		if(enemyHealth < 0)
		{
			Hide();
		}
		 //var node = GetNode<CollisionShape2D>("CollisionShape2D");
		//de.Disabled = false;

		//eue_free();
		//damaged = false;
	}
	
	

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
