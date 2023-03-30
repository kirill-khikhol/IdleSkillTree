using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance { get; private set; }

    [SerializeField] private int _whitePrana;
    [SerializeField] private int _redPrana;
    [SerializeField] private int _greenPrana;
    [SerializeField] private int _bluePrana;



    private void Awake() {
        Instance = this; 
    }


}
