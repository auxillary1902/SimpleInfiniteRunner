using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerController pc;  
    public GameObject canvas;

    void OnCollisionEnter(Collision coll){
    	
    	
           if(coll.collider.tag == "obstacle")
           {
           	pc.enabled = false;

           	FindObjectOfType<GameManager>().EndGame();
            GameObject.Find("Score").GetComponent<UpdateScore>().EndScore();
           }
    }
}
