using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Data : MonoBehaviour
{
    public int maxHealth;
    public static int health;

    void Start()
    {
        health = maxHealth;
    }
    void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        }
    }

}
