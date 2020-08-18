using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForceManager : MonoBehaviour
{
    public ConstantForce2D force;
    public Slider slider;
    public float waitTime = 3;

    void Start()
    {
        
    }

    void Update()
    {
        StartCoroutine(WaitForStop(waitTime));

    }

    public void Force()
    {
        force.force = new Vector2(slider.value,0);
        force.torque = slider.value/3;
    }

    public IEnumerator WaitForStop(float time)
    {
        time = waitTime;
        Force();
        yield return new WaitForSeconds(waitTime);
        Stop();
    }

    public void Stop()
    {
        force.force = new Vector2(0, 0);
        force.torque = 0;
        force.enabled = false;
    }
}
