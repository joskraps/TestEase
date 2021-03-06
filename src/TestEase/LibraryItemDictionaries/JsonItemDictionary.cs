﻿using TestEase.LibraryItems;

namespace TestEase.LibraryItemDictionaries
{
    /// <inheritdoc />
    /// <summary>
    ///     The json item dictionary.
    /// </summary>
    public class JsonItemDictionary : BaseItemDictionary
    {
        /// <inheritdoc />
        public override string FileExtension => ".json";

        /// <inheritdoc />
        public override ItemFileType FileType => ItemFileType.Json;
    }
}