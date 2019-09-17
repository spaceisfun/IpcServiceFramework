using System;

namespace IpcServiceFramework.Services
{
    public interface IValueConverter
    {
        bool TryConvert(object origValue, Type destType, out object destValue);
    }
}
