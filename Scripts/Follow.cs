using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

    // Use this for initialization
    public GameObject player;
    private Vector3 offset;
    void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = player.transform.position + offset;
	}
}
