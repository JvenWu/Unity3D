using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {
	public float verticalSpeed=10;
	public float horizontalSpeed=10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float h = Input.GetAxis ("Horizontal") * horizontalSpeed*Time.deltaTime;
		float v = Input.GetAxis ("Vertical") * verticalSpeed*Time.deltaTime;
		this.transform.Translate (new Vector3 (h, v, 0));
	}
}
