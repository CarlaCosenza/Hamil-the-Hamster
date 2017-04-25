using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy2 : MonoBehaviour {

    public float speed;
    private float x;
    private float y;

    private GameObject hamster;
    private AudioSource audio;
    private int state;
    public AudioClip soundKill;

    // Use this for initialization
    void Start () {
        hamster = GameObject.Find("Hamster") as GameObject;
        audio = hamster.GetComponent<AudioSource>();
        state = 1;
    }
	
	// Update is called once per frame
	void Update () {

        x = transform.position.x;
        y = transform.position.y;
        x += speed * Time.deltaTime;
        if (y > 1)
        {
            if (state == 1) state = -1; else state = 1;
        }

        if (y < 0.5)
        {
            if (state == 1) state = -1; else state = 1;
        }

        y += state * speed * Time.deltaTime;

        transform.position = new Vector3(x, y, transform.position.z);

        if (x <= -7)
        {
            Destroy(transform.gameObject);
        }
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Shot(Clone)")
        {
            Destroy(other.gameObject);
            Destroy(transform.gameObject);
            audio.PlayOneShot(soundKill);
            audio.volume = 1;
        }
    }
}
