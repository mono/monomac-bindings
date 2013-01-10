using System;
using System.IO;
using MonoMac.AppKit;
using MonoMac.Foundation;
using MonoMac.ObjCRuntime;

namespace TwoMinuteGrowler {

	public partial class MainWindow : NSWindow {

		public MainWindow (IntPtr handle) : base (handle)
		{
			Initialize ();
		}

		[Export("initWithCoder:")]
		public MainWindow (NSCoder coder) : base (coder)
		{
			Initialize ();
		}

		void Initialize ()
		{
			// First check if Growl is available globally
			string growlPath = "/Library/Frameworks/Growl.framework/Growl";
			// if not...
			if (!File.Exists (growlPath)) {
				// then look if the application is bundling the framework
				growlPath = Path.Combine (NSBundle.MainBundle.ExecutablePath, "../../Frameworks/Growl.framework/Growl");
			}
			// Try loading the framework
			if (Dlfcn.dlopen (growlPath, 0) == IntPtr.Zero) {
				// if we can't then show some instructions
				NSAlert alert = NSAlert.WithMessage ("Missing Growl.framework", "Quit", null, null, 
					"See README.md for the additional requirements");
				alert.RunSheetModal (this);
				NSApplication.SharedApplication.Terminate (this);
			}
		}
	}
}