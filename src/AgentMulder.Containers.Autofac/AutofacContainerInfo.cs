using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using AgentMulder.Containers.Autofac.Patterns;
using AgentMulder.ReSharper.Domain.Containers;
using AgentMulder.ReSharper.Domain.Patterns;
using AgentMulder.ReSharper.Domain.Registrations;

namespace AgentMulder.Containers.Autofac
{
    [Export(typeof(IContainerInfo))]
    public class AutofacContainerInfo : IContainerInfo
    {
        private readonly List<IRegistrationPattern> registrationPatterns; 

        public string ContainerDisplayName
        {
            get { return "Autofac"; }
        }

        public IEnumerable<IRegistrationPattern> RegistrationPatterns
        {
            get { return registrationPatterns; }
        }

        public AutofacContainerInfo()
        {
            registrationPatterns = new List<IRegistrationPattern> 
            {
                new RegisterTypeGeneric(),
                new RegisterTypeNonGeneric(),
            };
        }
    }
}