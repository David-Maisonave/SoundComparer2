# SoundComparer2
A GUI application to compare and calculate accuracy between two audio files (WAV) using FFT (Fast Fourier Transform) comparison method.
[![ScreenShot](src/Resources/Image/Screenshot.png)](https://github.com/David-Maisonave/SoundComparer2)

This is a fork from [eriekrahman/SoundComparer](https://github.com/eriekrahman/SoundComparer). This fork has 1 bug fix and multiple GUI enhancements.

## Compare Audio Files of different types and or format
Currently, SoundCompare2 can only compare WAV files. To compare files having different file types and/or format, use the script file ConvertAudioFileToSimpleWav.cmd.

FFMpeg.exe is required in order to use ConvertAudioFileToSimpleWav.cmd. This batch script converts all the audio files in a directory to a bare bone basic mono WAV file. The resulting files can then be accurately compared for similarities.
