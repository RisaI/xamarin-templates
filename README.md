# Xamarin Dotnet Templates
This repo contains installable templates for Xamarin related projects to be used with the `dotnet new` command.

## Installation
1. Clone this repo to a folder.
1. Run `make install` or manually call `dotnet new -i TEMPLATE` for any template you are interested in.
1. Create a new project by calling `dotnet new SHORT`, all available templates can be listed with `dotnet new -l`.

## Using a project created ftom the template
The project can be built using `msbuild` (use the parameter `/t:install` to send it to a device over ADB). This requires Xamarin.Android SDKs to be present on your system and also that you have the `platforms;android-28` Android SDK installed. 

### Minimal installation on Arch Linux
You need these packages to use these templates on Arch:
- [`dotnet-sdk`](https://www.archlinux.org/packages/community/x86_64/dotnet-sdk/)
- [Android SDK and build tools](https://wiki.archlinux.org/index.php/Android#SDK_packages)
- [xamarin-android](https://aur.archlinux.org/packages/xamarin-android/) from AUR
- `platforms;android-28` installed using `/opt/android-sdk/tools/bin/sdkmanager` shipped with `android-sdk`

If you run into issues with `libzip.so.4` missing, just create a symbolic link to the newer version via `ln -s /usr/lib/libzip.so.5 /usr/lib/libzip.so.4`.