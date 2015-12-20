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
            _typeNameTable = new string[18];
            _typeNameTable[0] = "BalloonPop.Helpers.Converters.VisibilityConverter";
            _typeNameTable[1] = "Object";
            _typeNameTable[2] = "BalloonPop.CustomControls.Joystick";
            _typeNameTable[3] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[4] = "Int32";
            _typeNameTable[5] = "Double";
            _typeNameTable[6] = "BalloonPop.Helpers.BindingHelper";
            _typeNameTable[7] = "String";
            _typeNameTable[8] = "Windows.UI.Xaml.DependencyObject";
            _typeNameTable[9] = "BalloonPop.MainPage";
            _typeNameTable[10] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[11] = "BalloonPop.ViewModels.MainPageViewModel";
            _typeNameTable[12] = "BalloonPop.ViewModels.ViewModelBase";
            _typeNameTable[13] = "Windows.UI.Xaml.DispatcherTimer";
            _typeNameTable[14] = "BalloonPop.Pages.Menu";
            _typeNameTable[15] = "BalloonPop.Pages.ResultPage";
            _typeNameTable[16] = "BalloonPop.ViewModels.Scores.AllScoresViewModel";
            _typeNameTable[17] = "BalloonPop.Data.ResultLocalDb";

            _typeTable = new global::System.Type[18];
            _typeTable[0] = typeof(global::BalloonPop.Helpers.Converters.VisibilityConverter);
            _typeTable[1] = typeof(global::System.Object);
            _typeTable[2] = typeof(global::BalloonPop.CustomControls.Joystick);
            _typeTable[3] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[4] = typeof(global::System.Int32);
            _typeTable[5] = typeof(global::System.Double);
            _typeTable[6] = typeof(global::BalloonPop.Helpers.BindingHelper);
            _typeTable[7] = typeof(global::System.String);
            _typeTable[8] = typeof(global::Windows.UI.Xaml.DependencyObject);
            _typeTable[9] = typeof(global::BalloonPop.MainPage);
            _typeTable[10] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[11] = typeof(global::BalloonPop.ViewModels.MainPageViewModel);
            _typeTable[12] = typeof(global::BalloonPop.ViewModels.ViewModelBase);
            _typeTable[13] = typeof(global::Windows.UI.Xaml.DispatcherTimer);
            _typeTable[14] = typeof(global::BalloonPop.Pages.Menu);
            _typeTable[15] = typeof(global::BalloonPop.Pages.ResultPage);
            _typeTable[16] = typeof(global::BalloonPop.ViewModels.Scores.AllScoresViewModel);
            _typeTable[17] = typeof(global::BalloonPop.Data.ResultLocalDb);
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

        private object Activate_0_VisibilityConverter() { return new global::BalloonPop.Helpers.Converters.VisibilityConverter(); }
        private object Activate_2_Joystick() { return new global::BalloonPop.CustomControls.Joystick(); }
        private object Activate_6_BindingHelper() { return new global::BalloonPop.Helpers.BindingHelper(); }
        private object Activate_9_MainPage() { return new global::BalloonPop.MainPage(); }
        private object Activate_11_MainPageViewModel() { return new global::BalloonPop.ViewModels.MainPageViewModel(); }
        private object Activate_12_ViewModelBase() { return new global::BalloonPop.ViewModels.ViewModelBase(); }
        private object Activate_14_Menu() { return new global::BalloonPop.Pages.Menu(); }
        private object Activate_15_ResultPage() { return new global::BalloonPop.Pages.ResultPage(); }
        private object Activate_16_AllScoresViewModel() { return new global::BalloonPop.ViewModels.Scores.AllScoresViewModel(); }
        private object Activate_17_ResultLocalDb() { return new global::BalloonPop.Data.ResultLocalDb(); }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::BalloonPop.BalloonPop_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  BalloonPop.Helpers.Converters.VisibilityConverter
                userType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_0_VisibilityConverter;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Object
                xamlType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  BalloonPop.CustomControls.Joystick
                userType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.UserControl"));
                userType.Activator = Activate_2_Joystick;
                userType.AddMemberName("Size");
                userType.AddMemberName("TouchSize");
                userType.AddMemberName("TouchLeftPosition");
                userType.AddMemberName("TouchTopPosition");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 3:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 4:   //  Int32
                xamlType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 5:   //  Double
                xamlType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 6:   //  BalloonPop.Helpers.BindingHelper
                userType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_6_BindingHelper;
                userType.AddMemberName("CanvasLeftBindingPath");
                userType.AddMemberName("CanvasTopBindingPath");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 7:   //  String
                xamlType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 8:   //  Windows.UI.Xaml.DependencyObject
                xamlType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 9:   //  BalloonPop.MainPage
                userType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_9_MainPage;
                userType.AddMemberName("ViewModel");
                userType.AddMemberName("PlayerMovementTimer");
                userType.AddMemberName("WeaponMovementTimer");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 10:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 11:   //  BalloonPop.ViewModels.MainPageViewModel
                userType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("BalloonPop.ViewModels.ViewModelBase"));
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 12:   //  BalloonPop.ViewModels.ViewModelBase
                userType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_12_ViewModelBase;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 13:   //  Windows.UI.Xaml.DispatcherTimer
                xamlType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 14:   //  BalloonPop.Pages.Menu
                userType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_14_Menu;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 15:   //  BalloonPop.Pages.ResultPage
                userType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_15_ResultPage;
                userType.AddMemberName("ScoresVM");
                userType.AddMemberName("ResultLocalDb");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 16:   //  BalloonPop.ViewModels.Scores.AllScoresViewModel
                userType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("BalloonPop.ViewModels.ViewModelBase"));
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 17:   //  BalloonPop.Data.ResultLocalDb
                userType = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
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
        private object get_4_BindingHelper_CanvasLeftBindingPath(object instance)
        {
            return global::BalloonPop.Helpers.BindingHelper.GetCanvasLeftBindingPath((global::Windows.UI.Xaml.DependencyObject)instance);
        }
        private void set_4_BindingHelper_CanvasLeftBindingPath(object instance, object Value)
        {
            global::BalloonPop.Helpers.BindingHelper.SetCanvasLeftBindingPath((global::Windows.UI.Xaml.DependencyObject)instance, (global::System.String)Value);
        }
        private object get_5_BindingHelper_CanvasTopBindingPath(object instance)
        {
            return global::BalloonPop.Helpers.BindingHelper.GetCanvasTopBindingPath((global::Windows.UI.Xaml.DependencyObject)instance);
        }
        private void set_5_BindingHelper_CanvasTopBindingPath(object instance, object Value)
        {
            global::BalloonPop.Helpers.BindingHelper.SetCanvasTopBindingPath((global::Windows.UI.Xaml.DependencyObject)instance, (global::System.String)Value);
        }
        private object get_6_MainPage_ViewModel(object instance)
        {
            var that = (global::BalloonPop.MainPage)instance;
            return that.ViewModel;
        }
        private void set_6_MainPage_ViewModel(object instance, object Value)
        {
            var that = (global::BalloonPop.MainPage)instance;
            that.ViewModel = (global::BalloonPop.ViewModels.MainPageViewModel)Value;
        }
        private object get_7_MainPage_PlayerMovementTimer(object instance)
        {
            var that = (global::BalloonPop.MainPage)instance;
            return that.PlayerMovementTimer;
        }
        private void set_7_MainPage_PlayerMovementTimer(object instance, object Value)
        {
            var that = (global::BalloonPop.MainPage)instance;
            that.PlayerMovementTimer = (global::Windows.UI.Xaml.DispatcherTimer)Value;
        }
        private object get_8_MainPage_WeaponMovementTimer(object instance)
        {
            var that = (global::BalloonPop.MainPage)instance;
            return that.WeaponMovementTimer;
        }
        private void set_8_MainPage_WeaponMovementTimer(object instance, object Value)
        {
            var that = (global::BalloonPop.MainPage)instance;
            that.WeaponMovementTimer = (global::Windows.UI.Xaml.DispatcherTimer)Value;
        }
        private object get_9_ResultPage_ScoresVM(object instance)
        {
            var that = (global::BalloonPop.Pages.ResultPage)instance;
            return that.ScoresVM;
        }
        private void set_9_ResultPage_ScoresVM(object instance, object Value)
        {
            var that = (global::BalloonPop.Pages.ResultPage)instance;
            that.ScoresVM = (global::BalloonPop.ViewModels.Scores.AllScoresViewModel)Value;
        }
        private object get_10_ResultPage_ResultLocalDb(object instance)
        {
            var that = (global::BalloonPop.Pages.ResultPage)instance;
            return that.ResultLocalDb;
        }
        private void set_10_ResultPage_ResultLocalDb(object instance, object Value)
        {
            var that = (global::BalloonPop.Pages.ResultPage)instance;
            that.ResultLocalDb = (global::BalloonPop.Data.ResultLocalDb)Value;
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
            case "BalloonPop.Helpers.BindingHelper.CanvasLeftBindingPath":
                userType = (global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType)GetXamlTypeByName("BalloonPop.Helpers.BindingHelper");
                xamlMember = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlMember(this, "CanvasLeftBindingPath", "String");
                xamlMember.SetTargetTypeName("Windows.UI.Xaml.DependencyObject");
                xamlMember.SetIsAttachable();
                xamlMember.Getter = get_4_BindingHelper_CanvasLeftBindingPath;
                xamlMember.Setter = set_4_BindingHelper_CanvasLeftBindingPath;
                break;
            case "BalloonPop.Helpers.BindingHelper.CanvasTopBindingPath":
                userType = (global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType)GetXamlTypeByName("BalloonPop.Helpers.BindingHelper");
                xamlMember = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlMember(this, "CanvasTopBindingPath", "String");
                xamlMember.SetTargetTypeName("Windows.UI.Xaml.DependencyObject");
                xamlMember.SetIsAttachable();
                xamlMember.Getter = get_5_BindingHelper_CanvasTopBindingPath;
                xamlMember.Setter = set_5_BindingHelper_CanvasTopBindingPath;
                break;
            case "BalloonPop.MainPage.ViewModel":
                userType = (global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType)GetXamlTypeByName("BalloonPop.MainPage");
                xamlMember = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlMember(this, "ViewModel", "BalloonPop.ViewModels.MainPageViewModel");
                xamlMember.Getter = get_6_MainPage_ViewModel;
                xamlMember.Setter = set_6_MainPage_ViewModel;
                break;
            case "BalloonPop.MainPage.PlayerMovementTimer":
                userType = (global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType)GetXamlTypeByName("BalloonPop.MainPage");
                xamlMember = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlMember(this, "PlayerMovementTimer", "Windows.UI.Xaml.DispatcherTimer");
                xamlMember.Getter = get_7_MainPage_PlayerMovementTimer;
                xamlMember.Setter = set_7_MainPage_PlayerMovementTimer;
                break;
            case "BalloonPop.MainPage.WeaponMovementTimer":
                userType = (global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType)GetXamlTypeByName("BalloonPop.MainPage");
                xamlMember = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlMember(this, "WeaponMovementTimer", "Windows.UI.Xaml.DispatcherTimer");
                xamlMember.Getter = get_8_MainPage_WeaponMovementTimer;
                xamlMember.Setter = set_8_MainPage_WeaponMovementTimer;
                break;
            case "BalloonPop.Pages.ResultPage.ScoresVM":
                userType = (global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType)GetXamlTypeByName("BalloonPop.Pages.ResultPage");
                xamlMember = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlMember(this, "ScoresVM", "BalloonPop.ViewModels.Scores.AllScoresViewModel");
                xamlMember.Getter = get_9_ResultPage_ScoresVM;
                xamlMember.Setter = set_9_ResultPage_ScoresVM;
                break;
            case "BalloonPop.Pages.ResultPage.ResultLocalDb":
                userType = (global::BalloonPop.BalloonPop_XamlTypeInfo.XamlUserType)GetXamlTypeByName("BalloonPop.Pages.ResultPage");
                xamlMember = new global::BalloonPop.BalloonPop_XamlTypeInfo.XamlMember(this, "ResultLocalDb", "BalloonPop.Data.ResultLocalDb");
                xamlMember.Getter = get_10_ResultPage_ResultLocalDb;
                xamlMember.Setter = set_10_ResultPage_ResultLocalDb;
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

