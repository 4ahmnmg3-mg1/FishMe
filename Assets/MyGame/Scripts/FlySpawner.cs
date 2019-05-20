using System.Collections;
using UnityEngine;

public class FlySpawner : MonoBehaviour
{
    public Fly flyPrefab;
    public GameObject boundaryLeft;
    public GameObject boundaryRight;
    public GameObject boundaryTop;
    public GameObject flyParent;
    private bool spawn = true;

    public float minSpawnDelay = 1.0f;
    public float maxSpawnDelay = 5.0f;

    public int xMinLeft;
    public int xMaxLeft;
    public float flyMinSize = 0.1f;
    public float flyMaxSize = 0.5f;

    public float flyGravityMin = 0.1f;
    public float flyGravityMax = 0.8f;

    public int yPos;

    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        xMaxLeft = (int)boundaryRight.gameObject.transform.position.x;
        xMinLeft = (int)boundaryLeft.gameObject.transform.position.x;
        yPos = (int)boundaryTop.gameObject.transform.position.y;
    }

    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnFly();
        }

    }

    private void SpawnFly()
    {
        // transform.position = new Vector3(Random.Range(xMinLeft, xMaxLeft), yPos, 0);

        float flySize = Random.Range(flyMinSize, flyMaxSize);
       
        Fly flyClone = (Fly)Instantiate(flyPrefab, transform.position, transform.rotation);
        flyClone.transform.SetParent(flyParent.transform);
        flyClone.transform.localPosition = new Vector3(Random.Range(xMinLeft, xMaxLeft), flyParent.transform.position.y, 0f);
        Debug.Log("Local Scale: " + flySize);
        flyClone.transform.localScale = new Vector3(flySize, flySize, 0);
        //flyClone.transform.localScale = new Vector3(1, 1, 0);

        flyClone.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(2, 8);
        if (flyClone.GetComponent<SpriteRenderer>().sortingOrder == 7)
        {
            flyClone.GetComponent<SpriteRenderer>().color = Color.blue;
        }
        flyClone.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-2, 2), Random.Range(-10, -1));
    }
}