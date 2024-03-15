using System.Buffers;
using System.ComponentModel;
using System.Runtime.InteropServices.JavaScript;
using Projekt_3.Exceptions;
using Projekt_3.Interfaces;
using IContainer = Projekt_3.Interfaces.IContainer;

namespace Projekt_3;

public abstract class Container : IContainer
{
 public double CargoWeight { get; set; }
 public double CargoHeight { get; set; }
 public double CargoItsWeight { get; set; }
 public double CargoDepth { get; set; }
 public string SeriesNumber { get; set; }
 public double CargoMaxWeight { get; set; }
 public static int number;
 
 
 protected Container(double cargoWeight)
 {
  CargoWeight = cargoWeight;
  number += 1;
 }
 
 public virtual void UnLoad()
 {
  CargoWeight=0.0;
 }

 public virtual void Load(double cargoWeight)
 {
  if(cargoWeight > CargoMaxWeight)
  throw new OverfillException();
 }
 
 
 
}