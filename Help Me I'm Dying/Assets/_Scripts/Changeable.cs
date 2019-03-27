﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Changeable : MonoBehaviour
{

    public GameObject changed;
    public int value;
    public int neededlvl;
    public static int level = -1;
    Text scoretext;
    public string changetext = "Press E to help the planet";

    FPS fps;


    private void Awake()
    {
        scoretext = GameObject.Find("ScoreText").GetComponentInChildren<Text>();
        fps = GameObject.FindGameObjectWithTag("Player").GetComponent<FPS>();
    }

    private void Update()
    {
        scoretext.text = "" + level +" Eco - Points";
    }

    public void Change()
    {
        if (level >= neededlvl)
        {
            level += value;
            //GameObject newobj = 
            Instantiate(changed, transform.position, transform.rotation);
            fps.SavePlayer();
            //newobj.transform.localScale = gameObject.transform.localScale;
            Destroy(gameObject);
        }
    }
}
