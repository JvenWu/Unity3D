using UnityEngine;
using System.Collections;

public class EatFood : MonoBehaviour {
	private int count=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.name == "Food") {
			GameObject.Destroy(other.gameObject);
			count++;
			Debug.Log("<color=yellow>"+count+"</color>");
			if(count>8){
				Debug.Log("<color=green>Game win</color>");
			}
		}
	}
}
