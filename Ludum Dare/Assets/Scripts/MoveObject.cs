using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {

    public float speed;
    private float x;

    public GameObject Player;

	// Use this for initialization
	void Start () {
        Player = GameObject.Find("Hamster") as GameObject;

    }
	
	// Update is called once per frame
	void Update () {

        x = transform.position.x;
        x += speed * Time.deltaTime;

        transform.position = new Vector3(x, transform.position.y, transform.position.z);

        if (x <= -7)
        {
            Destroy(transform.gameObject);
        }
		
	}
}
