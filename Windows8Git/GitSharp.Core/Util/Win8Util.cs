using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace GitSharp.Core.Util
{
    public static class Win8Util
    {
        public static DateTimeOffset GetLastModified(this StorageFile file)
        {
                var t = file.GetBasicPropertiesAsync().AsTask();
                t.Wait();
                return t.Result.DateModified;
        }
        public static long GetLastModifiedMilli(this StorageFile file)
        {
            return GetLastModified(file).ToMillisecondsSinceEpoch();
        }
    }
}
