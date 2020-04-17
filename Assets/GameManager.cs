using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public bool gameEnded = false;
    public void EndGame()
    {
    	if(!gameEnded)
    	{   
    		gameEnded = true;
    		Debug.Log("Game Over Loser!");
    		// Restart();
    		Invoke("Restart",2f);
        }
    }

    void Restart(){
       
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
