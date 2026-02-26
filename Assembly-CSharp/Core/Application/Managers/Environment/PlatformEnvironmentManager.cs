using System;
using System.Runtime.CompilerServices;
using Gameplay.Billing.BillingProvider.UnityIAP;
using Il2CppDummyDll;

namespace Core.Application.Managers.Environment
{
	// Token: 0x02001262 RID: 4706
	[Token(Token = "0x2001262")]
	public class PlatformEnvironmentManager : IAppManager, IBaseManager, IDisposable, IEnvironment
	{
		// Token: 0x140002F3 RID: 755
		// (add) Token: 0x06006F85 RID: 28549 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F86 RID: 28550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002F3")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006F85")]
			[Address(RVA = "0xB9E7", Offset = "0xB9E7", VA = "0xB9E7", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F86")]
			[Address(RVA = "0xB9E8", Offset = "0xB9E8", VA = "0xB9E8", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002F4 RID: 756
		// (add) Token: 0x06006F87 RID: 28551 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F88 RID: 28552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002F4")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006F87")]
			[Address(RVA = "0xB9E9", Offset = "0xB9E9", VA = "0xB9E9", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F88")]
			[Address(RVA = "0xB9EA", Offset = "0xB9EA", VA = "0xB9EA", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006F89 RID: 28553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F89")]
		[Address(RVA = "0xB9EB", Offset = "0xB9EB", VA = "0xB9EB")]
		public PlatformEnvironmentManager(IApp app)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Application_Managers_Environment_PlatformEnvironmentManager___ctor
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a85b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_IBaseManager_TypeInfo);
		    DAT_ram_00a5a85b = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		        goto code_r0x8127fb03;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_IBaseManager_TypeInfo,4);
		code_r0x8127fb03:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06006F8A RID: 28554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F8A")]
		[Address(RVA = "0xB9EC", Offset = "0xB9EC", VA = "0xB9EC", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Application_Managers_Environment_PlatformEnvironmentManager__Init
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a85c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_IBaseManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Environment_PlatformEnvironmentManager_ImplementationOnInitCompleteEvent__
		              );
		    DAT_ram_00a5a85c = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Action_IBaseManager__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Core_Application_Managers_Environment_PlatformEnvironmentManager_ImplementationOnInitCompleteEvent__
		             ,0);
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 200);
		        goto code_r0x8127fbd6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_IBaseManager_TypeInfo,1);
		code_r0x8127fbd6:
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

		// Token: 0x06006F8B RID: 28555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F8B")]
		[Address(RVA = "0xB9ED", Offset = "0xB9ED", VA = "0xB9ED")]
		private void ImplementationOnInitCompleteEvent(IBaseManager manager)
		{
		/* --- GHIDRA: ImplementationOnInitCompleteEvent ---
		void Core_Application_Managers_Environment_PlatformEnvironmentManager__ImplementationOnInitCompleteEvent
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a85d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_IBaseManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Environment_PlatformEnvironmentManager_ImplementationOnDeinitCompleteEvent__
		              );
		    DAT_ram_00a5a85d = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Action_IBaseManager__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Core_Application_Managers_Environment_PlatformEnvironmentManager_ImplementationOnDeinitCompleteEvent__
		             ,0);
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd8);
		        goto code_r0x8127fcc3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_IBaseManager_TypeInfo,3);
		code_r0x8127fcc3:
		  (**(code **)((ulonglong)*puVar2 * 4))(param2,param1_00,puVar2[1]);
		  iVar3 = *(int *)(param1 + 0xc);
		  if (iVar3 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),param1,*(undefined4 *)(iVar3 + 0x14));
		  }
		  Core_Application_Managers_Environment_PlatformEnvironmentManager__get_Name(param1,iVar3);
		  return;
		}
		*/

		}

		// Token: 0x06006F8C RID: 28556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F8C")]
		[Address(RVA = "0xB9EE", Offset = "0xB9EE", VA = "0xB9EE")]
		private void ImplementationOnDeinitCompleteEvent(IBaseManager manager)
		{
		/* --- GHIDRA: ImplementationOnDeinitCompleteEvent ---
		void Core_Application_Managers_Environment_PlatformEnvironmentManager__ImplementationOnDeinitCompleteEvent
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a85e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_IBaseManager_TypeInfo);
		    DAT_ram_00a5a85e = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe8);
		        goto code_r0x8127ff13;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_IBaseManager_TypeInfo,5);
		code_r0x8127ff13:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06006F8D RID: 28557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F8D")]
		[Address(RVA = "0xB9EF", Offset = "0xB9EF", VA = "0xB9EF", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		undefined4
		Core_Application_Managers_Environment_PlatformEnvironmentManager__Deinit
		          (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a5a85f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_IBaseManager_TypeInfo);
		    DAT_ram_00a5a85f = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xf0);
		        goto code_r0x8127ffba;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_IBaseManager_TypeInfo,6);
		code_r0x8127ffba:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/

		}

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x06006F8E RID: 28558 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016C3")]
		public string Name
		{
			[Token(Token = "0x6006F8E")]
			[Address(RVA = "0xB9F0", Offset = "0xB9F0", VA = "0xB9F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006F8F RID: 28559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F8F")]
		[Address(RVA = "0xB9F1", Offset = "0xB9F1", VA = "0xB9F1", Slot = "11")]
		public void Dispose()
		{
		}

		// Token: 0x06006F90 RID: 28560 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006F90")]
		public T GetUiapWrapper<T>() where T : class, IUiapWrapper, new()
		{
			return null;
		}

		// Token: 0x04003A43 RID: 14915
		[Token(Token = "0x4003A43")]
		[FieldOffset(Offset = "0x10")]
		private IAppManager _implementation;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Application_Managers_Environment_PlatformEnvironmentManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a857 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a857 = '\x01';
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
		void Core_Application_Managers_Environment_PlatformEnvironmentManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a858 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a858 = '\x01';
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
		void Core_Application_Managers_Environment_PlatformEnvironmentManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a859 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a859 = '\x01';
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
		void Core_Application_Managers_Environment_PlatformEnvironmentManager__remove_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a85a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_IBaseManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Platforms_WebGL_PlatformEnvironmentManagerImplementation_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Environment_PlatformEnvironmentManager_ImplementationOnDeinitCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Environment_PlatformEnvironmentManager_ImplementationOnInitCompleteEvent__
		              );
		    DAT_ram_00a5a85a = '\x01';
		  }
		  piVar2 = (int *)unnamed_function_1417
		                            (Platforms_WebGL_PlatformEnvironmentManagerImplementation_TypeInfo);
		  *(int **)(param1 + 0x10) = piVar2;
		  uVar3 = unnamed_function_1417(System_Action_IBaseManager__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Core_Application_Managers_Environment_PlatformEnvironmentManager_ImplementationOnInitCompleteEvent__
		             ,0);
		  iVar5 = *piVar2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8127835f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar2,Core_IBaseManager_TypeInfo,0);
		code_r0x8127835f:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar2,uVar3,puVar4[1]);
		  piVar2 = *(int **)(param1 + 0x10);
		  uVar1 = 0;
		  uVar3 = unnamed_function_1417(System_Action_IBaseManager__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Core_Application_Managers_Environment_PlatformEnvironmentManager_ImplementationOnDeinitCompleteEvent__
		             ,0);
		  iVar5 = *piVar2;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x81278401;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar2,Core_IBaseManager_TypeInfo,2);
		code_r0x81278401:
		  (**(code **)((ulonglong)*puVar4 * 4))(piVar2,uVar3,puVar4[1]);
		  return;
		}
		*/


		/* --- GHIDRA: get_Name ---
		void Core_Application_Managers_Environment_PlatformEnvironmentManager__get_Name
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a860 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_IBaseManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Environment_PlatformEnvironmentManager_ImplementationOnDeinitCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Application_Managers_Environment_PlatformEnvironmentManager_ImplementationOnInitCompleteEvent__
		              );
		    DAT_ram_00a5a860 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_IBaseManager__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Application_Managers_Environment_PlatformEnvironmentManager_ImplementationOnInitCompleteEvent__
		             ,0);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x8127fdc7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_IBaseManager_TypeInfo,1);
		code_r0x8127fdc7:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,uVar2,puVar3[1]);
		  piVar4 = *(int **)(param1 + 0x10);
		  uVar1 = 0;
		  uVar2 = unnamed_function_1417(System_Action_IBaseManager__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Application_Managers_Environment_PlatformEnvironmentManager_ImplementationOnDeinitCompleteEvent__
		             ,0);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_IBaseManager_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		        goto code_r0x8127fe69;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_IBaseManager_TypeInfo,3);
		code_r0x8127fe69:
		  (**(code **)((ulonglong)*puVar3 * 4))(piVar4,uVar2,puVar3[1]);
		  *(undefined4 *)(param1 + 0x10) = 0;
		  return;
		}
		*/


		/* --- GHIDRA: GetUiapWrapper<object> ---
		undefined4
		Core_Application_Managers_Environment_PlatformEnvironmentManager__GetUiapWrapper_object_
		          (int param1,int param2)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  int param1_01;
		  
		  if (*(int *)(param2 + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(param2);
		  }
		  param1_00 = *(int *)(param1 + 8);
		  if (param1_00 == 0) {
		    param1_00 = System_Delegate__Combine(**(undefined4 **)(param2 + 0x1c));
		    *(int *)(param1 + 8) = param1_00;
		  }
		  param1_01 = *(int *)(*(int *)(param2 + 0x1c) + 4);
		  if ((*(byte *)(param1_01 + 0xbd) & 1) == 0) {
		    param1_01 = func_ii_1079(param1_01);
		  }
		  uVar1 = func_ii_1082(param1_00,param1_01);
		  return uVar1;
		}
		*/

}
