namespace Assets.Scripts
{
    [System.Serializable]
    public class PlayerSoundSettings
    {
        public float MainVolume;
        public float MusicVolume;
        public float SfxVolume;
        public float VoiceVolume;
        public PlayerSoundSettings()
        {

        }
        public PlayerSoundSettings(float mainVolume, float musicVolume, float sfxVolume, float voiceVolume)
        {
            MainVolume = mainVolume;
            MusicVolume = musicVolume;
            SfxVolume = sfxVolume;
            VoiceVolume = voiceVolume;
        }
    }
}
