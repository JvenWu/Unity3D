#pragma strict
var Force:float=10f;
function Start () {

}

function Update () {
	var move_horizontal:float=Input.GetAxis("Horizontal");
	var move_vertical:float=Input.GetAxis("Vertical");
	this.rigidbody.AddForce(new Vector3(move_horizontal,0,move_vertical)*Force);
}