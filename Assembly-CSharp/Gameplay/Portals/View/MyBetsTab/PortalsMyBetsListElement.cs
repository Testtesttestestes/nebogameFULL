using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Portal;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Portals.View.MyBetsTab
{
	// Token: 0x020005C7 RID: 1479
	[Token(Token = "0x20005C7")]
	public class PortalsMyBetsListElement : MonoBehaviour
	{
		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06002373 RID: 9075 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002374 RID: 9076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000699")]
		public Action<ulong> ClickAction
		{
			[Token(Token = "0x6002373")]
			[Address(RVA = "0x74C6", Offset = "0x74C6", VA = "0x74C6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002374")]
			[Address(RVA = "0x74C7", Offset = "0x74C7", VA = "0x74C7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002375")]
		[Address(RVA = "0x74C8", Offset = "0x74C8", VA = "0x74C8")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Portals_View_MyBetsTab_PortalsMyBetsListElement__Start(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5810e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_View_MyBetsTab_PortalsMyBetsListElement_OnClick__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5810e = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Portals_View_MyBetsTab_PortalsMyBetsListElement_OnClick__,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06002376 RID: 9078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002376")]
		[Address(RVA = "0x74C9", Offset = "0x74C9", VA = "0x74C9")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		undefined4
		Gameplay_Portals_View_MyBetsTab_PortalsMyBetsListElement__OnDestroy
		          (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = 0;
		  if (param2 == 0) {
		    return *(undefined4 *)(param1 + 0x28);
		  }
		  if (param2 != 1) {
		    if (param2 == 2) {
		      uVar1 = *(undefined4 *)(param1 + 0x30);
		    }
		    return uVar1;
		  }
		  return *(undefined4 *)(param1 + 0x2c);
		}
		*/

		}

		// Token: 0x06002377 RID: 9079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002377")]
		[Address(RVA = "0x1C95", Offset = "0x1C95", VA = "0x1C95")]
		public void Init(BetHistoryRow myBet, Action<ulong> argsClickAction)
		{
		/* --- GHIDRA: Init ---
		int * Gameplay_Portals_View_MyBetsTab_PortalsMyBetsListElement__Init(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002378 RID: 9080 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002378")]
		[Address(RVA = "0x74CA", Offset = "0x74CA", VA = "0x74CA")]
		private Sprite GetChoiceSprite(Bet.Types.State state)
		{
		/* --- GHIDRA: GetChoiceSprite ---
		undefined4
		Gameplay_Portals_View_MyBetsTab_PortalsMyBetsListElement__GetChoiceSprite
		          (undefined4 param1,uint param2,undefined4 param3)
		
		{
		  undefined **ppuVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58110 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12154);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12157);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12158);
		    DAT_ram_00a58110 = '\x01';
		  }
		  ppuVar1 = &PTR_StringLiteral_12157_ram_005a3600 + param2;
		  if (2 < param2) {
		    ppuVar1 = (undefined **)(DAT_ram_00a66978 + 0x5c);
		  }
		  uVar2 = *(undefined4 *)*ppuVar1;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(uVar2,1,0,1,0,0,0,0);
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002379")]
		[Address(RVA = "0x74CB", Offset = "0x74CB", VA = "0x74CB")]
		private string GetChoiceText(Bet.Types.State state)
		{
		/* --- GHIDRA: GetChoiceText ---
		void Gameplay_Portals_View_MyBetsTab_PortalsMyBetsListElement__GetChoiceText
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x40);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined8 *)(param1 + 0x38),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600237A")]
		[Address(RVA = "0x74CC", Offset = "0x74CC", VA = "0x74CC")]
		private void OnClick()
		{
		}

		// Token: 0x0600237B RID: 9083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600237B")]
		[Address(RVA = "0x74CD", Offset = "0x74CD", VA = "0x74CD")]
		public PortalsMyBetsListElement()
		{
		}

		// Token: 0x04001381 RID: 4993
		[Token(Token = "0x4001381")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _button;

		// Token: 0x04001382 RID: 4994
		[Token(Token = "0x4001382")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _id;

		// Token: 0x04001383 RID: 4995
		[Token(Token = "0x4001383")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _date;

		// Token: 0x04001384 RID: 4996
		[Token(Token = "0x4001384")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _choice;

		// Token: 0x04001385 RID: 4997
		[Token(Token = "0x4001385")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _reward;

		// Token: 0x04001386 RID: 4998
		[Token(Token = "0x4001386")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Image _background;

		// Token: 0x04001387 RID: 4999
		[Token(Token = "0x4001387")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _wait;

		// Token: 0x04001388 RID: 5000
		[Token(Token = "0x4001388")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Sprite _win;

		// Token: 0x04001389 RID: 5001
		[Token(Token = "0x4001389")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _lose;

		// Token: 0x0400138A RID: 5002
		[Token(Token = "0x400138A")]
		[FieldOffset(Offset = "0x38")]
		private ulong _betId;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_ClickAction ---
		void Gameplay_Portals_View_MyBetsTab_PortalsMyBetsListElement__set_ClickAction
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5810d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_View_MyBetsTab_PortalsMyBetsListElement_OnClick__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5810d = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Portals_View_MyBetsTab_PortalsMyBetsListElement_OnClick__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

}
