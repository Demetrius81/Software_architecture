using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudService.Model.Abstractions;
public class Entity : IEntity
{
    public int Id { get; set; }
}
