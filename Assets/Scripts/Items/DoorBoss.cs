using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBoss : MonoBehaviour
{
    public GameObject door3;
    public Door door3Script;
    public bool isDoorUsed = false;

    private void Start()
    {
        door3Script = door3.GetComponent<Door>();
        gameObject.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !isDoorUsed)
        {
            isDoorUsed = true;
            StartCoroutine(
                door3Script.MoveDoor(door3Script.openPosition, door3Script.closedPosition)
            );
        }
    }
}
