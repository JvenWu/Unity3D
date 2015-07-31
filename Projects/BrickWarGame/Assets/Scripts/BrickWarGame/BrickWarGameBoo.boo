import UnityEngine

class BrickWarGameBoo (MonoBehaviour): 
	public brick as GameObject
	private columnNum as int=4
	private rowNum as int=7
	def Start ():
		//pass
		//Instantiate(brick,Vector3(0,0,0),Quaternion.identity)
		Debug.Log("<color=red>From Boo</color>")
		i as int=0
		//j as int=0
		//for i in range(columnNum):
			//for j in range(rowNum):
				//Instantiate(brick,Vector3(j-3,0.5f+i,0),Quaternion.identity)
		while i<columnNum:
			j as int=0
			while j<rowNum:
				Instantiate(brick,Vector3(j-3,0.5f+i,0),Quaternion.identity)
				j++
				Debug.Log("<color=yellow>"+i+":"+j+"</color>")
			i++
				
	
	def Update ():
		pass
