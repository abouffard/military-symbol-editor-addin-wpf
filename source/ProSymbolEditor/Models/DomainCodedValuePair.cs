﻿/*******************************************************************************
 * Copyright 2016 Esri
 * 
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 * 
 *  http://www.apache.org/licenses/LICENSE-2.0
 *  
 *   Unless required by applicable law or agreed to in writing, software
 *   distributed under the License is distributed on an "AS IS" BASIS,
 *   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *   See the License for the specific language governing permissions and
 *   limitations under the License.
 ******************************************************************************/

using ArcGIS.Desktop.Framework.Contracts;
using System;

namespace ProSymbolEditor
{
    public class DomainCodedValuePair : PropertyChangedBase, IComparable
    {
        public object Code { get; set; }
        public string Name { get; set; }

        public DomainCodedValuePair() { }
            
        public DomainCodedValuePair(object value, string name)
        {
            Code = value;
            Name = name;
        }

        public int CompareTo(object obj)
        {
            DomainCodedValuePair a = this;
            DomainCodedValuePair b = (DomainCodedValuePair)obj;

            return string.Compare(a.Name, b.Name);
        }
    }
}
