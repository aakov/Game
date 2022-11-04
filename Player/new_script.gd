extends KinematicBody2D

export (int) var speed = 400
var velocity = Vector2()


func get_input():
		
	velocity = Vector2()
	#position.x = clamp(position.x, -448, 1000)
	#position.y = clamp(position.y, -256, 256)
	if Input.is_action_pressed("right"):
		velocity.x += 1
	if Input.is_action_pressed("left"):
		velocity.x -= 1
	if Input.is_action_pressed("down"):
		velocity.y += 1
	if Input.is_action_pressed("up"):
		velocity.y -= 1
	velocity = velocity.normalized() * speed
 


func _physics_process(delta):
	
	get_input()
	#if(move_and_collide(velocity*delta)):
		 #print("I collided with ")
	velocity = move_and_slide(velocity)	
		
	
