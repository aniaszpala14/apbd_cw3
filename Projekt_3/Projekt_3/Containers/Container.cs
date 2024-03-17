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
 public static string Type { get; protected set; }
 
 protected Container(double cargoWeight,double cargoMaxWeight)
 {
  CargoMaxWeight = cargoMaxWeight;
  number += 1;
  SeriesNumber = "KON-"+Type+"-" + number;
  Load(cargoWeight);
 }
 public virtual void UnLoad()
 {
  CargoWeight=0.0;
 }
 public virtual void Load(double cargoWeight)
 {
  if(cargoWeight > CargoMaxWeight){ throw new OverfillException();}
  else{CargoWeight = cargoWeight;}
 }
}