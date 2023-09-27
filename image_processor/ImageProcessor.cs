using System;
using System.Drawing;

public class ImageProcessor
{
    public static void Inverse(string[] filenames)
    {
        foreach (var filename in filenames)
        {
            using (var originalImage = new System.Drawing.Bitmap(filename))
            {
                using (var invertedImage = new System.Drawing.Bitmap(originalImage.Width, originalImage.Height))
                {
                    for (int x = 0; x < originalImage.Width; x++)
                    {
                        for (int y = 0; y < originalImage.Height; y++)
                        {
                            Color originalColor = originalImage.GetPixel(x, y);

                            Color invertedColor = Color.FromArgb(
                                255 - originalColor.R,
                                255 - originalColor.G,
                                255 - originalColor.B
                            );
                            invertedImage.SetPixel(x, y, invertedColor);
                        }
                    }
                    string finalFilename = System.IO.Path.GetFileNameWithoutExtension(filename);
                    finalFilename += "_inverse";
                    finalFilename += System.IO.Path.GetExtension(filename);
                    invertedImage.Save(finalFilename);
                }
            }
        }
    }
}
