using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject Player;
    
    private float moveSpeed = 20.0f;
    private Rigidbody2D _rigidbodyBullet;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbodyBullet = GetComponent<Rigidbody2D>();
        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    private void move()
    {
        _rigidbodyBullet.velocity = transform.up * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D ObjectCollision)
    {
        if (ObjectCollision.gameObject.name == "Ball(Clone)" || ObjectCollision.gameObject.name == "Bullet(Clone)")
        {
            Destroy(gameObject);
            Destroy(ObjectCollision.gameObject);
            
            Player.GetComponent<WeaponController>().setCountDestroyed();
            Player.GetComponent<WeaponController>().setScoreBoard();
        }
    }
}
