﻿namespace MyImageProcessing.ImageOperations {
    public enum OperationList {
        None,
        InvertBrightness,
        GrayScale,
        Original,
        InvertRedBlue,
        InvertBlueGreen,
        InvertRedGreen,
        InvertHue,
        ExtractChannelRed,
        ExtractChannelGreen,
        ExtractChannelBlue,
        Monotone,
        RotateLeft,
        RotateRight,
        FlipHorizontal,
        FlipVertical,
        Blur,
        GaussianBlur,
        TopSobel,
        BottomSobel,
        LeftSobel,
        RightSobel,
        Basic,
        EdgeDetection,
        Emboss,
        Resize,
        Scale,
        Crop,
        Undo,
        Redo,
        Reset
    };
}