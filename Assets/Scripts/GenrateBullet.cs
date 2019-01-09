using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenrateBullet : MonoBehaviour
{
    public GameObject Bullet;
    public double TimeToGenerateBall = 0;
    private float countTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
    }
    
    private void shoot()
    {
        TimeToGenerateBall = 0.1;
        countTime += Time.deltaTime;

        if (countTime >= TimeToGenerateBall)
        {
            Instantiate(Bullet, new Vector2(transform.position.x, transform.position.y), transform.rotation);
            countTime = 0;
        }
    }
}
