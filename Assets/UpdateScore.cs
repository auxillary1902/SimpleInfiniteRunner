using UnityEngine;
using UnityEngine.UI;
public class UpdateScore : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public float score;

    public bool notEnded = true;
    // Update is called once per frame
    void Start(){
      score=0;
    }
    public void EndScore(){
        notEnded=false;
    }
    void Update()
    {
        if(notEnded)
        {score+= (Time.deltaTime * 100);
    	scoreText.text = score.ToString("0");
        }
        
    }
}
