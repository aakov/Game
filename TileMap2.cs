using Godot;
using System;

public class TileMap2 : TileMap
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	//var map = [];
	//var rooms = []; 


	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Randomize();
		Random rnd = new Random();
	 	for (int i = 0; i < 10000; i++)
		{
			int x = rnd.Next(-100,100);
			int y = rnd.Next(-100,100);
		 	if(x == 1 || x== -1 || x == 0 || y == 1 || y== -1 || y == 0){
				
			}
			else{
				SetCell(x,y,2);
			}
			
		}
		for(int i = 0; i < 100; i++){
			var scene = GD.Load<PackedScene>("res://Heart.tscn");
			int x = rnd.Next(-100,100);
			int y = rnd.Next(-100,100);
			Area2D node = (Area2D)scene.Instance();
			node.Position = new Vector2(x*64,y*64);
			AddChild(node);
		}
		for(int i = 0; i < 100; i++){
			var scene = GD.Load<PackedScene>("res://Sword.tscn");
			int x = rnd.Next(-100,100);
			int y = rnd.Next(-100,100);
			Sword node = (Sword)scene.Instance();
			node.Position = new Vector2(x*64,y*64);
			AddChild(node);
		}
		
	}
	
	//void set_cell(20,20,false,false, false, (0,0));
	//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
