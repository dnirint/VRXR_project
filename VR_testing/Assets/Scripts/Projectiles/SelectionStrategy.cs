using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SelectionStrategy : MonoBehaviour
{

    public void OnActivateWithTrigger()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<XRSimpleInteractable>().onActivate.AddListener((val) => { OnActivateWithTrigger(); });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
