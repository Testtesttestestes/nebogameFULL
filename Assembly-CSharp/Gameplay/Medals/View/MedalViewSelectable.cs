using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Medals.View
{
	// Token: 0x020005F9 RID: 1529
	[Token(Token = "0x20005F9")]
	public class MedalViewSelectable : MonoBehaviour
	{
		// Token: 0x1400014E RID: 334
		// (add) Token: 0x06002522 RID: 9506 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002523 RID: 9507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400014E")]
		public event Action<MedalViewSelectable> SelectEvent
		{
			[Token(Token = "0x6002522")]
			[Address(RVA = "0x766B", Offset = "0x766B", VA = "0x766B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002523")]
			[Address(RVA = "0x766C", Offset = "0x766C", VA = "0x766C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002524")]
		[Address(RVA = "0x766D", Offset = "0x766D", VA = "0x766D")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Medals_View_MedalViewSelectable__Awake(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a57d95 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MedalView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_View_MedalViewSelectable_MedalViewOnClickEvent__);
		    DAT_ram_00a57d95 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x10);
		  param1_01 = unnamed_function_1417(System_Action_MedalView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Medals_View_MedalViewSelectable_MedalViewOnClickEvent__,0);
		  if (DAT_ram_00a57d8c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MedalView__TypeInfo);
		    DAT_ram_00a57d8c = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x4c);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = func_ii_7048(param1_00,param1_01,0);
		    param2_00 = System_Action_MedalView__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_Action_MedalView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar3 + 0x4c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002525 RID: 9509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002525")]
		[Address(RVA = "0x766E", Offset = "0x766E", VA = "0x766E")]
		private void OnDestroy()
		{
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06002526 RID: 9510 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006F6")]
		public MedalView MedalView
		{
			[Token(Token = "0x6002526")]
			[Address(RVA = "0x766F", Offset = "0x766F", VA = "0x766F")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002527")]
		[Address(RVA = "0x7670", Offset = "0x7670", VA = "0x7670")]
		private void MedalViewOnClickEvent(MedalView obj)
		{
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06002528 RID: 9512 RVA: 0x00007110 File Offset: 0x00005310
		// (set) Token: 0x06002529 RID: 9513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F7")]
		public bool IsSelected
		{
			[Token(Token = "0x6002528")]
			[Address(RVA = "0x7671", Offset = "0x7671", VA = "0x7671")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002529")]
			[Address(RVA = "0x7672", Offset = "0x7672", VA = "0x7672")]
			set
			{
			}
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600252A")]
		[Address(RVA = "0x7673", Offset = "0x7673", VA = "0x7673")]
		public MedalViewSelectable()
		{
		}

		// Token: 0x0400144F RID: 5199
		[Token(Token = "0x400144F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private MedalView _medalView;

		// Token: 0x04001450 RID: 5200
		[Token(Token = "0x4001450")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _selectorView;

		// Token: 0x04001451 RID: 5201
		[Token(Token = "0x4001451")]
		[FieldOffset(Offset = "0x18")]
		private bool _isSelected;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_SelectEvent ---
		void Gameplay_Medals_View_MedalViewSelectable__add_SelectEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57d93 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MedalViewSelectable__TypeInfo);
		    DAT_ram_00a57d93 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_MedalViewSelectable__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MedalViewSelectable__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
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


		/* --- GHIDRA: remove_SelectEvent ---
		void Gameplay_Medals_View_MedalViewSelectable__remove_SelectEvent(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a57d94 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MedalView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_View_MedalViewSelectable_MedalViewOnClickEvent__);
		    DAT_ram_00a57d94 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x10);
		  param1_01 = unnamed_function_1417(System_Action_MedalView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Medals_View_MedalViewSelectable_MedalViewOnClickEvent__,0);
		  if (DAT_ram_00a57d8b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MedalView__TypeInfo);
		    DAT_ram_00a57d8b = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x4c);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = UnityEngine_UI_Image__set_sprite(param1_00,param1_01,0);
		    param2_00 = System_Action_MedalView__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_Action_MedalView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar3 + 0x4c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      *(undefined4 *)(*(int *)(param1 + 0x10) + 0x40) = 1;
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_MedalView ---
		void Gameplay_Medals_View_MedalViewSelectable__get_MedalView
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if ((*(char *)(param1 + 0x18) == '\0') && (iVar1 = *(int *)(param1 + 0x1c), iVar1 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_IsSelected ---
		void Gameplay_Medals_View_MedalViewSelectable__get_IsSelected
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  *(undefined1 *)(param1 + 0x18) = (undefined1)param2;
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)*(byte *)(param1 + 0x18),0);
		  return;
		}
		*/

}
