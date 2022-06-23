using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneMaterialManager : MonoBehaviour
{
    //taking the input from user 
    [SerializeField]
    private Material _floorMaterial;
    [SerializeField]
    private Button[] _buttons;
    [SerializeField]
    private Texture[] _textures;

    // Start is called before the first frame update
    void Start()
    {
        // adding listeners on button click
        _buttons[0].onClick.AddListener(() => onClickButtonZero());
        _buttons[1].onClick.AddListener(() => onClickButtonOne());
        _buttons[2].onClick.AddListener(() => onClickButtonTwo());
        _buttons[3].onClick.AddListener(() => onClickButtonThree());
        _buttons[4].onClick.AddListener(() => onClickButtonFour());
        _buttons[5].onClick.AddListener(() => onClickButtonFive());
    }

    // changing the texture on event trigger
    void onClickButtonZero() {
        _floorMaterial.SetTexture("_MainTex", _textures[0]);
    }

    void onClickButtonOne()
    {
        _floorMaterial.SetTexture("_MainTex", _textures[1]);
    }

    void onClickButtonTwo()
    {
        _floorMaterial.SetTexture("_MainTex", _textures[2]);
    }

    void onClickButtonThree()
    {
        _floorMaterial.SetTexture("_MainTex", _textures[3]);
    }

    void onClickButtonFour()
    {
        _floorMaterial.SetTexture("_MainTex", _textures[4]);
    }

    void onClickButtonFive()
    {
        _floorMaterial.SetTexture("_MainTex", _textures[5]);
    }
}
