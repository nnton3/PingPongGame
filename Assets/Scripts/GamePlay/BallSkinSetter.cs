using System;
using System.Collections;
using System.Collections.Generic;
using Models;
using Services;
using UnityEngine;

public class BallSkinSetter : MonoBehaviour
{
    [SerializeField] private Material _blueMat, _redMat, _yellowMat;
    private Dictionary<BallSkin, Material> _skinsDic = new Dictionary<BallSkin, Material>();

    private void Start()
    {
        _skinsDic = new Dictionary<BallSkin, Material>
        {
            {BallSkin.Blue, _blueMat},
            {BallSkin.Red, _redMat},
            {BallSkin.Yellow, _yellowMat}
        };

        var skin = SaveGameDataService.Model.BallSkin;
        GetComponent<MeshRenderer>().material = _skinsDic[skin];
    }
}
