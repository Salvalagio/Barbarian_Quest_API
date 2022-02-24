using Microsoft.Extensions.DependencyInjection;
using BQuest.Services;
using BQuest.Services.Interfaces;
using BQuest.Domain;
using BQuest.Infrastructure.Data;

namespace BQuest.Infrastructure.IoC
{
    public class DependencyInjection
    {
        public DependencyInjection() { }

        public void Inject(IServiceCollection services) 
        {
            #region Services

                services.AddSingleton<IAlterCharacterService, AlterCharacterService>();
                services.AddSingleton<IDeleteCharacterService, DeleteCharacterService>();
                services.AddSingleton<IConsultCharacterService, ConsultCharacterService>();
                services.AddSingleton<ICreateCharacterService, CreateCharacterService>();

            #endregion

            #region Domain

            #endregion

            #region Infrastructure.Data

            #endregion

        }

    }
}
