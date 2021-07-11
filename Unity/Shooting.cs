using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public float shootingStrength;
    public Rigidbody BBrb;
    public GameObject Player;
    public float upwardCoeff;


    // Start is called before the first frame update
    void Start()
    {
        BBrb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1")){
            BBrb.AddForce(0, upwardCoeff * shootingStrength, shootingStrength, ForceMode.Impulse);
        }

        if (Input.GetButtonDown("Fire2")){
            transform.position = Player.transform.position + new Vector3(3,3,3);
        }
    }
}
