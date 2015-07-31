#pragma strict
var verticalSpeed:float=10f;
var horizontalSpeed:float=10f;
function Start () {

}

function Update () {
	var h:float=Input.GetAxis("Horizontal")*horizontalSpeed*Time.deltaTime;
	var v:float=Input.GetAxis("Vertical")*verticalSpeed*Time.deltaTime;
	this.transform.Translate(Vector3(h,v,0));
	Debug.Log("<color=yellow>From JS</color>");
}