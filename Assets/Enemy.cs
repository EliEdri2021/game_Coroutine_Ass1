using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float moveDelay = 1f;

    void Start()
    {
        StartCoroutine(MoveAfterDelay());
    }

    IEnumerator MoveAfterDelay()
    {
        yield return new WaitForSeconds(moveDelay);
        GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, 0);
    }
}
