using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    public GameObject[] hearts;
    public int life;

    void Start()
    {
        life = hearts.Length;
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void takeDamage(int d)
    {
        if(life >= 1)
        {
            life -= d;
            hearts[life].SetActive(false);
        }
       
    }

    public void addLife(int l)
    {
        if(life < hearts.Length)
        {
            hearts[life].SetActive(true);
            life += l;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        takeDamage(1);
    }
}
