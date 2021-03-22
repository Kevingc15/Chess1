using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Casillero : MonoBehaviour
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
        if (GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget)
        {
            GameObject Target = GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget;
            Target.transform.position = transform.position + new Vector3(0, 0.02f, 0);

            if (GameObject.Find("Select"))
            {
                Destroy(GameObject.Find("Select"));
            }

        }
        
    }
}
