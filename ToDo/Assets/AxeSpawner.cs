using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeSpawner : MonoBehaviour
{
    public GameObject axe;
    public float spawnRate = 10;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawnAxe(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnAxe();
            timer = 0;
        }
    }

    void spawnAxe()
    {
        Instantiate(axe, transform.position, Quaternion.Euler(Vector3.forward * 25));
    }
}
