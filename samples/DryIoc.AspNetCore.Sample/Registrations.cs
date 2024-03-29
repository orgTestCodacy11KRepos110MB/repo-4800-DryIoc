using DryIoc.AspNetCore.Sample.Services;
//using DryIoc.MefAttributedModel;

namespace DryIoc.AspNetCore.Sample
{
    // Possible organization of registrations by the specifics
    public static class Registrations
    {
        // If you need the whole container then change the parameter type from IRegistrator to IContainer
        public static void RegisterMyBusinessLogic(this IRegistrator r)
        {
            r.Register<ISingletonService, SingletonService>(Reuse.Singleton);
            r.Register<ITransientService, TransientService>(Reuse.Transient);
            r.Register<IScopedService, ScopedService>(Reuse.InCurrentScope);

            r.Register<IExportedService, ExportedService>();

            // optional: registering MEF Exported services
            //var assemblies = new[] { typeof(ExportedService).GetAssembly() };
            //r.RegisterExports(assemblies);
        }
    }
}