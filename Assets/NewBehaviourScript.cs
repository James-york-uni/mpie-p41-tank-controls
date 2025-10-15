using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 50.0f;
    public float turnSpeed = 50.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float throttle = Input.GetAxis("Vertical");
        float movement = throttle * speed * Time.deltaTime;

        float rotate = Input.GetAxis("Horizontal");
        float turn = rotate * turnSpeed * Time.deltaTime;

        Transform t = gameObject.transform;
        t.Translate (0.0f, 0.0f, -movement);
        t.Rotate (0f, turn, 0f);
        
    }
}
