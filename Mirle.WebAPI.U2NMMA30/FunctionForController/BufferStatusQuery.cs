﻿using Mirle.Def;
using Mirle.WebAPI.V2BYMA30.ReportInfo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirle.WebAPI.V2BYMA30.Function
{
    public class BufferStatusQuery
    {
        public bool FunReport(BufferStatusQueryInfo info, string IP, ref BufferStatusReply reply)
        {
            try
            {
                string strJson = JsonConvert.SerializeObject(info);
                clsWriLog.Log.FunWriLog(WriLog.clsLog.Type.Trace, strJson);
                string sLink = $"http://{IP}/BUFFER_STAUS_QUERY";
                clsWriLog.Log.FunWriLog(WriLog.clsLog.Type.Debug, $"URL: {sLink}");
                string re = clsTool.HttpPost(sLink, strJson);
                clsWriLog.Log.FunWriLog(WriLog.clsLog.Type.Trace, re);
                reply = (BufferStatusReply)Newtonsoft.Json.Linq.JObject.Parse(re).ToObject(typeof(BufferStatusReply));
                if (reply.returnCode == clsConstValue.ApiReturnCode.Success) return true;
                else return false;
            }
            catch (Exception ex)
            {
                var cmet = System.Reflection.MethodBase.GetCurrentMethod();
                clsWriLog.Log.subWriteExLog(cmet.DeclaringType.FullName + "." + cmet.Name, ex.Message);
                return false;
            }
        }
    }
}
