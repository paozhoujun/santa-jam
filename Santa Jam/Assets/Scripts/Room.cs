using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TagColor
{
    One,
    Two,
    None
}

public class Room : MonoBehaviour
{
    private Renderer rend;
    private TagColor roomColor = TagColor.None;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponentInChildren<Renderer>();
        SetTagColor(roomColor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetTagColor(TagColor tagColor)
    {
        roomColor = tagColor;

        if (tagColor == TagColor.One)
        {
            rend.material.color = Color.red;
        }
        else if (tagColor == TagColor.Two)
        {
            rend.material.color = Color.blue;
        }
        else
        {
            rend.material.color = Color.black;
        }
    }

    public TagColor GetTagColor()
    {
        return roomColor;
    }
}
