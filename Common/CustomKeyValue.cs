namespace Common
{
    public class CustomKeyValue<V, T>
    {
        public CustomKeyValue(V key, T value)
        {
            Key = key;
            Value = value;
        }

        public V Key { get; set; }
        public T Value { get; set; }
    }

    public class KeyValueStringDouble : CustomKeyValue<string, double>
    {
        public KeyValueStringDouble(string key, double value) : base(key, value)
        {
        }
    }

    public class KeyValueStringInt : CustomKeyValue<string, int>
    {
        public KeyValueStringInt() : base(string.Empty, default(int))
        {
        }

        public KeyValueStringInt(string key, int value) : base(key, value)
        {
        }
    }

    public class KeyValueStringString : CustomKeyValue<string, string>
    {
        public KeyValueStringString(string key, string value) : base(key, value)
        {
        }
    }
}