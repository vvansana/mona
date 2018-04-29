using AutoMapper;
using AutoMapper.Configuration;
using Mona.Webapi.Models;
using SharedKernel.Data.Repository;
using SharedKernelData.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.Data
{
   public static class AutoMapperInitializer
    {
        public static IMapper Mapper { get; set; }
        public static void Initialize()
        {
         
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
            Mapper = new Mapper(mapperConfig);
        }
    }
}
