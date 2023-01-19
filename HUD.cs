using Godot;
using System;

public class HUD : Godot.CanvasLayer
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	public void UpdateScore(int score)
	{
		GetNode<Label>("ScoreLabel").Text = "Score: " + score.ToString();
	}
	
	public void UpdateAttack(int attack)
	{
		GetNode<Label>("AttackLabel").Text = "Attack: " + attack.ToString();
	}
	
	
}
