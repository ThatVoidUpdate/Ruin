using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TreeExample : MonoBehaviour
{
    public UnityEvent ClearTrees;
    public UnityEvent GenerateTrees;
    public TreeTypeEvent ChangeType;
    public TreeType[] types;
    public float WaitTime;
    private float CurrentTime;
    private int CurrentType = 0;

    // Update is called once per frame
    void Update()
    {
        if (CurrentTime >= WaitTime)
        {
            ClearTrees.Invoke();
            GenerateTrees.Invoke();
            CurrentTime -= WaitTime;
            CurrentType++;
            CurrentType %= types.Length;
            ChangeType.Invoke(types[CurrentType]);
        }

        transform.position = new Vector3((Mathf.Sin(Time.time / 10) * 50) + 50, 17, (Mathf.Cos(Time.time / 10) * 50) + 50);
        transform.LookAt(new Vector3(50, 0, 50));

        CurrentTime += Time.deltaTime;
    }
}
