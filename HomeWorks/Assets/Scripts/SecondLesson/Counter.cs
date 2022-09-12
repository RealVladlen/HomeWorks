using TMPro;
using UnityEngine;
using DG.Tweening;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Counter : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _count;

    [SerializeField] private GameObject _vinPanel, _startText, _counter;

    [SerializeField] private PlayerController _playerController;


    private int _coinsCount;

    private CanvasGroup _vinPanelCanvas, _startTextCanvas;

    private void Awake()
    {
        _vinPanelCanvas = _vinPanel.GetComponent<CanvasGroup>();
        _startTextCanvas = _startText.GetComponent<CanvasGroup>();
    }

    private void Start()
    {
        _coinsCount = 0;
        _count.text = _coinsCount.ToString() + " / 5";

        _startTextCanvas.DOFade(0, 0.5f).SetDelay(3).onComplete += () => 
        {
            _startText.SetActive(false);
        };
    }

    public void UpCountCoins()
    {
        _counter.transform.DOScale(new Vector3(1.25f, 1.25f, 1.25f),0.1f).SetLoops(2,LoopType.Yoyo);

        _coinsCount++;
        _count.text = _coinsCount.ToString() + " / 5";

        if (_coinsCount >= 5)
        {
            _vinPanel.SetActive(true);
            _vinPanelCanvas.DOFade(1, 0.5f);
            _playerController.EndGame();
        }
    }
}
