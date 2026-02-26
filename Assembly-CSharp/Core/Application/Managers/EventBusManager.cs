using System;
using System.Runtime.CompilerServices;
using Core.Events;
using Il2CppDummyDll;

namespace Core.Application.Managers
{
	// Token: 0x02001250 RID: 4688
	[Token(Token = "0x2001250")]
	public class EventBusManager : IAppManager, IBaseManager
	{
		// Token: 0x140002E9 RID: 745
		// (add) Token: 0x06006F18 RID: 28440 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F19 RID: 28441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002E9")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006F18")]
			[Address(RVA = "0xB993", Offset = "0xB993", VA = "0xB993", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F19")]
			[Address(RVA = "0xB994", Offset = "0xB994", VA = "0xB994", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002EA RID: 746
		// (add) Token: 0x06006F1A RID: 28442 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F1B RID: 28443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002EA")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006F1A")]
			[Address(RVA = "0xB995", Offset = "0xB995", VA = "0xB995", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F1B")]
			[Address(RVA = "0xB996", Offset = "0xB996", VA = "0xB996", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x06006F1C RID: 28444 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006F1D RID: 28445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016B0")]
		public EventBus EventBus
		{
			[Token(Token = "0x6006F1C")]
			[Address(RVA = "0xB997", Offset = "0xB997", VA = "0xB997")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F1D")]
			[Address(RVA = "0xB998", Offset = "0xB998", VA = "0xB998")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006F1E RID: 28446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F1E")]
		[Address(RVA = "0xB999", Offset = "0xB999", VA = "0xB999", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Application_Managers_EventBusManager__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(int *)(param1 + 0x10) != 0) {
		    Core_Events_EventBus__InitAllScopes(*(int *)(param1 + 0x10),0);
		  }
		  *(undefined4 *)(param1 + 0x10) = 0;
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006F1F RID: 28447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F1F")]
		[Address(RVA = "0xB99A", Offset = "0xB99A", VA = "0xB99A", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		undefined4 Core_Application_Managers_EventBusManager__Deinit(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a828 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_7516);
		    DAT_ram_00a5a828 = '\x01';
		  }
		  return StringLiteral_7516;
		}
		*/

		}

		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x06006F20 RID: 28448 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016B1")]
		public string Name
		{
			[Token(Token = "0x6006F20")]
			[Address(RVA = "0xB99B", Offset = "0xB99B", VA = "0xB99B", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006F21 RID: 28449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F21")]
		[Address(RVA = "0xB99C", Offset = "0xB99C", VA = "0xB99C")]
		public EventBusManager()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Application_Managers_EventBusManager___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a829 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_8048);
		    DAT_ram_00a5a829 = '\x01';
		  }
		  return StringLiteral_8048;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Application_Managers_EventBusManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a824 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a824 = '\x01';
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
		void Core_Application_Managers_EventBusManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a825 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a825 = '\x01';
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
		void Core_Application_Managers_EventBusManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a826 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a826 = '\x01';
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


		/* --- GHIDRA: set_EventBus ---
		void Core_Application_Managers_EventBusManager__set_EventBus(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5a827 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_EventBus_TypeInfo);
		    DAT_ram_00a5a827 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Core_Events_EventBus_TypeInfo);
		  Core_Events_EventBus__set_PortalsScope(param1_00,0);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  iVar1 = *(int *)(param1 + 8);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}
