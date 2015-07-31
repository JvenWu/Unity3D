#pragma strict

function Start () {

}

function Update () {
	//this.transform.Rotate(Vector3.up);
	this.GetComponent(Transform).Rotate(Vector3.up);
}