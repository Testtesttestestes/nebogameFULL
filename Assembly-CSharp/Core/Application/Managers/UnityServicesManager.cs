using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Application.Managers
{
	// Token: 0x0200125F RID: 4703
	[Token(Token = "0x200125F")]
	public class UnityServicesManager : IAppManager, IBaseManager
	{
		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x06006F7A RID: 28538 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016C2")]
		public string Name
		{
			[Token(Token = "0x6006F7A")]
			[Address(RVA = "0xB9DE", Offset = "0xB9DE", VA = "0xB9DE", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002F1 RID: 753
		// (add) Token: 0x06006F7B RID: 28539 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F7C RID: 28540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002F1")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006F7B")]
			[Address(RVA = "0xB9DF", Offset = "0xB9DF", VA = "0xB9DF", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F7C")]
			[Address(RVA = "0xB9E0", Offset = "0xB9E0", VA = "0xB9E0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002F2 RID: 754
		// (add) Token: 0x06006F7D RID: 28541 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F7E RID: 28542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002F2")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006F7D")]
			[Address(RVA = "0xB9E1", Offset = "0xB9E1", VA = "0xB9E1", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F7E")]
			[Address(RVA = "0xB9E2", Offset = "0xB9E2", VA = "0xB9E2", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006F7F RID: 28543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F7F")]
		[Address(RVA = "0xB9E3", Offset = "0xB9E3", VA = "0xB9E3", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Application_Managers_UnityServicesManager__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06006F80 RID: 28544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F80")]
		[Address(RVA = "0xB9E4", Offset = "0xB9E4", VA = "0xB9E4", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006F81 RID: 28545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F81")]
		[Address(RVA = "0xB9E5", Offset = "0xB9E5", VA = "0xB9E5")]
		public UnityServicesManager()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Application_Managers_UnityServicesManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a850 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a850 = '\x01';
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
		void Core_Application_Managers_UnityServicesManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a851 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a851 = '\x01';
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
		void Core_Application_Managers_UnityServicesManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a852 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a852 = '\x01';
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
		void Core_Application_Managers_UnityServicesManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a853 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a853 = '\x01';
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
		void Core_Application_Managers_UnityServicesManager__remove_DeinitCompleteEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined8 local_1c;
		  undefined8 local_14;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a854 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_UnityServicesManager__Init_d__8___
		              );
		    DAT_ram_00a5a854 = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_30,0);
		  local_14 = local_28;
		  local_20 = 0xffffffff;
		  local_1c = local_30;
		  local_c = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_UnityServicesInitializer__EnableServicesInitializationAsync_d__1_
		            (&local_1c,&local_20,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_UnityServicesManager__Init_d__8___
		            );
		  return;
		}
		*/

}
