using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _whiteScore;
    [SerializeField] private TextMeshProUGUI _redScore;
    [SerializeField] private TextMeshProUGUI _greenScore;
    [SerializeField] private TextMeshProUGUI _blueScore;


    private void Start() {
        ResourceManager.Instance.OnWhitePranaChanged += ResourseManager_OnWhitePranaChanged;
        ResourceManager.Instance.OnRedPranaChanged += ResourseManager_OnRedPranaChanged;
        ResourceManager.Instance.OnGreenPranaChanged += ResourseManager_OnGreenPranaChanged;
        ResourceManager.Instance.OnBluePranaChanged += ResourseManager_OnBluePranaChanged;
    }

    private void ResourseManager_OnBluePranaChanged(object sender, ResourceManager.OnBluePranaChangedEventArgs e) {
        _blueScore.text = e.bluePrana.ToString();
    }

    private void ResourseManager_OnGreenPranaChanged(object sender, ResourceManager.OnGreenPranaChangedEventArgs e) {
        _greenScore.text = e.greenPrana.ToString();
    }

    private void ResourseManager_OnRedPranaChanged(object sender, ResourceManager.OnRedPranaChangedEventArgs e) {
        _redScore.text = e.redPrana.ToString(); ;
    }

    private void ResourseManager_OnWhitePranaChanged(object sender, ResourceManager.OnWhitePranaChangedEventArgs e) {
        _whiteScore.text = e.whitePrana.ToString();
    }

}
