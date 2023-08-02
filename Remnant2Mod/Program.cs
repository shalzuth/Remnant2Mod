var mem = new UnrealSharp.Memory("Remnant2-Win64-Shipping");
var ue = new UnrealSharp.UnrealEngine(mem);
ue.UpdateAddresses();
//ue.DumpSdk(@"C:\Users\shalzuth\Documents\GitHub\Remnant2Mod\Remnant2Sdk\SDK");
using var overlay = new GameOverlay();
overlay.UE = ue;
await overlay.Run();