using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Money;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;
using TMPro;
using UI;
using UI.Elements.Buttons;
using UI.Price;
using UnityEngine;

namespace Gameplay.Tournaments.View
{
	// Token: 0x020004A3 RID: 1187
	[Token(Token = "0x20004A3")]
	public class BetControlView : MonoBehaviour
	{
		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001C05 RID: 7173 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004EE")]
		public TextMeshProUGUI PlayerStatus
		{
			[Token(Token = "0x6001C05")]
			[Address(RVA = "0x6D84", Offset = "0x6D84", VA = "0x6D84")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000134 RID: 308
		// (add) Token: 0x06001C06 RID: 7174 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001C07 RID: 7175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000134")]
		public event Action<ResourceSet> BetAddedEvent
		{
			[Token(Token = "0x6001C06")]
			[Address(RVA = "0x6D85", Offset = "0x6D85", VA = "0x6D85")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001C07")]
			[Address(RVA = "0x6D86", Offset = "0x6D86", VA = "0x6D86")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C08")]
		[Address(RVA = "0x6D87", Offset = "0x6D87", VA = "0x6D87")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Tournaments_View_BetControlView__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a584e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tournaments_View_BetControlView_InputChangedEventHandler__);
		    DAT_ram_00a584e8 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_int__TypeInfo);
		  System_Action_short___Invoke
		            (param1_00,param1,
		             Method_Gameplay_Tournaments_View_BetControlView_InputChangedEventHandler__,0);
		  UI_NumbersInput__add_InputChangedEvent(param1_01,param1_00,0);
		  func_ii_14558(*(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4),0);
		  return;
		}
		*/

		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C09")]
		[Address(RVA = "0x6D88", Offset = "0x6D88", VA = "0x6D88")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Tournaments_View_BetControlView__OnDestroy(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a584e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    DAT_ram_00a584e9 = '\x01';
		  }
		  iVar1 = Core_Money_Money__op_Multiply(*(undefined4 *)(*(int *)(param1 + 0x20) + 0x28),0);
		  if ((iVar1 == 0) ||
		     (*(double *)(param1 + 0x38) <= (double)*(int *)(*(int *)(param1 + 0x10) + 0x18))) {
		    param1_00 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		    Core_Extensions_Dict_ResourceSetExt__HasNewCurrency
		              (param1_00,*(undefined4 *)(param1 + 0x2c),
		               (double)*(int *)(*(int *)(param1 + 0x10) + 0x18),0);
		    iVar1 = *(int *)(param1 + 0x40);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C0A")]
		[Address(RVA = "0x6D89", Offset = "0x6D89", VA = "0x6D89")]
		private void PriceButtonClickedEventHandler()
		{
		/* --- GHIDRA: PriceButtonClickedEventHandler ---
		void Gameplay_Tournaments_View_BetControlView__PriceButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Tournaments_View_BetControlView__InputChangedEventHandler(param1,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C0B")]
		[Address(RVA = "0x6D8A", Offset = "0x6D8A", VA = "0x6D8A")]
		private void InputChangedEventHandler(int value)
		{
		/* --- GHIDRA: InputChangedEventHandler ---
		void Gameplay_Tournaments_View_BetControlView__InputChangedEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  double dVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a584ea == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a584ea = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x2c);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  uVar2 = Utils_MathUtils_MathUtils__SaferDivide(uVar2,0);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar2 = Core_Data_ArtifactData__get_SellPrice(uVar2,(double)param2,0);
		  UI_Price_Price__SetColor
		            (*(undefined4 *)(*(int *)(param1 + 0x14) + 0xb8),*(undefined4 *)(param1 + 0x30),uVar2,0)
		  ;
		  dVar1 = Core_Extensions_Dict_ResourceSetExt__GetNonZeroResourcesesIds
		                    (*(undefined4 *)(*(int *)(param1 + 0x20) + 0x28),*(undefined4 *)(param1 + 0x2c),
		                     0);
		  UI_Price_PriceItemRenderer__set_TruncatePrice
		            (*(undefined4 *)(param1 + 0x24),
		             (uint)(*(double *)(param1 + 0x38) <= dVar1 + (double)param2),0);
		  return;
		}
		*/

		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C0C")]
		[Address(RVA = "0x6D8B", Offset = "0x6D8B", VA = "0x6D8B")]
		private void SetNewPrice(int value)
		{
		/* --- GHIDRA: SetNewPrice ---
		void Gameplay_Tournaments_View_BetControlView__SetNewPrice
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  double dVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a584eb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_Money___);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    DAT_ram_00a584eb = '\x01';
		  }
		  UI_Price_Price__SetColor(*(undefined4 *)(param1 + 0x18),0,param2,0);
		  UI_Price_Price__SetColor(*(undefined4 *)(param1 + 0x1c),0,param3,0);
		  UI_Price_Price__SetColor(*(undefined4 *)(param1 + 0x20),0,param4,0);
		  iVar1 = System_Linq_Enumerable__Count_object_(param3,Method_System_Linq_Enumerable_First_Money___)
		  ;
		  uVar3 = *(undefined4 *)(iVar1 + 8);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  uVar3 = func_ii_7278(uVar3,0);
		  *(undefined4 *)(param1 + 0x2c) = uVar3;
		  dVar2 = Core_Extensions_Dict_ResourceSetExt__GetNonZeroResourcesesIds(param3,uVar3,0);
		  *(double *)(param1 + 0x38) = dVar2;
		  UI_Price_PriceItemRenderer__set_MoneyType
		            (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(param1 + 0x2c),0);
		  Gameplay_Tournaments_View_BetControlView__InputChangedEventHandler
		            (param1,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x18),param1);
		  return;
		}
		*/

		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C0D")]
		[Address(RVA = "0x6D8C", Offset = "0x6D8C", VA = "0x6D8C")]
		public void Init(Money gladiatorsBet, Money viewersBet, Money playerBet)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Tournaments_View_BetControlView__Init(int param1,undefined4 param2,undefined4 param3)
		
		{
		  UI_Price_Price__SetColor(*(undefined4 *)(param1 + 0x18),0,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C0E")]
		[Address(RVA = "0x6D8D", Offset = "0x6D8D", VA = "0x6D8D")]
		public void UpdateGladiatorsBet(Money bet)
		{
		/* --- GHIDRA: UpdateGladiatorsBet ---
		void Gameplay_Tournaments_View_BetControlView__UpdateGladiatorsBet
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  UI_Price_Price__SetColor(*(undefined4 *)(param1 + 0x20),0,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C0F")]
		[Address(RVA = "0x6D8E", Offset = "0x6D8E", VA = "0x6D8E")]
		public void UpdatePlayerBet(Money bet)
		{
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C10")]
		[Address(RVA = "0x6D8F", Offset = "0x6D8F", VA = "0x6D8F")]
		public BetControlView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Tournaments_View_BetControlView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(param1 + 0x14),0);
		  UnityEngine_Transform__SetAsLastSibling(param1_00,1,0);
		  return;
		}
		*/

		}

		// Token: 0x04000F1F RID: 3871
		[Token(Token = "0x4000F1F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private NumbersInput _input;

		// Token: 0x04000F20 RID: 3872
		[Token(Token = "0x4000F20")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ButtonWithCost _priceButton;

		// Token: 0x04000F21 RID: 3873
		[Token(Token = "0x4000F21")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Price _gladiatorsBet;

		// Token: 0x04000F22 RID: 3874
		[Token(Token = "0x4000F22")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Price _viewersBet;

		// Token: 0x04000F23 RID: 3875
		[Token(Token = "0x4000F23")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Price _playerBet;

		// Token: 0x04000F24 RID: 3876
		[Token(Token = "0x4000F24")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private PriceItemRenderer _validationRenderer;

		// Token: 0x04000F25 RID: 3877
		[Token(Token = "0x4000F25")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _playerStatus;

		// Token: 0x04000F26 RID: 3878
		[Token(Token = "0x4000F26")]
		[FieldOffset(Offset = "0x2C")]
		private Protocol.Consts.Resources _currency;

		// Token: 0x04000F27 RID: 3879
		[Token(Token = "0x4000F27")]
		[FieldOffset(Offset = "0x30")]
		private UserData _user;

		// Token: 0x04000F28 RID: 3880
		[Token(Token = "0x4000F28")]
		[FieldOffset(Offset = "0x38")]
		private double _minBetValue;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_PlayerStatus ---
		void Gameplay_Tournaments_View_BetControlView__get_PlayerStatus
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a584e5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ResourceSet__TypeInfo);
		    DAT_ram_00a584e5 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ResourceSet__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ResourceSet__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: add_BetAddedEvent ---
		void Gameplay_Tournaments_View_BetControlView__add_BetAddedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a584e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ResourceSet__TypeInfo);
		    DAT_ram_00a584e6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x40);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ResourceSet__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ResourceSet__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_BetAddedEvent ---
		void Gameplay_Tournaments_View_BetControlView__remove_BetAddedEvent(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a584e7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tournaments_View_BetControlView_InputChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Tournaments_View_BetControlView_PriceButtonClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a584e7 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x10);
		  uVar2 = unnamed_function_1417(System_Action_int__TypeInfo);
		  System_Action_short___Invoke
		            (uVar2,param1,Method_Gameplay_Tournaments_View_BetControlView_InputChangedEventHandler__
		             ,0);
		  UI_CounterBacklight___ctor(uVar4,uVar2,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80efacf4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80efacf4:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  uVar2 = func_ii_7112(uVar2,0);
		  *(undefined4 *)(param1 + 0x30) = uVar2;
		  UI_Price_PriceItemRenderer__SetColor(*(undefined4 *)(param1 + 0x24),1,0);
		  uVar4 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Tournaments_View_BetControlView_PriceButtonClickedEventHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar4,uVar2,0);
		  return;
		}
		*/

}
