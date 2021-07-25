# Util_Dot_Art_Maker

##### Programing Language: `C#` `Windows Forms App(.NET Framework)`

## Introduction

This is a program that can help you to change different kinds of images and videos into dither images and dot art texts.

#### Supporting image types now: `.jpg` `.png` `.gif`
#### Supporting video type now: `.mp4`

### what's special
This program can make dither and dot art gif from video and gif files.

## Kits

* [NGif](https://github.com/avianbc/NGif)
* [OpenCvSharp](https://github.com/shimat/opencvsharp) managed by [Nuget](https://www.nuget.org/)

## How to use

1. download the folder `\project\Util_Dot_Art_Maker\Util_Dot_Art_Maker\bin\Release`
2. open `Util_Dot_Art_Maker.exe`
3. enjoy functions

## Customized Setting
* Process setting:
    * output width or hight (it will keep the proportion)
    * output threshold (the standard value to judge the picture)
    * output rendering process (dither FS or dither thresh)
* Video setting:
    * Clip start time
    * Clip end time
    * Clip fps (output as gif)

## Functions

* Image to dither image
* Image to dot art image
* Gif to dither gif:
    * origin: ![](https://i.imgur.com/pU1Yt2L.gif)
    * processed: ![](https://i.imgur.com/8HsMscO.gif)
* Gif to dot art gif:
    * origin: ![](https://i.imgur.com/pU1Yt2L.gif)
    * processed: ![](https://i.imgur.com/cdnjAuf.gif)
* Clip video to dither gif:
    * processed: ![](https://i.imgur.com/ybJ4Wvb.gif)
* Clip video to dot art gif:
    * processed: ![](https://i.imgur.com/Qg5kLP9.gif)

## Problem Unsolved

* Blank space may sometimes cause problems on making the right picture (width problem)