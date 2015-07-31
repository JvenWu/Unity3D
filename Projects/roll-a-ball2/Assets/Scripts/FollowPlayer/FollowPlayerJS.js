#pragma strict
var Player:GameObject;
function Start () {

}

function Update () {
	var x:float=Player.transform.position.x;
	var y:float=Player.transform.position.y;
	var z:float=Player.transform.position.z;
	this.transform.position=new Vector3(x,y+8.235468f,z-9.367381f);
}