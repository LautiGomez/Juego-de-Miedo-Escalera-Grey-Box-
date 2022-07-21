using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpen : MonoBehaviour
{
    PlayerMovement1 playerMovement1;
    [SerializeField] GameObject player;

    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject Door;
    public AudioSource doorSound;
    public Transform TeleportDest;
    public GameObject extraCross;
    public Animation doorFade;


    private void Start()
    {
        playerMovement1 = player.GetComponent<PlayerMovement1>();
    }

    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            extraCross.SetActive(true);
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <=2)
            {
                //this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive (false);
                ActionText.SetActive (false);
                doorSound.Play();
                //Door.SetActive(false);
                StartCoroutine("Teleport");
            }
        }
       
    }
    private void OnMouseExit()
    {
        extraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }

    IEnumerator Teleport()
    {
        playerMovement1.disable = true;
        doorFade.Play("DoorFade");
        yield return new WaitForSeconds(1f);
        player.transform.position = TeleportDest.position;
        yield return new WaitForSeconds(1f);
        playerMovement1.disable = false;
    }


    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    //codigo de agus
    //Vector3 coordenadas;
    //[SerializeField] GameObject objeto;

    //void almacenarPosicion()
    //{
    //    coordenadas = objeto.transform.position;
    //}


}
