﻿/*
 * The MIT License (MIT)
 * 
 * Copyright (c) 2015 Wu Yuntao
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
*/

using System;

namespace Synchronica.Simulation.Modifiers
{
    sealed class LinearModifier_Int16 : IModifier<short>
    {
        public short GetValue(KeyFrame<short> startFrame, KeyFrame<short> endFrame, int milliseconds)
        {
            var slope = (float)(endFrame.Value - startFrame.Value) / (float)(endFrame.Milliseconds - startFrame.Milliseconds);
            var intercept = (startFrame.Value);
            var value = slope * milliseconds + intercept;

            return (short)Math.Round(value);
        }
    }

    sealed class LinearModifier_Int32 : IModifier<int>
    {
        public int GetValue(KeyFrame<int> startFrame, KeyFrame<int> endFrame, int milliseconds)
        {
            var slope = (float)(endFrame.Value - startFrame.Value) / (float)(endFrame.Milliseconds - startFrame.Milliseconds);
            var intercept = (startFrame.Value);
            var value = slope * milliseconds + intercept;

            return (int)Math.Round(value);
        }
    }

    sealed class LinearModifier_Int64 : IModifier<long>
    {
        public long GetValue(KeyFrame<long> startFrame, KeyFrame<long> endFrame, int milliseconds)
        {
            var slope = (float)(endFrame.Value - startFrame.Value) / (float)(endFrame.Milliseconds - startFrame.Milliseconds);
            var intercept = (startFrame.Value);
            var value = slope * milliseconds + intercept;

            return (long)Math.Round(value);
        }
    }
}
