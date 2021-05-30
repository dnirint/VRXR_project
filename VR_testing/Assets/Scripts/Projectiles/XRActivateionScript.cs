using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class XRActivateionScript : MonoBehaviour
{
    public void OnActivateWithTrigger()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }

    void Start()
    {
        //gameObject.GetComponent<XRSimpleInteractable>().onActivate.AddListener((val) => { OnActivateWithTrigger(); });
    }
}
