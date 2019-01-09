using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public GameObject Player;
    
    private float moveSpeed = 2;
    private Rigidbody2D _rigidbody2DBall;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2DBall = GetComponent<Rigidbody2D>();
        
        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        move();
    }

    void move()
    {
        float distance = Vector2.Distance(transform.position, Player.transform.position);
        Vector2 direction = Player.transform.position - transform.position;
        
        // Follow player
        _rigidbody2DBall.MovePosition(_rigidbody2DBall.position + direction.normalized * moveSpeed * Time.deltaTime);
        
        // Don't follow player
        //_rigidbody2DBall.velocity = transform.up * -1.0f * moveSpeed;
    }
    
    private void OnCollisionEnter2D(Collision2D ObjectCollision)
    {
        if (ObjectCollision.gameObject.name == "Weapon")
        {
            Player.GetComponent<WeaponController>().setCountAgainstHits();
            Player.GetComponent<WeaponController>().setScoreBoard();
            
            Destroy(gameObject);
        }
    }
}
