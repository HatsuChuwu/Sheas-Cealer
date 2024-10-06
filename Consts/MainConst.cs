﻿using System;
using System.IO;
using System.Security.Principal;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace Sheas_Cealer.Consts;

internal partial class MainConst : MainMultilangConst
{
    internal enum SettingsMode
    { BrowserPathMode, UpstreamUrlMode, ExtraArgsMode };

    public static bool IsAdmin => new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);

    internal static string CealingHostPath => Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase!, "Cealing-Host-*.json");
    internal static string LocalHostPath => Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase!, "Cealing-Host-Local.json");
    internal static string UpstreamHostPath => Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase!, "Cealing-Host-Upstream.json");
    internal static string EdgeBrowserRegistryPath => @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\msedge.exe";
    internal static string ChromeBrowserRegistryPath => @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\chrome.exe";
    internal static string BraveBrowserRegistryPath => @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\brave.exe";
    internal static string UncealedBrowserPath => Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase!, "Uncealed-Browser.lnk");
    internal static string UncealedBrowserDescription => "Created By Sheas Cealer";
    internal static string CommandName => "Cmd.exe";
    internal static string HostsConfPath => Path.Combine(Registry.LocalMachine.OpenSubKey(@"\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\DataBasePath")?.GetValue("DataBasePath", null)?.ToString() ?? @"C:\Windows\System32\drivers\etc", "hosts");
    internal static string HostsConfStartMarker => "# Cealing Nginx Start\n";
    internal static string HostsConfEndMarker => "# Cealing Nginx End";
    internal static string NginxPath => Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase!, "Cealing-Nginx.exe");
    internal static string NginxConfPath => Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase!, "nginx.conf");
    internal static string NginxLogsPath => Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase!, "logs");
    internal static string NginxTempPath => Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase!, "Temp");
    internal static string NginxCertPath => Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase!, "Cealing-Cert.pem");
    internal static string NginxRootCertSubjectName => "CN=Cealing Cert Root";
    internal static string NginxChildCertSubjectName => "CN=Cealing Cert Child";
    internal static string NginxKeyPath => Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase!, "Cealing-Key.pem");
    internal static string MihomoPath => Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase!, "Cealing-Mihomo.exe");
    internal static string MihomoConfPath => Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase!, "config.yaml");
    internal static string DefaultUpstreamUrl => "https://gitlab.com/SpaceTimee/Cealing-Host/raw/main/Cealing-Host.json";

    [GeneratedRegex(@"^(https?:\/\/)?[a-zA-Z0-9](-*[a-zA-Z0-9])*(\.[a-zA-Z0-9](-*[a-zA-Z0-9])*)*(:\d{1,5})?(\/[a-zA-Z0-9.\-_\~\!\$\&\'\(\)\*\+\,\;\=\:\@\%]*)*$")]
    internal static partial Regex UpstreamUrlRegex();

    [GeneratedRegex(@"^(--[a-z](-?[a-z])*(=("".*"")|.*)?( --[a-z](-?[a-z])*(="".*"")?)*)?$")]
    internal static partial Regex ExtraArgsRegex();
}