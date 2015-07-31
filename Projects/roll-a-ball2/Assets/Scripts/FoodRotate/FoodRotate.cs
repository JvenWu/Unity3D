using UnityEngine;
using System.Collections;

public class FoodRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Transform>().Rotate(Vector3.up);
	}
}
