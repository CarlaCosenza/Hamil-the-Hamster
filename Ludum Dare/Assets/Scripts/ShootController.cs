using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour {

    public GameObject PrefabShot;
    public float rateShot;
    public float currentTime;

    public AudioSource audio;
    public AudioClip soundShot;

    // Use this for initialization
    void Start () {
        currentTime = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
        currentTime += Time.deltaTime;
        if (Input.GetMouseButtonDown(1) && currentTime >= rateShot)
        {
            currentTime = 0;
            GameObject tempPrefab = Instantiate(PrefabShot) as GameObject;
            tempPrefab.transform.position = new Vector3(transform.position.x+0.37f, transform.position.y+0.3f, transform.position.z);

            audio.PlayOneShot(soundShot);
            audio.volume = 1;
        }
		
	}
}
