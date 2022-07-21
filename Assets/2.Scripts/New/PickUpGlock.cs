using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpGlock : MonoBehaviour
{
    PlayerMovement1 playerMovement1;
    [SerializeField] GameObject player;

    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject FakeGlock;
    public GameObject RealGlock;
    public AudioSource PickUpSound;
    public GameObject extraCross;
    


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
            ActionText.GetComponent<Text>().text = "Agarrar";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <=2)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive (false);
                ActionText.SetActive (false);
                PickUpSound.Play();
                FakeGlock.SetActive(false);
                RealGlock.SetActive(true);
            }
        }
       
    }
    private void OnMouseExit()
    {
        extraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }


    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    //codigo de agus
    //Vector3 coordenadas;
    //[SerializeField] GameObject objeto;

    //void almacenarPosicion()
    //{
    //    coordenadas = objeto.transform.position;
    //}


}
