using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {
	public GameObject shotPst;
	public float force=1000f;
	public GameObject ball;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Fire1")) {
			GameObject created_Ball = Instantiate (ball, shotPst.transform.position, Quaternion.identity) as GameObject;
			created_Ball.rigidbody.AddForce (force * shotPst.transform.forward);
			Debug.Log("<color=red>From C##</color>");
		}

	}
}
