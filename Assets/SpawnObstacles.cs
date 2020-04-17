using UnityEngine;
using System.Collections;

public class SpawnObstacles : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obs;
    void Start()
    {
        Instantiate(obs, new Vector3(-0.2f, 1f, 130f), Quaternion.identity);
        InvokeRepeating("createObstacle",0.2f,0.2f);
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    public void createObstacle()
    {
        
        Vector3 position = new Vector3(Random.Range(-8.5f, 8.5f), 1f,130f);
        Instantiate(obs, position, Quaternion.identity);
    }
}
