using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const string AXISHORIZONTAL = "Horizontal";
    private const string AXISVERTICAL = "Vertical";


    public GameObject boundaryLeft;
    public GameObject boundaryRight;
    public ScoreData myScoreData;
    private float moveSpeed = 3.0f;

    private void Move()
    {
        var deltaX = Input.GetAxis(AXISHORIZONTAL) * Time.deltaTime * moveSpeed;
        var newPosX = Mathf.Clamp(transform.position.x + deltaX, 
            boundaryLeft.gameObject.transform.position.x, 
            boundaryRight.gameObject.transform.position.x);

        transform.position = new Vector2(newPosX, transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("fly " + collision.name);
        if(collision.name == "Fly")
        {
            myScoreData.points += 10;
        }
    }


    void Start ()
    {
		
	}
	
	void Update ()
    {
        Move();	
	}
}
