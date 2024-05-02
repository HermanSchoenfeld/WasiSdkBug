This repo demonstrates a bug with dotnet-wasi-sdk showing garbage collection is broken in all circumstances. It's extremely basic.


**Error**
```
[wasm_trace_logger] * Assertion at /home/runner/work/dotnet-wasi-sdk/dotnet-wasi-sdk/modules/runtime/src/mono/mono/metadata/sgen-stw.c:77, condition `info->client_info.stack_start >= info->client_info.info.stack_start_limit && info->client_info.stack_start < info->client_info.info.stack_end' not met
```

**Offending Code**
```csharp
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args) {
            GC.Collect();
        }
    }
}
```

**Environment**
.NET 8, .NET 7
Wasi.Sdk 0.1.4-preview.10020 and 0.1.1
wasmtime-cli 19.0.2 (040ec9209 2024-04-11)
