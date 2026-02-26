using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UI.Price;
using UnityEngine;

namespace Gameplay.Medals.View
{
	// Token: 0x020005F5 RID: 1525
	[Token(Token = "0x20005F5")]
	public class MedalGroupView : MonoBehaviour
	{
		// Token: 0x1400014C RID: 332
		// (add) Token: 0x060024EE RID: 9454 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060024EF RID: 9455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400014C")]
		private event Action<MedalView> ClickCallback
		{
			[Token(Token = "0x60024EE")]
			[Address(RVA = "0x7639", Offset = "0x7639", VA = "0x7639")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60024EF")]
			[Address(RVA = "0x763A", Offset = "0x763A", VA = "0x763A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060024F0 RID: 9456 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060024F1 RID: 9457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006E1")]
		public MedalData MedalData
		{
			[Token(Token = "0x60024F0")]
			[Address(RVA = "0x763B", Offset = "0x763B", VA = "0x763B")]
			get
			{
				return null;
			}
			[Token(Token = "0x60024F1")]
			[Address(RVA = "0x763C", Offset = "0x763C", VA = "0x763C")]
			set
			{
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (set) Token: 0x060024F2 RID: 9458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006E2")]
		public bool SaleEnabled
		{
			[Token(Token = "0x60024F2")]
			[Address(RVA = "0x763D", Offset = "0x763D", VA = "0x763D")]
			set
			{
			}
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F3")]
		[Address(RVA = "0x763E", Offset = "0x763E", VA = "0x763E")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Medals_View_MedalGroupView__Awake(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a57d7f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MedalView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_View_MedalGroupView_MedalViewOnClickEvent__);
		    DAT_ram_00a57d7f = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x10);
		  param1_01 = unnamed_function_1417(System_Action_MedalView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,Method_Gameplay_Medals_View_MedalGroupView_MedalViewOnClickEvent__,0);
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

		// Token: 0x060024F4 RID: 9460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F4")]
		[Address(RVA = "0x763F", Offset = "0x763F", VA = "0x763F")]
		private void OnDestroy()
		{
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F5")]
		[Address(RVA = "0x7640", Offset = "0x7640", VA = "0x7640")]
		private void MedalViewOnClickEvent(MedalView medalView)
		{
		/* --- GHIDRA: MedalViewOnClickEvent ---
		void Gameplay_Medals_View_MedalGroupView__MedalViewOnClickEvent
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  *(undefined4 *)(param1 + 0x1c) = param3;
		  *(undefined4 *)(param1 + 0x18) = param2;
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)(*(int *)(param1 + 0x18) == *(int *)(param1 + 0x1c)),0);
		  return;
		}
		*/

		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F6")]
		[Address(RVA = "0x7641", Offset = "0x7641", VA = "0x7641")]
		public void SetUsers(UserData user, UserData loggedUser)
		{
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F7")]
		[Address(RVA = "0x7642", Offset = "0x7642", VA = "0x7642")]
		public void SetCallback(Action<MedalView> clickCallback)
		{
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024F8")]
		[Address(RVA = "0x7643", Offset = "0x7643", VA = "0x7643")]
		public MedalGroupView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Medals_View_MedalGroupView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57d80 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12651);
		    DAT_ram_00a57d80 = '\x01';
		  }
		  return StringLiteral_12651;
		}
		*/

		}

		// Token: 0x04001429 RID: 5161
		[Token(Token = "0x4001429")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected MedalView _medalView;

		// Token: 0x0400142A RID: 5162
		[Token(Token = "0x400142A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected Price _price;

		// Token: 0x0400142B RID: 5163
		[Token(Token = "0x400142B")]
		[FieldOffset(Offset = "0x18")]
		private UserData _userData;

		// Token: 0x0400142C RID: 5164
		[Token(Token = "0x400142C")]
		[FieldOffset(Offset = "0x1C")]
		private UserData _loggedUserData;

		// Token: 0x0400142E RID: 5166
		[Token(Token = "0x400142E")]
		[FieldOffset(Offset = "0x24")]
		private MedalData _medalData;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickCallback ---
		void Gameplay_Medals_View_MedalGroupView__add_ClickCallback
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57d7c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MedalView__TypeInfo);
		    DAT_ram_00a57d7c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_MedalView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MedalView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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


		/* --- GHIDRA: get_MedalData ---
		void Gameplay_Medals_View_MedalGroupView__get_MedalData(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  float param2_01;
		  undefined4 param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a57d7d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a57d7d = '\x01';
		  }
		  *(int *)(param1 + 0x24) = param2;
		  piVar2 = *(int **)(param1 + 0x10);
		  if (*(int *)(param2 + 0x10) == 0) {
		    uVar1 = func_ii_8766(param2,0);
		  }
		  else {
		    uVar1 = Core_Data_MedalData__ValidateState(param2,0);
		  }
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x138) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x13c));
		  uVar1 = 0;
		  piVar2 = *(int **)(param1 + 0x10);
		  iVar3 = *(int *)(*(int *)(param1 + 0x24) + 0x10);
		  *(bool *)(piVar2 + 0x14) = iVar3 != 0;
		  param2_01 = 0.0;
		  if (iVar3 == 0) {
		    param2_01 = 1.0;
		  }
		  Core_Data_MedalData__IsMedalAchieved(piVar2[9],param2_01,0);
		  Core_Data_MedalData__IsMedalAchieved(piVar2[10],param2_01,0);
		  Core_Data_MedalData__IsMedalAchieved(piVar2[0xb],param2_01,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x130) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0x134));
		  if (iVar3 != 0) {
		    UI_RawImageWithGrayscale__SetGrayscale(piVar2,param1);
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x24);
		  *(undefined4 *)(*(int *)(param1 + 0x10) + 0x48) = param1_01;
		  param2_00 = *(undefined4 *)(param1 + 0x18);
		  param1_00 = *(undefined4 *)(param1 + 0x14);
		  iVar3 = Core_Data_MedalData__get_CurrentMedal(param1_01,0);
		  if (iVar3 != 0) {
		    uVar1 = *(undefined4 *)(*(int *)(iVar3 + 0x10) + 0x24);
		  }
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar1 = Core_Money_Money__op_Explicit(uVar1,0);
		  UI_Price_Price__SetColor(param1_00,param2_00,uVar1,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_MedalData ---
		void Gameplay_Medals_View_MedalGroupView__set_MedalData
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x3c),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_SaleEnabled ---
		void Gameplay_Medals_View_MedalGroupView__set_SaleEnabled(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a57d7e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MedalView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_View_MedalGroupView_MedalViewOnClickEvent__);
		    DAT_ram_00a57d7e = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x10);
		  param1_01 = unnamed_function_1417(System_Action_MedalView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,Method_Gameplay_Medals_View_MedalGroupView_MedalViewOnClickEvent__,0);
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

}
