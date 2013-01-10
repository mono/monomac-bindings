# MONOMAC variable needs to be edited to match your setup
MONOMAC=/Developer/MonoTouch/Source/monomac/
MONOMAC_DLL=$(MONOMAC)/src/MonoMac.dll
XAMMAC=/Library/Frameworks/Xamarin.Mac.framework/Versions/Current
XAMMAC_DLL=$(XAMMAC)/usr/lib/mono/XamMac.dll
MCS=mcs

all: Mono.Growl.dll Xamarin.Growl.dll

clean:
	-rm -f *.dll*
	-rm -rf xamarin mono

Mono.Growl.dll: ApiDefinition.cs Extra.cs
	mkdir -p mono
	mono $(MONOMAC)/src/bmac.exe -e ApiDefinition.cs --tmpdir=mono -baselib=$(MONOMAC_DLL) -sourceonly mono/sources.list
	$(MCS) -target:library -unsafe -out:$@ Extra.cs @mono/sources.list -r:System.Drawing -r:$(MONOMAC_DLL)

Xamarin.Growl.dll: ApiDefinition.cs Extra.cs
	mkdir -p xamarin
	$(XAMMAC)/usr/bin/bmac -e ApiDefinition.cs --tmpdir=xamarin -baselib=$(XAMMAC_DLL) -sourceonly xamarin/sources.list
	$(MCS) -target:library -unsafe -out:$@ Extra.cs @xamarin/sources.list -r:System.Drawing -r:$(XAMMAC_DLL)
