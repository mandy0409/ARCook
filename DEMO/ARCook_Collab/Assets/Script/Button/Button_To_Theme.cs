﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_To_Theme : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Click()
    {
        SceneManager.LoadScene("02_1_Theme cooking");   //테마로 돌아가는 버튼
    }

    public void onClick()
    {
        SceneManager.LoadScene("05_WebView");
    }
}