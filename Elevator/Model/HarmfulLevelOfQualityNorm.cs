﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class HarmfulLevelOfQualityNorm : AbstractQualityLevelNorm
    {
        public const string NameTable = "Norm_harmful_impurities";
        public const string NormAttr = "norm_harm_imp";
        public const string ClassIdAttr = "id_class";
        public const string TypeOfLevelQualityAttr = "name_harm_imp";
        public HarmfulLevelOfQualityNorm(string norm) : base(norm)
        {
        }
        public HarmfulLevelOfQualityNorm(string raw, string classRaw) : base(raw, classRaw)
        {
        }
    }
}