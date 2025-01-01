using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private int _score;
    [SerializeField] private TextMeshProUGUI _scoreText;
  //  [SerializeField] private Slider _healthSlider;
    [SerializeField] private GameObject _blastParticle;

    public static GameManager Instance;

    private void Awake() => Instance = this;

    public void ScoreIncrease()
    {
        _score += 10;
        _scoreText.text = "Score" + _score;
    }

  //  public void PlanetGotHit() => _healthSlider.Value -= 5;

    public void BlastEffect(Transform _pos)
    {
        GameObject _partical = Instantiate(_blastParticle, _pos.position, _pos.rotation);
        Destroy(_partical, 2f);
    }


}
