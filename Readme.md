Test dll seems to be produced one level down from where I'd expect so isn't found by test runner.  Moving the files from bin up one directory to `Testing.Test\bin\Debug\net461` rather than `Testing.Test\bin\Debug\net461\bin` gets me this error during testing

```
[8/24/2017 5:47:11 PM Informational] [xUnit.net 00:00:02.1390050] System.MissingMethodException : Method not found: 'System.Net.Http.HttpResponseMessage System.Net.Http.HttpRequestMessageExtensions.CreateResponse(System.Net.Http.HttpRequestMessage, System.Net.HttpStatusCode, !!0)'.
[8/24/2017 5:47:11 PM Informational] [xUnit.net 00:00:02.1390050]       Stack Trace:
[8/24/2017 5:47:11 PM Informational] [xUnit.net 00:00:02.1406438]            at Testing.AwesomeFunction.<Run>d__0.MoveNext()
[8/24/2017 5:47:11 PM Informational] [xUnit.net 00:00:02.1421124]            at System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1.Start[TStateMachine](TStateMachine& stateMachine)
[8/24/2017 5:47:11 PM Informational] [xUnit.net 00:00:02.1435186]            at Testing.AwesomeFunction.Run(HttpRequestMessage req, TraceWriter log)
[8/24/2017 5:47:11 PM Informational] [xUnit.net 00:00:02.1453423]            at Testing.Test.AwesomeFunctionTests.<Is_pretty_awesome>d__0.MoveNext()
[8/24/2017 5:47:11 PM Informational] [xUnit.net 00:00:02.1470333]         --- End of stack trace from previous location where exception was thrown ---
[8/24/2017 5:47:11 PM Informational] [xUnit.net 00:00:02.1490313]            at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(Task task)
[8/24/2017 5:47:11 PM Informational] [xUnit.net 00:00:02.1534351]            at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
[8/24/2017 5:47:11 PM Informational] [xUnit.net 00:00:02.1541644]         --- End of stack trace from previous location where exception was thrown ---
[8/24/2017 5:47:11 PM Informational] [xUnit.net 00:00:02.1547902]            at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(Task task)
[8/24/2017 5:47:11 PM Informational] [xUnit.net 00:00:02.1554317]            at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
[8/24/2017 5:47:11 PM Informational] [xUnit.net 00:00:02.1561898]         --- End of stack trace from previous location where exception was thrown ---
[8/24/2017 5:47:11 PM Informational] [xUnit.net 00:00:02.1573929]            at System.Runtime.CompilerServices.TaskAwaiter.ThrowForNonSuccess(Task task)
[8/24/2017 5:47:11 PM Informational] [xUnit.net 00:00:02.1590616]            at System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(Task task)
[8/24/2017 5:47:11 PM Informational] [xUnit.net 00:00:02.2047474]  
```
