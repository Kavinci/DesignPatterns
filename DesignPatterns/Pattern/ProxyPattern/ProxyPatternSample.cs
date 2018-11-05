﻿using System;
using DesignPatterns.Pattern.ProxyPattern.Protection;
using DesignPatterns.Pattern.ProxyPattern.Remote;
using DesignPatterns.Pattern.ProxyPattern.Virtual;
using DesignPatterns.Utilities;

namespace DesignPatterns.Pattern.ProxyPattern {
  public class ProxyPatternSample : IDesignPatternSample {
    public void ShowSample() {
      VirtualProxySample();
      ProtectionProxySample();
      RemoteProxySample();
    }

    private static void VirtualProxySample() {
      IExampleExpensiveObject withProxy = new VirtualProxy("JIT");
      IExampleExpensiveObject withoutProxy = new ExampleExpensiveObject("AOT");
      Console.WriteLine(withoutProxy.Text);
      Console.WriteLine(withProxy.Text);
    }

    private static void ProtectionProxySample() {
      var classWithoutPermission = new ProtectionProxy(false);
      ErrorUtilities.LogException(classWithoutPermission.SensitiveMethod);

      var classWithPermission = new ProtectionProxy(true);
      Console.WriteLine(classWithPermission.SensitiveMethod());
    }

    private static void RemoteProxySample() {
      var remoteProxy = new RemoteProxy();
      Console.WriteLine($"Will block until I get this data: {remoteProxy.GetData()}");
    }
  }
}