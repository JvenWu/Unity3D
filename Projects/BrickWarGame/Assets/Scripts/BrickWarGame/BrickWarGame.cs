using UnityEngine;
using System.Collections;

public class BrickWarGame : MonoBehaviour {

    public GameObject brick;
	private int columnNum=4;
	private int rowNum=7;
	// Use this for initialization
	void Start () {
		//Debug.Log("<color=green>From C#</color>");
        //Create gameobject
        //Instantiate(brick);
		for(int i=0;i<columnNum;i++)
		{
			for(int j=0;j<rowNum;j++)
			{
				Instantiate(brick,new Vector3(j-3,0.5f+i,0),Quaternion.identity);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
