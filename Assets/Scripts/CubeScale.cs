using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScale : MonoBehaviour
{
    #region PublicVariables
    #endregion

    #region PrivateVariables
    #endregion

    #region PublicMethod
    private void Start()
    {
        transform.localScale *= Mathf.Sqrt(2);
    }
    #endregion

    #region PrivateMethod
    #endregion
}
