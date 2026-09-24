using System;
using System.Drawing;
using System.IO;

namespace C__Group_Assignment
{
    internal static class MenuImageStore
    {
        private const string FilePrefix = "file:";

        public static string Import(string sourcePath)
        {
            if (string.IsNullOrWhiteSpace(sourcePath) || !File.Exists(sourcePath))
            {
                throw new InvalidOperationException("Please select a valid image file.");
            }

            string extension = Path.GetExtension(sourcePath).ToLowerInvariant();
            if (extension != ".jpg" && extension != ".jpeg" && extension != ".png" && extension != ".bmp")
            {
                throw new InvalidOperationException("Only JPG, PNG, and BMP images are supported.");
            }

            string directory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MenuImages");
            Directory.CreateDirectory(directory);
            string fileName = Guid.NewGuid().ToString("N") + extension;
            File.Copy(sourcePath, Path.Combine(directory, fileName), false);
            return FilePrefix + fileName;
        }

        public static Image Load(string imageKey)
        {
            if (string.IsNullOrWhiteSpace(imageKey))
            {
                return null;
            }

            if (!imageKey.StartsWith(FilePrefix, StringComparison.OrdinalIgnoreCase))
            {
                return (Image)Properties.Resources.ResourceManager.GetObject(imageKey);
            }

            string fileName = imageKey.Substring(FilePrefix.Length);
            if (!string.Equals(fileName, Path.GetFileName(fileName), StringComparison.Ordinal))
            {
                return null;
            }

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MenuImages", fileName);
            if (!File.Exists(path))
            {
                return null;
            }

            using (Image image = Image.FromFile(path))
            {
                return new Bitmap(image);
            }
        }
    }
}
