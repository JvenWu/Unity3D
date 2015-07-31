#pragma strict

function Start () {

}

function Update () {

}
var count:int=0;
function OnTriggerEnter(other:Collider){
	if(other.gameObject.name=="Food"){
		GameObject.Destroy(other.gameObject);
		count++;
		Debug.Log("<color=yellow>"+count+"</color>");
		if(count>8){
			Debug.Log("<color=green>Game win</color>");
		}
	}
}