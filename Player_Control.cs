using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player_1;
    private Rigidbody2D rb;
    public float playerSpeed;


    // Start is called before the first frame update
    void Start()
    {
        rb = player_1.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * playerSpeed, 0);
    }
}
