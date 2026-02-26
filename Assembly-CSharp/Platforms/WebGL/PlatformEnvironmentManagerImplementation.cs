using System;
using System.Runtime.CompilerServices;
using Core;
using Core.Application;
using Core.Application.Managers.Environment;
using Gameplay.Billing.BillingProvider.UnityIAP;
using Il2CppDummyDll;

namespace Platforms.WebGL
{
	// Token: 0x020000C1 RID: 193
	[Token(Token = "0x20000C1")]
	public class PlatformEnvironmentManagerImplementation : IAppManager, IBaseManager, IEnvironment
	{
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000C9")]
		public string Name
		{
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x5B26", Offset = "0x5B26", VA = "0x5B26", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140000C0 RID: 192
		// (add) Token: 0x06000731 RID: 1841 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000732 RID: 1842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000C0")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x5B27", Offset = "0x5B27", VA = "0x5B27", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x5B28", Offset = "0x5B28", VA = "0x5B28", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000C1 RID: 193
		// (add) Token: 0x06000733 RID: 1843 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000734 RID: 1844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000C1")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6000733")]
			[Address(RVA = "0x5B29", Offset = "0x5B29", VA = "0x5B29", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000734")]
			[Address(RVA = "0x5B2A", Offset = "0x5B2A", VA = "0x5B2A", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x5B2B", Offset = "0x5B2B", VA = "0x5B2B")]
		public PlatformEnvironmentManagerImplementation(IApp app)
		{
		/* --- GHIDRA: .ctor ---
		void Platforms_UnityEditor_PlatformEnvironmentManagerImplementation___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b834 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5b834 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
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

		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x5B2C", Offset = "0x5B2C", VA = "0x5B2C", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x5B2D", Offset = "0x5B2D", VA = "0x5B2D", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Platforms_UnityEditor_PlatformEnvironmentManagerImplementation__Deinit
		               (undefined8 *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  undefined1 local_30 [8];
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined4 local_1c;
		  undefined4 uStack_18;
		  undefined8 local_14;
		  undefined4 local_c;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a5b839 == '\0') {
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTaskCompletionSource_TypeInfo);
		    DAT_ram_00a5b839 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Cysharp_Threading_Tasks_UniTaskCompletionSource_TypeInfo);
		  if (DAT_ram_00a5b83a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_UnityServicesInitializer__InitService_d__1___
		              );
		    DAT_ram_00a5b83a = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(local_30,0);
		  local_14 = local_28;
		  local_20 = 0xffffffff;
		  local_1c = local_30._0_4_;
		  uStack_18 = local_30._4_4_;
		  local_c = param2_00;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_SkinManager__HandleDictChangedEvent_d__28_
		            (&local_1c,&local_20,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_UnityServicesInitializer__InitService_d__1___
		            );
		  Cysharp_Threading_Tasks_UniTaskCompletionSource__TrySetResult(&local_20,param2_00,0);
		  *param1 = CONCAT44(local_1c,local_20);
		  return;
		}
		*/

		/* --- GHIDRA: Deinit ---
		void Platforms_WebGL_PlatformEnvironmentManagerImplementation__Deinit
		               (undefined8 *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined1 auStack_30 [4];
		  undefined8 local_2c;
		  undefined4 local_24;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5b82a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_IPlatformSigninProvider__Create__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_IPlatformSigninProvider__Start_PlatformSigninProvider__UpdateSigninRecord_d__2___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_IPlatformSigninProvider__get_Task__
		              );
		    DAT_ram_00a5b82a = '\x01';
		  }
		  local_4 = 0;
		  local_14 = 0;
		  local_c = 0;
		  local_1c = 0;
		  local_20 = 0xffffffff;
		  local_10 = param2;
		  if (*(int *)(
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_IPlatformSigninProvider__Start_PlatformSigninProvider__UpdateSigninRecord_d__2___
		              + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference
		              (
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_IPlatformSigninProvider__Start_PlatformSigninProvider__UpdateSigninRecord_d__2___
		              );
		  }
		  Platforms_WebGL_PlatformSigninProvider_SigninParams___ctor(&local_20,auStack_30);
		  unnamed_function_126403
		            (&local_2c,&local_1c,
		             Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_IPlatformSigninProvider__get_Task__
		            );
		  *(undefined4 *)(param1 + 1) = local_24;
		  *param1 = local_2c;
		  return;
		}
		*/

		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000738")]
		public T GetUiapWrapper<T>() where T : class, IUiapWrapper, new()
		{
			return null;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Platforms_WebGL_PlatformEnvironmentManagerImplementation__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b826 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5b826 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
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


		/* --- GHIDRA: add_InitCompleteEvent ---
		void Platforms_WebGL_PlatformEnvironmentManagerImplementation__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b827 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5b827 = '\x01';
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
		void Platforms_WebGL_PlatformEnvironmentManagerImplementation__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b828 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5b828 = '\x01';
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
		void Platforms_WebGL_PlatformEnvironmentManagerImplementation__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b829 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5b829 = '\x01';
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


		/* --- GHIDRA: add_InitCompleteEvent ---
		void Platforms_UnityEditor_PlatformEnvironmentManagerImplementation__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b835 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5b835 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
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
		void Platforms_UnityEditor_PlatformEnvironmentManagerImplementation__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b836 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5b836 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
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
		void Platforms_UnityEditor_PlatformEnvironmentManagerImplementation__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b837 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5b837 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
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
		void Platforms_UnityEditor_PlatformEnvironmentManagerImplementation__remove_DeinitCompleteEvent
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int *param1_01;
		  undefined4 param2_00;
		  undefined4 param3;
		  
		  if (DAT_ram_00a5b838 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_BaseEventBusEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    DAT_ram_00a5b838 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x10);
		  if (iVar3 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),param1,*(undefined4 *)(iVar3 + 0x14));
		  }
		  uVar1 = 0;
		  param1_01 = *(int **)(param1 + 0xc);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x100);
		        goto code_r0x81385458;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Application_IApp_TypeInfo,8);
		code_r0x81385458:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  iVar3 = *(int *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x1c) + 8);
		  if (iVar3 != 0) {
		    param2_00 = *(undefined4 *)(param1 + 0xc);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    param1_00 = unnamed_function_1417(Core_Events_BaseEventBusEventArgs_TypeInfo);
		    Core_Application_Managers_Connection_ServerConnectionDelay__ResetAll
		              (param1_00,param2_00,param3,0);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),param1_00,*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

}
