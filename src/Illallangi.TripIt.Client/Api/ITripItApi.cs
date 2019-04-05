namespace Illallangi.TripIt.Api
{
    using System;

    public interface ITripItApi
    {
        IProfileApi ProfileApi { get; }

        ITripApi TripApi { get; }

        ISettingsApi SettingsApi { get; }

        IRequestTokenApi RequestTokenApi { get; }

        IAccessTokenApi AccessTokenApi { get; }

        Action<string> Debug { get; }
    }
}