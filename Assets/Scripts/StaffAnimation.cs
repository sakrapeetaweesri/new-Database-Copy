using System;
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
        if (_staff.State == UnitState.Harvest)
        {
            DisableAll();
            _anim.SetBool("isHarvest", true);
        }
        if (_staff.State == UnitState.Sow)
        {
            DisableAll();
            _anim.SetBool("isSow", true);
        }
        if (_staff.State == UnitState.Water)
        {
            DisableAll();
            _anim.SetBool("isWater", true);
        }
        if (_staff.State == UnitState.Plow)
        {
            DisableAll();
            _anim.SetBool("isPlow", true);
        }
        
    }

    private void DisableAll()
    {
        _anim.SetBool("isIdle", false);
        _anim.SetBool("isWalk", false);
        _anim.SetBool("isHarvest", false);
        _anim.SetBool("isSow", false);
        _anim.SetBool("isWater", false);
        _anim.SetBool("isPlow", false);
    }
}
