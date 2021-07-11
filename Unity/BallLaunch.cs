using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLaunch : MonoBehaviour
{
    public Rigidbody ball;
    public Transform target;
    public GameObject Player;

    public float h = 25;
    public float gravity = -18;


    // Start is called before the first frame update
    void Start()
    {
        ball.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocityIni = CalculateLaunchVelocity();

        if (Input.GetButtonDown("Fire2")){
            // ball.transform.position = Player.transform.position + new Vector3(3,3,3);
            // ball.AddForce(-velocityIni/2, ForceMode.VelocityChange);
            Instantiate(ball,Player.transform.position + new Vector3(3,3,3),ball.rotation);
            }

        if (Input.GetKeyDown(KeyCode.Space)) {
            Launch();
        }
        
    }

    void Launch() {
        Physics.gravity = Vector3.up * gravity;
        ball.useGravity = true;
        ball.velocity = CalculateLaunchVelocity();
        print(CalculateLaunchVelocity());
    }

    Vector3 CalculateLaunchVelocity() {
        float displacementY = target.position.y - ball.position.y;
        Vector3 displacementXZ = new Vector3(target.position.x - ball.position.x, 0, target.position.z - ball.position.z);
        Vector3 velocityY = Vector3.up * Mathf.Sqrt(-2*gravity*h);
        Vector3 velocityXZ = displacementXZ / (Mathf.Sqrt(-2*h/gravity) + Mathf.Sqrt(2*(displacementY - h)/gravity));
        
        return velocityXZ + velocityY;
    }
}
