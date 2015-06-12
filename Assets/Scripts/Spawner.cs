using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Spawner : MonoBehaviour {

    public GameObject[] circles;
    public GameObject[] spawnerPositions;
    public static int level = 0;
    public static int score;
    private GameObject scoreText;
    public GameObject mainCamera;
    private Animator anim;
	// Use this for initialization
	void Start () 
    {
        InvokeRepeating("SpawnCircle", 1, 1);
        scoreText = GameObject.Find("Score");
        anim = mainCamera.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        scoreText.GetComponent<Text>().text = "Score: " + score;
        if(score >=6)
        {
            level = 1;
        }
        if(level == 1)
        {
            anim.SetInteger("Hardness", level);
        }

	}

    void SpawnCircle()
    {
        int ranSide0index = Random.Range(0,3);
        int ranColor0index = Random.Range(0, 3);
        GameObject circle = (GameObject)Instantiate(circles[ranColor0index]);
        Vector3 assignPos = spawnerPositions[ranSide0index].transform.position;
        circle.transform.position = assignPos;

    }
}
