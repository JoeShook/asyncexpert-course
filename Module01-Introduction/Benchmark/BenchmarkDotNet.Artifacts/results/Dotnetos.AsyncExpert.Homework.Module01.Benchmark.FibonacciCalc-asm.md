## .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       cmp       rsi,1
       je        short M00_L00
       cmp       rsi,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       lea       rdx,[rsi+0FFFE]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       mov       rbx,rax
       lea       rdx,[rsi+0FFFF]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       add       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 76
```

## .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       lea       rdx,[rsi+1]
       test      rdx,rdx
       jl        short M00_L00
       mov       rcx,offset MT_System.UInt64[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdx,rax
       mov       rcx,rsi
       mov       rax,offset Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemoized(UInt64, UInt64[])
       add       rsp,20
       pop       rsi
       jmp       rax
M00_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 62
```
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemoized(UInt64, UInt64[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       jl        short M01_L03
       mov       rbx,rdi
       mov       eax,[rsi+8]
       movsxd    rax,eax
       cmp       rbx,rax
       jae       short M01_L04
       mov       rax,[rsi+rbx*8+10]
       test      rax,rax
       je        short M01_L00
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       cmp       rdi,1
       je        short M01_L01
       cmp       rdi,2
       jne       short M01_L02
M01_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rbp,rbx
       lea       rcx,[rdi+0FFFE]
       mov       rdx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemoized(UInt64, UInt64[])
       mov       r14,rax
       lea       rcx,[rdi+0FFFF]
       mov       rdx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemoized(UInt64, UInt64[])
       add       rax,r14
       mov       [rsi+rbp*8+10],rax
       mov       rax,[rsi+rbx*8+10]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 150
```

## .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Iterative(UInt64)
       cmp       rdx,1
       je        short M00_L00
       cmp       rdx,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       ret
M00_L01:
       xor       eax,eax
       mov       ecx,1
       xor       r8d,r8d
       test      rdx,rdx
       jbe       short M00_L05
M00_L02:
       add       rax,rcx
       inc       r8
       cmp       r8,rdx
       jb        short M00_L04
M00_L03:
       mov       rax,rcx
       ret
M00_L04:
       xchg      rax,rcx
       jmp       short M00_L02
M00_L05:
       mov       rcx,rax
       jmp       short M00_L03
; Total bytes of code 58
```

## .NET Core 5.0.0 (CoreCLR 5.0.20.45114, CoreFX 5.0.20.45114), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       cmp       rsi,1
       je        short M00_L00
       cmp       rsi,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       lea       rdx,[rsi+0FFFE]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       mov       rbx,rax
       lea       rdx,[rsi+0FFFF]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       add       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 76
```

## .NET Core 5.0.0 (CoreCLR 5.0.20.45114, CoreFX 5.0.20.45114), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       lea       rdx,[rsi+1]
       test      rdx,rdx
       jl        short M00_L00
       mov       rcx,offset MT_System.UInt64[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdx,rax
       mov       rcx,rsi
       add       rsp,20
       pop       rsi
       jmp       near ptr Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemoized(UInt64, UInt64[])
M00_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 54
```
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemoized(UInt64, UInt64[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       jl        short M01_L03
       mov       rbx,rdi
       mov       eax,[rsi+8]
       movsxd    rax,eax
       cmp       rbx,rax
       jae       short M01_L04
       mov       rax,[rsi+rbx*8+10]
       test      rax,rax
       je        short M01_L00
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       cmp       rdi,1
       je        short M01_L01
       cmp       rdi,2
       jne       short M01_L02
M01_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rbp,rbx
       lea       rcx,[rdi+0FFFE]
       mov       rdx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemoized(UInt64, UInt64[])
       mov       r14,rax
       lea       rcx,[rdi+0FFFF]
       mov       rdx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemoized(UInt64, UInt64[])
       add       rax,r14
       mov       [rsi+rbp*8+10],rax
       mov       rax,[rsi+rbx*8+10]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 150
```

## .NET Core 5.0.0 (CoreCLR 5.0.20.45114, CoreFX 5.0.20.45114), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Iterative(UInt64)
       cmp       rdx,1
       je        short M00_L00
       cmp       rdx,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       ret
M00_L01:
       xor       eax,eax
       mov       ecx,1
       xor       r8d,r8d
       test      rdx,rdx
       jbe       short M00_L05
M00_L02:
       add       rax,rcx
       inc       r8
       cmp       r8,rdx
       jb        short M00_L04
M00_L03:
       mov       rax,rcx
       ret
M00_L04:
       xchg      rax,rcx
       jmp       short M00_L02
M00_L05:
       mov       rcx,rax
       jmp       short M00_L03
; Total bytes of code 58
```

## .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       cmp       rsi,1
       je        short M00_L00
       cmp       rsi,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       lea       rdx,[rsi+0FFFE]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       mov       rbx,rax
       lea       rdx,[rsi+0FFFF]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       add       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 76
```

## .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       lea       rdx,[rsi+1]
       test      rdx,rdx
       jl        short M00_L00
       mov       rcx,offset MT_System.UInt64[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdx,rax
       mov       rcx,rsi
       mov       rax,offset Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemoized(UInt64, UInt64[])
       add       rsp,20
       pop       rsi
       jmp       rax
M00_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 62
```
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemoized(UInt64, UInt64[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       jl        short M01_L03
       mov       rbx,rdi
       mov       eax,[rsi+8]
       movsxd    rax,eax
       cmp       rbx,rax
       jae       short M01_L04
       mov       rax,[rsi+rbx*8+10]
       test      rax,rax
       je        short M01_L00
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       cmp       rdi,1
       je        short M01_L01
       cmp       rdi,2
       jne       short M01_L02
M01_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rbp,rbx
       lea       rcx,[rdi+0FFFE]
       mov       rdx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemoized(UInt64, UInt64[])
       mov       r14,rax
       lea       rcx,[rdi+0FFFF]
       mov       rdx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemoized(UInt64, UInt64[])
       add       rax,r14
       mov       [rsi+rbp*8+10],rax
       mov       rax,[rsi+rbx*8+10]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 150
```

## .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Iterative(UInt64)
       cmp       rdx,1
       je        short M00_L00
       cmp       rdx,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       ret
M00_L01:
       xor       eax,eax
       mov       ecx,1
       xor       r8d,r8d
       test      rdx,rdx
       jbe       short M00_L05
M00_L02:
       add       rax,rcx
       inc       r8
       cmp       r8,rdx
       jb        short M00_L04
M00_L03:
       mov       rax,rcx
       ret
M00_L04:
       xchg      rax,rcx
       jmp       short M00_L02
M00_L05:
       mov       rcx,rax
       jmp       short M00_L03
; Total bytes of code 58
```

## .NET Core 5.0.0 (CoreCLR 5.0.20.45114, CoreFX 5.0.20.45114), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       cmp       rsi,1
       je        short M00_L00
       cmp       rsi,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       lea       rdx,[rsi+0FFFE]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       mov       rbx,rax
       lea       rdx,[rsi+0FFFF]
       mov       rcx,rdi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Recursive(UInt64)
       add       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 76
```

## .NET Core 5.0.0 (CoreCLR 5.0.20.45114, CoreFX 5.0.20.45114), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveWithMemoization(UInt64)
       push      rsi
       sub       rsp,20
       mov       rsi,rdx
       lea       rdx,[rsi+1]
       test      rdx,rdx
       jl        short M00_L00
       mov       rcx,offset MT_System.UInt64[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdx,rax
       mov       rcx,rsi
       add       rsp,20
       pop       rsi
       jmp       near ptr Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemoized(UInt64, UInt64[])
M00_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 54
```
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemoized(UInt64, UInt64[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       jl        short M01_L03
       mov       rbx,rdi
       mov       eax,[rsi+8]
       movsxd    rax,eax
       cmp       rbx,rax
       jae       short M01_L04
       mov       rax,[rsi+rbx*8+10]
       test      rax,rax
       je        short M01_L00
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L00:
       cmp       rdi,1
       je        short M01_L01
       cmp       rdi,2
       jne       short M01_L02
M01_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rbp,rbx
       lea       rcx,[rdi+0FFFE]
       mov       rdx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemoized(UInt64, UInt64[])
       mov       r14,rax
       lea       rcx,[rdi+0FFFF]
       mov       rdx,rsi
       call      Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.RecursiveMemoized(UInt64, UInt64[])
       add       rax,r14
       mov       [rsi+rbp*8+10],rax
       mov       rax,[rsi+rbx*8+10]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 150
```

## .NET Core 5.0.0 (CoreCLR 5.0.20.45114, CoreFX 5.0.20.45114), X64 RyuJIT
```assembly
; Dotnetos.AsyncExpert.Homework.Module01.Benchmark.FibonacciCalc.Iterative(UInt64)
       cmp       rdx,1
       je        short M00_L00
       cmp       rdx,2
       jne       short M00_L01
M00_L00:
       mov       eax,1
       ret
M00_L01:
       xor       eax,eax
       mov       ecx,1
       xor       r8d,r8d
       test      rdx,rdx
       jbe       short M00_L05
M00_L02:
       add       rax,rcx
       inc       r8
       cmp       r8,rdx
       jb        short M00_L04
M00_L03:
       mov       rax,rcx
       ret
M00_L04:
       xchg      rax,rcx
       jmp       short M00_L02
M00_L05:
       mov       rcx,rax
       jmp       short M00_L03
; Total bytes of code 58
```

