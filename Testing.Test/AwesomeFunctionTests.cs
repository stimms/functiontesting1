﻿using System;
using System.Threading.Tasks;
using Xunit;

namespace Testing.Test
{
    public class AwesomeFunctionTests
    {
        [Fact]
        async Task Is_pretty_awesome()
        { 
            await AwesomeFunction.Run(new System.Net.Http.HttpRequestMessage(), null);
        }
    }
}
