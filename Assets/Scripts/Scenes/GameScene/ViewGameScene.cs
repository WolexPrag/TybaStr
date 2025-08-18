using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewGameScene : MonoBehaviour
{
    private ViewModelGameScene _viewModel;
    public void Init(ViewModelGameScene viewModel)
    {
        _viewModel = viewModel;
    }
}
