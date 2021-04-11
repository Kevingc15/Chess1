using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    public List<GameObject> objs;
    public float offSet;
    public bool turno = false; //false blanco, true negro


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

        CrearPiezas();
    }

    void CrearPiezas()
    {
        char letra = 'A';
        int num = 2;

        GameObject Game_Padre = GameObject.Find("Game_Padre");

        
        //PEONES
            //BLANCAS
        for (int i = 0; i <= 7; i++)
        {
            GameObject newPawn = Instantiate(objs[1], Game_Padre.transform);
            newPawn.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(offSet * 1, 0.55f, offSet * i);
            newPawn.GetComponent<Pieza>().posActual = letra.ToString() + num.ToString();
            letra++;
        }

        letra = 'A';
        num = 7;
            //NEGRAS
        for (int i = 0; i <= 7; i++)
        {
            GameObject newPawn = Instantiate(objs[7], Game_Padre.transform);
            newPawn.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(offSet * 6, 0.25f, offSet * i);
            newPawn.GetComponent<Pieza>().posActual = letra.ToString() + num.ToString();
            letra++;
        }

        //TORRES

        letra = 'A';
        num = 1;
            //BLANCAS
        GameObject newTorre = Instantiate(objs[2], Game_Padre.transform);
        newTorre.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(0, 0.5f, 0);
        newTorre.GetComponent<Pieza>().posActual = letra.ToString() + num.ToString();

        letra = 'H';
        newTorre = Instantiate(objs[2], Game_Padre.transform);
        newTorre.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(0, 0.5f, offSet * 7);
        newTorre.GetComponent<Pieza>().posActual = letra.ToString() + num.ToString();

            //NEGRAS
        letra = 'A';
        num = 8;
        newTorre = Instantiate(objs[8], Game_Padre.transform);
        newTorre.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(offSet * 7, 0.39f, 0);
        newTorre.GetComponent<Pieza>().posActual = letra.ToString() + num.ToString();

        letra = 'H';
        newTorre = Instantiate(objs[8], Game_Padre.transform);
        newTorre.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(offSet * 7, 0.39f, offSet * 7);
        newTorre.GetComponent<Pieza>().posActual = letra.ToString() + num.ToString();

        //Caballo
            //BLANCAS
        letra = 'B';
        num = 1;
        GameObject newCaballo = Instantiate(objs[3], Game_Padre.transform);
        newCaballo.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(0, 0.58f, offSet * 1);
        newCaballo.GetComponent<Pieza>().posActual = letra.ToString() + num.ToString();

        letra = 'G';
        newCaballo = Instantiate(objs[3], Game_Padre.transform);
        newCaballo.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(0, 0.58f, offSet * 6);
        newCaballo.GetComponent<Pieza>().posActual = letra.ToString() + num.ToString();

            //NEGRAS
        letra = 'B';
        num = 8;
        newCaballo = Instantiate(objs[9], Game_Padre.transform);
        newCaballo.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(offSet * 7, 0.45f, offSet * 1);
        newCaballo.GetComponent<Pieza>().posActual = letra.ToString() + num.ToString();

        letra = 'G';
        newCaballo = Instantiate(objs[9], Game_Padre.transform);
        newCaballo.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(offSet * 7, 0.45f, offSet * 6);
        newCaballo.GetComponent<Pieza>().posActual = letra.ToString() + num.ToString();

        //Alfil
            //BLANCAS
        letra = 'C';
        num = 1;
        GameObject newAlfil = Instantiate(objs[4], Game_Padre.transform);
        newAlfil.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(0, 0.70f, offSet * 2);
        newAlfil.GetComponent<Pieza>().posActual = letra.ToString() + num.ToString();

        letra = 'F';
        newAlfil = Instantiate(objs[4], Game_Padre.transform);
        newAlfil.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(0, 0.70f, offSet * 5);
        newAlfil.GetComponent<Pieza>().posActual = letra.ToString() + num.ToString();

          //NEGRAS
        letra = 'C';
        num = 8;
        newAlfil = Instantiate(objs[10], Game_Padre.transform);
        newAlfil.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(offSet * 7, 0.33f, offSet * 2);
        newAlfil.GetComponent<Pieza>().posActual = letra.ToString() + num.ToString();

        letra = 'F';
        newAlfil = Instantiate(objs[10], Game_Padre.transform);
        newAlfil.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(offSet * 7, 0.33f, offSet * 5);
        newAlfil.GetComponent<Pieza>().posActual = letra.ToString() + num.ToString();

        //Reina
         //BLANCAS
        letra = 'D';
        num = 1;
        GameObject newReina = Instantiate(objs[5], Game_Padre.transform);
        newReina.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(0, 0.75f, offSet * 3);
        newReina.GetComponent<Pieza>().posActual = letra.ToString() + num.ToString();

            //NEGRAS
        letra = 'D';
        num = 8;
        newReina = Instantiate(objs[11], Game_Padre.transform);
        newReina.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(offSet * 7, 0.33f, offSet * 3);
        newReina.GetComponent<Pieza>().posActual = letra.ToString() + num.ToString();

        //Rey
            //BLANCAS
        letra = 'E';
        num = 1;
        GameObject newRey = Instantiate(objs[6], Game_Padre.transform);
        newRey.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(0, 0.60f, offSet * 4);
        newRey.GetComponent<Pieza>().posActual = letra.ToString() + num.ToString();

        //NEGRAS
        num = 8;
        newRey = Instantiate(objs[12], Game_Padre.transform);
        newRey.transform.position = GameObject.Find("SpawnC").transform.position + new Vector3(offSet * 7, 0.33f, offSet * 4);
        newRey.GetComponent<Pieza>().posActual = letra.ToString() + num.ToString();
    }

    public void CambiarTurno()
    {
        turno = !turno;
        pTarget = null;
    }

}
