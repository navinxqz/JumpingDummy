using UnityEngine;

public class HippoScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flapStrength;
   
    void Start()
    {
        gameObject.name = "Hippo";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true) { rb.linearVelocity = Vector2.up * flapStrength; }
            
    }
}
