using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Dict;
using Core.Dict.Controller;
using Core.Dict.Controller.WebGL;
using Core.Dict.DictWrappers.Base;
using Core.Dict.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using Protocol.Dic;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001163 RID: 4451
	[Token(Token = "0x2001163")]
	public class DictManager : IGameManager, IBaseManager, IDictProvider, IGameAssetProvider
	{
		// Token: 0x1400027D RID: 637
		// (add) Token: 0x060068DB RID: 26843 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060068DC RID: 26844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400027D")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60068DB")]
			[Address(RVA = "0xB401", Offset = "0xB401", VA = "0xB401", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60068DC")]
			[Address(RVA = "0xB402", Offset = "0xB402", VA = "0xB402", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400027E RID: 638
		// (add) Token: 0x060068DD RID: 26845 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060068DE RID: 26846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400027E")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60068DD")]
			[Address(RVA = "0xB403", Offset = "0xB403", VA = "0xB403", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60068DE")]
			[Address(RVA = "0xB404", Offset = "0xB404", VA = "0xB404", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x060068DF RID: 26847 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001574")]
		public string Name
		{
			[Token(Token = "0x60068DF")]
			[Address(RVA = "0xB405", Offset = "0xB405", VA = "0xB405", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001575 RID: 5493
		// (get) Token: 0x060068E0 RID: 26848 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068E1 RID: 26849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001575")]
		public DictController Controller
		{
			[Token(Token = "0x60068E0")]
			[Address(RVA = "0xB406", Offset = "0xB406", VA = "0xB406")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068E1")]
			[Address(RVA = "0xB407", Offset = "0xB407", VA = "0xB407")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x060068E2 RID: 26850 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068E3 RID: 26851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001576")]
		public DictModel Model
		{
			[Token(Token = "0x60068E2")]
			[Address(RVA = "0xB408", Offset = "0xB408", VA = "0xB408")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068E3")]
			[Address(RVA = "0xB409", Offset = "0xB409", VA = "0xB409")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x060068E4 RID: 26852 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068E5 RID: 26853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001577")]
		public DictEvents Events
		{
			[Token(Token = "0x60068E4")]
			[Address(RVA = "0xB40A", Offset = "0xB40A", VA = "0xB40A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068E5")]
			[Address(RVA = "0xB40B", Offset = "0xB40B", VA = "0xB40B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x060068E6 RID: 26854 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001578")]
		public Dictionaries D
		{
			[Token(Token = "0x60068E6")]
			[Address(RVA = "0x1AAD", Offset = "0x1AAD", VA = "0x1AAD", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400027F RID: 639
		// (add) Token: 0x060068E7 RID: 26855 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060068E8 RID: 26856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400027F")]
		public event Action ChangedEvent
		{
			[Token(Token = "0x60068E7")]
			[Address(RVA = "0xB40C", Offset = "0xB40C", VA = "0xB40C", Slot = "11")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60068E8")]
			[Address(RVA = "0xB40D", Offset = "0xB40D", VA = "0xB40D", Slot = "12")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x060068E9 RID: 26857 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068EA RID: 26858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001579")]
		public IApp App
		{
			[Token(Token = "0x60068E9")]
			[Address(RVA = "0xB40E", Offset = "0xB40E", VA = "0xB40E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068EA")]
			[Address(RVA = "0xB40F", Offset = "0xB40F", VA = "0xB40F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x060068EB RID: 26859 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068EC RID: 26860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700157A")]
		public DictWrappersStorage WrappersStorage
		{
			[Token(Token = "0x60068EB")]
			[Address(RVA = "0xB410", Offset = "0xB410", VA = "0xB410", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068EC")]
			[Address(RVA = "0xB411", Offset = "0xB411", VA = "0xB411")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060068ED RID: 26861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068ED")]
		[Address(RVA = "0xB412", Offset = "0xB412", VA = "0xB412")]
		public DictManager(IApp app)
		{
		/* --- GHIDRA: .ctor ---
		uint Core_Gameplay_Managers_DictManager___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a637b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_IndexOf_string___);
		    Mono_Security_ASN1__get_Item(&string___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27528);
		    DAT_ram_00a637b4 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 0x28);
		  if (iVar2 == 0) {
		    uVar1 = Core_Extensions_Dict_DictExt__GetResourceSetParameter
		                      (*(undefined4 *)(*(int *)(param1 + 0x14) + 0x14),StringLiteral_27528,0);
		    iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar1,0);
		    if (iVar2 == 0) {
		      iVar2 = System_Net_WebConnection__ReadLine(uVar1,0x2c,0,0);
		    }
		    else {
		      iVar2 = Mono_Security_ASN1Convert__ToOid(string___TypeInfo,0);
		    }
		    *(int *)(param1 + 0x28) = iVar2;
		  }
		  local_4 = param2;
		  uVar1 = func_ii_4443(&local_4,0);
		  iVar2 = LunarConsolePlugin_CVar__set_Value(iVar2,uVar1,Method_System_Array_IndexOf_string___);
		  return (uint)(iVar2 != -1);
		}
		*/

		}

		// Token: 0x060068EE RID: 26862 RVA: 0x00013938 File Offset: 0x00011B38
		[Token(Token = "0x60068EE")]
		[Address(RVA = "0xB413", Offset = "0xB413", VA = "0xB413")]
		public bool CheckSupportedService(Services serviceId)
		{
		/* --- GHIDRA: CheckSupportedService ---
		undefined4
		Core_Gameplay_Managers_DictManager__CheckSupportedService(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 local_4;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a637b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__AssetDic__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_233);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3332);
		    DAT_ram_00a637b5 = '\x01';
		  }
		  local_4 = 0;
		  if ((param2 != 0) &&
		     (iVar2 = Spine_Unity_AttachmentTools_AttachmentRegionExtensions__GetRegion
		                        (*(undefined4 *)(*(int *)(param1 + 0x14) + 0x18),param2,&local_4,
		                         Method_System_Collections_Generic_Dictionary_string__AssetDic__TryGetValue__
		                        ), uVar1 = local_4, iVar2 == 0)) {
		    uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                      (StringLiteral_3332,param2,StringLiteral_233,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar1,0);
		    uVar1 = 0;
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x060068EF RID: 26863 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60068EF")]
		[Address(RVA = "0x1D72", Offset = "0x1D72", VA = "0x1D72", Slot = "16")]
		public string GetAssetPath(string assetId)
		{
		/* --- GHIDRA: GetAssetPath ---
		void Core_Gameplay_Managers_DictManager__GetAssetPath
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  char cVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  
		  uVar4 = *(undefined4 *)(param3 + 4);
		  *(int *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 8) = uVar4;
		  *(int *)(param1 + 0x10) = param2;
		  cVar1 = *(char *)(param3 + 0x2e);
		  *(int *)(param1 + 0x20) = param1;
		  iVar2 = func_ii_4538(param3);
		  if (iVar2 == 0) {
		    if (cVar1 == '\x01') {
		      if (*(char *)(param1 + 0x38) == '\0') {
		        *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x2f;
		      }
		      else {
		        iVar2 = unnamed_function_159288(param3);
		        iVar3 = func_ii_21171(param3);
		        if (iVar2 == 0) {
		          if (iVar3 == 0) {
		            *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x2e;
		          }
		          else {
		            *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x2d;
		          }
		        }
		        else if (iVar3 == 0) {
		          *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x2c;
		        }
		        else {
		          *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x2b;
		        }
		      }
		    }
		    else {
		      if (param2 == 0) {
		        uVar4 = Mono_Unity_CertHelper__AddCertificatesToNativeChain
		                          (0,s_Delegate_to_an_instance_method_c_ram_0005d205);
		        func_ii_1050(uVar4,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		      *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		    }
		  }
		  else if (cVar1 == '\x02') {
		    *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x2a;
		  }
		  else {
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  *(char **)(param1 + 0x1c) = s___Scripting__UnityEngine__UnityS_ram_00003636 + 0x30;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060068F0 RID: 26864 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60068F0")]
		[Address(RVA = "0xB414", Offset = "0xB414", VA = "0xB414", Slot = "15")]
		public AssetDic GetAsset(string assetId)
		{
		/* --- GHIDRA: GetAsset ---
		void Core_Gameplay_Managers_DictManager__GetAsset(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param5;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 param4;
		  int iVar7;
		  
		  if (DAT_ram_00a637b6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_Controller_WebGL_DictController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_Controller_DictEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_DictManager_InitEventHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_DictManager_NotifyDictChanged__);
		    Mono_Security_ASN1__get_Item(&Core_Dict_Model_DictModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    DAT_ram_00a637b6 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(Core_Dict_Controller_DictEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  piVar4 = *(int **)(param1 + 0x20);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x108);
		        goto code_r0x822ff628;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,9);
		code_r0x822ff628:
		  uVar1 = 0;
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  piVar4 = *(int **)(param1 + 0x20);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x160);
		        goto code_r0x822ff6ad;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,0x14);
		code_r0x822ff6ad:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar6 = *(undefined4 *)(iVar5 + 0x14);
		  uVar1 = 0;
		  piVar4 = *(int **)(param1 + 0x20);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x110);
		        goto code_r0x822ff735;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,10);
		code_r0x822ff735:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  param4 = *(undefined4 *)(iVar5 + 0x10);
		  uVar1 = 0;
		  piVar4 = *(int **)(param1 + 0x20);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x188);
		        goto code_r0x822ff7bd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,0x19);
		code_r0x822ff7bd:
		  param5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  param1_00 = unnamed_function_1417(Core_Dict_Model_DictModel_TypeInfo);
		  Core_Dict_Model_DictModel__Dispose(param1_00,uVar2,uVar6,param4,param5,0,0);
		  *(undefined4 *)(param1 + 0x14) = param1_00;
		  uVar6 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(Core_Dict_Controller_WebGL_DictController_TypeInfo);
		  Core_Dict_Controller_WebGL_DictController___ctor(uVar2,param1_00,uVar6,0);
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  iVar7 = *(int *)(param1 + 0x18);
		  uVar6 = *(undefined4 *)(iVar7 + 8);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Core_Gameplay_Managers_DictManager_InitEventHandler__,0);
		  piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		  iVar5 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 8) = 0;
		  }
		  else if ((*piVar4 != System_Action_TypeInfo) || (*(int **)(iVar7 + 8) = piVar4, *piVar4 != iVar5))
		  {
		    System_Activator__CreateInstance(piVar4,iVar5);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar7 = *(int *)(param1 + 0x18);
		  uVar6 = *(undefined4 *)(iVar7 + 0x14);
		  uVar2 = unnamed_function_1417(iVar5);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Core_Gameplay_Managers_DictManager_NotifyDictChanged__,0);
		  piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		  iVar5 = System_Action_TypeInfo;
		  if (piVar4 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar4) ||
		          (*(int **)(iVar7 + 0x14) = piVar4, *piVar4 != iVar5)) {
		    System_Activator__CreateInstance(piVar4,iVar5);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x10),0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060068F1 RID: 26865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068F1")]
		[Address(RVA = "0xB415", Offset = "0xB415", VA = "0xB415", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_DictManager__Init(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a637b7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_DictManager_InitEventHandler__);
		    DAT_ram_00a637b7 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x18);
		  param1_02 = *(undefined4 *)(iVar1 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Core_Gameplay_Managers_DictManager_InitEventHandler__,0);
		  param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		  iVar2 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_01) ||
		          (*(int **)(iVar1 + 0x14) = param1_01, *param1_01 != iVar2)) {
		    System_Activator__CreateInstance(param1_01,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Core_Gameplay_Managers_DictManager__Deinit(param1,param1);
		  iVar2 = *(int *)(param1 + 8);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060068F2 RID: 26866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068F2")]
		[Address(RVA = "0xB416", Offset = "0xB416", VA = "0xB416")]
		private void InitEventHandler()
		{
		}

		// Token: 0x060068F3 RID: 26867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068F3")]
		[Address(RVA = "0xB417", Offset = "0xB417", VA = "0xB417")]
		private void NotifyDictChanged()
		{
		/* --- GHIDRA: NotifyDictChanged ---
		void Core_Gameplay_Managers_DictManager__NotifyDictChanged(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a637b8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_DictManager_InitEventHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_DictManager_NotifyDictChanged__);
		    DAT_ram_00a637b8 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x18);
		  uVar4 = *(undefined4 *)(iVar3 + 8);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Core_Gameplay_Managers_DictManager_InitEventHandler__,0);
		  piVar2 = (int *)func_ii_7048(uVar4,uVar1,0);
		  iVar5 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(iVar3 + 8) = 0;
		  }
		  else if ((*piVar2 != System_Action_TypeInfo) || (*(int **)(iVar3 + 8) = piVar2, *piVar2 != iVar5))
		  {
		    System_Activator__CreateInstance(piVar2,iVar5);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar3 = *(int *)(param1 + 0x18);
		  uVar4 = *(undefined4 *)(iVar3 + 0x14);
		  uVar1 = unnamed_function_1417(iVar5);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Core_Gameplay_Managers_DictManager_NotifyDictChanged__,0);
		  piVar2 = (int *)func_ii_7048(uVar4,uVar1,0);
		  iVar5 = System_Action_TypeInfo;
		  if (piVar2 == (int *)0x0) {
		    *(undefined4 *)(iVar3 + 0x14) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar2) ||
		          (*(int **)(iVar3 + 0x14) = piVar2, *piVar2 != iVar5)) {
		    System_Activator__CreateInstance(piVar2,iVar5);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x10),0);
		  iVar5 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe8) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar5 + 0xec));
		  iVar5 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe8) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar5 + 0xec));
		  Core_Dict_DictWrappers_Base_DictWrappersStorage___ctor(*(undefined4 *)(param1 + 0x24),0);
		  *(undefined8 *)(param1 + 0x20) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  *(undefined4 *)(param1 + 0x18) = 0;
		  iVar5 = *(int *)(param1 + 0xc);
		  if (iVar5 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		              (*(undefined4 *)(iVar5 + 0x20),param1,*(undefined4 *)(iVar5 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060068F4 RID: 26868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068F4")]
		[Address(RVA = "0xB418", Offset = "0xB418", VA = "0xB418", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_DictManager__Deinit(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int iVar8;
		  uint *puVar9;
		  int *piVar10;
		  
		  if (DAT_ram_00a637b9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Net_Monitor_Responseability_Configuration_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_Managers_INotificationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25201);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25203);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25204);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25206);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25202);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25205);
		    DAT_ram_00a637b9 = '\x01';
		  }
		  iVar2 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic
		                    (*(undefined4 *)(*(int *)(param1 + 0x14) + 0x14),StringLiteral_25202,0);
		  iVar3 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic
		                    (*(undefined4 *)(*(int *)(param1 + 0x14) + 0x14),StringLiteral_25204,0);
		  iVar4 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic
		                    (*(undefined4 *)(*(int *)(param1 + 0x14) + 0x14),StringLiteral_25206,0);
		  iVar5 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic
		                    (*(undefined4 *)(*(int *)(param1 + 0x14) + 0x14),StringLiteral_25205,0);
		  iVar6 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic
		                    (*(undefined4 *)(*(int *)(param1 + 0x14) + 0x14),StringLiteral_25201,0);
		  uVar7 = Core_Extensions_Dict_DictExt__GetLongParameter
		                    (*(undefined4 *)(*(int *)(param1 + 0x14) + 0x14),StringLiteral_25203,0);
		  if ((((iVar2 == 0) || (iVar3 == 0)) || (iVar4 == 0)) || ((iVar5 == 0 || (iVar6 == 0)))) {
		    iVar8 = unnamed_function_1417(Core_Net_Monitor_Responseability_Configuration_TypeInfo);
		  }
		  else {
		    uVar1 = 0;
		    piVar10 = *(int **)(param1 + 0x20);
		    iVar8 = *piVar10;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar9 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x120);
		          goto code_r0x822ffb52;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar9 = (uint *)func_ii_1080(piVar10,Core_Application_IApp_TypeInfo,0xc);
		code_r0x822ffb52:
		    iVar8 = (**(code **)((ulonglong)*puVar9 * 4))(piVar10,puVar9[1]);
		    iVar8 = *(int *)(*(int *)(iVar8 + 0x30) + 0x14);
		    *(int *)(iVar8 + 0x18) = iVar6;
		    *(int *)(iVar8 + 0x14) = iVar5;
		    *(int *)(iVar8 + 0x10) = iVar4;
		    *(int *)(iVar8 + 0xc) = iVar3;
		    *(int *)(iVar8 + 8) = iVar2;
		  }
		  *(char *)(iVar8 + 0x1c) = (char)uVar7;
		  uVar1 = 0;
		  piVar10 = *(int **)(param1 + 0x20);
		  iVar2 = *piVar10;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar9 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x120);
		        goto code_r0x822ffc16;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar9 = (uint *)func_ii_1080(piVar10,Core_Application_IApp_TypeInfo,0xc);
		code_r0x822ffc16:
		  iVar2 = (**(code **)((ulonglong)*puVar9 * 4))(piVar10,puVar9[1]);
		  *(int *)(*(int *)(iVar2 + 0x30) + 0x14) = iVar8;
		  uVar1 = 0;
		  piVar10 = *(int **)(param1 + 0x20);
		  iVar2 = *piVar10;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar9 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x148);
		        goto code_r0x822ffca1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar9 = (uint *)func_ii_1080(piVar10,Core_Application_IApp_TypeInfo,0x11);
		code_r0x822ffca1:
		  piVar10 = (int *)(**(code **)((ulonglong)*puVar9 * 4))(piVar10,puVar9[1]);
		  uVar1 = 0;
		  iVar2 = *piVar10;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Application_Managers_INotificationManager_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar9 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		        goto code_r0x822ffd25;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar9 = (uint *)func_ii_1080(piVar10,Core_Application_Managers_INotificationManager_TypeInfo,2);
		code_r0x822ffd25:
		  (**(code **)((ulonglong)*puVar9 * 4))(piVar10,param1,puVar9[1]);
		  return;
		}
		*/

		}

		// Token: 0x060068F5 RID: 26869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068F5")]
		[Address(RVA = "0xB419", Offset = "0xB419", VA = "0xB419")]
		private void ConfigureApp()
		{
		/* --- GHIDRA: ConfigureApp ---
		undefined4 Core_Gameplay_Managers_DictManager__ConfigureApp(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a637ba == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_6570);
		    DAT_ram_00a637ba = '\x01';
		  }
		  return StringLiteral_6570;
		}
		*/

		}

		// Token: 0x040037BA RID: 14266
		[Token(Token = "0x40037BA")]
		[FieldOffset(Offset = "0x28")]
		private string[] _supportedServices;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_DictManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637ad == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637ad = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Gameplay_Managers_DictManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637ae == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637ae = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_DictManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637af == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637af = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_DeinitCompleteEvent ---
		undefined4
		Core_Gameplay_Managers_DictManager__remove_DeinitCompleteEvent(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a637b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_6535);
		    DAT_ram_00a637b0 = '\x01';
		  }
		  return StringLiteral_6535;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Core_Gameplay_Managers_DictManager__set_Events(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a637b1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a637b1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x1c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_D ---
		undefined4 Core_Gameplay_Managers_DictManager__get_D(int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad20 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EventTypeDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_EventTypeDic__get_Item__);
		    DAT_ram_00a5ad20 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(param1 + 0x78) + 0xc);
		  if (0 < iVar2) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x78),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_EventTypeDic__get_Item__);
		      if (*(int *)(iVar1 + 0xc) == param2) {
		        return iVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar2);
		  }
		  return 0;
		}
		*/


		/* --- GHIDRA: add_ChangedEvent ---
		void Core_Gameplay_Managers_DictManager__add_ChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a637b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a637b2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x1c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_WrappersStorage ---
		void Core_Gameplay_Managers_DictManager__set_WrappersStorage
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a637b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_DictWrappers_Base_DictWrappersStorage_TypeInfo);
		    DAT_ram_00a637b3 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x20) = param2;
		  param1_00 = unnamed_function_1417(Core_Dict_DictWrappers_Base_DictWrappersStorage_TypeInfo);
		  Core_Dict_DictWrappers_Base_DictWrappersStorage__set_AprDicStorage(param1_00,param1,0);
		  *(undefined4 *)(param1 + 0x24) = param1_00;
		  return;
		}
		*/

}
