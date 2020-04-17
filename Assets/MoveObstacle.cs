using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject obs;
    public float fforce = 2000f;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,-fforce * Time.deltaTime);
        if(rb.position.z < -20f ){
            Destroy(obs);
        }
        
    }
}
