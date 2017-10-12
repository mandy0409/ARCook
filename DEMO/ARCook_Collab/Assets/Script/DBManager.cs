﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBManager : MonoBehaviour {

    private static DBManager _instance;
    public static DBManager instance { get { return _instance; } }
    void Awake()
    {
        _instance = this;
    }

    public WWW GET(string url)
    {
        WWW www = new WWW(url);
        StartCoroutine(WaitForRequest(www));
        return www;

    }

    public WWW POST(string url, Dictionary<string, string> post)
    {
        WWWForm form = new WWWForm();
        foreach(KeyValuePair<string,string> post_arg in post)
        {
            form.AddField(post_arg.Key, post_arg.Value);

        }
        WWW www = new WWW(url, form);

        StartCoroutine( WaitForRequest(www) );
        return www;

    }

    private IEnumerator WaitForRequest(WWW www)
    {

        yield return www;

        if(www.error==null)
        {
            Debug.Log("www url:"+www.text);


        }
        else
        {
            Debug.Log("www error:" + www.error);
        }
    }
 
}