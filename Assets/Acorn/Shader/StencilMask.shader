Shader "Unlit/StencilMask"
{
    SubShader
    {
        Tags { "Queue" = "Geometry-1" }
        
        ZWrite Off
        ColorMask 0 //不写入任何颜色（完全透明）
        
        Stencil
        {
            Ref 2          // 参考值设为 2
            Comp Always    // 永远通过比较
            Pass Replace   // 把参考值写入模板缓冲
        }

        Pass {}
    }
}