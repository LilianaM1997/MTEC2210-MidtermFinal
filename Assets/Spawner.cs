using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public Transform LeftPoint;
    public Transform RightPoint;
    
    
    
    private float timePassed;
    private float spawnTime;

    public float minSpawnTime = 1f;
    public float maxSpawnTime = 3f;


    public GameObject coin;
    public GameObject Pokeball;
    public GameObject TeamRocketLogo;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCoin", 5, 2);

        spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        
    }

    // Update is called once per frame
    public void SpawnCoin()
    {
        float xPos = Random.Range(LeftPoint.position.x, RightPoint.position.x);
        float yPos = LeftPoint.position.y;

        Vector3 newPos = new Vector3(xPos, yPos, 0);
        print(newPos);
        Instantiate(coin, newPos, Quaternion.identity);
        
    }

    private void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed >= spawnTime) 
        { int randomPrefab = Random.Range(minInclusive:0, maxExclusive:3);
            int randomX = Random.Range((int)LeftPoint.transform.position.x, (int)RightPoint.transform.position.x);
            if (randomPrefab == 0)
            {
                Instantiate(coin, position: new Vector3(randomX, transform.position.y, 0), Quaternion.identity);
            }
            else if (randomPrefab == 1) 
            {
                Instantiate(Pokeball, position: new Vector3(randomX, transform.position.y, 0), Quaternion.identity);
            
            
            }
            else if (randomPrefab == 2)
            {
                Instantiate(TeamRocketLogo, position: new Vector3(randomX, transform.position.y, 0), Quaternion.identity);


            }
            timePassed = 0f;
            spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        }

        
    }
}
