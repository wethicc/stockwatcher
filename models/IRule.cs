using System;

public class IRule{

    Func<IStock,bool> Predicate {get;}

    IStock Stock {get;}

    IUser OnBehalfOf {get;}
}