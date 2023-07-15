
if (test-path ./nupkg) {
    remove-item ./nupkg -Force -Recurse
}   

dotnet build -c Release

$filename = gci "./nupkg/*.nupkg" | sort LastWriteTime | select -last 1 | select -ExpandProperty "Name"


$len = $filename.length

if ($len -gt 0) {
    Write-Host "Signing... $filename"
    nuget sign  ".\nupkg\$filename" -CertificateSubject "West Wind Technologies" -timestamper " http://timestamp.digicert.com"  
       
    nuget push  ".\nupkg\$filename" -source "https://nuget.org" 
}