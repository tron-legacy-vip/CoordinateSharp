﻿/*
CoordinateSharp is a .NET standard library that is intended to ease geographic coordinate 
format conversions and location based celestial calculations.
https://github.com/Tronald/CoordinateSharp

Many celestial formulas in this library are based on Jean Meeus's 
Astronomical Algorithms (2nd Edition). Comments that reference only a chapter
are referring to this work.

License

CoordinateSharp is split licensed and may be licensed under the GNU Affero General Public License version 3 or a commercial use license as stated.

Copyright (C) 2019, Signature Group, LLC
  
This program is free software; you can redistribute it and/or modify it under the terms of the GNU Affero General Public License version 3 
as published by the Free Software Foundation with the addition of the following permission added to Section 15 as permitted in Section 7(a): 
FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY Signature Group, LLC. Signature Group, LLC DISCLAIMS THE WARRANTY OF 
NON INFRINGEMENT OF THIRD PARTY RIGHTS.

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Affero General Public License for more details. You should have received a copy of the GNU 
Affero General Public License along with this program; if not, see http://www.gnu.org/licenses or write to the 
Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA, 02110-1301 USA, or download the license from the following URL:

https://www.gnu.org/licenses/agpl-3.0.html

The interactive user interfaces in modified source and object code versions of this program must display Appropriate Legal Notices, 
as required under Section 5 of the GNU Affero General Public License.

You can be released from the requirements of the license by purchasing a commercial license. Buying such a license is mandatory 
as soon as you develop commercial activities involving the CoordinateSharp software without disclosing the source code of your own applications. 
These activities include: offering paid services to customers as an ASP, on the fly location based calculations in a web application, 
or shipping CoordinateSharp with a closed source product.

Organizations or use cases that fall under the following conditions may receive a free commercial use license upon request.
-Department of Defense
-Department of Homeland Security
-Open source contributors to this library
-Scholarly or scientific uses on a case by case basis.
-Emergency response / management uses on a case by case basis.

For more information, please contact Signature Group, LLC at this address: sales@signatgroup.com
*/
using System;

namespace CoordinateSharp.Magnetic
{
    [Serializable]
    internal class DataPoint
    {
        public Magnetic Parent { get; }
        public DataPoint(CoefficientModel cem, Magnetic parent, int index)
        {
            IndexPoint = index;
            Parent = parent;

            Degree = cem.Degree;
            Order = cem.Order;


            Gm = cem.Gm;
            Hm = cem.Hm;
            Gtm = cem.Gtm;
            Htm = cem.Htm;

        }

        public int IndexPoint;//Current index point in the DataMode;

        public int Degree { get; }
        public int Order { get; }
        public double? Gm { get; }
        public double? Hm { get;  }
        public double? Gtm { get;  }
        public double? Htm { get;  }

        public double? TimeDependent_Gm  { get;set; }
        public double? TimeDependent_Hm {get;set; }
  

        public double Schmidt_Semi_P { get; set; }

        public double Schmidt_Semi_Pt{get;set;}

        public double? Schmidt_Semi_dP{ get; set; }

        public double? Field_X { get; set; }
        public double? Field_Y { get; set; }
        public double? Field_Z { get; set; }

        public double? Secular_X { get; set; }
        public double? Secular_Y { get; set; }
        public double? Secular_Z { get; set; }

        //Math Functions
        public bool IsFactFactDouble
        {
            get
            {
                if (Degree == Order) { return true; }
                return false;
            }
        }

    }
}
