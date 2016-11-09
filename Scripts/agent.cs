using UnityEngine;
using System.Collections;

public class agent : MonoBehaviour {
    NavMeshAgent agentt;
	// Use this for initialization
	void Start () {
        agentt = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, 100))
            {
                agentt.SetDestination(hit.point);
            }
        }
	}
}
