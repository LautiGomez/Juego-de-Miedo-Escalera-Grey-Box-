using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AOpening : MonoBehaviour
{
    public GameObject player;
    PlayerMovement1 playerMovement;

    public GameObject fadeScreen;
    public GameObject textBox;
    // Start is called before the first frame update
    void Awake()
    {
        playerMovement = player.GetComponent<PlayerMovement1>();
        StartCoroutine("StartSequence");
    }

    IEnumerator StartSequence()
    {
        playerMovement.disable = true;
        yield return new WaitForSeconds(1.5f);
        textBox.GetComponent<Text>().text = "Texto de Prueba";
        Debug.Log("anda");
        yield return new WaitForSeconds(2f);
        textBox.GetComponent<Text>().text = "";
        fadeScreen.SetActive(false);
        playerMovement.disable = false;
    }

    
}
