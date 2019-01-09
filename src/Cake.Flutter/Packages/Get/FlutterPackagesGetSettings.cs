using System;
using System.Runtime.CompilerServices;
using Cake.Core.IO;

namespace Cake.Flutter
{
	/// <summary>
	/// Settings for flutter packages get.
	/// Get packages in a Flutter project..
	/// </summary>
	[CompilerGenerated]
	public sealed class FlutterPackagesGetSettings : AutoToolSettings
	{
		/// <summary>
		/// -h, --help       Print this usage information.
		/// </summary>
		public bool? Help { get; set; }
		/// <summary>
		/// --offline    Use cached packages instead of accessing the network.
		/// </summary>
		public bool? Offline { get; set; }
	}
}