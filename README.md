Andriks.HueApiDemo
=========

Demonstration of the open source Q42 library for communication with the Philips Hue bridge.

Download the latest version of this software from [GitHub]https://github.com/andriks2/Andriks.HueApiDemo   

Download the library directly from NuGet [Q42.HueApi on NuGet](https://nuget.org/packages/Q42.HueApi).

## How To install?
Download the source from GitHub or CodeProject.

## Usage

This is a project to demonstrate a few uses of the library. It by no means covers all aspects and
is not intended to be seriously used. E.g. lack of multi-colour light means I could not test the
'hue slider' on the `LightControl`. So if you need that it's up to you...

Also I don't like the extensive use of `var's` and Linq that is in vogue nowadays. To me `var's`
are a step back to the BASIC language of the 1980's, when all variables were untyped. Yes, I know,
'the compiler knows'. But the point of using types is that the person writing the code knows.

### Open Source Project Credits

* Newtonsoft.Json is used for object serialization
* Q42.HueApi and Q42.ColorConvertors are from [Q42]https://www.q42.nl/en and is maintained 
by [Michiel Post]https://github.com/michielpost

## License

Q42.HueApi is licensed under [MIT](http://www.opensource.org/licenses/mit-license.php "Read more about the MIT license form"). Refer to [license.txt](https://github.com/Q42/Q42.HueApi/blob/master/LICENSE.txt) for more information.

## Contributions

Contributions are welcome. 

## Related Projects

* [Q42.HueApi](https://github.com/Q42/Q42.HueApi)
* [Lists of hue libraries](https://github.com/Q42/hue-libs)
* [Official Philips hue API documentation](http://developers.meethue.com)

