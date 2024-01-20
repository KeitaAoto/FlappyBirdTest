using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    [SerializeField]private float flapStrength = 15f;

    [SerializeField] private Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rigidbody.velocity = Vector2.up * flapStrength;
        }
    }
}
