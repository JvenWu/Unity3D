using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal_move = Input.GetAxis("Horizontal");
        float vertical_move = Input.GetAxis("Vertical");
        this.rigidbody.AddForce(new Vector3(horizontal_move, 0, vertical_move) * 10f);
        Debug.Log("<color=red>Horizontal" + horizontal_move + "</color>");
	}
}
