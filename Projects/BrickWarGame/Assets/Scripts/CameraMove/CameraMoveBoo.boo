import UnityEngine

class CameraMoveBoo (MonoBehaviour): 
	public horizontalSpeed as double=10
	public verticalSpeed as double=10
	def Start ():
		pass
	
	def Update ():
		//pass
		h as double=Input.GetAxis("Horizontal")*horizontalSpeed*Time.deltaTime
		v as double=Input.GetAxis("Vertical")*verticalSpeed*Time.deltaTime
		self.transform.Translate(Vector3(h,v,0))
		Debug.Log("<color=yellow>From Boo</color>")
