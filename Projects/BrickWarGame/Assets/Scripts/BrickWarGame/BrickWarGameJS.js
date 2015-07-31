#pragma strict
var brick:GameObject;
function Start () {
	//Debug.Log("<color=red>From JS</color>");
	//Instantiate(brick);
	var columnNum:int=4;
	var rowNum:int=7;
	for(var i:int=0;i<columnNum;i++){
		for(var j:int=0;j<rowNum;j++){
			Instantiate(brick,Vector3(j-3,0.5f+i,0),Quaternion.identity);
		}
	}
}

function Update () {
	
}