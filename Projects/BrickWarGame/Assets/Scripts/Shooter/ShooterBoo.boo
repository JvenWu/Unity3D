import UnityEngine

class ShooterBoo (MonoBehaviour): 
	public shotPst as GameObject
	public force as double=1000
	public ball as GameObject
	def Start ():
		pass
	
	def Update ():
		//pass
		if (Input.GetButtonDown("Fire1")):
			create_Ball as GameObject=Instantiate(ball,shotPst.transform.position,Quaternion.identity)
			create_Ball.rigidbody.AddForce(force*shotPst.transform.forward)
			Debug.Log("<color=red>From Boo</color>")
