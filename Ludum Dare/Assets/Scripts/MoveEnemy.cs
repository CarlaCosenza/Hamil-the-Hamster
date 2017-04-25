using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour {

    public float speed;
    private float x;

    private GameObject hamster;
    private AudioSource audio;
    public AudioClip soundKill;

    // Use this for initialization
    void Start () {
        hamster = GameObject.Find("Hamster") as GameObject;
        audio = hamster.GetComponent<AudioSource>();
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
