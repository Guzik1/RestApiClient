using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiClient
{
    public interface IDeserializable<T>
    {
        public T Deserialize(string input);
    }
}