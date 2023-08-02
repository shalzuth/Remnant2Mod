using ClickableTransparentOverlay;
using ImGuiNET;
using SDK.Script.EngineSDK;
using SDK.Script.GunfireRuntimeSDK;
using SDK.Script.RemnantSDK;
using System.Net;
using System.Numerics;
using System.Runtime.InteropServices;
using UnrealSharp;

class GameOverlay : Overlay
{
    public UnrealEngine UE { get; set; }
    protected override Task PostInitialized()
    {
        this.VSync = false;
        return Task.CompletedTask;
    }
    [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)] static extern IntPtr GetForegroundWindow();
    protected override void Render()
    {
        if (GetForegroundWindow() != UnrealEngine.Memory.MainWindowHandle) return;
        Config();
        MainMenu();
        Hacks();
    }
    bool IsRunning = true;
    bool IsCollapsed = false;

    bool InfiniteAmmo = true;
    bool NoSway = true;
    bool AutomaticGuns = true;
    bool AimHack = false;
    bool Aiming = false;
    bool TriggerBot = false;
    bool Esp = true;
    bool Heal = false;
    bool Items = true;
    bool Debug = true;
    void Config()
    {
        if (Hotkeys.SinglePress(Keys.Insert)) IsCollapsed = !IsCollapsed;
        if (Hotkeys.SinglePress(Keys.F1)) InfiniteAmmo = !InfiniteAmmo;
        if (Hotkeys.SinglePress(Keys.F2)) NoSway = !NoSway;
        if (Hotkeys.SinglePress(Keys.F3)) AutomaticGuns = !AutomaticGuns;
        if (Hotkeys.SinglePress(Keys.F4)) AimHack = !AimHack;
        if (Hotkeys.SinglePress(Keys.F5)) TriggerBot = !TriggerBot;
        if (Hotkeys.SinglePress(Keys.F6)) Esp = !Esp;
        Heal = Hotkeys.IsPressed(Keys.F7);
        if (Hotkeys.SinglePress(Keys.F8)) Items = !Items;
        if (Hotkeys.SinglePress(Keys.F12)) Debug = !Debug;
        Aiming = Hotkeys.IsPressed(Keys.RightButton);
    }
    void MainMenu()
    {
        ImGui.SetNextWindowCollapsed(IsCollapsed);
        IsCollapsed = !ImGui.Begin("Main Menu (Insert)", ref IsRunning, ImGuiWindowFlags.NoResize | ImGuiWindowFlags.AlwaysAutoResize);
        if (!IsRunning || IsCollapsed)
        {
            ImGui.End();
            if (!IsRunning) Close();
            return;
        }
        ImGui.Text(ImGui.GetIO().Framerate.ToString() + "FPS");
        ImGui.Checkbox("InfiniteAmmo (F1)", ref InfiniteAmmo);
        ImGui.Checkbox("NoSway (F2)", ref NoSway);
        ImGui.Checkbox("AutomaticGuns (F3)", ref AutomaticGuns);
        ImGui.Checkbox("AimHack (F4)", ref AimHack);
        ImGui.Checkbox("TriggerBot (F5)", ref TriggerBot);
        ImGui.Checkbox("ESP (F6)", ref Esp);
        ImGui.Checkbox("Heal (F7)", ref Heal);
        ImGui.Checkbox("Items (F8)", ref Items);
        ImGui.Checkbox("Debug (F12)", ref Debug);
        ImGui.End();
    }
    Dictionary<string, int> weakbone = new Dictionary<string, int>();
    int Hacks()
    {
        var World = new World(UnrealEngine.Memory.ReadProcessMemory<nint>(UnrealEngine.GWorldPtr)); if (!World.IsA<World>()) return 1;
        var OwningGameInstance = World.OwningGameInstance; if (!OwningGameInstance.IsA<GameInstance>()) return 2;
        var LocalPlayers = OwningGameInstance.LocalPlayers;
        var PlayerController = LocalPlayers[0].PlayerController.As<PlayerControllerGunfire>(); if (!PlayerController.IsA<PlayerController>()) return 3;
        var Player = PlayerController.Player;
        var myPlayer = PlayerController.AcknowledgedPawn.As<CharacterGunfire>();
        if (myPlayer == null || !myPlayer.IsA<CharacterGunfire>()) return 4;
        var PlayerCameraManager = PlayerController.PlayerCameraManager; if (!PlayerCameraManager.IsA<PlayerCameraManager>()) return 5;
        var playerFaction = myPlayer.Faction.Value;
        var pDrawList = ImGui.GetForegroundDrawList();
        if (InfiniteAmmo || NoSway || AutomaticGuns || Items)
        {
            var items = myPlayer.CachedInventory.Items;
            for (var i = 0; i < items.Num; i++)
            {
                var item = items[i, true];
                if (false)
                {
                    System.Console.WriteLine("item : " + i);
                    System.Console.WriteLine(item.Dump());
                    System.Console.WriteLine(new UEObject(item.ItemBP.Value).Dump());
                    System.Console.WriteLine(item.EquippedActor.Dump());
                    System.Console.WriteLine(item.InstanceData.Dump());
                }
                if ((InfiniteAmmo || NoSway || AutomaticGuns) && item.EquippedActor.IsA(out RangedWeapon weapon))
                {
                    if (InfiniteAmmo && weapon.AmmoPoolComponent.Value < 50.0f) weapon.AmmoPoolComponent.Value = 100.0f;
                    if (NoSway && weapon.DefaultWeaponMode.CachedProfile.SwayScalarAim > 0)
                        weapon.DefaultWeaponMode.CachedProfile.SwayScalarAim = 0.0f;
                    if (AutomaticGuns)
                        weapon.DefaultWeaponMode.IsAutomatic = true;
                }
                if (InfiniteAmmo && item.InstanceData.IsA(out RangedWeaponInstanceData data))
                {
                    if (data.AmmoInClip < 5) data.AmmoInClip = 10;
                }
                if (Items && item.EquippedActor.IsA(out UseableItem useableItem))
                {
                    if (useableItem.IsA(out DragonHeart heart))
                    {
                        if (heart.DHPoolComponent.Value != 3)
                            heart.DHPoolComponent.Value = 3;
                    }
                    else if (item.InstanceData.IsA(out ItemInstanceData utilityItem))
                    {
                        if (utilityItem.Quantity == 0)
                            utilityItem.Quantity = 1;
                    }
                }
            }
        }
        if (Heal) myPlayer.HealthNormalized = 1000.0f;
        var CameraCache = PlayerCameraManager.CameraCachePrivate;
        var CameraPOV = CameraCache.POV;
        //var CameraLocation = new Vector3((float)CameraPOV.Location.X, (float)CameraPOV.Location.Y, (float)CameraPOV.Location.Z);
        var CameraLocation = UnrealEngine.Memory.ReadProcessMemory<Extensions.Vector3Double>(CameraPOV.Location.Address).ToFloats(); // minor optimization
        //var CameraRotation = new Vector3((float)CameraPOV.Rotation.Pitch, (float)CameraPOV.Rotation.Yaw, (float)CameraPOV.Rotation.Roll);
        var CameraRotation = UnrealEngine.Memory.ReadProcessMemory<Extensions.Vector3Double>(CameraPOV.Rotation.Address).ToFloats(); // minor optimization
        var CameraFOV = CameraPOV.FOV;
        var bestDistance = Single.MaxValue;
        var target = Vector2.Zero;

        // https://github.com/EpicGames/UnrealTournament/blob/3bf4b43c329ce041b4e33c9deb2ca66d78518b29/Engine/Source/Runtime/Engine/Classes/Engine/Level.h#L366
        // Actors
        // StreamedLevelOwningWorld
        // Owning
        var add = World.PersistentLevel.Address;
        var actorListOffset = World.PersistentLevel.GetFieldOffset(World.PersistentLevel.GetFieldAddr("OwningWorld")) - 0x10; // - 0x10 // - 0x20
        // esp
        for (var j = 0; j < World.Levels.Num; j++)
        {
            var level = World.Levels[j];
            var Actors = new Array<Actor>(level.Address + actorListOffset);
            var ac = level.ActorCluster;
            for (var i = 0; i < Actors.Num; i++)
            {
                var Actor = Actors[i];
                if (Actor.Address == 0) continue;
                if (Actor.Address == Player.Address) continue;
                if (Actor.Address == myPlayer.Address) continue;
                if (!Actor.IsA<Actor>()) continue;
                var RootComponent = Actor.RootComponent; if (RootComponent.Address == 0) continue; if (!RootComponent.IsA<SceneComponent>()) continue;
                var RelativeLocation = RootComponent.RelativeLocation; if (RelativeLocation.Address == 0) continue;
                var Location = UnrealEngine.Memory.ReadProcessMemory<Extensions.Vector3Double>(RelativeLocation.Address).ToFloats(); // minor optimization
                var loc = Extensions.WorldToScreen(Location, CameraLocation, CameraRotation, CameraFOV, 2560 / 2, 1440 / 2);

                if (Actor.IsA(out CharacterGunfire playerCharacter))
                {
                    if (playerCharacter.HealthNormalized == 0) continue;
                    if (playerCharacter.HitLogComp.Address == 0) continue;
                    if (playerCharacter.Faction.Value == playerFaction) continue;
                    var mesh = playerCharacter.Mesh;
                    if (mesh.CachedBoneSpaceTransforms.Address == 0) continue;
                    var enemyName = playerCharacter.Mesh.SkeletalMesh.GetName();
                    var hitlocs = playerCharacter.HitLogComp.HitLocations;
                    if (hitlocs.Num == 0) continue;
                    if ((AimHack && Aiming) || Esp)
                    {
                        if (!weakbone.ContainsKey(enemyName))
                        {
                            var hitlocstart = UnrealEngine.Memory.ReadProcessMemory<nint>(hitlocs.Address);
                            var finalBones = new Array<string>(playerCharacter.Mesh.SkeletalMesh.Skeleton.BoneTree.Address + 0x10);
                            var numBones = finalBones.Num;
                            for (var h = 0; h < hitlocs.Num; h++)
                            {
                                var physMatName = UEObject.GetName(UnrealEngine.Memory.ReadProcessMemory<int>(hitlocstart + 0x78 * h));
                                var bIsWeakSpot = UnrealEngine.Memory.ReadProcessMemory<bool>(hitlocstart + 0x78 * h + 0x49);
                                if (bIsWeakSpot)
                                {
                                    var sockets = mesh.SkeletalMesh.Skeleton.Sockets;
                                    for (var s = 0; s < sockets.Num; s++)
                                    {
                                        var socket = sockets[s];
                                        var socketName = UEObject.GetName((int)socket.SocketName.Value);
                                        if (socketName == "VFX_" + physMatName)
                                        {
                                            var weakBone = UEObject.GetName((int)socket.BoneName.Value);
                                            for (var b = 1; b < numBones; b++)
                                            {
                                                var boneName = UEObject.GetName(UnrealEngine.Memory.ReadProcessMemory<int>(UnrealEngine.Memory.ReadProcessMemory<nint>(finalBones.Address) + 0xc * b));
                                                if (boneName == weakBone)
                                                {
                                                    System.Console.WriteLine("found : " + boneName + " for " + enemyName + " (weak @ " + physMatName + ", socket " + socketName);
                                                    weakbone[enemyName] = b;
                                                    break;
                                                }
                                            }
                                            if (weakbone.ContainsKey(enemyName)) break;
                                        }
                                    }
                                    if (!weakbone.ContainsKey(enemyName))
                                    {
                                        System.Console.WriteLine("failed to find socket for weakpoint : " + enemyName + " : " + physMatName + ", searching for head bone");
                                        for (var b = 1; b < numBones; b++)
                                        {
                                            var boneName = UEObject.GetName(UnrealEngine.Memory.ReadProcessMemory<int>(UnrealEngine.Memory.ReadProcessMemory<nint>(finalBones.Address) + 0xc * b));
                                            if (boneName.ToLower().Contains("head"))
                                            {
                                                System.Console.WriteLine("found : " + boneName + " for " + enemyName);
                                                weakbone[enemyName] = b;
                                                break;
                                            }
                                        }
                                    }
                                    if (weakbone.ContainsKey(enemyName)) break;
                                }
                            }
                            if (!weakbone.ContainsKey(enemyName))
                            {
                                weakbone[enemyName] = 1;
                                System.Console.WriteLine("no weakpoint for " + enemyName + ", searching for head bone");
                                for (var b = 1; b < numBones; b++)
                                {
                                    var boneName = UEObject.GetName(UnrealEngine.Memory.ReadProcessMemory<int>(UnrealEngine.Memory.ReadProcessMemory<nint>(finalBones.Address) + 0xc * b));
                                    if (boneName.ToLower().Contains("head"))
                                    {
                                        System.Console.WriteLine("found : " + boneName + " for " + enemyName);
                                        weakbone[enemyName] = b;
                                        break;
                                    }
                                }
                            }

                            if (!weakbone.ContainsKey(enemyName))
                            {
                                weakbone[enemyName] = 1;
                                System.Console.WriteLine("no weakpoint / headbone for : " + enemyName);
                            }
                        }
                        var componentToWorldTransform = UnrealEngine.Memory.ReadProcessMemory<Extensions.Transform>(mesh.Address + 0x240);
                        var componentToWorldMatrix = componentToWorldTransform.ToMatrixWithScale();
                        var boneStartAddr = mesh.Address + 0x600;//.CachedBoneSpaceTransforms.Address - 0x290;// - 0x68; // why doesn't CachedBoneSpaceTransforms work?
                        var boneStart = UnrealEngine.Memory.ReadProcessMemory<nint>(boneStartAddr);

                        var headBoneTransform = UnrealEngine.Memory.ReadProcessMemory<Extensions.Transform>(boneStart + weakbone[enemyName] * 12 * 4 * 2);
                        var headBoneMatrix = headBoneTransform.ToMatrixWithScale();
                        headBoneMatrix = Matrix4x4.Multiply(headBoneMatrix, componentToWorldMatrix);
                        var headBone3D = new Vector3(headBoneMatrix.M41, headBoneMatrix.M42, headBoneMatrix.M43);
                        var headBone2D = Extensions.WorldToScreen(headBone3D, CameraLocation, CameraRotation, CameraFOV, 2560 / 2, 1440 / 2);
                        if (AimHack)
                        {
                            var distFromMiddle = Vector2.DistanceSquared(headBone2D, new Vector2(2560 / 2, 1440 / 2));
                            if (distFromMiddle < bestDistance)
                            {
                                bestDistance = distFromMiddle;
                                target = headBone2D;// Extensions.WorldToScreen(boneLocation, CameraLocation, CameraRotation, CameraFOV, 2560 / 2, 1440 / 2);
                            }
                        }
                        if (Esp)
                        {

                            var rootBoneTransform = UnrealEngine.Memory.ReadProcessMemory<Extensions.Transform>(boneStart);
                            var rootBoneMatrix = rootBoneTransform.ToMatrixWithScale();
                            rootBoneMatrix = Matrix4x4.Multiply(rootBoneMatrix, componentToWorldMatrix);
                            var rootBone3D = new Vector3(rootBoneMatrix.M41, rootBoneMatrix.M42, rootBoneMatrix.M43);
                            var rootBone2D = Extensions.WorldToScreen(rootBone3D, CameraLocation, CameraRotation, CameraFOV, 2560 / 2, 1440 / 2);
                            pDrawList.AddLine(rootBone2D, headBone2D, Color(0xff, 0, 0, 0xff), 2);
                        }
                    }
                    {
                        if (Debug)
                        {
                            pDrawList.AddText(loc + new Vector2(0, 0), Color(0, 0xff, 0, 0xff), mesh.SkeletalMesh.GetName() + (playerCharacter.Faction.Value == playerFaction ? " friend" : " enemy"));
                            var hitlocstart = UnrealEngine.Memory.ReadProcessMemory<nint>(hitlocs.Address);
                            if (weakbone[enemyName] != 1) continue;
                            for (var h = 0; h < hitlocs.Num; h++)
                            {
                                var n = UEObject.GetName(UnrealEngine.Memory.ReadProcessMemory<int>(hitlocstart + 0x78 * h));
                                var bIsWeakSpot = UnrealEngine.Memory.ReadProcessMemory<bool>(hitlocstart + 0x78 * h + 0x49);
                                var d = Convert.ToHexString(UnrealEngine.Memory.ReadProcessMemory(hitlocstart + 0x78 * h + 0x48, 8));
                                pDrawList.AddText(loc + new Vector2(0, 15 + h * 15), Color(0, 0xff, 0, 0xff), n + " : " + d + " : weakspot " + bIsWeakSpot);
                            }
                            var sockets = mesh.SkeletalMesh.Skeleton.Sockets;
                            pDrawList.AddText(loc + new Vector2(0, 15 + hitlocs.Num * 15), Color(0, 0xff, 0, 0xff), "sockets");
                            for (var h = 0; h < sockets.Num; h++)
                            {
                                var s1 = UEObject.GetName((int)sockets[h].SocketName.Value);
                                var s2 = UEObject.GetName((int)sockets[h].BoneName.Value);
                                pDrawList.AddText(loc + new Vector2(0, 15 + hitlocs.Num * 15 + h * 15 + 15), Color(0, 0xff, 0, 0xff), s1 + " -> " + s2);
                            }

                        }
                    }
                }
                else
                {
                    if (Debug)
                    {
                        var name = Actor.GetName();
                        if (name == "UIPFActor") continue;
                        if (name == "TPSPlayerCameraManager_C") continue;
                        if (name == "Tracer_Default_C") continue;
                        if (name == "AIGoalActor") continue;
                        if (name.Contains("Spawner")) continue;
                        if (name.Contains("AIController")) continue;
                        if (name.Contains("Mini")) continue;
                        var dist = Vector3.Distance(Location, CameraLocation);
                        pDrawList.AddText(loc, Color(0, 0xff, 0, 0xff), Actor.GetName() + " : " + dist);

                    }
                }
            }
        }
        if (AimHack && Aiming)
        {
            pDrawList.AddCircle(target, 10f, Color(0xff, 0, 0, 0xff), 5, 6f);
            Extensions.AimAtPos(target);
        }
        if (TriggerBot)
        {
            if (myPlayer.AimTarget.Address != 0)
                Extensions.MouseLeftClick();
        }
        return 0;
    }
    public static uint Color(byte r, byte g, byte b, byte a) { uint ret = a; ret <<= 8; ret += b; ret <<= 8; ret += g; ret <<= 8; ret += r; return ret; }
}