import UnityEngine

class EatFoodBoo (MonoBehaviour): 
	private count as int=0
	def Start ():
		pass
	
	def Update ():
		pass
		
	def OnTriggerEnter(other as Collider):
		food as GameObject=other.gameObject
		if(food.name=="Food"):
			GameObject.Destroy(food)
			count++
			Debug.Log("<color=green>Eat("+count+")</color>")
		if(count==10):
			Debug.Log("<color=green>Game Win??</color>");
		
