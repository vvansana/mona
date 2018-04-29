// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultRegistry.cs" company="Web Advanced">
// Copyright 2012 Web Advanced (www.webadvanced.com)
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace MonaLisaWebApi.DependencyResolution {
    using AutoMapper;
    using AutoMapper.Configuration;
    using DisconnectedGenericRepository;
    using SharedKernel.Data;
    using SharedKernel.Data.Repository;
    using SharedKernelData.Context;
    using StructureMap;
    using StructureMap.Configuration.DSL;
    using StructureMap.Graph;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DefaultRegistry : Registry {
        #region Constructors and Destructors

        public DefaultRegistry() {
            Scan(
                scan => {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
					scan.With(new ControllerConvention());
                });
            //For<IExample>().Use<Example>();
            For<DbContext>().Use<DatabaseContext>().Transient();
            For<IProductRepository>().Use<ProductRepository>().Transient();

            //Get all Profiles
            var profiles = typeof(AutomapperProfile).Assembly.GetTypes()
                .Where(x => typeof(Profile).IsAssignableFrom(x))
                .Select(x => (Profile)Activator.CreateInstance(x));
            //For each profile, include that profile in the MapperConfiguration
            var config = new MapperConfigurationExpression();
           
            foreach (var profile in profiles)
            {
                config.AddProfile(profile);
            }


            //Create a mapper that will be used by the DI container
            var mapperConfig = new MapperConfiguration(config);
            var mapper = new Mapper(mapperConfig);

            //Register the DI interfaces with their implementation
            For<IMapper>().Use(mapper);
            //sample code to only replace DatabaseContext with DbContent for GenericRepository
            //For(typeof(GenericRepository<>))
            //    .Use(typeof(GenericRepository<>))
            //    .Ctor<DbContext>().Is(new DatabaseContext());
          
        }

        #endregion
    }
}