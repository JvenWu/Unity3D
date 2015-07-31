#pragma strict

var count:int=0;
function Start () {

}

function Update () {
	
}

function OnTriggerEnter(other:Collider){
	var food:GameObject=other.gameObject;
	if(food.name=="Food")
	{
		GameObject.Destroy(food);
		count++;
		Debug.Log("<color=green>Eat["+count+"]</color>");
	}
	if(count==10)
	{
		Debug.Log("<color=green>Game Win?</color>");
	}
}