﻿using M3u8Downloader_H.M3U8.AttributeReaders;
using M3u8Downloader_H.M3U8.Utilities;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace M3u8Downloader_H.M3U8.AttributeReaderManager
{
    public class AttributeReaderManager : IAttributeReaderManager
    {
        public IDictionary<string, IAttributeReader> AttributeReaders { get; }
        public AttributeReaderManager()
        {
            AttributeReaders = AttributeReaderRoot.Instance.AttributeReaders;
        }

        public IAttributeReader this[string key]
        {
            get => AttributeReaders[key];
            set => AttributeReaders[key] = value;
        }

        public void Add(string key, IAttributeReader value)
        {
            AttributeReaders.Add(key, value);
        }

        public void Set(string key, IAttributeReader value)
        {
            this[key] = value;
        }

        public bool ContainsKey(string key)
        {
            return AttributeReaders.ContainsKey(key);
        }
        public bool TryGetValue(string key, [MaybeNullWhen(false)] out IAttributeReader value)
        {
            return AttributeReaders.TryGetValue(key, out value);
        }


    }
}
