using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class HealthBarStat
{
    [SerializeField]
    private healthbar bar;
        
    [SerializeField]
    private float maxVal;

    [SerializeField]
    private float currentVal;
    public float CurrenVal
    {
        get
        {
            return currentVal;
        }
        set
        {
            this.currentVal = Mathf.Clamp(value,0,MaxVal);
            bar.Value = currentVal;
        }
    }

    public float MaxVal
    {
        get
        {
            return maxVal;
        }

        set
        {
            this.maxVal = value;
            bar.MaxValue = value;
        }
    }
    public void Initialize()
    {
        this.MaxVal = maxVal;
        this.CurrenVal = currentVal;
    }
}
