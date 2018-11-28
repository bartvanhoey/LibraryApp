using System.Threading.Tasks;
using LibraryApp.Configuration.Dto;

namespace LibraryApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
