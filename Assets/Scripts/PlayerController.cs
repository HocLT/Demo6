using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float torqueValue = 1f;

    Rigidbody2D myBody;
    // Start is called before the first frame update
    void Start()
    {
        myBody= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myBody.AddTorque(torqueValue);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myBody.AddTorque(-torqueValue);
        }

    }
}
