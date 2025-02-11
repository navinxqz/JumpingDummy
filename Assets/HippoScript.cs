using UnityEngine;

public class HippoScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flapStrength;
    public LogicScript logicScript;
    public bool hippoIsAlive = true;
    public AudioSource warningAudio;

    void Start()
    {
        //gameObject.name = "Hippo";
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && hippoIsAlive)
        { rb.linearVelocity = Vector2.up * flapStrength; }

        if(transform.position.y >= 21 || transform.position.y <= -20)
        {
            logicScript.GameOver();
            hippoIsAlive = false;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicScript.GameOver();
        hippoIsAlive = false;
    }
}
