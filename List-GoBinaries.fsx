let goBinPath = System.IO.Path.Combine(System.Environment.GetEnvironmentVariable("GOPATH"), "bin")

if not (System.IO.Directory.Exists(goBinPath)) then
    printfn "path at %s does not exist." goBinPath
    exit 1
else
    System.IO.Directory.GetFiles(goBinPath)
    |> Array.iter (fun file -> printfn "%s" file)
