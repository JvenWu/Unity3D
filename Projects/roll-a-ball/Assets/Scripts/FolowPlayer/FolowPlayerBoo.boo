import UnityEngine

class FolowPlayerBoo (MonoBehaviour): 
	
	
	def Start ():
		pass
	public player as GameObject
	def Update ():
		player_position as Vector3=player.transform.position
		self.GetComponent(Transform).position=Vector3(player_position.x,player_position.y + 9.909719f,player_position.z + -7.431555f)
		//第二种写法self.GetComponent[of Transform]()
		//pass
