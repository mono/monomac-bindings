TwoMinuteGrowler
================

Shows the use of using Growl in your applications.  It is simple Two-Minute countdown timer that
notifies the user by Growl notifications of specific time events.

Author:  Kenneth J. Pouncey 2011/01/23 

Requirements:
=============
Growl application installed
Growl SDK to be linked in
And of course either MonoMac or Xamarin.Mac

Distributing the Growl framework:
=================================

By default the sample looks for the Growl framework installed in /Library/Frameworks

However you can also include the framework inside your own application. This will ease distribution by avoiding an extra dependency.

In this case you'll need to add a custom command for After Build:

mkdir -p ${TargetDir}/${SolutionName}.app/Contents/Frameworks; cp –r <LINK_TO_YOUR_GROWL_FRAMEWORK>/Frameworks/Growl.framework ${TargetDir}/${SolutionName}.app/Contents/Frameworks

Make sure you replace the <LINK_TO_YOUR_GROWL_FRAMEWORK> with the directory location where you copied the SDK frameworks.


For a full description of the process of linking the Growl framework can be found here:
http://cocoa-mono.org/archives/254/growl-my-monomac-application-says/
