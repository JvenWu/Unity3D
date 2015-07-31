import UnityEngine

class EatFoodBoo (MonoBehaviour): 

	def Start ():
		pass
	
	def Update ():
		pass
	private count as int=0
	def nTriggerEnter(other as Collider):
		if(other.gameObject.name=="Food"):
			GameObject.Destroy(other.gameObject)
			count++
			Debug.Log("<color=yellow>"+count+"</color>");
			if(count>8):
				Debug.Log("<color=green>Game win</color>");
			
