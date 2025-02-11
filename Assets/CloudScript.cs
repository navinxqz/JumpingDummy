using UnityEngine;

public class CloudScript : MonoBehaviour
{
    public float movespeed = 3;
    public float destroyer = -70;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * movespeed * Time.deltaTime;
        if (transform.position.x < destroyer)
        {
            Debug.Log("Destroying tree");
            Destroy(gameObject);
        }
    }
}
