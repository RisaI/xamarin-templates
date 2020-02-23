
.PHONY: install uninstall clean

install:
	dotnet new -i xamarin-android
	# dotnet new -i xamarin-forms

uninstall:
	dotnet new -u ${PWD}/xamarin-android
	# dotnet new -u ${PWD}/xamarin-forms

clean:
	rm -rf **/bin/ **/obj/