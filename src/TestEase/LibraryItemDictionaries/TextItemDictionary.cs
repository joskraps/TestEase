using TestEase.LibraryItems;

namespace TestEase.LibraryItemDictionaries
{
    /// <inheritdoc />
    /// <summary>
    ///     The text item dictionary.
    /// </summary>
    public class TextItemDictionary : BaseItemDictionary
    {
        /// <inheritdoc />
        public override string FileExtension => ".txt";

        /// <inheritdoc />
        public override ItemFileType FileType => ItemFileType.Text;
    }
}