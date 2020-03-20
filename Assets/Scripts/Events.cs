using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class GameObjectEvent : UnityEvent<GameObject> { } // Can pass a GameObject as an argument in the event

[System.Serializable]
public class IntEvent : UnityEvent<int> { } // Can pass an int as an argument in the event

[System.Serializable]
public class FloatEvent : UnityEvent<float> { } // Can pass a float as an argument in the event

[System.Serializable]
public class TreeTypeEvent : UnityEvent<TreeType> { } // Can pass a TreeType as an argument in the event