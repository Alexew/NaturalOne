using Blazored.LocalStorage;
using NaturalOne.Models;

namespace NaturalOne.Services
{
    public interface IUserSettingsService
    {
        public Task<UserSettings> Get();
        public Task Set(UserSettings settings);
    }

    public class UserSettingsService : IUserSettingsService
    {
        private const string KEY = "userSettings";
        private readonly ILocalStorageService _localStorage;

        public UserSettingsService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public async Task<UserSettings> Get()
        {
            var settings = await _localStorage.GetItemAsync<UserSettings>(KEY);

            settings ??= new UserSettings();

            return settings;
        }

        public async Task Set(UserSettings settings)
        {
            await _localStorage.SetItemAsync(KEY, settings);
        }
    }
}