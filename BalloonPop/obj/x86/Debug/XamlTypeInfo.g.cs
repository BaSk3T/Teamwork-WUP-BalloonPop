﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace BalloonPop
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
    private global::BalloonPop.BalloonPop_XamlTypeInfo.XamlTypeInfoProvider _provider;

        /// <summary>
        /// GetXamlType(Type)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        /// <summary>
        /// GetXamlType(String)
        /// </summary>
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        /// <summary>
        /// GetXmlnsDefinitions()
        /// </summary>
        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace BalloonPop.BalloonPop_XamlTypeInfo
{
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[11];
            _typeNameTable[0] = "BalloonPop.CustomControls.Joystick";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[2] = "Int32";
            _typeNameTable[3] = "Double";
            _typeNameTable[4] = "BalloonPop.MainPage";
            _typeNameTable[5] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[6] = "Boolean";
            _typeNameTable[7] = "BalloonPop.ViewModels.MainPageViewModel";
            _typeNameTable[8] = "BalloonPop.ViewModels.ViewModelBase";
            _typeNameTable[9] = "Object";
            _typeNameTable[10] = "Windows.UI.Xaml.DispatcherTimer";

            _typeTable = new global::System.Type[11];
            _typeTable[0] = typeof(global::BalloonPop.CustomControls.Joystick);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[2] = typeof(global::System.Int32);
            _typeTable[3] = typeof(global::System.Double);
            _typeTable[4] = typeof(global::BalloonPop.MainPage);
            _typeTable[5] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[6] = typeof(global::System.Boolean);
            _typeTable[7] = typeof(global::BalloonPop.ViewModels.MainPageViewModel);
            _typeTable[8] = typeof(global::BalloonPop.ViewModels.ViewModelBase);
            _typeTable[9] = typeof(global::System.Object);
            _typeTable[10] = typeof(global::Windows.UI.Xaml.DispatcherTimer);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_Joystick() { return new global::BalloonPop.CustomControls.Joystick(); }
        private object Activate_4_MainPage() { return new global::BalloonPop.MainPage(); }
        private object Activate_7_MainPageViewModel() { return new global::BalloonPop.ViewModels.MainPageViewModel(); }
        private object Activate_8_ViewModelBase() { return new global::BalloonPop.ViewModels.ViewModelBase(); }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::BalloonPop.BalloonPop_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  BalloonPop.CustomControls.Joystick
                userType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.UserControl"));
                userType.Activator = Activate_0_Joystick;
                userType.AddMemberName("Size");
                userType.AddMemberName("TouchSize");
                userType.AddMemberName("TouchLeftPosition");
                userType.AddMemberName("TouchTopPosition");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Int32
                xamlType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  Double
                xamlType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 4:   //  BalloonPop.MainPage
                userType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_4_MainPage;
                userType.AddMemberName("GoingLeft");
                userType.AddMemberName("StandingStill");
                userType.AddMemberName("IsMoving");
                userType.AddMemberName("CanFire");
                userType.AddMemberName("ViewModel");
                userType.AddMemberName("Timer");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 5:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 6:   //  Boolean
                xamlType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 7:   //  BalloonPop.ViewModels.MainPageViewModel
                userType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("BalloonPop.ViewModels.ViewModelBase"));
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 8:   //  BalloonPop.ViewModels.ViewModelBase
                userType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_8_ViewModelBase;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 9:   //  Object
                xamlType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 10:   //  Windows.UI.Xaml.DispatcherTimer
                xamlType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;
            }
            return xamlType;
        }


        private object get_0_Joystick_Size(object instance)
        {
            var that = (global::BalloonPop.CustomControls.Joystick)instance;
            return that.Size;
        }
        private void set_0_Joystick_Size(object instance, object Value)
        {
            var that = (global::BalloonPop.CustomControls.Joystick)instance;
            that.Size = (global::System.Int32)Value;
        }
        private object get_1_Joystick_TouchSize(object instance)
        {
            var that = (global::BalloonPop.CustomControls.Joystick)instance;
            return that.TouchSize;
        }
        private void set_1_Joystick_TouchSize(object instance, object Value)
        {
            var that = (global::BalloonPop.CustomControls.Joystick)instance;
            that.TouchSize = (global::System.Int32)Value;
        }
        private object get_2_Joystick_TouchLeftPosition(object instance)
        {
            var that = (global::BalloonPop.CustomControls.Joystick)instance;
            return that.TouchLeftPosition;
        }
        private void set_2_Joystick_TouchLeftPosition(object instance, object Value)
        {
            var that = (global::BalloonPop.CustomControls.Joystick)instance;
            that.TouchLeftPosition = (global::System.Double)Value;
        }
        private object get_3_Joystick_TouchTopPosition(object instance)
        {
            var that = (global::BalloonPop.CustomControls.Joystick)instance;
            return that.TouchTopPosition;
        }
        private void set_3_Joystick_TouchTopPosition(object instance, object Value)
        {
            var that = (global::BalloonPop.CustomControls.Joystick)instance;
            that.TouchTopPosition = (global::System.Double)Value;
        }
        private object get_4_MainPage_GoingLeft(object instance)
        {
            var that = (global::BalloonPop.MainPage)instance;
            return that.GoingLeft;
        }
        private void set_4_MainPage_GoingLeft(object instance, object Value)
        {
            var that = (global::BalloonPop.MainPage)instance;
            that.GoingLeft = (global::System.Boolean)Value;
        }
        private object get_5_MainPage_StandingStill(object instance)
        {
            var that = (global::BalloonPop.MainPage)instance;
            return that.StandingStill;
        }
        private void set_5_MainPage_StandingStill(object instance, object Value)
        {
            var that = (global::BalloonPop.MainPage)instance;
            that.StandingStill = (global::System.Boolean)Value;
        }
        private object get_6_MainPage_IsMoving(object instance)
        {
            var that = (global::BalloonPop.MainPage)instance;
            return that.IsMoving;
        }
        private void set_6_MainPage_IsMoving(object instance, object Value)
        {
            var that = (global::BalloonPop.MainPage)instance;
            that.IsMoving = (global::System.Boolean)Value;
        }
        private object get_7_MainPage_CanFire(object instance)
        {
            var that = (global::BalloonPop.MainPage)instance;
            return that.CanFire;
        }
        private void set_7_MainPage_CanFire(object instance, object Value)
        {
            var that = (global::BalloonPop.MainPage)instance;
            that.CanFire = (global::System.Boolean)Value;
        }
        private object get_8_MainPage_ViewModel(object instance)
        {
            var that = (global::BalloonPop.MainPage)instance;
            return that.ViewModel;
        }
        private void set_8_MainPage_ViewModel(object instance, object Value)
        {
            var that = (global::BalloonPop.MainPage)instance;
            that.ViewModel = (global::BalloonPop.ViewModels.MainPageViewModel)Value;
        }
        private object get_9_MainPage_Timer(object instance)
        {
            var that = (global::BalloonPop.MainPage)instance;
            return that.Timer;
        }
        private void set_9_MainPage_Timer(object instance, object Value)
        {
            var that = (global::BalloonPop.MainPage)instance;
            that.Timer = (global::Windows.UI.Xaml.DispatcherTimer)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::BalloonPop.BalloonPop_XamlTypeInfo.XamlMember xamlMember = null;
            global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "BalloonPop.CustomControls.Joystick.Size":
                userType = (global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType)GetXamlTypeByName("BalloonPop.CustomControls.Joystick");
                xamlMember = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlMember(this, "Size", "Int32");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_0_Joystick_Size;
                xamlMember.Setter = set_0_Joystick_Size;
                break;
            case "BalloonPop.CustomControls.Joystick.TouchSize":
                userType = (global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType)GetXamlTypeByName("BalloonPop.CustomControls.Joystick");
                xamlMember = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlMember(this, "TouchSize", "Int32");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_1_Joystick_TouchSize;
                xamlMember.Setter = set_1_Joystick_TouchSize;
                break;
            case "BalloonPop.CustomControls.Joystick.TouchLeftPosition":
                userType = (global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType)GetXamlTypeByName("BalloonPop.CustomControls.Joystick");
                xamlMember = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlMember(this, "TouchLeftPosition", "Double");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_2_Joystick_TouchLeftPosition;
                xamlMember.Setter = set_2_Joystick_TouchLeftPosition;
                break;
            case "BalloonPop.CustomControls.Joystick.TouchTopPosition":
                userType = (global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType)GetXamlTypeByName("BalloonPop.CustomControls.Joystick");
                xamlMember = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlMember(this, "TouchTopPosition", "Double");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_3_Joystick_TouchTopPosition;
                xamlMember.Setter = set_3_Joystick_TouchTopPosition;
                break;
            case "BalloonPop.MainPage.GoingLeft":
                userType = (global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType)GetXamlTypeByName("BalloonPop.MainPage");
                xamlMember = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlMember(this, "GoingLeft", "Boolean");
                xamlMember.Getter = get_4_MainPage_GoingLeft;
                xamlMember.Setter = set_4_MainPage_GoingLeft;
                break;
            case "BalloonPop.MainPage.StandingStill":
                userType = (global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType)GetXamlTypeByName("BalloonPop.MainPage");
                xamlMember = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlMember(this, "StandingStill", "Boolean");
                xamlMember.Getter = get_5_MainPage_StandingStill;
                xamlMember.Setter = set_5_MainPage_StandingStill;
                break;
            case "BalloonPop.MainPage.IsMoving":
                userType = (global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType)GetXamlTypeByName("BalloonPop.MainPage");
                xamlMember = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlMember(this, "IsMoving", "Boolean");
                xamlMember.Getter = get_6_MainPage_IsMoving;
                xamlMember.Setter = set_6_MainPage_IsMoving;
                break;
            case "BalloonPop.MainPage.CanFire":
                userType = (global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType)GetXamlTypeByName("BalloonPop.MainPage");
                xamlMember = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlMember(this, "CanFire", "Boolean");
                xamlMember.Getter = get_7_MainPage_CanFire;
                xamlMember.Setter = set_7_MainPage_CanFire;
                break;
            case "BalloonPop.MainPage.ViewModel":
                userType = (global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType)GetXamlTypeByName("BalloonPop.MainPage");
                xamlMember = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlMember(this, "ViewModel", "BalloonPop.ViewModels.MainPageViewModel");
                xamlMember.Getter = get_8_MainPage_ViewModel;
                xamlMember.Setter = set_8_MainPage_ViewModel;
                break;
            case "BalloonPop.MainPage.Timer":
                userType = (global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType)GetXamlTypeByName("BalloonPop.MainPage");
                xamlMember = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlMember(this, "Timer", "Windows.UI.Xaml.DispatcherTimer");
                xamlMember.Getter = get_9_MainPage_Timer;
                xamlMember.Setter = set_9_MainPage_Timer;
                break;
            }
            return xamlMember;
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::BalloonPop.BalloonPop_XamlTypeInfo.XamlSystemBaseType
    {
        global::BalloonPop.BalloonPop_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::BalloonPop.BalloonPop_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::BalloonPop.BalloonPop_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::BalloonPop.BalloonPop_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}

