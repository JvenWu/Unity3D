using UnityEngine;
using System.Collections;

public class FolowPlayer : MonoBehaviour {
    public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 player_position = player.transform.position;
        this.GetComponent<Transform>().position = new Vector3(
            player_position.x,
            player_position.y + 9.909719f,
            player_position.z + -7.431555f);
	}
}
