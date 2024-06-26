﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagePack;
using MessagePack.Formatters;

namespace CoreServices.Setting.Structs;

[MessagePackObject]
internal readonly record struct SettingData(
    [property: Key(0)] string Key,
    [property: Key(1), MessagePackFormatter(typeof(TypelessFormatter))] object Value);

