﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alfil : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp()
    {
        GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget = gameObject;

        if (GameObject.Find("Select"))
        {
            Destroy(GameObject.Find("Select"));
        }

        GameObject newSelect = Instantiate(GameObject.Find("GameHandler").GetComponent<GameHandler>().objs[13]);
        newSelect.name = "Select";
        newSelect.transform.position = transform.position + new Vector3(0, 1.7f, 0);
    }
}