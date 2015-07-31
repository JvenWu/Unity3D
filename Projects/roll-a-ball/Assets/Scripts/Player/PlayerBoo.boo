import UnityEngine
import System.Collections
class PlayerBoo (MonoBehaviour): 

	def Start ():
		pass
		
	def Update () as void:
		horizontal_move as double = Input.GetAxis("Horizontal")
		vertical_move as double = Input.GetAxis('Vertical')
		self.rigidbody.AddForce(Vector3(horizontal_move,0,vertical_move)*10.0)
		//Debug.Log("<color=yellow>H:V="+horizontal_move+":"+vertical_move+"</color>")
		//pass