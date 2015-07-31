using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float x=player.transform.position.x;
        float y=player.transform.position.y;
        float z=player.transform.position.z;
        this.GetComponent<Transform>().position = new Vector3(x, y + 7.235468f, z-9.367381f);
	}
}
