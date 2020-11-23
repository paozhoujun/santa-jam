using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-1, 0, 0);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Room"))
        {
            if (collision.GetComponent<Room>().GetTagColor() != TagColor.One)
            {
                Debug.Log("Entered");
                collision.GetComponent<Room>().SetTagColor(TagColor.One);
            }
        }
    }
}