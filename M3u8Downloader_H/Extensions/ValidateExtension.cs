﻿using M3u8Downloader_H.Attributes;
using M3u8Downloader_H.Models;
using M3u8Downloader_H.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3u8Downloader_H.Extensions;

public static class ValidateExtension
{
    public static void Validate(this SettingsService obj)
    {
        Type type = obj.GetType();
        foreach (var prop in type.GetProperties())
        {
            if (!prop.IsDefined(typeof(BaseAttribute), false)) continue;

            BaseAttribute attribute = (BaseAttribute)prop.GetCustomAttributes(typeof(BaseAttribute), false)[0];
            attribute.Validate(obj, prop, prop.GetValue(obj));
        }
    }

}
