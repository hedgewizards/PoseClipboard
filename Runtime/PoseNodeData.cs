using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PoseClipboard
{
    [System.Serializable]
    public struct PoseNodeData
    {
        public Vector3 localPosition, localScale;
        public Quaternion localRotation;
        public PoseNodeData[] children;
    }
}