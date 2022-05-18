using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_follow : MonoBehaviour
{
    public float speed;
    private Transform Targets;
    // Start is called before the first frame update
    void Start()
    {
        Targets = GameObject.FindGameObjectWithTag("enemyfollow").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Targets.position, speed * Time.deltaTime);
    }
}
