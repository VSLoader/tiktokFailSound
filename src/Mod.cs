using System.Drawing;
using GMSL;
using Underanalyzer;
using UndertaleModLib;
using UndertaleModLib.Util;
using UndertaleModLib.Models;

namespace tiktokfailsound;

public class Mod : GMSLMod
{
    // Runs when patching the game when changes are detected.
    public override void Patch()
    {
        Console.WriteLine("[tiktokFailSound]: Patching fail sound...");
        
        var tiktok = File.ReadAllBytes(Path.Combine(assetsDir, "sounds", "tiktok.ogg"));
        var failHard = moddingData.Sounds.First(s => s.Name.Content == "fail_hard");
        var sfxFailSong = moddingData.Sounds.First(s => s.Name.Content == "sfx_failsong");
        failHard.AudioFile.Data = tiktok;
        sfxFailSong.AudioFile.Data = tiktok;
    }

    // Runs before every startup.
    public override void Start() {}
}
