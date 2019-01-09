using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;
    
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (transform.position.x > screenBounds.x - objectWidth)
            transform.position = new Vector2(screenBounds.x - objectWidth, transform.position.y);

        if (transform.position.x < screenBounds.x * -1 + objectWidth)
            transform.position = new Vector2(screenBounds.x * -1 + objectWidth, transform.position.y);

        if (transform.position.y < screenBounds.y * -1 + objectHeight)
            transform.position = new Vector2(transform.position.x, screenBounds.y * -1 + objectHeight);

        //transform.position = viewPos;
    }
}
