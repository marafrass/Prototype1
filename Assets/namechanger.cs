using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class namechanger : MonoBehaviour
{
    public TextAsset changingText;
    public GameObject textToChange;

    private string[] names = new string[] {
        "BULLETSTAB X",
        "PHLEGM",
        "GORELOAD",
        "COOM",
        "MOOM",
        "DEATH MAN",
        "KILLERGUN",
        "PUTRIFY",
        "MAIMER",
        "GIBS: DEADLY GIBS",
        "FUDGE",
        "HOLE SHOOTER",
        "SKELETON X",
        "DUNDERDOG",
        "WEAPON ALPHA: REVENGE",
        "INORDINATE EXSANGUINATION",
        "BOX IS A WEEB",
        "LOREGUN",
        "CHOCOLATE QUAKE",
        "SEISMIC FUDGE",
        "DECAY",
        "RANCID",
        "QUICKKILL",
        "MURDER MONK",
        "GUNFIRE: RELOADED",
        "L.M.A.O.",
        "REAVER 11",
        "IMPACT X",
        "CHUD",
        "LONG LONG MAN"
    
    };


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeName() {

        string randomString = names[Random.Range(0, names.Length)];
        textToChange.GetComponent<UnityEngine.UI.Text>().text = randomString;


    }




}
