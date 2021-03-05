using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public List<GameObject> objs;
    public float offSet;  

    //Pieza Seleccionada
    public GameObject pTarget;
    void Start()
    {
        StartMatch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartMatch()
    {
        for(int i = 0; i < 8; i++)
        {
            string name = "";
            switch(i){
                case 0: name += "A";
                    break;
                case 1: name += "B";
                    break;
                case 2: name += "C";
                    break;
                case 3: name += "D";
                    break;
                case 4: name += "E";
                    break;
                case 5: name += "F";
                    break;
                case 6: name += "G";
                    break;
                case 7: name += "H";
                    break;
            }
            for(int j = 0; j < 8; j++)
            {
                string nameP = name + (j + 1).ToString();
                GameObject newCas = Instantiate(objs[0]);
                newCas.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(j * offSet, 0, i * offSet);

                newCas.name = nameP;
            }
        }
        CrearPiezasBlancas();
        CrearPiezasNegras();
    }

    void CrearPiezasBlancas()
    {
        //PEONES
        for(int i = 0; i <= 7; i++)
        {
            GameObject newPawn = Instantiate(objs[1]);
            newPawn.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(offSet * 1, 0.02f, offSet * i);
        }

        //TORRES
        GameObject newTorre = Instantiate(objs[2]);
        newTorre.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(0, 0.02f, 0);
        newTorre = Instantiate(objs[2]);
        newTorre.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(0, 0.02f, offSet * 7);

        //Caballo
        GameObject newCaballo = Instantiate(objs[3]);
        newCaballo.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(0, 0.02f, offSet * 1);
        newCaballo = Instantiate(objs[3]);
        newCaballo.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(0, 0.02f, offSet * 6);

        //Alfil
        GameObject newAlfil = Instantiate(objs[4]);
        newAlfil.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(0, 0.02f, offSet * 2);
        newAlfil = Instantiate(objs[4]);
        newAlfil.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(0, 0.02f, offSet * 5);

        //Reina
        GameObject newReina = Instantiate(objs[5]);
        newReina.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(0, 0.02f, offSet * 3);

        //Rey
        GameObject newRey = Instantiate(objs[6]);
        newRey.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(0, 0.02f, offSet * 4);

    }

    void CrearPiezasNegras()
    {
        //PEONES
        for (int i = 0; i <= 7; i++)
        {
            GameObject newPawn = Instantiate(objs[7]);
            newPawn.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(offSet * 6, 0.02f, offSet * i);
        }
        //TORRES
        GameObject newTorre = Instantiate(objs[8]);
        newTorre.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(offSet * 7, 0.02f, 0);
        newTorre = Instantiate(objs[8]);
        newTorre.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(offSet * 7, 0.02f, offSet * 7);

        //Caballo
        GameObject newCaballo = Instantiate(objs[9]);
        newCaballo.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(offSet * 7, 0.02f, offSet * 1);
        newCaballo = Instantiate(objs[9]);
        newCaballo.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(offSet * 7, 0.02f, offSet * 6);

        //Alfil
        GameObject newAlfil = Instantiate(objs[10]);
        newAlfil.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(offSet * 7, 0.02f, offSet * 2);
        newAlfil = Instantiate(objs[10]);
        newAlfil.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(offSet * 7, 0.02f, offSet * 5);

        //Reina
        GameObject newReina = Instantiate(objs[11]);
        newReina.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(offSet * 7, 0.02f, offSet * 3);

        //Rey
        GameObject newRey = Instantiate(objs[12]);
        newRey.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(offSet * 7, 0.02f, offSet * 4);

    }
}
