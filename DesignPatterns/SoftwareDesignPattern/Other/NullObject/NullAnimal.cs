﻿namespace DesignPatterns.SoftwareDesignPattern.Other.NullObject {
  public class NullAnimal : IAnimal {
    public string Speak() => default(string);
  }
}
