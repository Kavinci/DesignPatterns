﻿namespace DesignPatterns.Pattern.Structural.Facade {
  public class FacadePatternSample : IDesignPatternSample {
    public void ShowSample() {
      var facade = new ComplexSystemFacade();
      ComplexSystemFacade.UseMethodBehindFacade("Sample");
    }
  }
}
