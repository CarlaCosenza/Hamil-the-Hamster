using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {

    public GameObject spawnTree;
    public GameObject spawnNut;
    public GameObject spawnPlatform;
    public GameObject spawnEnemy1;
    public GameObject spawnEnemy2;
    public float rateSpawn;
    private float currentTime;

    private int choose;
    private int numRand;

	// Use this for initialization
	void Start () {
        currentTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
        currentTime += Time.deltaTime;
        choose = Random.Range(1, 1000);
        numRand = Random.Range(1, 3);
        if (currentTime >= rateSpawn)
        {
            currentTime = 0;
            if (choose % 3 == 0)
            {
                GameObject tempPrefab10 = Instantiate(spawnTree) as GameObject;
                tempPrefab10.transform.position = new Vector3(transform.position.x + 3 + numRand, tempPrefab10.transform.position.y, tempPrefab10.transform.position.z);
            }
            if (choose % 4 == 0)
            {
                GameObject tempPrefab10 = Instantiate(spawnEnemy2) as GameObject;
                tempPrefab10.transform.position = new Vector3(transform.position.x + 3 + numRand, tempPrefab10.transform.position.y, tempPrefab10.transform.position.z);
            }
            if (choose % 2 == 0)
            {
                GameObject tempPrefab10 = Instantiate(spawnNut) as GameObject;
                tempPrefab10.transform.position = new Vector3(transform.position.x, tempPrefab10.transform.position.y, tempPrefab10.transform.position.z);
                GameObject tempPrefab1 = Instantiate(spawnNut) as GameObject;
                tempPrefab1.transform.position = new Vector3(transform.position.x + 3, tempPrefab1.transform.position.y, tempPrefab1.transform.position.z);
                GameObject tempPrefab2 = Instantiate(spawnNut) as GameObject;
                tempPrefab2.transform.position = new Vector3(transform.position.x + 6, tempPrefab2.transform.position.y, tempPrefab2.transform.position.z);
            }
            if (choose % 5 == 0)
            {
                GameObject tempPrefab10 = Instantiate(spawnEnemy1) as GameObject;
                tempPrefab10.transform.position = new Vector3(3.5f, -2, tempPrefab10.transform.position.z);
            }
            if (choose % 6 == 0)
            {
                GameObject tempPrefab10 = Instantiate(spawnEnemy1) as GameObject;
                tempPrefab10.transform.position = new Vector3(4.5f, 0, tempPrefab10.transform.position.z);
            }
            if (choose > 500)
            {
                GameObject tempPrefab1 = Instantiate(spawnPlatform) as GameObject;
                tempPrefab1.transform.position = new Vector3(transform.position.x, -1.5f, tempPrefab1.transform.position.z);
                GameObject tempPrefab2 = Instantiate(spawnNut) as GameObject;
                tempPrefab2.transform.position = new Vector3(transform.position.x - 0.3f, -1, tempPrefab2.transform.position.z);
                GameObject tempPrefab3 = Instantiate(spawnNut) as GameObject;
                tempPrefab3.transform.position = new Vector3(transform.position.x + 0.3f, -1, tempPrefab3.transform.position.z);

                GameObject tempPrefab4 = Instantiate(spawnPlatform) as GameObject;
                tempPrefab4.transform.position = new Vector3(transform.position.x + 2, -0.5f, tempPrefab4.transform.position.z);
                GameObject tempPrefab5 = Instantiate(spawnNut) as GameObject;
                tempPrefab5.transform.position = new Vector3(transform.position.x + 2 - 0.3f, 0, tempPrefab5.transform.position.z);
                GameObject tempPrefab6 = Instantiate(spawnNut) as GameObject;
                tempPrefab6.transform.position = new Vector3(transform.position.x + 2 + 0.3f, 0, tempPrefab6.transform.position.z);

                GameObject tempPrefab7 = Instantiate(spawnPlatform) as GameObject;
                tempPrefab7.transform.position = new Vector3(transform.position.x + 4, 0.5f, tempPrefab7.transform.position.z);
                GameObject tempPrefab8 = Instantiate(spawnNut) as GameObject;
                tempPrefab8.transform.position = new Vector3(transform.position.x + 4 - 0.3f, 1, tempPrefab8.transform.position.z);
                GameObject tempPrefab9 = Instantiate(spawnNut) as GameObject;
                tempPrefab9.transform.position = new Vector3(transform.position.x + 4 + 0.3f, 1, tempPrefab9.transform.position.z);

                GameObject tempPrefab10 = Instantiate(spawnEnemy1) as GameObject;
                tempPrefab10.transform.position = new Vector3(transform.position.x, 0, tempPrefab10.transform.position.z);


            } else if (choose > 0)
            {
                GameObject tempPrefab1 = Instantiate(spawnPlatform) as GameObject;
                tempPrefab1.transform.position = new Vector3(transform.position.x, -1.5f, tempPrefab1.transform.position.z);
                GameObject tempPrefab2 = Instantiate(spawnNut) as GameObject;
                tempPrefab2.transform.position = new Vector3(transform.position.x - 0.3f, -1, tempPrefab2.transform.position.z);
                GameObject tempPrefab3 = Instantiate(spawnNut) as GameObject;
                tempPrefab3.transform.position = new Vector3(transform.position.x + 0.3f, -1, tempPrefab3.transform.position.z);

                GameObject tempPrefab4 = Instantiate(spawnPlatform) as GameObject;
                tempPrefab4.transform.position = new Vector3(transform.position.x + 2, -0.5f, tempPrefab4.transform.position.z);
                GameObject tempPrefab5 = Instantiate(spawnEnemy1) as GameObject;
                tempPrefab5.transform.position = new Vector3(transform.position.x + 1 + numRand, 0, tempPrefab5.transform.position.z);
                GameObject tempPrefab6 = Instantiate(spawnNut) as GameObject;
                tempPrefab6.transform.position = new Vector3(transform.position.x + 4 + 0.3f, 0, tempPrefab6.transform.position.z);
                GameObject tempPrefab7 = Instantiate(spawnNut) as GameObject;
                tempPrefab7.transform.position = new Vector3(transform.position.x + 4 + 0.9f, 0, tempPrefab7.transform.position.z);
            }
        }

    }
}
