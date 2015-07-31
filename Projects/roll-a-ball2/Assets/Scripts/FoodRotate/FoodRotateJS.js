#pragma strict

function Start () {

}

function Update () {
	this.GetComponent(Transform).Rotate(Vector3.right);
}