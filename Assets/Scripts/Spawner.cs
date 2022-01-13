using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawnee;
    private float spawntime = 1;
    private float spawndelay=1;
    private int randomInt;
    float positionx;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnobject", spawntime, spawndelay);

    }

    // Update is called once per frame
    void Update()
    {
        
       // spawntime = Random.Range(1, 3);
    }

    void spawnobject()
    {
        randomInt = Random.Range(0, spawnee.Length);
        positionx = Random.Range(8f,-8f);
        this.transform.position = new Vector3(positionx,transform.position.y , transform.position.z);
        var spawnedObject = Instantiate(spawnee[randomInt], transform.position, transform.rotation);
        
        if(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == "GamePlay_Level 2")
        {
            IncreaseObjectSpeed(spawnedObject);
        }
    }

    void IncreaseObjectSpeed(GameObject obj)
    {
        obj.GetComponent<ObjectMovement>().ySpeed *= Random.Range(1.5f,2.5f);
    }
}
