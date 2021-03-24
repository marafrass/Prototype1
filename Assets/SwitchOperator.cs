using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOperator : MonoBehaviour
{

    public Collider trigger;
    public GameObject door;
    public int distanceX;
    public int distanceY;
    public int distanceZ;
    private bool interactable = true;
    public AudioSource source;
    public AudioClip sound;
    public AudioSource doorSource;
    public AudioClip doorSound;
    public GameObject button;
    public GameObject light;
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false); //myGameObject = GameObject var
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnTriggerStay(Collider other)
    {
        text.SetActive(true); //myGameObject = GameObject var
        if (Input.GetKeyDown(KeyCode.E)) {

            if (interactable == true)
            {
                door.transform.Translate(new Vector3(distanceX, distanceY, distanceZ));
                button.transform.Translate(new Vector3(0.2f, 0, 0));
                Destroy(light);
                source.PlayOneShot(sound);
                doorSource.PlayOneShot(doorSound);
                interactable = false;
                text.SetActive(false); //myGameObject = GameObject var

            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        text.SetActive(false); //myGameObject = GameObject var
    }

}
