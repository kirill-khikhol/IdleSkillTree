using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PranaCollector : MonoBehaviour
{
    [SerializeField] private TheCore _theCore;
    private CircleCollider2D _circleCollider;

    private void OnEnable() {
        _theCore.OnRangeChanged += TheCore_OnRangeChanged;
    }

    private void TheCore_OnRangeChanged(object sender, System.EventArgs e) {
        Debug.Log($"TheCore_OnRangeChanged: {_theCore.Range}");
        _circleCollider.radius = _theCore.Range;
    }

    private void OnDisable() {
          
    }

    private void OnValidate() {
        _circleCollider = GetComponent<CircleCollider2D>();
        _circleCollider.radius= _theCore.Range;
    }


    private
    // Start is called before the first frame update
    void Start()
    {
        _circleCollider = GetComponent<CircleCollider2D>();
        Debug.Log($"_circleCollider.radius = {_theCore.Range};");
        _circleCollider.radius = _theCore.Range;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision) {
        Debug.Log("OnTriggerEnter2D");
    }
    private void OnTriggerStay(Collider collision) {
        Debug.Log("OnTriggerStay2D");
    }
    private void OnTriggerExit(Collider collision) {
        Debug.Log("OnTriggerExit2D");
    }

    private void OnParticleTrigger() {
        Debug.Log("Callback");
    }
}
