import UnityEngine

class FollowPlayerBoo (MonoBehaviour): 
	public Player as GameObject;
	def Start ():
		pass
	
	def Update ():
		//pass
		x as double=Player.GetComponent[of Transform]().position.x
		y as double=Player.GetComponent[of Transform]().position.y
		z as double=Player.GetComponent[of Transform]().position.z
		self.GetComponent[of Transform]().position=Vector3(x,y+8.235468,z-9.367381)
