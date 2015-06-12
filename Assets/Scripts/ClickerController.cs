using UnityEngine;
using System.Collections;

public class ClickerController : MonoBehaviour {

	// Use this for initialization
    Animator anim;
    public static bool gameOver;

	void Start () 
    {
        anim = this.gameObject.GetComponentInChildren<Animator>();
        gameOver = false;
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(gameOver)
        {
            
            Time.timeScale = 0;
        }
        
	
	}

    void OnMouseDown()
    {
        anim.SetTrigger("Flash");
        GameObject[] blueBoxes = GameObject.FindGameObjectsWithTag("Blue");
        GameObject[] orangeBoxes = GameObject.FindGameObjectsWithTag("Orange");
        GameObject[] purpleBoxes = GameObject.FindGameObjectsWithTag("Purple");
        for (int i = 0; i < blueBoxes.Length; i++)
        {
            if (this.gameObject.tag == blueBoxes[i].gameObject.tag + "Box" && blueBoxes[i].transform.position.y <= -3)
            {
                Spawner.score++;
                Destroy(blueBoxes[i]);
            }
          
        }
        for(int b = 0;b < orangeBoxes.Length; b++)
        {
            if (this.gameObject.tag == orangeBoxes[b].gameObject.tag + "Box" && orangeBoxes[b].transform.position.y <= -3)
            {
                Spawner.score++;
                Destroy(orangeBoxes[b]);
            }
            
        }
        for(int c = 0;c < orangeBoxes.Length; c++)
        {
            if (this.gameObject.tag == orangeBoxes[c].gameObject.tag + "Box" && orangeBoxes[c].transform.position.y <= -3)
            {
                Spawner.score++;
                Destroy(orangeBoxes[c]);
            }
           
        }
    }
}
