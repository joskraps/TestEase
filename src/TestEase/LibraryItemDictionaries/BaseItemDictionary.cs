using System;
using System.Collections.Generic;
using System.IO;
using TestEase.LibraryItems;

namespace TestEase.LibraryItemDictionaries
{
    /// <inheritdoc cref="IItemDictionary" />
    /// <summary>
    ///     Wrapper for item dictionaries containing common setup logic.
    /// </summary>
    public abstract class BaseItemDictionary : Dictionary<string, LibraryItem>, IItemDictionary
    {
        /// <inheritdoc />
        public abstract string FileExtension { get; }

        /// <inheritdoc />
        public abstract ItemFileType FileType { get; }

        /// <inheritdoc />
        /// <summary>
        ///     Using the file path, the item is keyed based on folder directory (dot notation starting from the root test data
        ///     library folder)
        /// </summary>
        /// <param name="file">
        ///     The <see cref="T:System.IO.FileInfo" /> file info object to set base information about the item/&gt;
        /// </param>
        /// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission. </exception>
        public void AddFileInfo(FileInfo file)
        {
            var libraryFolderName = "_TestDataLibrary";

            if (!file.FullName.Contains(libraryFolderName)) return;

            var key = file.FullName.Substring(file.FullName.IndexOf(libraryFolderName, StringComparison.Ordinal));
            key = key.Replace($"{libraryFolderName}\\", string.Empty);
            key = key.Replace("\\", ".");
            key = key.Replace(file.Extension, string.Empty);

            if (!ContainsKey(key)) Add(key, new LibraryItem(file));
        }
    }
}