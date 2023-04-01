using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaffAnimation : MonoBehaviour
{
    private Animator _anim;
    private Staff _staff;

    void Awake()
    {
        _anim = GetComponent<Animator>();
        _staff = GetComponent<Staff>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_staff.State == UnitState.Idle)
        {
            DisableAll();
            _anim.SetBool("isIdle", true);
        }

        if (_staff.State == UnitState.Walk)
        {
            DisableAll();
            _anim.SetBool("isWalk", true);
        }
    }

    private void DisableAll()
    {
        _anim.SetBool("isIdle", false);
        _anim.SetBool("isWalk", false);
    }
}
