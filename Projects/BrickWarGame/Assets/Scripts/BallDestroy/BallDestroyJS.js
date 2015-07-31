#pragma strict
var liveDuration:float=4f;
function Start () {
	GameObject.Destroy(this.gameObject,liveDuration);
	Debug.Log("<color=green>From JS</color>");
}

function Update () {

}