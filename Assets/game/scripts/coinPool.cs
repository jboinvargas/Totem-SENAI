using UnityEngine;
using System.Collections;

public class coinPool : MonoBehaviour {
    public int obstaculoPoolSize = 8;
    public GameObject obstaculoPrefab;
    public float spawnRate = 4f;
    public float[] spawnYPosition = { -0.22f, -1f, -1.7f, -2.26f };


    private GameObject[] obstaculos;
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    private float timeSinceLastSpawned;
    private float spawnXPosition = 10f;
    private int currentObstaculo = 0;
    private int actualLand = 0;
    private int lastLand = 0;


    // Use this for initialization
    void Start()
    {
        obstaculos = new GameObject[obstaculoPoolSize];
        for (int i = 0; i < obstaculoPoolSize; i++)
        {
            obstaculos[i] = (GameObject)Instantiate(obstaculoPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;
        if (!gameControl.instance.gameOver && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            actualLand = Random.Range(0, 4);
            if (actualLand == lastLand)
            {
                if (actualLand == 3)
                {
                    actualLand = 0;
                }
                else if (actualLand == 0)
                {
                    actualLand = 3;
                }
                else
                {
                    actualLand++;
                }
            }
            obstaculos[currentObstaculo].transform.position = new Vector2(spawnXPosition, spawnYPosition[actualLand]);
            currentObstaculo++;
            //spawnRate = Random.Range(0.4f, 0.6f);
            if (currentObstaculo >= obstaculoPoolSize)
            {
                currentObstaculo = 0;
            }
            lastLand = actualLand;
            obstaculos[currentObstaculo].GetComponent<SpriteRenderer>().enabled = true;
        }

    }
}
