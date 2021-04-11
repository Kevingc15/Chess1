using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rey : MonoBehaviour
{
    

    private void OnMouseUp()
    {
        if (GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget)
        {

            if (GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget.tag == transform.tag)
            {
                Seleccionar();
            }
            else
            {
                if (GameObject.Find("Select"))
                {
                    Destroy(GameObject.Find("Select"));
                }
                GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget.transform.position = new Vector3(transform.position.x, GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget.transform.position.y, transform.position.z);
                GameObject.Find("GameHandler").GetComponent<GameHandler>().CambiarTurno();
                Destroy(gameObject);
            }
        }
        else
        {
            if ((GameObject.Find("GameHandler").GetComponent<GameHandler>().turno && transform.tag == "Negro") || (!GameObject.Find("GameHandler").GetComponent<GameHandler>().turno && transform.tag == "Blanco"))

            {
                    Seleccionar();
            }
        }
    }

    void Seleccionar()
    {
        GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget = gameObject;
        if (GameObject.Find("Select"))
        {
            Destroy(GameObject.Find("Select"));
        }

        GameObject newSelect = Instantiate(GameObject.Find("GameHandler").GetComponent<GameHandler>().objs[13]);
        newSelect.name = "Select";
        newSelect.transform.position = transform.position + new Vector3(0, 1f, 0);
    }
}
