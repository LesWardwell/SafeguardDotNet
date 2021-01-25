﻿namespace OneIdentity.SafeguardDotNet
{
    public class UploadProgress
    {
        public long BytesTransferred { get; set;  }
        public long BytesTotal { get; set; }
        public int PercentComplete => BytesTotal == 0 ? 0 : (int)((double)BytesTransferred / BytesTotal * 100);
    }
}