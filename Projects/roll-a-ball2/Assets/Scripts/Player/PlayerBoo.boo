import UnityEngine

class PlayerBoo (MonoBehaviour): 
	public Force as double=10
	def Start ():
		pass
	
	def Update ():
		//pass
		move_horizontal as double=Input.GetAxis("Horizontal")
		move_vertical as double=Input.GetAxis("Vertical")
		self.rigidbody.AddForce(Vector3(move_horizontal,0,move_vertical)*Force)
