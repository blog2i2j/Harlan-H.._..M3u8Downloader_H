﻿using System;
using System.Text;
using M3u8Downloader_H.Abstractions.M3u8;
using M3u8Downloader_H.Common.Extensions;

namespace M3u8Downloader_H.Common.M3u8Infos
{
    public partial class M3UKeyInfo : IM3uKeyInfo
    {
        public string Method { get; set; } = default!;

        public Uri Uri { get; set; } = default!;

        public byte[] BKey { get; set; } = default!;

        public byte[] IV { get; set; } = default!;

        public M3UKeyInfo()
        {
            
        }

      /*  public M3UKeyInfo(string method, string key)
        {
            Method = method;
            BKey = Encoding.UTF8.GetBytes(key);
            IV = null!;
        }

        public M3UKeyInfo(string method, string key, string iv)
        {
            Method = method;
            BKey = Encoding.UTF8.GetBytes(key);
            IV = iv?.ToHex()!;
        }

        public M3UKeyInfo(string method, byte[] key, byte[] iv)
        {
            Method = method;
            BKey = key;
            IV = iv;
        }

        public M3UKeyInfo(M3UKeyInfo m3UKeyInfo) : this (m3UKeyInfo.Method, m3UKeyInfo.BKey, m3UKeyInfo.IV)
        {

        }*/

    }
    
    public partial class M3UKeyInfo 
    {
        public bool Equals(IM3uKeyInfo? other) => Object.ReferenceEquals(this, other);

        public override bool Equals(object? obj) => obj is M3UKeyInfo && Equals(obj);

        public override int GetHashCode() => StringComparer.Ordinal.GetHashCode();

        public static bool operator ==(M3UKeyInfo M3UKeyInfo1, M3UKeyInfo M3UKeyInfo2) => M3UKeyInfo1.Equals(M3UKeyInfo2);
        public static bool operator !=(M3UKeyInfo M3UKeyInfo1, M3UKeyInfo M3UKeyInfo2) => !(M3UKeyInfo1 == M3UKeyInfo2);
    } 
}