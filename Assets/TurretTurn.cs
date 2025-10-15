using UnityEngine;

public class TurretTurn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public float turnSpeed = 100.0f;
    public float cameraMode = 1;

    // Update is called once per frame
    void Update()
    {
        float rotateTurret = 0.0f;
        Transform t = gameObject.transform;

        if (Input.GetKeyDown (KeyCode.Alpha1)) {
            cameraMode = 1;
        }

        else if (Input.GetKeyDown (KeyCode.Alpha2)) {
            cameraMode = 2;
        }

        if (cameraMode == 1) {

        if (Input.GetKey (KeyCode.Q)) {
            rotateTurret = -turnSpeed * Time.deltaTime;
        }

        else if (Input.GetKey (KeyCode.E)) {
            rotateTurret = turnSpeed * Time.deltaTime;
        }
        }

        if (cameraMode == 2) {
            float mouseX = Input.GetAxis("Mouse X");
            rotateTurret = 10 * mouseX;
        }

        t.Rotate (0.0f, rotateTurret, 0.0f);
    }
}
