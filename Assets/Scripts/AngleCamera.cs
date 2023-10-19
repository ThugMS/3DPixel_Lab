using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleCamera : MonoBehaviour
{
    #region PublicVariables
    #endregion

    #region PrivateVariables
    private Camera m_camera;
    #endregion

    #region PublicMethod
    private void OnValidate()
    {
        TryGetComponent(out m_camera);  
    }

    private void LateUpdate()
    {
        m_camera.ResetProjectionMatrix();
        var mat = m_camera.projectionMatrix;

        mat[1, 1] *= Mathf.Sqrt(2);

        m_camera.projectionMatrix = mat;
    }
    #endregion

    #region PrivateMethod
    #endregion
}
