using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Application.Managers.Configuration.Curator;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Configuration
{
	// Token: 0x0200122F RID: 4655
	[Token(Token = "0x200122F")]
	public class ConfigurationManager : IAppManager, IBaseManager
	{
		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x06006E3A RID: 28218 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700165B")]
		public string Name
		{
			[Token(Token = "0x6006E3A")]
			[Address(RVA = "0xB8E5", Offset = "0xB8E5", VA = "0xB8E5", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002DD RID: 733
		// (add) Token: 0x06006E3B RID: 28219 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006E3C RID: 28220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002DD")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006E3B")]
			[Address(RVA = "0xB8E6", Offset = "0xB8E6", VA = "0xB8E6", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006E3C")]
			[Address(RVA = "0xB8E7", Offset = "0xB8E7", VA = "0xB8E7", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002DE RID: 734
		// (add) Token: 0x06006E3D RID: 28221 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006E3E RID: 28222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002DE")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006E3D")]
			[Address(RVA = "0xB8E8", Offset = "0xB8E8", VA = "0xB8E8", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006E3E")]
			[Address(RVA = "0xB8E9", Offset = "0xB8E9", VA = "0xB8E9", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x06006E3F RID: 28223 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006E40 RID: 28224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700165C")]
		public IPlatformConfigurationProvider Provider
		{
			[Token(Token = "0x6006E3F")]
			[Address(RVA = "0xB8EA", Offset = "0xB8EA", VA = "0xB8EA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E40")]
			[Address(RVA = "0xB8EB", Offset = "0xB8EB", VA = "0xB8EB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x06006E41 RID: 28225 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006E42 RID: 28226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700165D")]
		public IApp Application
		{
			[Token(Token = "0x6006E41")]
			[Address(RVA = "0xB8EC", Offset = "0xB8EC", VA = "0xB8EC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006E42")]
			[Address(RVA = "0xB8ED", Offset = "0xB8ED", VA = "0xB8ED")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006E43 RID: 28227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E43")]
		[Address(RVA = "0xB8EE", Offset = "0xB8EE", VA = "0xB8EE")]
		public ConfigurationManager(App application)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Configuration_ConfigurationManager___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined8 local_34;
		  undefined8 local_2c;
		  undefined4 local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a7e5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_ConfigurationManager__Init_d__17___
		              );
		    DAT_ram_00a5a7e5 = '\x01';
		  }
		  local_4 = 0;
		  local_c = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_34,0);
		  local_18 = local_2c;
		  local_24 = 0xffffffff;
		  local_20 = local_34;
		  local_10 = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_CallAccumulator__RunTimer_d__8_
		            (&local_20,&local_24,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_ConfigurationManager__Init_d__17___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06006E44 RID: 28228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E44")]
		[Address(RVA = "0xB8EF", Offset = "0xB8EF", VA = "0xB8EF", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_Configuration_ConfigurationManager__Init(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  int *local_4;
		  
		  if (DAT_ram_00a5a7e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ICuratorDataProvider__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Configuration_ConfigurationManager_HandleForAnalyticCuratorCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo);
		    DAT_ram_00a5a7e6 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  piVar3 = *(int **)(param1 + 0x10);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x81274ce0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,
		                                Core_Gameplay_Managers_Configuration_IPlatformConfigurationProvider_TypeInfo
		                                ,5);
		code_r0x81274ce0:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,&local_4,puVar2[1]);
		  piVar3 = local_4;
		  if (iVar4 != 0) {
		    uVar1 = 0;
		    param1_00 = unnamed_function_1417(System_Action_ICuratorDataProvider__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_00,param1,
		               Method_Core_Gameplay_Managers_Configuration_ConfigurationManager_HandleForAnalyticCuratorCompleteEvent__
		               ,0);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		          goto code_r0x81274d8d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,
		                                  Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo
		                                  ,1);
		code_r0x81274d8d:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar3,param1_00,puVar2[1]);
		  }
		  uVar1 = 0;
		  piVar3 = *(int **)(param1 + 0x10);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81274e0d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,System_IDisposable_TypeInfo,0);
		code_r0x81274e0d:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar4 = *(int *)(param1 + 0xc);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),param1,*(undefined4 *)(iVar4 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006E45 RID: 28229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E45")]
		[Address(RVA = "0xB8F0", Offset = "0xB8F0", VA = "0xB8F0", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_Configuration_ConfigurationManager__Deinit
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined8 local_3c;
		  undefined8 local_34;
		  undefined4 local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a7e7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_ConfigurationManager__HandleConfigurationProvider_d__19___
		              );
		    DAT_ram_00a5a7e7 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_3c,0);
		  local_20 = local_34;
		  local_2c = 0xffffffff;
		  local_28 = local_3c;
		  local_18 = param2;
		  local_14 = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_object___ConfigurationManager__Init_d__17_
		            (&local_28,&local_2c,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_ConfigurationManager__HandleConfigurationProvider_d__19___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06006E46 RID: 28230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E46")]
		[Address(RVA = "0xB8F1", Offset = "0xB8F1", VA = "0xB8F1")]
		private void HandleConfigurationProvider(IPlatformConfigurationProvider provider)
		{
		/* --- GHIDRA: HandleConfigurationProvider ---
		void Core_Gameplay_Managers_Configuration_ConfigurationManager__HandleConfigurationProvider
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a7e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ICuratorDataProvider__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Configuration_ConfigurationManager_HandleCuratorCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo);
		    DAT_ram_00a5a7e8 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Action_ICuratorDataProvider__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_Configuration_ConfigurationManager_HandleCuratorCompleteEvent__
		             ,0);
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 200);
		        goto code_r0x81274f8f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,
		                                Core_Application_Managers_Configuration_Curator_ICuratorDataProvider_TypeInfo
		                                ,1);
		code_r0x81274f8f:
		  (**(code **)((ulonglong)*puVar2 * 4))(param2,param1_00,puVar2[1]);
		  iVar3 = *(int *)(param1 + 8);
		  if (iVar3 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),param1,*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006E47 RID: 28231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E47")]
		[Address(RVA = "0xB8F2", Offset = "0xB8F2", VA = "0xB8F2")]
		private void HandleCuratorCompleteEvent(ICuratorDataProvider provider)
		{
		/* --- GHIDRA: HandleCuratorCompleteEvent ---
		void Core_Gameplay_Managers_Configuration_ConfigurationManager__HandleCuratorCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  int param2_00;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5a7e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_BaseEventBusEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    DAT_ram_00a5a7e9 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x14);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x100);
		        goto code_r0x81275058;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Application_IApp_TypeInfo,8);
		code_r0x81275058:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar4 = *(int *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x1c) + 0x10);
		  if (iVar4 != 0) {
		    if (DAT_ram_00a5a7ed == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Application_App_TypeInfo);
		      DAT_ram_00a5a7ed = '\x01';
		    }
		    param2_00 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    if (param2_00 == 0) {
		      uVar3 = unnamed_function_1417(Core_Application_App_TypeInfo);
		      Core_Application_App__set_FileDownloadLogger(uVar3,iVar4);
		      **(undefined4 **)(Core_Application_App_TypeInfo + 0x5c) = uVar3;
		      param2_00 = **(int **)(Core_Application_App_TypeInfo + 0x5c);
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    uVar3 = unnamed_function_1417(Core_Events_BaseEventBusEventArgs_TypeInfo);
		    Core_Application_Managers_Connection_ServerConnectionDelay__ResetAll
		              (uVar3,param2_00,param3_00,0);
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),uVar3,*(undefined4 *)(iVar4 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006E48 RID: 28232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E48")]
		[Address(RVA = "0xB8F3", Offset = "0xB8F3", VA = "0xB8F3")]
		private void HandleForAnalyticCuratorCompleteEvent(ICuratorDataProvider obj)
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_Configuration_ConfigurationManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a7e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a7e1 = '\x01';
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
		void Core_Gameplay_Managers_Configuration_ConfigurationManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a7e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a7e2 = '\x01';
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
		void Core_Gameplay_Managers_Configuration_ConfigurationManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a7e3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a7e3 = '\x01';
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
		void Core_Gameplay_Managers_Configuration_ConfigurationManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a7e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a7e4 = '\x01';
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

}
