using UnityEngine;

[System.Serializable]
public class BaseData : PlayerData
{
    [SerializeField] private float _moveSpeed; // 이동 속도

    public float MoveSpeed { get { return _moveSpeed; } set { _moveSpeed = value; } }

    [SerializeField] private float _maxJumpPower; // 최대 점프력 = 5m

    public float MaxJumpPower { get { return _maxJumpPower; } set { _maxJumpPower = value; } }

    [SerializeField] private float _rate;

    public float Rate { get { return _rate; } set { _rate = value; } }

    [SerializeField] private float _throwPower;

    public float ThrowPower { get { return _throwPower; } set { _throwPower = value; } }

    [SerializeField] private bool _hasItem;

    public bool HasItem { get { return _hasItem; } set { _hasItem = value; } } //추후에 SaveData 쪽과 연동할 예정.

    [SerializeField] private float _pickUpRange;

    public float PickUpRange { get { return _pickUpRange; ; } set { _pickUpRange = value; } }

    [SerializeField] private bool _isReadyToThrow;
    public bool IsReadyToThrow { get { return _isReadyToThrow; } set { _isReadyToThrow = value; } }

    private Coroutine _walkRoutine;

    public Coroutine WalkRoutine {  get { return _walkRoutine; } set { _walkRoutine = value; } }
}
