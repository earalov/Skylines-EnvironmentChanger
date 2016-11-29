﻿using EnvironmentChanger.Detours;
using EnvironmentChanger.Redirection;
using ICities;

namespace EnvironmentChanger
{
    public class Mod : IUserMod
    {
        private static bool _bootstrapped;

        public string Name
        {
            get
            {
                if (!_bootstrapped)
                {
                    //TODO(earalov): restore
                    //RedirectionUtil.RedirectType(typeof (NewGamePanelDetour));
                    LoadPanelUI.Initialize(false);
                    //TODO(earalov): restore
                    //NewGamePanelUI.Initialize();
                    LoadMapPanelUI.Initialize(false);
                    LoadThemePanelUI.Initialize();
                    _bootstrapped = true;
                }
                return "Environment Changer";
            }
        }

        public string Description => "Allows to switch environment or theme when starting a new game or loading a save game/map/theme!";
    }
}
