using UnityEngine;
using TMPro;
using DG.Tweening;

public class UIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coinsCountText, _lifeCountText, _gamePanelText;

    [SerializeField] private Transform _coinsCountTransform, _lifeCountTransform;

    [SerializeField] private PlaneController _planeController;

    [SerializeField] private GameObject _gamePanel;

    private CanvasGroup _gamePanelCanvas;

    private int _coinsCount;
    private int _lifeCount;

    private void Start()
    {
        _gamePanelCanvas = _gamePanel.GetComponent<CanvasGroup>();

        _coinsCount = 0;
        _lifeCount = 3;
        CoinsUpdate();
        LifeUpdate();
    }

    private void CoinsUpdate()
    {
        _coinsCountText.text = _coinsCount.ToString() + "/10";
    }

    private void LifeUpdate()
    {
        _lifeCountText.text = _lifeCount.ToString();
    }

    public void UpCoins()
    {
        _coinsCount++;
        CoinsUpdate();
        _coinsCountTransform.DOScale(1.5f, 0.15f).SetLoops(2, LoopType.Yoyo);

        if (_coinsCount >= 10)
        {
            GameWin();
        }
    }

    public void UpLife()
    {
        _lifeCount++;
        LifeUpdate();

        _lifeCountTransform.DOScale(1.5f, 0.15f).SetLoops(2, LoopType.Yoyo);
    }
    public void TakingLife()
    {
        _lifeCount--;
        LifeUpdate();

        _lifeCountTransform.DOScale(0.5f, 0.15f).SetLoops(2, LoopType.Yoyo);

        if (_lifeCount <= 0)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        _planeController.ZeroSpeed();
        ShowGamePanel("GameOver!");
    }

    private void GameWin()
    {
        _planeController.ZeroSpeed();
        ShowGamePanel("You win!");
    }

    private void ShowGamePanel(string text)
    {
        _gamePanel.SetActive(true);

        _gamePanelText.text = text;

        _gamePanelCanvas.DOFade(1, 0.5f);
    }
}
