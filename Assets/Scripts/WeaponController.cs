using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponController : MonoBehaviour
{
    public Text countDestroyedText;
    public Text countAgainstHitsText;
    public Text countScoreBoardText;
    
    private int countDestroyed = 0;
    private int countAgainstHits = 0;

    private int level = 1;
    public GameObject[] GenerateBall;
    // Start is called before the first frame update
    void Start()
    {
        GenerateBall = GameObject.FindGameObjectsWithTag("GenerateBall");
    }

    // Update is called once per frame
    void Update()
    {
        levelDefineByShoot();
    }

    public void setCountDestroyed()
    {
        countDestroyed++;
        countDestroyedText.text = "You destroy " + countDestroyed + " asteroids";
    }
    
    public void setCountAgainstHits()
    {
        countAgainstHits++;
        countAgainstHitsText.text = "You've been hit by " + countAgainstHits + " asteroids";
    }

    public void setScoreBoard()
    {
        countScoreBoardText.text = "You "+countDestroyed+" x "+countAgainstHits+" Asteroids | Level: " + level;
    }

    public void levelDefineByShoot()
    {
        // Level 1
        if (countDestroyed >= 0 && countDestroyed <= 50)
        {
            // GenerateBall.GetComponent<GenerateBall>().changeLevel(2000);
            foreach (var comp in GenerateBall)
            {
                comp.GetComponent<GenerateBall>().changeLevel(2000);
            }
            level = 1;
        }
        
        // Level 2
        if (countDestroyed >= 51 && countDestroyed <= 100)
        {
            foreach (var comp in GenerateBall)
            {
                comp.GetComponent<GenerateBall>().changeLevel(1500);
            }
            level = 2;
        }
        
        // Level 3
        if (countDestroyed >= 101 && countDestroyed <= 200)
        {
            foreach (var comp in GenerateBall)
            {
                comp.GetComponent<GenerateBall>().changeLevel(1000);
            }
            level = 3;
        }
        
        // Level 4
        if (countDestroyed >= 201 && countDestroyed <= 300)
        {
            foreach (var comp in GenerateBall)
            {
                comp.GetComponent<GenerateBall>().changeLevel(500);
            }
            level = 4;
        }
        
        // Level 5
        if (countDestroyed >= 301 && countDestroyed <= 400)
        {
            foreach (var comp in GenerateBall)
            {
                comp.GetComponent<GenerateBall>().changeLevel(200);
            }
            level = 5;
        }
        
        // Level 6
        if (countDestroyed >= 401)
        {
            foreach (var comp in GenerateBall)
            {
                comp.GetComponent<GenerateBall>().changeLevel(100);
            }
            level = 6;
        }
    }
}
