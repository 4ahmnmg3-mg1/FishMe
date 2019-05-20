using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public ScoreData myScoreData;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("fly " + collision.name);
        if(collision.name == "Fly")
        {
            myScoreData.points += 10;
        }
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
