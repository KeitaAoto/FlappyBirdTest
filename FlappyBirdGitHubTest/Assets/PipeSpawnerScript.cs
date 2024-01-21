using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    private float timer = 0f;
    [SerializeField] private float spawnRate = 2.5f;
    [SerializeField] private float random = 5;

    [SerializeField] private GameObject pipes;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pipes, new Vector3(transform.localPosition.x, Random.Range(-random, random), 0), Quaternion.identity);   
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            Instantiate(pipes, new Vector3(transform.localPosition.x, Random.Range(-random, random), 0), Quaternion.identity);
            timer = 0f;
        }
    }
}
