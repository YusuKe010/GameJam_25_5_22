using UnityEngine;

/// <summary>
/// プレイヤーの動きに合わせて背景が滑らかに動く（パララックス）
/// </summary>
public class ParallaxBackground : MonoBehaviour
{
    [SerializeField] private Transform player; // プレイヤーのTransform
    [SerializeField] private float parallaxFactor = 0.5f; // 0〜1の値（小さいほど遅く動く）

    private Vector3 _previousPlayerPosition;


    private void LateUpdate()
    {
        transform.position = new Vector3(player.position.x, player.position.y + 2); ;
    }
}
