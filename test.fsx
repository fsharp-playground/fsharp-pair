
#r "packages/FsUnit/lib/net45/FsUnit.NUnit.dll"
#r "packages/NUnit/lib/net45/nunit.framework.dll"

#I "packages/FsUnit/lib/net45/"
#I "packages/NUnit/lib/dotnet/"

open FsUnit
open NUnit.Framework

1 + 1 |> should equal 0


