using UnityEngine;
using System.Collections;

public class BallDestroy : MonoBehaviour {
	public float liveDuration=4f;
	// Use this for initialization
	void Start () {
		GameObject.Destroy (this.gameObject, liveDuration);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
