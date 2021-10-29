using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Item : MonoBehaviour
{
    public GameController gc;
    public TextMeshProUGUI textMessage;

    private void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }


    private void OnTriggerStay(Collider collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            
            textMessage.enabled = true;
            textMessage.text = "Press E to collect " + gameObject.name;

            if(Input.GetKeyDown(KeyCode.E))
            {
                gc.totalColetado++;
                textMessage.enabled = false;
                Destroy(this.gameObject);
                switch (gameObject.tag)
                {
                    case "Coletavel1":
                        gc.objOvelha = true;
                        gc.imgOvelha.color = new Color(1, 1, 1, 1);
                        break;
                    case "Coletavel2":
                        gc.objPorco = true;
                        gc.imgPorco.color = new Color(1, 1, 1, 1);
                        break;
                    case "Coletavel3":
                        gc.objPinguim = true;
                        gc.imgPinguim.color = new Color(1, 1, 1, 1);
                        break;
                    case "Coletavel4":
                        gc.objMacaco = true;
                        gc.imgMacaco.color = new Color(1, 1, 1, 1);
                        break;
                    case "Coletavel5":
                        gc.objCoelho = true;
                        gc.imgCoelho.color = new Color(1, 1, 1, 1);
                        break;
                    case "Coletavel6":
                        gc.objUrso = true;
                        gc.imgUrso.color = new Color(1, 1, 1, 1);
                        break;
                }
            }
        }
    }


    private void OnTriggerExit(Collider collision)
    {
        textMessage.enabled = false;
    }
}
