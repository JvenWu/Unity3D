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

    public void OnTriggerEnter(Collider other)
    {
        GameObject food = other.gameObject;
        if (food.name == "Food")
        {
            GameObject.Destroy(food);
            count++;
        }
        Debug.Log("<color=green>Eat[" + count + "]</color>");
        if (count == 10)
        {
            Debug.Log("<color=green>Game Win</color>");
        }
    }


}
