﻿using Cake.Core.IO;
using NUnit.Framework;

namespace Cake.Flutter.Tests.Build.Aot
{
    [TestFixture]
    public class Flutter
    {
        [Test]
        public void WithoutSettings_CommandIsCorrect()
        {
            var fixture = new FlutterBuildAotFixture
            {
                Settings = new FlutterBuildAotSettings()
            };

            var actual = fixture.Run();
            Assert.That(actual.Args, Is.EqualTo("build aot"));
        }
        [Test]
        public void WithDifferentSettingsTypes_CommandIsCorrect()
        {
            var fixture = new FlutterBuildAotFixture
            {
                Settings = new FlutterBuildAotSettings
                {
                    Target = new FilePath("c:/temp/somewhere/some.dart"),
                    Debug = true,
                    Pub = true,
                    Quiet = false,
                    TargetPlatform = TargetPlatform.AndroidArm64,
                }
            };

            var actual = fixture.Run();
            Assert.That(actual.Args, Is.EqualTo("build aot --target=\"c:/temp/somewhere/some.dart\" --debug --pub --target-platform=android-arm64 --no-quiet"));
        }
    }
}
