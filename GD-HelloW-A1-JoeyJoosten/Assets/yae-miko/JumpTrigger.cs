using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
    public AudioSource Scream;
    public GameObject Player;
    public GameObject Jumpcam;

     void OnTriggerEnter()
    {
        Scream.Play();
        Jumpcam.SetActive(true);
        Player.SetActive(false);
        StartCoroutine(EndJump());
        
    }

    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(59);
        Player.SetActive(true);
        Jumpcam.SetActive(false);
    }


}
