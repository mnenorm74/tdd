﻿using System;
using System.Drawing;
using FluentAssertions;
using NUnit.Framework;

namespace TagsCloudVisualization
{
    [TestFixture]
    public class Spriral_Tests
    {
        private Spiral spiral;
        
        [SetUp]
        public void SetUp()
        {
            spiral = new Spiral(new Point(100, 100));
        }
        
        [Test]
        public void GetNextPoint_SpiralRadius_ShouldBeGreaterThanBefore()
        {
            var previousRadius = spiral.Radius;
            spiral.GetNextPoint();
            var currentRadius = spiral.Radius;
            var difference = currentRadius - previousRadius;
            difference.Should().BePositive();
        }

        [Test]
        public void GetNextPoint_SpiralAngle_ShouldBeGreaterThanBefore()
        {
            var previousAngle = spiral.Angle;
            spiral.GetNextPoint();
            var currentAngle = spiral.Angle;
            var difference = currentAngle - previousAngle;
            difference.Should().BePositive();
        }
    }
}