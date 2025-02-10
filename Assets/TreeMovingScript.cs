using UnityEngine;

public class TreeMovingScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float destroyer = -60;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        if (transform.position.x < destroyer)
        {
            Debug.Log("Destroying tree");
            Destroy(gameObject);
        }

    }
}
