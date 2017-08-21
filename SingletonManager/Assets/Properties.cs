using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Properties : MonoBehaviour
{
    void Start()
    {
        GameManager.Instance.Score = 10;
    }
}