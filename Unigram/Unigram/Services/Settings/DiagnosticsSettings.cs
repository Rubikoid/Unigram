﻿namespace Unigram.Services.Settings
{
    public class DiagnosticsSettings : SettingsServiceBase
    {
        public DiagnosticsSettings()
            : base("Diagnostics")
        {
        }

        private bool? _bubbleAnimations;
        public bool BubbleAnimations
        {
            get => _bubbleAnimations ??= GetValueOrDefault("BubbleAnimations", true);
            set => AddOrUpdateValue(ref _bubbleAnimations, "BubbleAnimations", value);
        }

        private bool? _minithumbnails;
        public bool Minithumbnails
        {
            get => _minithumbnails ??= GetValueOrDefault("Minithumbnails", true);
            set => AddOrUpdateValue(ref _minithumbnails, "Minithumbnails", value);
        }
    }
}
