using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hehe.classlib
{
    public interface IService
    {
        public Task<int> Add( int b);

    }
}
