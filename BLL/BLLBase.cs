﻿using ComResolution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class BLLBase
    {
        /// <summary>
        /// 输送机对象初始化
        /// </summary>
        protected CRLTRANSControl crltranclass = new CRLTRANSControl();

        #region 报头
        protected readonly static byte[] MessageHeader_2000 = new byte[] { 0x53, 0x35, 0x10, 0x01, 0x03, 0x03, 0x03, 0x08, 0x01, 0x3C, 0x00, 0x00, 0x00, 0x0C, 0xFF, 0x02 };
        protected readonly static byte[] MessageHeader_4000 = new byte[] { 0x53, 0x35, 0x10, 0x01, 0x03, 0x05, 0x03, 0x08, 0x01, 0x3D, 0x00, 0x00, 0x00, 0x0C, 0xFF, 0x02 };
        protected readonly static byte[] MessageHeader_6000 = new byte[] { 0x53, 0x35, 0x10, 0x01, 0x03, 0x05, 0x03, 0x08, 0x01, 0x46, 0x00, 0x00, 0x00, 0x47, 0xFF, 0x02 };
        protected readonly static byte[] MessageHeaderHC_6000 = new byte[] { 0x53, 0x35, 0x10, 0x01, 0x03, 0x05, 0x03, 0x08, 0x01, 0x46, 0x00, 0x00, 0x00, 0x3D, 0xFF, 0x02 };
        #endregion

        protected static List<string> schhastorgv = new List<string>();
    }
}
