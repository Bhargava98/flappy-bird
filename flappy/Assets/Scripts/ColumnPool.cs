using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColumnPool : MonoBehaviour {
 
    public int columnPoolSize = 5;
    public GameObject columnPrefab;
    public float spawnRate = 4f;
    public float columnMin = -1f;
    public float columnMax = 3f;
    

    private GameObject[] columns;
    private Vector2 objectPoolPosition = new Vector2(-30f, -30f);
    private float TimeSinceLastSpawned;
    private float spawnXposition = 30f;
    private int currentColumn = 0;

    // Use this for initialization
	void Start () {
        columns = new GameObject[columnPoolSize];
        for (int i = 0; i < columnPoolSize; i++)
        {
            columns[i] = (GameObject)Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {

        TimeSinceLastSpawned += Time.deltaTime;
        if(TimeSinceLastSpawned >=spawnRate)
        {
            TimeSinceLastSpawned = 0;
            float spawnYPosition = Random.Range(columnMin, columnMax);
            columns[currentColumn].transform.position = new Vector2(spawnXposition, spawnYPosition);
            currentColumn++;

            if(currentColumn >= columnPoolSize)
            {
                currentColumn = 0;
            }
            
        }
	}
}
