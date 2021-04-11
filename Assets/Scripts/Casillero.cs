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
            bool puedeMover = true;
            GameObject target = GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget;
            Vector3 posComp = transform.position + new Vector3(0, 0.02f, 0);
            foreach (Transform hijo in GameObject.Find("Game_Padre").transform)
            {
                if (posComp == hijo.transform.position) //Ya había un objeto en el casillero al que me quiero mover
                {
                    if (target.tag == hijo.tag) //Pertenecen al mismo equipo
                    {
                        puedeMover = false;
                    }
                    else //Si hay un enemigo
                    {
                        Destroy(hijo.gameObject);
                        puedeMover = true;
                    }
                }
            }

            if (puedeMover)
            {
                if (CheckMove(target))
                {
                    target.transform.position = transform.position + new Vector3(0, target.transform.position.y, 0);

                    target.GetComponent<Pieza>().posActual = name;

                    GameObject.Find("GameHandler").GetComponent<GameHandler>().CambiarTurno();
                    if (GameObject.Find("Select"))
                    {
                        Destroy(GameObject.Find("Select"));
                    }
                }

               
            }
            else
            {
                Debug.Log("No puedo mover");
            }

            
        }

    }

    public bool CheckMove(GameObject pE)
    {
        double posicionX;
        char posicionY;

        double cx;
        char cy;
        int dif;

        switch (GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget.GetComponent<Pieza>().piezaN)
        {
            case 0 : //Peon
                double pPosicion = char.GetNumericValue(GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget.GetComponent<Pieza>().posActual[1]);
                double cPosicoin = char.GetNumericValue(name[1]);

                if(GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget.tag == "Blanco")
                {
                    if(cPosicoin == (pPosicion + 1) && GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget.GetComponent<Pieza>().posActual[0]== name[0])
                    {
                        
                            return true;
                    }
                    else if(pPosicion == 2 && (cPosicoin == pPosicion + 2))
                    {
                        return CheckCasillero();
                    }
                }
                else
                {
                    if (cPosicoin == (pPosicion - 1) && GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget.GetComponent<Pieza>().posActual[0] == name[0])
                    {
                        return true;
                    }
                    else if(pPosicion == 7 && (cPosicoin == pPosicion - 2))
                    {
                        return CheckCasillero();
                    }
                }
                break;

            case 1: //Torre
                posicionX = char.GetNumericValue(GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget.GetComponent<Pieza>().posActual[1]);
                posicionY = (GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget.GetComponent<Pieza>().posActual[0]);

                cx = char.GetNumericValue(name[1]);
                cy = name[0];
                if(((posicionX == cx) && (posicionY != cy)) || ((posicionY == cy) && (posicionX != cx)))
                {
                    return CheckCasillero();

                }
                break;

            case 2: //Caballo
                posicionX = char.GetNumericValue(GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget.GetComponent<Pieza>().posActual[1]);
                posicionY = (GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget.GetComponent<Pieza>().posActual[0]);

                cx = char.GetNumericValue(name[1]);
                cy = name[0];
                dif = (int)posicionX - (int)cx;

                if (Mathf.Abs(dif) > 2 || Mathf.Abs(dif) == 0)
                {
                    return false;
                }
                else
                {
                    if (Mathf.Abs(dif) == 1)
                    {
                        if(Mathf.Abs(posicionY - cy) == 2)
                        {
                            return true;
                        }
                    }
                    else if ((Mathf.Abs(dif) == 2))
                    {
                        if (Mathf.Abs(posicionY - cy) == 1)
                        {
                            return true;
                        }
                            
                    }
                }

                break;

            case 3: //Alfil
                posicionX = char.GetNumericValue(GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget.GetComponent<Pieza>().posActual[1]);
                posicionY = (GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget.GetComponent<Pieza>().posActual[0]);

                cx = char.GetNumericValue(name[1]);
                cy = name[0];

                if((posicionX != cx)&&(posicionY != cy))
                {
                    dif = (int)posicionX - (int)cx;
                    if(Mathf.Abs(posicionY - cy) == Mathf.Abs(dif))
                    {
                        return CheckCasillero();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }


            case 4: //Reina
                posicionX = char.GetNumericValue(GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget.GetComponent<Pieza>().posActual[1]);
                posicionY = (GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget.GetComponent<Pieza>().posActual[0]);

                cx = char.GetNumericValue(name[1]);
                cy = name[0];
                if (((posicionX == cx) && (posicionY != cy)) || ((posicionY == cy) && (posicionX != cx)))
                {
                    return CheckCasillero();

                }

                if ((posicionX != cx) && (posicionY != cy))
                {
                    dif = (int)posicionX - (int)cx;
                    if (Mathf.Abs(posicionY - cy) == Mathf.Abs(dif))
                    {
                        return CheckCasillero();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }


            case 5: //Rey
                posicionX = char.GetNumericValue(GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget.GetComponent<Pieza>().posActual[1]);
                posicionY = (GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget.GetComponent<Pieza>().posActual[0]);

                cx = char.GetNumericValue(name[1]);
                cy = name[0];
                dif = (int)posicionX - (int)cx;
                if(Mathf.Abs(dif) > 1 || Mathf.Abs(posicionY - cy) > 1)
                {
                    return false;
                }
                if (((posicionX == cx) && (posicionY != cy)) || ((posicionY == cy) && (posicionX != cx)))
                {
                    return CheckCasillero();

                }

                if ((posicionX != cx) && (posicionY != cy))
                {
                    if (Mathf.Abs(posicionY - cy) == Mathf.Abs(dif))
                    {
                        return CheckCasillero();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
        }
        return false;
    }

    public bool CheckCasillero()
    {
        Vector3 t = new Vector3(transform.position.x, GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget.GetComponent<Pieza>().transform.position.y, transform.position.z);
        Vector3 direc = (GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget.GetComponent<Pieza>().transform.position - t).normalized;
        float dist = (GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget.GetComponent<Pieza>().transform.position - t).magnitude;
        RaycastHit[] col = Physics.RaycastAll(GameObject.Find("GameHandler").GetComponent<GameHandler>().pTarget.GetComponent<Pieza>().transform.position, -direc, dist);
        if (col.Length > 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
