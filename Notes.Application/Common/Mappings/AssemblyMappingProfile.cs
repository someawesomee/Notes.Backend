﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using AutoMapper;
using System.ComponentModel;

namespace Notes.Application.Common.Mappings
{
    public class AssemblyMappingProfile : Profile
    {
        public AssemblyMappingProfile(Assembly assembly) =>
            ApplyMappingFromAssembly(assembly);
        private void ApplyMappingFromAssembly(Assembly assembly)
        {
            var types = assembly.GetExportedTypes()
                .Where(type = > type.GetInterfaces())
                    .Any (i => i.IsGenericType && i.GetGenericTypeDefenition() = typeof(IMapWith<>)))
                        .ToList();
            foreach (var type in types) { }
        }
    }
}
