using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    public float Force = 10f;
	// Use this for initialization
	void Start () {
        Debug.Log("<color=red>Game Start</color>");
	}
	
	// Update is called once per frame
	void Update () {
        float move_horizontal=Input.GetAxis("Horizontal");
        float move_vertical=Input.GetAxis("Vertical");
        this.rigidbody.AddForce(new Vector3(move_horizontal, 0, move_vertical) * Force);
        //Debug.Log("<color=yellow>Horizontal:" + move_horizontal + "|Vertical:" + move_vertical + "</color>");
	}
}
