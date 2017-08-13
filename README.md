[![Build Status](https://travis-ci.org/przbadu/NepaliDateConverterCS.svg?branch=master)](https://travis-ci.org/przbadu/NepaliDateConverterCS.svg?branch=master)
# NepaliDateConverterCS

C# Class library for nepali date converter, with NUnit testing framework

## Installation

Download TODO: [DLL]() file and add reference to your project.
Or You can install [https://www.nuget.org/packages/NepaliDateConverter.Net](https://www.nuget.org/packages/NepaliDateConverter.Net) package manger.

## Usage

Convert English Date to Nepali Date

```cs
NepaliDateConverter converter = new NepaliDateConverter();
calendar = converter.ConvertToNepali(2017, 1, 6);
calendar.Year // => 2073
calendar.Month // => 9
calendar.Day // => 22
calendar.WeekDayName // => Friday
calendar.MonthName // => Poush
calendar.WeekDay // => 6
```

convert B.S to A.D

```cs
NepaliDateConverter converter = new NepaliDateConverter();
calendar = converter.ConvertToEnglish(2073, 9, 22);
calendar.Year // => 2017
calendar.Month // => 1
calendar.Day //=> 6
calendar.WeekDayName // => Friday
calendar.MonthName // => January
calendar.WeekDay // => 6
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

Bug reports and pull requests are welcome on GitHub at https://github.com/[USERNAME]/NepaliDateConverterCS. This project is intended to be a safe, welcoming space for collaboration, and contributors are expected to adhere to the [Contributor Covenant](http://contributor-covenant.org) code of conduct.

# References

* [Ruby Gem](https://github.com/przbadu/nepali_date_converter)
* [C# Class Library](https://github.com/przbadu/NepaliDateConverterCS)


## License

The library is available as open source under the terms of the [MIT License](http://opensource.org/licenses/MIT).

