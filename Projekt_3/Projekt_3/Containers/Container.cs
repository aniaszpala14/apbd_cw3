using System.Buffers;
using System.ComponentModel;
using System.Runtime.InteropServices.JavaScript;
using Projekt_3.Exceptions;
using Projekt_3.Interfaces;
using IContainer = Projekt_3.Interfaces.IContainer;

namespace Projekt_3;

public abstract class Container : IContainer
{
public double CargoWeight {get; set; }
protected double CargoHeight { get; set; }
public double CargoItsWeight { get; set; }
protected double CargoDepth { get; set; }
public string SeriesNumber { get; set; }
protected double CargoMaxWeight { get; set; }
private static int number=0;
private static string Type { get; set; }
 
 protected Container(double cargoMaxWeight,double cargoDepth,double cargoHeight,double cargoItsWeight,string Type)
 {
  CargoItsWeight = cargoItsWeight;
  CargoHeight = cargoHeight;
  CargoDepth = cargoDepth;
  CargoMaxWeight = cargoMaxWeight;
  number += 1;
  SeriesNumber = "KON-"+Type+"-" + number;
  CargoWeight = 0.0;
 }
 public virtual void UnLoad()
 {
  CargoWeight=0.0;
 }
 public virtual void Load(double cargoWeight)
 {
  if(cargoWeight > CargoMaxWeight){ throw new OverfillException();}
 }

 public override string ToString()
 {
  return "Kontener " + SeriesNumber + " o wadze " + CargoItsWeight + " i wymiarach " + CargoDepth + "x" + CargoHeight;
 }
}
