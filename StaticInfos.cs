﻿using System.Runtime.InteropServices;
using Jackal.Types;

namespace Jackal;

[StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
[Serializable]
public record StaticInfos
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public string? SMVersion;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public string? ACVersion;

    public int NumberOfSessions;
    public int NumCars;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public string? CarModel;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public string? Track;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public string? PlayerName;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public string? PlayerSurname;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public string? PlayerNick;

    public int SectorCount;
    public float MaxTorque;
    public float MaxPower;
    public int MaxRpm;
    public float MaxFuel;
    public Wheels<float> SuspensionMaxTravel;
    public Wheels<float> TyreRadius;
    public float MaxTurboBoost;
    public float Deprecated1;
    public float Deprecated2;
    public int PenaltiesEnabled;
    public float AidFuelRate;
    public float AidTireRate;
    public float AidMechanicalDamage;
    public int AidAllowTyreBlankets;
    public float AidStability;
    public int AidAutoClutch;
    public int AidAutoBlip;
    public int HasDRS;
    public int HasERS;
    public int HasKERS;
    public float KersMaxJoules;
    public int EngineBrakeSettingsCount;
    public int ErsPowerControllerCount;
    public float TrackSplineLength;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
    public string? TrackConfiguration;

    public float ErsMaxJ;
    public int IsTimedRace;
    public int HasExtraLap;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public string? CarSkin;

    public int ReversedGridPositions;
    public int PitWindowStart;
    public int PitWindowEnd;
    public int IsOnline;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public string? dryTyresName;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
    public string? wetTyresName;
}