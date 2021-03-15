using DG.Tweening;
using UnityEngine;

public class DoTweenController : MonoBehaviour
{
    [SerializeField]
    private Vector3 _targetLocation = Vector3.zero;

    private Vector3 _tL;

    [Range(0.5f, 10.0f), SerializeField]
    private float _moveDuration = 1.0f;

    [SerializeField]
    private Ease _moveEase = Ease.InOutBounce;

    [SerializeField]
    private DoTweenType _doTweenType = DoTweenType.MovementOneWay;

    private enum DoTweenType
    {
        MovementOneWay,

    }

    private void Start()
    {
        _tL = transform.position;
    }

    // Start is called before the first frame update
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            //_targetLocation.y = 0f;
            if (_doTweenType == DoTweenType.MovementOneWay)
            {
                //if (_targetLocation == Vector3.zero)
                //_targetLocation = transform.position;
                transform.DOMoveY(_targetLocation.y, _moveDuration).SetEase(_moveEase);
            }
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            _targetLocation = _tL;
            transform.DOMoveY(_targetLocation.y, _moveDuration).SetEase(_moveEase);
        }
    }

}