extends KinematicBody2D

var velocity = Vector2()

func _physics_process(delta):
	
	if(move_and_collide(velocity*delta)):
		 print("Enemy killed ")
	
