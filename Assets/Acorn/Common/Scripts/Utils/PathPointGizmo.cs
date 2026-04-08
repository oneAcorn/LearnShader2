using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class PathPointGizmo : MonoBehaviour
{
    [Header("Gizmo Settings")]
    public Color gizmoColor = Color.cyan;
    public float radius = 0.06f;
    public bool alwaysVisible = true;

    // 只在编辑器中绘制Gizmo
#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        if (alwaysVisible)
        {
            DrawGizmo();
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (!alwaysVisible)
        {
            DrawGizmo();
        }
    }

    private void DrawGizmo()
    {
        Gizmos.color = gizmoColor;
        Gizmos.DrawSphere(transform.position, radius);

        // 可选：添加坐标轴指示
        // Gizmos.color = Color.red;
        // Gizmos.DrawLine(transform.position, transform.position + transform.right * radius * 2);
        // Gizmos.color = Color.green;
        // Gizmos.DrawLine(transform.position, transform.position + transform.up * radius * 2);
        // Gizmos.color = Color.blue;
        // Gizmos.DrawLine(transform.position, transform.position + transform.forward * radius * 2);
    }
#endif
}