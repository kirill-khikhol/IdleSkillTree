using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class TheCore:MonoBehaviour {

    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private int _power;
    [SerializeField] private float _productionRate;
    [SerializeField] private float _range;

    public float Range {
        get { return _range; }

        private set {
            _range=value;
            OnRangeChanged?.Invoke(this,EventArgs.Empty);
        }
    }

    public event EventHandler OnRangeChanged;

    private void OnMouseDown() {
        _power++;
        ChangeBurstCount();
    }

    private void Start() {
        OnRangeChanged?.Invoke(this, EventArgs.Empty);
    }

    private void ChangeBurstCount() {
        _particleSystem.emissionRate = _power;
        //ParticleSystem.EmissionModule emission = _particleSystem.emission;
        //ParticleSystem.Burst burst = emission.GetBurst(0);
        //emission.SetBurst(0, new ParticleSystem.Burst(burst.time, Convert.ToInt16(burst.count.constant + _power)));
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, _range);
    }
    private void OnParticleTrigger() {
        Debug.Log("Callback");
    }
}
