using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBall : MonoBehaviour
{
    public GameObject Ball;
    
    private float countTime = 0;
    private int generateVelocity = 0;
    private float TimeToGenerate = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        generateBall();
    }

    void generateBall()
    {
        countTime += Time.deltaTime;
        TimeToGenerate = Random.Range(1, generateVelocity);

        if (countTime >= TimeToGenerate)
        {
            Instantiate(Ball, transform.position, transform.rotation);
            countTime = 0;
            TimeToGenerate = 0;
        }
    }

    public void changeLevel(int newLevel)
    {
        generateVelocity = newLevel;
    }
}
