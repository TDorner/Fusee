﻿using System.Collections.Generic;
using Fusee.Math;
using ProtoBuf;

namespace Fusee.Serialization
{
    [ProtoContract]
    public class SceneNodeContainer
    {
        [ProtoMember(1)]
        public string Name;

        [ProtoMember(2)]
        public TransformContainer Transform;

        [ProtoMember(3, AsReference = true)]
        public List<SceneComponentContainer> Components;

        [ProtoMember(4, AsReference = true)]
        public List<SceneNodeContainer> Children;

        [ProtoMember(5)]
        public bool IsBone;
    }
}
