
.PHONY: install uninstall

install:
	dotnet new -i xamarin-android

uninstall:
	dotnet new -u ${PWD}/xamarin-android