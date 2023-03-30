using System;
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

    public event EventHandler<OnWhitePranaChangedEventArgs> OnWhitePranaChanged;
    public class OnWhitePranaChangedEventArgs:EventArgs {
       public int whitePrana;
    }
    public event EventHandler<OnRedPranaChangedEventArgs> OnRedPranaChanged;
    public class OnRedPranaChangedEventArgs:EventArgs {
        public int redPrana;
    }
    public event EventHandler<OnGreenPranaChangedEventArgs> OnGreenPranaChanged;
    public class OnGreenPranaChangedEventArgs:EventArgs {
        public int greenPrana;
    }
    public event EventHandler<OnBluePranaChangedEventArgs> OnBluePranaChanged;
    public class OnBluePranaChangedEventArgs:EventArgs {
        public int bluePrana;
    }


    private void Awake() {
        Instance = this; 
    }

    private void Start() {
        OnWhitePranaChanged?.Invoke(this, new OnWhitePranaChangedEventArgs {
            whitePrana = _whitePrana
        });
        OnRedPranaChanged?.Invoke(this, new OnRedPranaChangedEventArgs {
             redPrana = _redPrana
         });
        OnGreenPranaChanged?.Invoke(this, new OnGreenPranaChangedEventArgs {
             greenPrana = _greenPrana
         });
        OnBluePranaChanged?.Invoke(this, new OnBluePranaChangedEventArgs {
             bluePrana = _bluePrana
         });

    }

    private void Update() {
        //_whitePrana++;
        //OnWhitePranaChanged?.Invoke(this, new OnWhitePranaChangedEventArgs {
        //    whitePrana = _whitePrana
        //});
    }



}
