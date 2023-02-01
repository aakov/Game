using Godot;
using System;

public class Movement : KinematicBody2D
{
	
	[Export] public int speed = 400;

	public Vector2 velocity = new Vector2();
	int rotation = 0;
	public void Move()
	{
		velocity = new Vector2();
		
		//GetNode<Sprite>("Sprite").FlipH = true;
		
		if (Input.IsActionPressed("down"))
		{
			velocity.y++;
		}
		if (Input.IsActionPressed("up"))
		{
			velocity.y--;
		}	
		if (Input.IsActionPressed("right"))
		{
			velocity.x++;
			GetNode<Sprite>("Sprite").FlipH = false;
		}
		if (Input.IsActionPressed("left"))
		{
			velocity.x--;
			GetNode<Sprite>("Sprite").FlipH = true;
		}		
		
		if (Input.IsActionPressed("Attack"))
		{
			//enemyHealth -= 1;
			//Console.WriteLine("Attack");
			//Hide();
		//	var enemy = GetNode<Enemy>("Enemy");
			var game = GetTree().GetRoot().GetNode<Game>("Game");
			game.dealDamage();
		//	enemy.enemyHealth = enemy.enemyHealth - game.attack;
				
		}
		velocity = velocity.Normalized() * speed;
	}
	
	public override void _PhysicsProcess()
	{
		if (Input.IsActionPressed("Attack"))
		{
			//enemyHealth -= 1;
			//Console.WriteLine("Attack");
			//Hide();
		//	var enemy = GetNode<Enemy>("Enemy");
			var game = GetTree().GetRoot().GetNode<Game>("Game");
			game.dealDamage();
		//	enemy.enemyHealth = enemy.enemyHealth - game.attack;
				
		}/odpowiada za kolizje
	}
	
	public override void _unhandled_input(float delta)
	{
		Move();
		velocity = MoveAndSlide(velocity); //odpowiada za kolizje
	}
	
	
	
}
