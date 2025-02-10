using UnityEngine;

public class TreeSpawnScript : MonoBehaviour
{
    public GameObject tree;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }
    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(tree, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint),0), transform.rotation);
    }
}
