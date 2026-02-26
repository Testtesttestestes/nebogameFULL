using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Balance;
using Gameplay.Clans.Office.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI;
using UI.Elements.Buttons;
using UnityEngine;

namespace Gameplay.Clans.Office.View.SquadTab
{
	// Token: 0x02000A10 RID: 2576
	[Token(Token = "0x2000A10")]
	public class SquadListElement : MonoBehaviourWithStates<SquadListElement.State>
	{
		// Token: 0x14000193 RID: 403
		// (add) Token: 0x06003D35 RID: 15669 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003D36 RID: 15670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000193")]
		public event Action<MemberSlotView, SquadListElement> JoinButtonClickedEvent
		{
			[Token(Token = "0x6003D35")]
			[Address(RVA = "0x8BF5", Offset = "0x8BF5", VA = "0x8BF5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003D36")]
			[Address(RVA = "0x8BF6", Offset = "0x8BF6", VA = "0x8BF6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000194 RID: 404
		// (add) Token: 0x06003D37 RID: 15671 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003D38 RID: 15672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000194")]
		public event Action<MemberSlotView, SquadListElement> CrossButtonClickedEvent
		{
			[Token(Token = "0x6003D37")]
			[Address(RVA = "0x8BF7", Offset = "0x8BF7", VA = "0x8BF7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003D38")]
			[Address(RVA = "0x8BF8", Offset = "0x8BF8", VA = "0x8BF8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06003D39 RID: 15673 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C1B")]
		public ButtonWithCost RentButton
		{
			[Token(Token = "0x6003D39")]
			[Address(RVA = "0x8BF9", Offset = "0x8BF9", VA = "0x8BF9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06003D3A RID: 15674 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003D3B RID: 15675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C1C")]
		public SquadModel.PartyData PartyData
		{
			[Token(Token = "0x6003D3A")]
			[Address(RVA = "0x8BFA", Offset = "0x8BFA", VA = "0x8BFA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D3B")]
			[Address(RVA = "0x8BFB", Offset = "0x8BFB", VA = "0x8BFB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06003D3C RID: 15676 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003D3D RID: 15677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C1D")]
		public ColossusPartiesInfoDic Dic
		{
			[Token(Token = "0x6003D3C")]
			[Address(RVA = "0x8BFC", Offset = "0x8BFC", VA = "0x8BFC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D3D")]
			[Address(RVA = "0x8BFD", Offset = "0x8BFD", VA = "0x8BFD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003D3E RID: 15678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D3E")]
		[Address(RVA = "0x8BFE", Offset = "0x8BFE", VA = "0x8BFE")]
		public void Init(ColossusPartiesInfoDic dic, IList<ColossusSlotsInfoDic> slots, IBalanceSource treasury)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Office_View_SquadTab_SquadListElement__Init
		               (int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param2_01;
		  int param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57f33 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SquadModel_ColossusPartySlot__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SquadModel_ColossusPartySlot__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_SquadListElement_State__set_CurrentState__);
		    DAT_ram_00a57f33 = '\x01';
		  }
		  *(int *)(param1 + 0x3c) = param2;
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,1,Method_UI_MonoBehaviourWithStates_SquadListElement_State__set_CurrentState__);
		  param1_00 = *(int *)(param2 + 0xc);
		  if (0 < *(int *)(param1_00 + 0xc)) {
		    param2_00 = 0;
		    do {
		      param1_01 = *(undefined4 *)(*(int *)(param1 + 0x30) + param2_00 * 4 + 0x10);
		      param2_01 = System_Linq_Enumerable__ToList_object_
		                            (param1_00,param2_00,
		                             Method_System_Collections_Generic_List_SquadModel_ColossusPartySlot__get_Item__
		                            );
		      Gameplay_Clans_Office_View_SquadTab_MemberSlotView__Init(param1_01,param2_01,param2_00);
		      param2_00 = param2_00 + 1;
		      param1_00 = *(int *)(param2 + 0xc);
		    } while (param2_00 < *(int *)(param1_00 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003D3F RID: 15679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D3F")]
		[Address(RVA = "0x8BFF", Offset = "0x8BFF", VA = "0x8BFF")]
		public void UpdateParty(SquadModel.PartyData party)
		{
		/* --- GHIDRA: UpdateParty ---
		void Gameplay_Clans_Office_View_SquadTab_SquadListElement__UpdateParty
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x34);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003D40 RID: 15680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D40")]
		[Address(RVA = "0x8C00", Offset = "0x8C00", VA = "0x8C00")]
		private void JoinButtonClickedEventHandler(MemberSlotView slot)
		{
		/* --- GHIDRA: JoinButtonClickedEventHandler ---
		void Gameplay_Clans_Office_View_SquadTab_SquadListElement__JoinButtonClickedEventHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x38);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003D41 RID: 15681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D41")]
		[Address(RVA = "0x8C01", Offset = "0x8C01", VA = "0x8C01")]
		private void CrossButtonClickedEventHandler(MemberSlotView slot)
		{
		/* --- GHIDRA: CrossButtonClickedEventHandler ---
		void Gameplay_Clans_Office_View_SquadTab_SquadListElement__CrossButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57f34 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_View_SquadTab_MemberSlotView___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_SquadListElement_State___ctor__)
		    ;
		    DAT_ram_00a57f34 = '\x01';
		  }
		  uVar1 = Mono_Security_ASN1Convert__ToOid
		                    (Gameplay_Clans_Office_View_SquadTab_MemberSlotView___TypeInfo,0);
		  *(undefined4 *)(param1 + 0x30) = uVar1;
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_SquadListElement_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06003D42 RID: 15682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D42")]
		[Address(RVA = "0x8C02", Offset = "0x8C02", VA = "0x8C02")]
		public SquadListElement()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_View_SquadTab_SquadListElement___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57f35 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MemberSlotView__SquadListElement__TypeInfo);
		    DAT_ram_00a57f35 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x4c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_MemberSlotView__SquadListElement__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MemberSlotView__SquadListElement__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x4c,iVar2,param1_00);
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

		// Token: 0x04002209 RID: 8713
		[Token(Token = "0x4002209")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400220A RID: 8714
		[Token(Token = "0x400220A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x0400220B RID: 8715
		[Token(Token = "0x400220B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private MemberSlotView _slotPrefab;

		// Token: 0x0400220C RID: 8716
		[Token(Token = "0x400220C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _titleGroup;

		// Token: 0x0400220D RID: 8717
		[Token(Token = "0x400220D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ButtonWithCost _costButton;

		// Token: 0x0400220E RID: 8718
		[Token(Token = "0x400220E")]
		[FieldOffset(Offset = "0x30")]
		private MemberSlotView[] _slots;

		// Token: 0x02000A11 RID: 2577
		[Token(Token = "0x2000A11")]
		public enum State
		{
			// Token: 0x04002214 RID: 8724
			[Token(Token = "0x4002214")]
			UNKNOWN_STATE,
			// Token: 0x04002215 RID: 8725
			[Token(Token = "0x4002215")]
			OPENED,
			// Token: 0x04002216 RID: 8726
			[Token(Token = "0x4002216")]
			CLOSED
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_JoinButtonClickedEvent ---
		void Gameplay_Clans_Office_View_SquadTab_SquadListElement__add_JoinButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57f2f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MemberSlotView__SquadListElement__TypeInfo);
		    DAT_ram_00a57f2f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x34);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_MemberSlotView__SquadListElement__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MemberSlotView__SquadListElement__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x34,iVar2,param1_00);
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


		/* --- GHIDRA: remove_JoinButtonClickedEvent ---
		void Gameplay_Clans_Office_View_SquadTab_SquadListElement__remove_JoinButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57f30 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MemberSlotView__SquadListElement__TypeInfo);
		    DAT_ram_00a57f30 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x38);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_MemberSlotView__SquadListElement__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MemberSlotView__SquadListElement__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x38,iVar2,param1_00);
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


		/* --- GHIDRA: add_CrossButtonClickedEvent ---
		void Gameplay_Clans_Office_View_SquadTab_SquadListElement__add_CrossButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57f31 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MemberSlotView__SquadListElement__TypeInfo);
		    DAT_ram_00a57f31 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x38);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_MemberSlotView__SquadListElement__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MemberSlotView__SquadListElement__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x38,iVar2,param1_00);
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


		/* --- GHIDRA: set_Dic ---
		void Gameplay_Clans_Office_View_SquadTab_SquadListElement__set_Dic
		               (int param1,int param2,int *param3,undefined4 param4,undefined4 param5)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  uint *puVar6;
		  int iVar7;
		  int iVar8;
		  undefined4 uVar9;
		  int *piVar10;
		  int iVar11;
		  int iVar12;
		  
		  iVar11 = 0;
		  if (DAT_ram_00a57f32 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MemberSlotView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_ICollection_ColossusSlotsInfoDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_ColossusSlotsInfoDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_UI_LayoutRebuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_View_SquadTab_MemberSlotView___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_SquadListElement_State__set_CurrentState__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_MemberSlotView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_SquadTab_SquadListElement_CrossButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_SquadTab_SquadListElement_JoinButtonClickedEventHandler__
		              );
		    DAT_ram_00a57f32 = '\x01';
		  }
		  *(int *)(param1 + 0x40) = param2;
		  iVar8 = *(int *)(param1 + 0x30);
		  if (0 < *(int *)(iVar8 + 0xc)) {
		    do {
		      iVar12 = *(int *)(iVar8 + iVar11 * 4 + 0x10);
		      uVar5 = unnamed_function_1417(System_Action_MemberSlotView__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar5,param1,
		                 Method_Gameplay_Clans_Office_View_SquadTab_SquadListElement_JoinButtonClickedEventHandler__
		                 ,0);
		      if (DAT_ram_00a57f25 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_MemberSlotView__TypeInfo);
		        DAT_ram_00a57f25 = '\x01';
		      }
		      iVar3 = *(int *)(iVar12 + 0x40);
		      do {
		        iVar7 = 0;
		        iVar4 = func_ii_7048(iVar3,uVar5,0);
		        uVar9 = System_Action_MemberSlotView__TypeInfo;
		        if ((iVar4 != 0) &&
		           (iVar7 = func_ii_1082(iVar4,System_Action_MemberSlotView__TypeInfo), iVar7 == 0)) {
		          System_Activator__CreateInstance(iVar4,uVar9);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar7 = func_ii_4329(iVar12 + 0x40,iVar7,iVar3);
		        bVar1 = iVar7 != iVar3;
		        iVar3 = iVar7;
		      } while (bVar1);
		      uVar5 = unnamed_function_1417(System_Action_MemberSlotView__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar5,param1,
		                 Method_Gameplay_Clans_Office_View_SquadTab_SquadListElement_CrossButtonClickedEventHandler__
		                 ,0);
		      if (DAT_ram_00a57f27 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_MemberSlotView__TypeInfo);
		        DAT_ram_00a57f27 = '\x01';
		      }
		      iVar3 = *(int *)(iVar12 + 0x44);
		      do {
		        iVar7 = 0;
		        iVar4 = func_ii_7048(iVar3,uVar5,0);
		        uVar9 = System_Action_MemberSlotView__TypeInfo;
		        if ((iVar4 != 0) &&
		           (iVar7 = func_ii_1082(iVar4,System_Action_MemberSlotView__TypeInfo), iVar7 == 0)) {
		          System_Activator__CreateInstance(iVar4,uVar9);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar7 = func_ii_4329(iVar12 + 0x44,iVar7,iVar3);
		        bVar1 = iVar7 != iVar3;
		        iVar3 = iVar7;
		      } while (bVar1);
		      uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (iVar12,0);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      UnityEngine_Application__get_isPlaying(uVar5,0);
		      iVar11 = iVar11 + 1;
		    } while (iVar11 < *(int *)(iVar8 + 0xc));
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,2,Method_UI_MonoBehaviourWithStates_SquadListElement_State__set_CurrentState__);
		  uVar9 = *(undefined4 *)(param1 + 0x1c);
		  uVar5 = Core_Extensions_Dict_OptionsMenuButtonExt__GetIcon(param2,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar9,uVar5,0);
		  uVar5 = *(undefined4 *)(param1 + 0x28);
		  if (*(int *)(UnityEngine_UI_LayoutRebuilder_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_UI_LayoutRebuilder_TypeInfo);
		  }
		  UnityEngine_UI_LayoutRebuilder__StripDisabledBehavioursFromList(uVar5,0);
		  iVar11 = *param3;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_ColossusSlotsInfoDic__TypeInfo ==
		          *(int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8)) {
		        puVar6 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e81a38;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar2);
		  }
		  puVar6 = (uint *)func_ii_1080(param3,
		                                System_Collections_Generic_ICollection_ColossusSlotsInfoDic__TypeInfo
		                                ,0);
		code_r0x80e81a38:
		  uVar5 = (**(code **)((ulonglong)*puVar6 * 4))(param3,puVar6[1]);
		  uVar5 = Mono_Security_ASN1Convert__ToOid
		                    (Gameplay_Clans_Office_View_SquadTab_MemberSlotView___TypeInfo,uVar5);
		  *(undefined4 *)(param1 + 0x30) = uVar5;
		  uVar5 = *(undefined4 *)(param2 + 0x14);
		  uVar9 = *(undefined4 *)(*(int *)(param1 + 0x2c) + 0xb8);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar5 = Core_Money_Money__op_Explicit(uVar5,0);
		  UI_Price_Price__SetColor(uVar9,param4,uVar5,0);
		  iVar11 = 0;
		  do {
		    iVar8 = *param3;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		        if (System_Collections_Generic_ICollection_ColossusSlotsInfoDic__TypeInfo == *piVar10) {
		          puVar6 = (uint *)(iVar8 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x80e81b05;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		    }
		    puVar6 = (uint *)func_ii_1080(param3,
		                                  System_Collections_Generic_ICollection_ColossusSlotsInfoDic__TypeInfo
		                                  ,0);
		code_r0x80e81b05:
		    iVar8 = (**(code **)((ulonglong)*puVar6 * 4))(param3,puVar6[1]);
		    if (iVar8 <= iVar11) {
		      return;
		    }
		    uVar5 = *(undefined4 *)(param1 + 0x20);
		    uVar9 = *(undefined4 *)(param1 + 0x24);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar8 = func_ii_6805(uVar9,uVar5,Method_UnityEngine_Object_Instantiate_MemberSlotView___);
		    iVar12 = *param3;
		    if (*(ushort *)(iVar12 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar12 + 0x58) + uVar2 * 8);
		        if (System_Collections_Generic_IList_ColossusSlotsInfoDic__TypeInfo == *piVar10) {
		          puVar6 = (uint *)(iVar12 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x80e81bbd;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar12 + 0xb6) != uVar2);
		    }
		    puVar6 = (uint *)func_ii_1080(param3,
		                                  System_Collections_Generic_IList_ColossusSlotsInfoDic__TypeInfo,0)
		    ;
		code_r0x80e81bbd:
		    uVar5 = (**(code **)((ulonglong)*puVar6 * 4))(param3,iVar11,puVar6[1]);
		    Gameplay_Clans_Office_View_SquadTab_MemberSlotView__OnDestroy(iVar8,uVar5,param4,puVar6);
		    uVar5 = unnamed_function_1417(System_Action_MemberSlotView__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar5,param1,
		               Method_Gameplay_Clans_Office_View_SquadTab_SquadListElement_JoinButtonClickedEventHandler__
		               ,0);
		    if (DAT_ram_00a57f24 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_MemberSlotView__TypeInfo);
		      DAT_ram_00a57f24 = '\x01';
		    }
		    iVar12 = *(int *)(iVar8 + 0x40);
		    do {
		      iVar3 = 0;
		      iVar7 = UnityEngine_UI_Image__set_sprite(iVar12,uVar5,0);
		      uVar9 = System_Action_MemberSlotView__TypeInfo;
		      if ((iVar7 != 0) &&
		         (iVar3 = func_ii_1082(iVar7,System_Action_MemberSlotView__TypeInfo), iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar7,uVar9);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar8 + 0x40,iVar3,iVar12);
		      bVar1 = iVar3 != iVar12;
		      iVar12 = iVar3;
		    } while (bVar1);
		    uVar5 = unnamed_function_1417(System_Action_MemberSlotView__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar5,param1,
		               Method_Gameplay_Clans_Office_View_SquadTab_SquadListElement_CrossButtonClickedEventHandler__
		               ,0);
		    if (DAT_ram_00a57f26 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_MemberSlotView__TypeInfo);
		      DAT_ram_00a57f26 = '\x01';
		    }
		    iVar12 = *(int *)(iVar8 + 0x44);
		    do {
		      iVar3 = 0;
		      iVar7 = UnityEngine_UI_Image__set_sprite(iVar12,uVar5,0);
		      uVar9 = System_Action_MemberSlotView__TypeInfo;
		      if ((iVar7 != 0) &&
		         (iVar3 = func_ii_1082(iVar7,System_Action_MemberSlotView__TypeInfo), iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar7,uVar9);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar8 + 0x44,iVar3,iVar12);
		      bVar1 = iVar3 != iVar12;
		      iVar12 = iVar3;
		    } while (bVar1);
		    piVar10 = *(int **)(param1 + 0x30);
		    if ((iVar8 != 0) && (iVar12 = func_ii_1082(iVar8,*(undefined4 *)(*piVar10 + 0x20)), iVar12 == 0)
		       ) {
		      uVar5 = func_ii_1083();
		      func_ii_1050(uVar5,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar10[iVar11 + 4] = iVar8;
		    iVar11 = iVar11 + 1;
		  } while( true );
		}
		*/

}
