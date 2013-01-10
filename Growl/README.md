Growl Bindings
==============

This is a copy of the Growl bindings that were included directly in monomac.dll in the past. Since Growl is an external application/framework, with a different release schedule than OSX, it is being moved to a separate assembly.

The current bindings are for Growl 1.2.1 (a bit outdated). For information in:
http://cocoa-mono.org/archives/254/growl-my-monomac-application-says/

Notes
=====

The currently (January 2013) shipping versions of MonoMac.dll still contains the MonoMac.Growl namespace. You cannot use the Mono.Growl.dll assembly until a new release of MonoDevelop ships with a newer MonoMac.dll.

Xamarin.Mac version 1.0.40 (and later) can uses Xamarin.Growl.dll. The sample code was update to use XamMac.dll by default - but this can be changed by replacing XamMac.dll by MonoMac.dll and Xamarin.Growl.dll with Mono.Growl.dll (see above).
