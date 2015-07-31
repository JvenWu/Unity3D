import UnityEngine

class BallDestroyBoo (MonoBehaviour): 
	public liveDuration as double=4
	def Start ():
		//pass
		GameObject.Destroy(self.gameObject,liveDuration)
		Debug.Log("<color=green>From Boo</color>")
	
	def Update ():
		pass
