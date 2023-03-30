using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript:MonoBehaviour {
    private ParticleSystem _ps;

    // these lists are used to contain the particles which match
    // the trigger conditions each frame.
    //List<ParticleSystem.Particle> enter = new List<ParticleSystem.Particle>();
    List<ParticleSystem.Particle> exit = new List<ParticleSystem.Particle>();

    void OnEnable() {
        _ps = GetComponent<ParticleSystem>();
    }

    void OnParticleTrigger() {

        
    }

}
