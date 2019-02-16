using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
    public GameObject plane;
    public GameObject spawnPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y < plane.transform.position.y - 10)
        {
            transform.position = spawnPosition.transform.position;
        }

    }
}
