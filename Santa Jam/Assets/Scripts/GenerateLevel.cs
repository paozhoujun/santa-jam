using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject PlayerOnePrefab;
    public GameObject PlayerTwoPrefab;
    public GameObject RoomPrefab;

    // Start is called before the first frame update
    void Start()
    {
        var PlayerOne = Instantiate(PlayerOnePrefab, transform.position, Quaternion.identity) as GameObject;
        var PlayerTwo = Instantiate(PlayerTwoPrefab, transform.position + new Vector3(1, 1, 0), Quaternion.identity) as GameObject;

        SpawnRooms();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRooms()
    {
        for (int i = 0; i < 5; i++)
        {
            Vector2 spawnPosition = new Vector2(5 + transform.position.x + (5 * i), transform.position.y);
            Instantiate(RoomPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
