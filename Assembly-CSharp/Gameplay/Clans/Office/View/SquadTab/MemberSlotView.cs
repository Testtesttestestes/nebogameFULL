using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data.Balance;
using Core.Materials;
using Gameplay.Clans.Office.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using UI;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.SquadTab
{
	// Token: 0x02000A0E RID: 2574
	[Token(Token = "0x2000A0E")]
	public class MemberSlotView : MonoBehaviourWithStates<MemberSlotView.State>, IGrayscalable
	{
		// Token: 0x14000191 RID: 401
		// (add) Token: 0x06003D26 RID: 15654 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003D27 RID: 15655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000191")]
		public event Action<MemberSlotView> JoinButtonClickedEvent
		{
			[Token(Token = "0x6003D26")]
			[Address(RVA = "0x8BE6", Offset = "0x8BE6", VA = "0x8BE6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003D27")]
			[Address(RVA = "0x8BE7", Offset = "0x8BE7", VA = "0x8BE7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000192 RID: 402
		// (add) Token: 0x06003D28 RID: 15656 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003D29 RID: 15657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000192")]
		public event Action<MemberSlotView> CrossButtonClickedEvent
		{
			[Token(Token = "0x6003D28")]
			[Address(RVA = "0x8BE8", Offset = "0x8BE8", VA = "0x8BE8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003D29")]
			[Address(RVA = "0x8BE9", Offset = "0x8BE9", VA = "0x8BE9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06003D2A RID: 15658 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003D2B RID: 15659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C19")]
		public SquadModel.ColossusPartySlot PartySlot
		{
			[Token(Token = "0x6003D2A")]
			[Address(RVA = "0x8BEA", Offset = "0x8BEA", VA = "0x8BEA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D2B")]
			[Address(RVA = "0x8BEB", Offset = "0x8BEB", VA = "0x8BEB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06003D2C RID: 15660 RVA: 0x0000C390 File Offset: 0x0000A590
		[Token(Token = "0x17000C1A")]
		public bool IsActive
		{
			[Token(Token = "0x6003D2C")]
			[Address(RVA = "0x8BEC", Offset = "0x8BEC", VA = "0x8BEC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003D2D RID: 15661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D2D")]
		[Address(RVA = "0x8BED", Offset = "0x8BED", VA = "0x8BED")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Clans_Office_View_SquadTab_MemberSlotView__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57f2a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_SquadTab_MemberSlotView_CrossButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_SquadTab_MemberSlotView_JoinButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57f2a = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x30) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_View_SquadTab_MemberSlotView_JoinButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x34) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_View_SquadTab_MemberSlotView_CrossButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003D2E RID: 15662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D2E")]
		[Address(RVA = "0x8BEE", Offset = "0x8BEE", VA = "0x8BEE")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Clans_Office_View_SquadTab_MemberSlotView__OnDestroy
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  float param2_00;
		  
		  if (DAT_ram_00a57f2b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_MemberSlotView_State__set_CurrentState__);
		    DAT_ram_00a57f2b = '\x01';
		  }
		  if (param2 == 0) {
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (param1,3,Method_UI_MonoBehaviourWithStates_MemberSlotView_State__set_CurrentState__);
		    param2_00 = 1.0;
		  }
		  else {
		    iVar1 = Core_Extensions_Dict_ResourceSetExt__GetDelta(*(undefined4 *)(param2 + 0x10),0);
		    if (iVar1 == 0) {
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (param1,2,Method_UI_MonoBehaviourWithStates_MemberSlotView_State__set_CurrentState__
		                );
		      func_ii_7050(*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(param1 + 0x28),0);
		      uVar2 = *(undefined4 *)(param2 + 0x10);
		      param1_00 = *(undefined4 *)(param1 + 0x3c);
		      if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_TypeInfo);
		      }
		      uVar2 = Core_Money_Money__op_Explicit(uVar2,0);
		      UI_Price_Price__SetColor(param1_00,param3,uVar2,0);
		    }
		    else {
		      Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		                (param1,1,Method_UI_MonoBehaviourWithStates_MemberSlotView_State__set_CurrentState__
		                );
		      func_ii_7050(*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(param1 + 0x2c),0);
		    }
		    param2_00 = 0.0;
		  }
		  UI_ImageAnimation__ShowAnimation_d__9__System_Collections_IEnumerator_get_Current
		            (*(undefined4 *)(param1 + 0x20),param2_00,0);
		  UI_ImageAnimation__ShowAnimation_d__9__System_Collections_IEnumerator_get_Current
		            (*(undefined4 *)(param1 + 0x1c),param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06003D2F RID: 15663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D2F")]
		[Address(RVA = "0x8BEF", Offset = "0x8BEF", VA = "0x8BEF")]
		public void Init(ColossusSlotsInfoDic dic, IBalanceSource treasury)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Office_View_SquadTab_MemberSlotView__Init
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57f2c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_MemberSlotView_State__set_CurrentState__);
		    DAT_ram_00a57f2c = '\x01';
		  }
		  *(int *)(param1 + 0x48) = param2;
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x34),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)*(byte *)(param2 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x24),(uint)*(byte *)(param2 + 0x14),0);
		  if (*(int *)(param2 + 8) == 0) {
		    func_ii_7050(*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(param1 + 0x2c),0);
		    uVar1 = 1;
		  }
		  else {
		    param1_00 = *(undefined4 *)(param1 + 0x38);
		    uVar1 = Core_Extensions_Dict_AprDicExt__GetAttackAssetId
		                      (*(undefined4 *)(*(int *)(*(int *)(param2 + 0xc) + 0x38) + 0x10),0);
		    Core_Extensions_Dict_AprDicExt__Get1024AssetId(param1_00,uVar1,0);
		    uVar1 = 4;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,uVar1,Method_UI_MonoBehaviourWithStates_MemberSlotView_State__set_CurrentState__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003D30 RID: 15664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D30")]
		[Address(RVA = "0x8BF0", Offset = "0x8BF0", VA = "0x8BF0")]
		public void UpdateData(SquadModel.ColossusPartySlot slot)
		{
		/* --- GHIDRA: UpdateData ---
		void Gameplay_Clans_Office_View_SquadTab_MemberSlotView__UpdateData(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57f28 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_MemberSlotView_State__get_CurrentState__);
		    DAT_ram_00a57f28 = '\x01';
		  }
		  if ((*(int *)(param1 + 0x18) != 3) && (iVar1 = *(int *)(param1 + 0x40), iVar1 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003D31 RID: 15665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D31")]
		[Address(RVA = "0x8BF1", Offset = "0x8BF1", VA = "0x8BF1")]
		private void JoinButtonClickedEventHandler()
		{
		/* --- GHIDRA: JoinButtonClickedEventHandler ---
		void Gameplay_Clans_Office_View_SquadTab_MemberSlotView__JoinButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57f28 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_MemberSlotView_State__get_CurrentState__);
		    DAT_ram_00a57f28 = '\x01';
		  }
		  if ((*(int *)(param1 + 0x18) != 3) && (iVar1 = *(int *)(param1 + 0x44), iVar1 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D32")]
		[Address(RVA = "0x8BF2", Offset = "0x8BF2", VA = "0x8BF2")]
		private void CrossButtonClickedEventHandler()
		{
		/* --- GHIDRA: CrossButtonClickedEventHandler ---
		void Gameplay_Clans_Office_View_SquadTab_MemberSlotView__CrossButtonClickedEventHandler
		               (int param1,float param2,undefined4 param3)
		
		{
		  UI_ImageAnimation__ShowAnimation_d__9__System_Collections_IEnumerator_get_Current
		            (*(undefined4 *)(param1 + 0x20),param2,0);
		  UI_ImageAnimation__ShowAnimation_d__9__System_Collections_IEnumerator_get_Current
		            (*(undefined4 *)(param1 + 0x1c),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06003D33 RID: 15667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D33")]
		[Address(RVA = "0x8BF3", Offset = "0x8BF3", VA = "0x8BF3", Slot = "5")]
		public void SetGrayscale(float value)
		{
		/* --- GHIDRA: SetGrayscale ---
		void Gameplay_Clans_Office_View_SquadTab_MemberSlotView__SetGrayscale
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57f2d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_MemberSlotView_State___ctor__);
		    DAT_ram_00a57f2d = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_MemberSlotView_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06003D34 RID: 15668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D34")]
		[Address(RVA = "0x8BF4", Offset = "0x8BF4", VA = "0x8BF4")]
		public MemberSlotView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_View_SquadTab_MemberSlotView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57f2e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MemberSlotView__SquadListElement__TypeInfo);
		    DAT_ram_00a57f2e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x34);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
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

		}

		// Token: 0x040021F7 RID: 8695
		[Token(Token = "0x40021F7")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ImageWithGrayscale _placeHolderImage;

		// Token: 0x040021F8 RID: 8696
		[Token(Token = "0x40021F8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ImageWithGrayscale _borderImage;

		// Token: 0x040021F9 RID: 8697
		[Token(Token = "0x40021F9")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameObject _selector;

		// Token: 0x040021FA RID: 8698
		[Token(Token = "0x40021FA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _lockSprite;

		// Token: 0x040021FB RID: 8699
		[Token(Token = "0x40021FB")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Sprite _plusSprite;

		// Token: 0x040021FC RID: 8700
		[Token(Token = "0x40021FC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _joinButton;

		// Token: 0x040021FD RID: 8701
		[Token(Token = "0x40021FD")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Button _crossButton;

		// Token: 0x040021FE RID: 8702
		[Token(Token = "0x40021FE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameAssetViewRawImage _dollImage;

		// Token: 0x040021FF RID: 8703
		[Token(Token = "0x40021FF")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Price _price;

		// Token: 0x02000A0F RID: 2575
		[Token(Token = "0x2000A0F")]
		public enum State
		{
			// Token: 0x04002204 RID: 8708
			[Token(Token = "0x4002204")]
			UNKNOWN_STATE,
			// Token: 0x04002205 RID: 8709
			[Token(Token = "0x4002205")]
			EMPTY,
			// Token: 0x04002206 RID: 8710
			[Token(Token = "0x4002206")]
			LOCKED,
			// Token: 0x04002207 RID: 8711
			[Token(Token = "0x4002207")]
			INACTIVE,
			// Token: 0x04002208 RID: 8712
			[Token(Token = "0x4002208")]
			FILLED
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_JoinButtonClickedEvent ---
		void Gameplay_Clans_Office_View_SquadTab_MemberSlotView__add_JoinButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57f25 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MemberSlotView__TypeInfo);
		    DAT_ram_00a57f25 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_MemberSlotView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MemberSlotView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x40,iVar2,param1_00);
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
		void Gameplay_Clans_Office_View_SquadTab_MemberSlotView__remove_JoinButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57f26 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MemberSlotView__TypeInfo);
		    DAT_ram_00a57f26 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x44);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_MemberSlotView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MemberSlotView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x44,iVar2,param1_00);
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
		void Gameplay_Clans_Office_View_SquadTab_MemberSlotView__add_CrossButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57f27 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MemberSlotView__TypeInfo);
		    DAT_ram_00a57f27 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x44);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_MemberSlotView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MemberSlotView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x44,iVar2,param1_00);
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


		/* --- GHIDRA: set_PartySlot ---
		uint Gameplay_Clans_Office_View_SquadTab_MemberSlotView__set_PartySlot(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57f28 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_MemberSlotView_State__get_CurrentState__);
		    DAT_ram_00a57f28 = '\x01';
		  }
		  return (uint)(*(int *)(param1 + 0x18) != 3);
		}
		*/


		/* --- GHIDRA: get_IsActive ---
		void Gameplay_Clans_Office_View_SquadTab_MemberSlotView__get_IsActive(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57f29 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_SquadTab_MemberSlotView_CrossButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_SquadTab_MemberSlotView_JoinButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57f29 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x30) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_View_SquadTab_MemberSlotView_JoinButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x34) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_View_SquadTab_MemberSlotView_CrossButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  return;
		}
		*/

}
