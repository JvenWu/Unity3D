#pragma strict

function Start () {

}

var player:GameObject;
function Update () {
	var player_position:Vector3=player.transform.position;
	this.GetComponent(Transform).position=Vector3(player_position.x,
		player_position.y + 9.909719,
		player_position.z + -7.431555);
}