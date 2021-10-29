using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shelf : MonoBehaviour
{

    public GameObject brinquedo;
    public GameController gc;

    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (gc.objOvelha && gameObject.name == "Tronco1")
            {
                brinquedo.SetActive(true);
                //Instantiate(ovelha, spawn);
                gc.objOvelha = false;
            }
            else if (gc.objCoelho && gameObject.name == "Tronco2")
            {
                brinquedo.SetActive(true);
                gc.objCoelho = false;
            }
            else if (gc.objMacaco && gameObject.name == "Tronco3")
            {
                brinquedo.SetActive(true);
                gc.objMacaco = false;
            }
            else if (gc.objPinguim && gameObject.name == "Tronco4")
            {
                brinquedo.SetActive(true);
                gc.objPinguim = false;
            }
            else if (gc.objPorco && gameObject.name == "Tronco5")
            {
                brinquedo.SetActive(true);
                gc.objPorco = false;
            }
            else if (gc.objUrso && gameObject.name == "Tronco6")
            {
                brinquedo.SetActive(true);
                gc.objUrso = false;
            }
        }
     }


















}
