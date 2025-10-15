using UnityEngine;

public class TurretTurn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public float turnSpeed = 100.0f;

    // Update is called once per frame
    void Update()
    {
        float rotateTurret = 0.0f;

        if(Input.GetKey (KeyCode.Q)) {
            rotateTurret = -turnSpeed * Time.deltaTime;
        }

        else if(Input.GetKey (KeyCode.E)) {
            rotateTurret = turnSpeed * Time.deltaTime;
        }
        
        Transform t = gameObject.transform;
        t.Rotate (0.0f, rotateTurret, 0.0f);
    }
}
