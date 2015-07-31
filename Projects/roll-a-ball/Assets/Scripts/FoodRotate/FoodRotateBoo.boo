import UnityEngine

class FoodRotateBoo (MonoBehaviour): 

	def Start ():
		pass
	
	def Update ():
		//pass
		//self.transform.Rotate(Vector3.up)
		self.GetComponent[of Transform]().Rotate(Vector3.up)
