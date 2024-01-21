using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    private float timer = 0f;
    [SerializeField] private float spawnRate = 2.5f;

    [SerializeField] private GameObject pipes;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pipes, transform.localPosition, Quaternion.identity);   
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            Instantiate(pipes, transform.localPosition, Quaternion.identity);
            timer = 0f;
        }
    }
}
