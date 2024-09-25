using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum RolleInKlasse
{
    Lehrer,
    Schueler
}

public class Mensch : MonoBehaviour
{
    [SerializeField] private Color augenfarbe;
    [SerializeField] private string personName;
    [SerializeField] private RolleInKlasse rolleInKlasse;
    [SerializeField] private Sprite meinBild;

    // Start is called before the first frame update
    void Start()
    {
        Image objImage = GetComponent<Image>();
        objImage.sprite = meinBild;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
