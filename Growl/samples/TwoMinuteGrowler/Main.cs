using System;
using MonoMac.AppKit;

namespace TwoMinuteGrowler {
	class MainClass {
		static void Main (string[] args)
		{
			NSApplication.Init ();
			NSApplication.Main (args);
		}
	}
}