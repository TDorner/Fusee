﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fusee.Math;

namespace SceneManagement
{
    public class RenderMatrix : RenderJob
    {
        private float4x4 _matrix;
        public RenderMatrix(float4x4 matrix)
        {
            _matrix = matrix;
        }

        public override float4x4 GetMatrix()
        {
            return _matrix;
        }
    }
}
