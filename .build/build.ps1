#Requires -Version 7.0

$RootDir = Split-Path $PSScriptRoot
$ProjectDir = "$RootDir/CreateAppCli"

dotnet publish $ProjectDir

$global:createapp = "$ProjectDir/bin/Debug/net5.0/create-app.dll"