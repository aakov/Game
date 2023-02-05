using Godot;
using System;

public class Game : Node2D
{
#pragma warning disable 649
[Export]
	public Godot.TileMap tile_map;	
//	[Export] public PackedScene HeartScene;
	// Declare member variables here. Examples:
	//var scene = GD.Load<PackedScene>("res://Heart.tscn");
	public int score = 10;
	public int attack = 0;
	public int health = 10;
	public int speed = 400;
	//TileMap tile_map
	[Export]
	public Vector2 tMapSize;


	int width, height;
	Random rnd;

	Vector2[] BoundsInt;
	int[,] terrainMap;
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

	public void dealDamage()
	{
		//var enemyHealth = enemyHealth - attack;
		var hud = GetNode<HUD>("HUD");
		var enemy = GetNode<Enemy>("Enemy");
		if(enemy.getDamaged() == true)
		{
			enemy.enemyHealth = enemy.enemyHealth - attack;
			score--;
			hud.UpdateScore(score);
			enemy.respond();
			if(health < 0){
						
			}
		}
				
	}
	
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var sword = GetNode<Sword>("Sword");
		sword.Position =new Vector2(3,3);
	//	var heart = HeartScene.Instance();
		//var scene = GD.Load<PackedScene>("res://Heart.tscn");
			
		//Area2D node = (Area2D)scene.Instance();
		//node.Position = new Vector2(128,1);
		//node.GetNode<Area2D>.Position;
		//Vector2 pos = [128,128];
		//node.Position.y = 128;
		//node.Position.x = 128;
		//node.position = pos;
		
		//AddChild(node);
		//node.GetNode<Heart>.position = Vector2(128,128);
		// GD.Randomize();
		//build_map();
		//tile_map.SetCell(4,4,0);
	//	 var heart = Heart.Instance();
	//	 heart.position.x = 100;
	//	heart.position.y = 100;
		// AddChild(heart);
	}
	
	public void build_map(){
		// tile_map.SetCell(4,4,0);
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
