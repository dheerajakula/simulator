// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: perception_config_schema.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.perception
{

    [global::ProtoBuf.ProtoContract()]
    public partial class KeyValueInt : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public KeyValueInt()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return __pbn__name ?? ""; }
            set { __pbn__name = value; }
        }
        public bool ShouldSerializename()
        {
            return __pbn__name != null;
        }
        public void Resetname()
        {
            __pbn__name = null;
        }
        private string __pbn__name;

        [global::ProtoBuf.ProtoMember(2)]
        public int value
        {
            get { return __pbn__value.GetValueOrDefault(); }
            set { __pbn__value = value; }
        }
        public bool ShouldSerializevalue()
        {
            return __pbn__value != null;
        }
        public void Resetvalue()
        {
            __pbn__value = null;
        }
        private int? __pbn__value;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class KeyValueString : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public KeyValueString()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return __pbn__name ?? ""; }
            set { __pbn__name = value; }
        }
        public bool ShouldSerializename()
        {
            return __pbn__name != null;
        }
        public void Resetname()
        {
            __pbn__name = null;
        }
        private string __pbn__name;

        [global::ProtoBuf.ProtoMember(2)]
        public byte[] value
        {
            get { return __pbn__value; }
            set { __pbn__value = value; }
        }
        public bool ShouldSerializevalue()
        {
            return __pbn__value != null;
        }
        public void Resetvalue()
        {
            __pbn__value = null;
        }
        private byte[] __pbn__value;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class KeyValueDouble : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public KeyValueDouble()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return __pbn__name ?? ""; }
            set { __pbn__name = value; }
        }
        public bool ShouldSerializename()
        {
            return __pbn__name != null;
        }
        public void Resetname()
        {
            __pbn__name = null;
        }
        private string __pbn__name;

        [global::ProtoBuf.ProtoMember(2)]
        public double value
        {
            get { return __pbn__value.GetValueOrDefault(); }
            set { __pbn__value = value; }
        }
        public bool ShouldSerializevalue()
        {
            return __pbn__value != null;
        }
        public void Resetvalue()
        {
            __pbn__value = null;
        }
        private double? __pbn__value;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class KeyValueFloat : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public KeyValueFloat()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return __pbn__name ?? ""; }
            set { __pbn__name = value; }
        }
        public bool ShouldSerializename()
        {
            return __pbn__name != null;
        }
        public void Resetname()
        {
            __pbn__name = null;
        }
        private string __pbn__name;

        [global::ProtoBuf.ProtoMember(2)]
        public float value
        {
            get { return __pbn__value.GetValueOrDefault(); }
            set { __pbn__value = value; }
        }
        public bool ShouldSerializevalue()
        {
            return __pbn__value != null;
        }
        public void Resetvalue()
        {
            __pbn__value = null;
        }
        private float? __pbn__value;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class KeyValueBool : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public KeyValueBool()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return __pbn__name ?? ""; }
            set { __pbn__name = value; }
        }
        public bool ShouldSerializename()
        {
            return __pbn__name != null;
        }
        public void Resetname()
        {
            __pbn__name = null;
        }
        private string __pbn__name;

        [global::ProtoBuf.ProtoMember(2)]
        public bool value
        {
            get { return __pbn__value.GetValueOrDefault(); }
            set { __pbn__value = value; }
        }
        public bool ShouldSerializevalue()
        {
            return __pbn__value != null;
        }
        public void Resetvalue()
        {
            __pbn__value = null;
        }
        private bool? __pbn__value;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class KeyValueArrayInt : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public KeyValueArrayInt()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return __pbn__name ?? ""; }
            set { __pbn__name = value; }
        }
        public bool ShouldSerializename()
        {
            return __pbn__name != null;
        }
        public void Resetname()
        {
            __pbn__name = null;
        }
        private string __pbn__name;

        [global::ProtoBuf.ProtoMember(2)]
        public int[] values { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class KeyValueArrayString : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public KeyValueArrayString()
        {
            values = new global::System.Collections.Generic.List<byte[]>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return __pbn__name ?? ""; }
            set { __pbn__name = value; }
        }
        public bool ShouldSerializename()
        {
            return __pbn__name != null;
        }
        public void Resetname()
        {
            __pbn__name = null;
        }
        private string __pbn__name;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<byte[]> values { get; private set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class KeyValueArrayDouble : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public KeyValueArrayDouble()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return __pbn__name ?? ""; }
            set { __pbn__name = value; }
        }
        public bool ShouldSerializename()
        {
            return __pbn__name != null;
        }
        public void Resetname()
        {
            __pbn__name = null;
        }
        private string __pbn__name;

        [global::ProtoBuf.ProtoMember(2)]
        public double[] values { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class KeyValueArrayFloat : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public KeyValueArrayFloat()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return __pbn__name ?? ""; }
            set { __pbn__name = value; }
        }
        public bool ShouldSerializename()
        {
            return __pbn__name != null;
        }
        public void Resetname()
        {
            __pbn__name = null;
        }
        private string __pbn__name;

        [global::ProtoBuf.ProtoMember(2)]
        public float[] values { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class KeyValueArrayBool : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public KeyValueArrayBool()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return __pbn__name ?? ""; }
            set { __pbn__name = value; }
        }
        public bool ShouldSerializename()
        {
            return __pbn__name != null;
        }
        public void Resetname()
        {
            __pbn__name = null;
        }
        private string __pbn__name;

        [global::ProtoBuf.ProtoMember(2)]
        public bool[] values { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ModelConfigProto : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ModelConfigProto()
        {
            integer_params = new global::System.Collections.Generic.List<KeyValueInt>();
            string_params = new global::System.Collections.Generic.List<KeyValueString>();
            double_params = new global::System.Collections.Generic.List<KeyValueDouble>();
            float_params = new global::System.Collections.Generic.List<KeyValueFloat>();
            bool_params = new global::System.Collections.Generic.List<KeyValueBool>();
            array_integer_params = new global::System.Collections.Generic.List<KeyValueArrayInt>();
            array_string_params = new global::System.Collections.Generic.List<KeyValueArrayString>();
            array_double_params = new global::System.Collections.Generic.List<KeyValueArrayDouble>();
            array_float_params = new global::System.Collections.Generic.List<KeyValueArrayFloat>();
            array_bool_params = new global::System.Collections.Generic.List<KeyValueArrayBool>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string name
        {
            get { return __pbn__name ?? ""; }
            set { __pbn__name = value; }
        }
        public bool ShouldSerializename()
        {
            return __pbn__name != null;
        }
        public void Resetname()
        {
            __pbn__name = null;
        }
        private string __pbn__name;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string version
        {
            get { return __pbn__version ?? ""; }
            set { __pbn__version = value; }
        }
        public bool ShouldSerializeversion()
        {
            return __pbn__version != null;
        }
        public void Resetversion()
        {
            __pbn__version = null;
        }
        private string __pbn__version;

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<KeyValueInt> integer_params { get; private set; }

        [global::ProtoBuf.ProtoMember(4)]
        public global::System.Collections.Generic.List<KeyValueString> string_params { get; private set; }

        [global::ProtoBuf.ProtoMember(5)]
        public global::System.Collections.Generic.List<KeyValueDouble> double_params { get; private set; }

        [global::ProtoBuf.ProtoMember(6)]
        public global::System.Collections.Generic.List<KeyValueFloat> float_params { get; private set; }

        [global::ProtoBuf.ProtoMember(7)]
        public global::System.Collections.Generic.List<KeyValueBool> bool_params { get; private set; }

        [global::ProtoBuf.ProtoMember(8)]
        public global::System.Collections.Generic.List<KeyValueArrayInt> array_integer_params { get; private set; }

        [global::ProtoBuf.ProtoMember(9)]
        public global::System.Collections.Generic.List<KeyValueArrayString> array_string_params { get; private set; }

        [global::ProtoBuf.ProtoMember(10)]
        public global::System.Collections.Generic.List<KeyValueArrayDouble> array_double_params { get; private set; }

        [global::ProtoBuf.ProtoMember(11)]
        public global::System.Collections.Generic.List<KeyValueArrayFloat> array_float_params { get; private set; }

        [global::ProtoBuf.ProtoMember(12)]
        public global::System.Collections.Generic.List<KeyValueArrayBool> array_bool_params { get; private set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class MultiModelConfigProto : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public MultiModelConfigProto()
        {
            model_configs = new global::System.Collections.Generic.List<ModelConfigProto>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<ModelConfigProto> model_configs { get; private set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ModelConfigFileListProto : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ModelConfigFileListProto()
        {
            model_config_path = new global::System.Collections.Generic.List<string>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<string> model_config_path { get; private set; }

    }

}

#pragma warning restore 0612, 1591, 3021