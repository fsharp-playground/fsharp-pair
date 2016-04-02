
#r "packages/FsUnit/lib/net45/FsUnit.NUnit.dll"
#I "packages/FsUnit/lib/net45"

#r "packages/NUnit/lib/dotnet/nunit.framework.dll"
#I "packages/NUnit/lib/dotnet"

open FsUnit
open NUnit.Framework

1 + 1 |> should equal  4
1 + 1 |> should equal  4
1 + 1 |> should equal  4



