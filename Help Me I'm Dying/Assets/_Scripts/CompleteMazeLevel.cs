﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CompleteMazeLevel : MonoBehaviour
{
    GameObject player;

     GameObject winmenu;

    private void Awake()
    {
        winmenu = GameObject.FindGameObjectWithTag("WinMenu");

        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            Time.timeScale = 1f;
            winmenu.SetActive(true);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
