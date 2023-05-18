@ECHO OFF
setlocal ENABLEDELAYEDEXPANSION
:: This script converts audio files to a simple basic wav format.
:: This allows a comparison tool (https://github.com/David-Maisonave/SoundComparer2) to be able to 
:: compare audio files to see if they're duplicates fairly accurately even if the original files are in different formats or file types.
:: Requirements:
::				ffmpeg.exe

:: Change the following path to point to ffmpeg.exe if ffmpeg.exe is not in the environmental path
set FFMPEG="ffmpeg.exe"
:: Change the following folder name to the desired target folder to send the converted files
set WorkingPath=Conversions

:: Ussing ffmpeg, convert audio file to *.wav type file with AudioCodec=PCM, Stream=1, Channel=Mono, Quality=Lossless, SampleRate=8k, BitDepth=8
set PRE_ARG=-y -i
set POST_ARG=-vn -c:a pcm_u8 -ar 8000 -rematrix_maxval 1.0 -ac 1 -map 0:a:0? -sn -map_chapters 0 -map_metadata 0 -f wav -threads 0

:: Optionally uncomment the following line and set a source path
:: cd /D E:\Repos\David-Maisonave\MediaFileDuplicateFinder\Test_Data\MediaTestFiles\Audio

mkdir %WorkingPath%
for /f "delims=" %%Q in ('dir *.* /b /a-d-h-s') do (
	%FFMPEG% %PRE_ARG% "%%Q" %POST_ARG% "%WorkingPath%\%%~nQ_ConvertFrom%%~xQ_PCM_8k_8_mono.wav"
)











