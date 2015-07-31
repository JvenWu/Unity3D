#pragma strict

function Start () {
	Debug.Log("<color=green>From js</color>");
}

function Update () {
	//Debug.Log("<color=green>From js</color>");
	Debug.LogError("<color=green>Form JS</color>");
	Debug.LogException(new UnityException());
	Debug.LogWarning("<color=green>Form JS</color>");
}