using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float moveSpeed = 10;
    private float _screenWidth;

    public GameObject Player;
    private Rigidbody2D _rigidbody2DPlayer;
    
    // Start is called before the first frame update
    void Start()
    {
        _screenWidth = Screen.width;
        _rigidbody2DPlayer = Player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        touchDetect();
    }
    
    private void FixedUpdate()
    {
        #if UNITY_EDITOR
            move(Input.GetAxis("Horizontal"));
        #endif
    }

    private void touchDetect()
    {
        int i = 0;

        while (i < Input.touchCount)
        {
            if (Input.GetTouch(i).position.x > _screenWidth / 2)
            {
                move(1.0f);
            }
            if (Input.GetTouch(i).position.x < _screenWidth / 2)
            {
                move(-1.0f);
            }

            ++i;
        }
    }

    private void move(float horizontalInput)
    {
        _rigidbody2DPlayer.transform.Translate(new Vector2(horizontalInput, 0) * moveSpeed * Time.deltaTime);
    }
}
