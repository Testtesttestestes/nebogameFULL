using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Combat;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001160 RID: 4448
	[Token(Token = "0x2001160")]
	public class CombatManager : ICombatManager, IGameManager, IBaseManager
	{
		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x060068B2 RID: 26802 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700156C")]
		public string Name
		{
			[Token(Token = "0x60068B2")]
			[Address(RVA = "0xB3D8", Offset = "0xB3D8", VA = "0xB3D8", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000277 RID: 631
		// (add) Token: 0x060068B3 RID: 26803 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060068B4 RID: 26804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000277")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60068B3")]
			[Address(RVA = "0xB3D9", Offset = "0xB3D9", VA = "0xB3D9", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60068B4")]
			[Address(RVA = "0xB3DA", Offset = "0xB3DA", VA = "0xB3DA", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000278 RID: 632
		// (add) Token: 0x060068B5 RID: 26805 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060068B6 RID: 26806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000278")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60068B5")]
			[Address(RVA = "0xB3DB", Offset = "0xB3DB", VA = "0xB3DB", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60068B6")]
			[Address(RVA = "0xB3DC", Offset = "0xB3DC", VA = "0xB3DC", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060068B7 RID: 26807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068B7")]
		[Address(RVA = "0xB3DD", Offset = "0xB3DD", VA = "0xB3DD", Slot = "12")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_CombatManager__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a63797 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ICombat___);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_LinkedList_ICombat__Clear__);
		    DAT_ram_00a63797 = '\x01';
		  }
		  iVar2 = func_ii_6295(*(undefined4 *)(param1 + 0x10),
		                       Method_System_Linq_Enumerable_ToArray_ICombat___);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      Core_Gameplay_Managers_CombatManager__TryRemove
		                (iVar1,*(undefined4 *)(iVar2 + iVar1 * 4 + 0x10),iVar1);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  System_Collections_Generic_LinkedList_UIRenderDevice_DeviceToFree___AddLast
		            (*(undefined4 *)(param1 + 0x10),
		             Method_System_Collections_Generic_LinkedList_ICombat__Clear__);
		  iVar1 = *(int *)(param1 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060068B8 RID: 26808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068B8")]
		[Address(RVA = "0xB3DE", Offset = "0xB3DE", VA = "0xB3DE", Slot = "13")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		undefined4 Core_Gameplay_Managers_CombatManager__Deinit(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63798 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_LastOrDefault_ICombat___);
		    DAT_ram_00a63798 = '\x01';
		  }
		  uVar1 = System_Linq_Enumerable__FirstOrDefault_object_
		                    (*(undefined4 *)(param1 + 0x10),
		                     Method_System_Linq_Enumerable_LastOrDefault_ICombat___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x060068B9 RID: 26809 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700156D")]
		public ICombat CurrentCombat
		{
			[Token(Token = "0x60068B9")]
			[Address(RVA = "0xB3DF", Offset = "0xB3DF", VA = "0xB3DF", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060068BA RID: 26810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068BA")]
		[Address(RVA = "0xB3E0", Offset = "0xB3E0", VA = "0xB3E0", Slot = "5")]
		public void Add(ICombat combat)
		{
		/* --- GHIDRA: Add ---
		undefined4 Core_Gameplay_Managers_CombatManager__Add(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6379a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_LinkedList_ICombat__Remove__);
		    DAT_ram_00a6379a = '\x01';
		  }
		  uVar1 = System_Net_WebConnection__StartOperation
		                    (*(undefined4 *)(param1 + 0x10),param2,
		                     Method_System_Collections_Generic_LinkedList_ICombat__Remove__);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060068BB RID: 26811 RVA: 0x00013920 File Offset: 0x00011B20
		[Token(Token = "0x60068BB")]
		[Address(RVA = "0xB3E1", Offset = "0xB3E1", VA = "0xB3E1", Slot = "6")]
		public bool TryRemove(ICombat combat)
		{
		/* --- GHIDRA: TryRemove ---
		void Core_Gameplay_Managers_CombatManager__TryRemove
		               (undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a6379b == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_ICombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    DAT_ram_00a6379b = '\x01';
		  }
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x822fd731;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Combat_ICombat_TypeInfo,0);
		code_r0x822fd731:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if (iVar3 != 0) {
		    uVar1 = 0;
		    iVar3 = *param2;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Combat_ICombat_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd8);
		          goto code_r0x822fd7af;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Gameplay_Combat_ICombat_TypeInfo,3);
		code_r0x822fd7af:
		    (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  }
		  uVar1 = 0;
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x822fd82c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,System_IDisposable_TypeInfo,0);
		code_r0x822fd82c:
		  (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060068BC RID: 26812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068BC")]
		[Address(RVA = "0xB3E2", Offset = "0xB3E2", VA = "0xB3E2")]
		public void StopCombat(ICombat combat)
		{
		/* --- GHIDRA: StopCombat ---
		void Core_Gameplay_Managers_CombatManager__StopCombat(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a63798 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_LastOrDefault_ICombat___);
		    DAT_ram_00a63798 = '\x01';
		  }
		  iVar1 = System_Linq_Enumerable__FirstOrDefault_object_
		                    (*(undefined4 *)(param1 + 0x10),
		                     Method_System_Linq_Enumerable_LastOrDefault_ICombat___);
		  if (iVar1 != 0) {
		    if (DAT_ram_00a63798 == '\0') {
		      Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_LastOrDefault_ICombat___);
		      DAT_ram_00a63798 = '\x01';
		    }
		    uVar2 = System_Linq_Enumerable__FirstOrDefault_object_
		                      (*(undefined4 *)(param1 + 0x10),
		                       Method_System_Linq_Enumerable_LastOrDefault_ICombat___);
		    Core_Gameplay_Managers_CombatManager__TryRemove(param1,uVar2,param1);
		    return;
		  }
		  uVar2 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar2 = unnamed_function_1417(uVar2);
		  uVar3 = unnamed_function_2232(&StringLiteral_6021);
		  System_String__Concat(uVar2,uVar3,0);
		  uVar3 = unnamed_function_2232(&Method_Core_Gameplay_Managers_CombatManager_StopCurrentCombat__);
		  func_ii_1050(uVar2,uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060068BD RID: 26813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068BD")]
		[Address(RVA = "0xB3E3", Offset = "0xB3E3", VA = "0xB3E3", Slot = "7")]
		public void StopCurrentCombat()
		{
		/* --- GHIDRA: StopCurrentCombat ---
		void Core_Gameplay_Managers_CombatManager__StopCurrentCombat(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6379c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_LinkedList_ICombat___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_LinkedList_ICombat__TypeInfo);
		    DAT_ram_00a6379c = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_LinkedList_ICombat__TypeInfo);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x060068BE RID: 26814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068BE")]
		[Address(RVA = "0xB3E4", Offset = "0xB3E4", VA = "0xB3E4")]
		public CombatManager()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Core_Gameplay_Managers_CombatManager___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a6379d == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5626);
		    DAT_ram_00a6379d = '\x01';
		  }
		  return StringLiteral_5626;
		}
		*/

		}

		// Token: 0x040037A7 RID: 14247
		[Token(Token = "0x40037A7")]
		[FieldOffset(Offset = "0x10")]
		public readonly LinkedList<ICombat> Combats;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_CombatManager__get_Name(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63793 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63793 = '\x01';
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
		void Core_Gameplay_Managers_CombatManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63794 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63794 = '\x01';
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
		void Core_Gameplay_Managers_CombatManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63795 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63795 = '\x01';
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
		void Core_Gameplay_Managers_CombatManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63796 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63796 = '\x01';
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


		/* --- GHIDRA: get_CurrentCombat ---
		void Core_Gameplay_Managers_CombatManager__get_CurrentCombat
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a63799 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_LinkedList_ICombat__AddLast__);
		    DAT_ram_00a63799 = '\x01';
		  }
		  System_Collections_Generic_LinkedList_object____ctor
		            (*(undefined4 *)(param1 + 0x10),param2,
		             Method_System_Collections_Generic_LinkedList_ICombat__AddLast__);
		  return;
		}
		*/

}
