#pragma strict

function Start () {

}

function Update () {
	var horizontal_move:float=Input.GetAxis("Horizontal");
	var vertical_move:float=Input.GetAxis("Vertical");
	this.rigidbody.AddForce(new Vector3(horizontal_move,0,vertical_move)*10.0);
	Debug.Log("<color=red>Vertical :"+vertical_move+"</color>");
}