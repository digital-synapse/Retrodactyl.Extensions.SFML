# Retrodactyl.Extensions.DotNet

A collection of useful extensions to classes and data structure in SFML.NET

##### Get the Nuget Package: 

[![NuGet version (Retrodactyl.Extensions.SFML)](https://img.shields.io/nuget/v/Retrodactyl.Extensions.SFML)](https://www.nuget.org/packages/Retrodactyl.Extensions.SFML/)


## Quick Start

Image Extensions
```
// perform an image transformation pixel by pixel (converting to grayscale)
image.Map(p => {
  var grayscale = (byte)(p.R + p.G + p.B / 3f);
  return new Color(grayscale, grayscale, grayscale, 255);
)

// evaluate all pixels with AND logic
var imageIsOpaque = image.All(p => p.A == 255);

// evaluate all pixels with OR logic
var imageIsTransparent = image.Any(p => p.A < 255);
```

Vector2 Extensions
```
  var a = new Vector2f(10,10);
  var b = new Vector2f(20,20);
  
  // 2d distance function
  float distance = a.Dist(b);

  // vector maths
  float product = a.Mul(b);
  float sum = a.Add(b);
  float quotient = a.Div(b);
  float difference = a.Sub(b);
  float dotProduct = a.Dot(b);
```