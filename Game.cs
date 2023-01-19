using Godot;
using System;

public class Game : Node2D
{
	// Declare member variables here. Examples:
	public int score = 0;
	public int attack = 0;
	public int health = 0;
	public int speed = 400;
	// private string b = "text";
	public void getScore()
	{
		score++;
		var hud = GetNode<HUD>("HUD");
		hud.UpdateScore(score);
	}
	
	public void updateAttackPower()
	{
		attack++;
		var hud = GetNode<HUD>("HUD");
		hud.UpdateAttack(attack);
	}
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
