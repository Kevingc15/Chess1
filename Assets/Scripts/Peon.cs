using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peon : MonoBehaviour
{
    //Seleccionar pieza
    private void OnMouseUp()
    {
        GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget = gameObject;

        if (GameObject.Find("Select"))
        {
            Destroy(GameObject.Find("Select"));
        }

        GameObject newSelect = Instantiate(GameObject.Find("GameHandler").GetComponent<GameHandler>().objs[13]);
        newSelect.name = "Select";
        newSelect.transform.position = transform.position + new Vector3(0, 1.5f, 0);
    }
}
