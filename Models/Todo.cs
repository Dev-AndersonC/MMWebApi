using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMWebApi.Models
{
    public record Todo(Guid id, string Title, bool Done);
}