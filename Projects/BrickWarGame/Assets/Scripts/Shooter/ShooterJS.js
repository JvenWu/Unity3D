#pragma strict
var shotPst:GameObject;
var force:float=1000f;
var ball:GameObject;
function Start () {

}

function Update () {
	if(Input.GetButtonDown("Fire1")){
		var create_Ball:GameObject=Instantiate(ball,shotPst.transform.position,Quaternion.identity);
		create_Ball.rigidbody.AddForce(force*shotPst.transform.forward);
		Debug.Log("<color=red>From JS</color>");
	}
}