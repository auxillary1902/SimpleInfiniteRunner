using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public Rigidbody rb;
	public float fforce = 2000f;
	public float sforce = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // rb.AddForce(0,0,fforce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
        	rb.AddForce(sforce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
        	rb.AddForce(-sforce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(rb.position.y < -1f) {
        		FindObjectOfType<GameManager>().EndGame();
                GameObject.Find("Score").GetComponent<UpdateScore>().EndScore();
        }
    }
}
