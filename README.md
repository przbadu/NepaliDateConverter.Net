[![Build Status](https://travis-ci.org/przbadu/NepaliDateConverter.Net.svg?branch=master)](https://travis-ci.org/przbadu/NepaliDateConverter.Net.svg?branch=master)
[![NuGet](https://img.shields.io/nuget/v/NepaliDateConverter.Net.svg)](https://www.nuget.org/packages/NepaliDateconverter.Net)

# Not maintained anymore!!!

Please Fork your own repo and make changes there. Thank you.

# NepaliDateConverter.Net

C# Class library for nepali date converter, with NUnit testing framework

## Installation

### Option 1

Download [Latest Release](https://github.com/przbadu/NepaliDateConverter.Net/releases) extract zip file and include `NepaliDateConverter.dll` file to your project reference.

### Option 2

You can install [https://www.nuget.org/packages/NepaliDateConverter.Net](https://www.nuget.org/packages/NepaliDateConverter.Net)package using Nuget package manger.

> Please use version `>= 2.x`

```sh
Install-Package NepaliDateConverter.Net
```

## Usage

Convert English Date to Nepali Date

```cs
DateConverter converter = DateConverter.ConvertToNepali(2017, 1, 6);
converter.Year // => 2073
converter.Month // => 9
converter.Day // => 22
converter.WeekDayName // => Friday
converter.MonthName // => Poush
converter.WeekDay // => 6
```

convert B.S to A.D

```cs
DateConverter converter = DateConverter.ConvertToEnglish(2073, 9, 22);
converter.Year // => 2017
converter.Month // => 1
converter.Day //=> 6
converter.WeekDayName // => Friday
converter.MonthName // => January
converter.WeekDay // => 6
```

## TODO

* Add more specs

## Gotcha

Till now, we can only convert date from 2000 to 2033 B.S (nepali date).

## Development

* Fork this repository to your github account; And/Or clone it. 
* And then open it in your `Visual Studio` IDE.
* Right click on Solution from Project Explorer and then select `Rebuild` Solution.
* It will download all required packages from Nuget package manager.
* Run `NUnit` test project to make sure everyting is green


## Contributing

Bug reports and pull requests are welcome on GitHub at https://github.com/[USERNAME]/NepaliDateConverter.Net. This project is intended to be a safe, welcoming space for collaboration, and contributors are expected to adhere to the [Contributor Covenant](http://contributor-covenant.org) code of conduct.

# References

* [Ruby Gem](https://github.com/przbadu/nepali_date_converter)
* [C# Class Library](https://github.com/przbadu/NepaliDateConverter.Net)


## License

The library is available as open source under the terms of the [MIT License](http://opensource.org/licenses/MIT).

