using UnityEngine;
using System.Collections;

public class interactable : MonoBehaviour {
    public GameObject popup;
	// Use this for initialization
	void Start () {
        popup.SetActive(false);
	}
	
	void OnTriggerEnter(Collider other)
    {
        popup.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        popup.SetActive(false);
    }
}
