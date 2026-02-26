using System;
using System.Runtime.CompilerServices;
using Gameplay.Accounts.Model.Data;
using Gameplay.Bank.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Accounts.View
{
	// Token: 0x02000DCD RID: 3533
	[Token(Token = "0x2000DCD")]
	public class OptionBuyButtonItem : MonoBehaviour
	{
		// Token: 0x14000205 RID: 517
		// (add) Token: 0x06005627 RID: 22055 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005628 RID: 22056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000205")]
		public event Action<OptionBuyButtonItem> ClickEvent
		{
			[Token(Token = "0x6005627")]
			[Address(RVA = "0xA3C5", Offset = "0xA3C5", VA = "0xA3C5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005628")]
			[Address(RVA = "0xA3C6", Offset = "0xA3C6", VA = "0xA3C6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x06005629 RID: 22057 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001183")]
		public TextMeshProUGUI OptionName
		{
			[Token(Token = "0x6005629")]
			[Address(RVA = "0xA3C7", Offset = "0xA3C7", VA = "0xA3C7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x0600562A RID: 22058 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001184")]
		public TextMeshProUGUI ButtonLabel
		{
			[Token(Token = "0x600562A")]
			[Address(RVA = "0xA3C8", Offset = "0xA3C8", VA = "0xA3C8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x0600562B RID: 22059 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001185")]
		public TextMeshProUGUI SaleLabel
		{
			[Token(Token = "0x600562B")]
			[Address(RVA = "0xA3C9", Offset = "0xA3C9", VA = "0xA3C9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x0600562C RID: 22060 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001186")]
		public VipPointsView VipPointsView
		{
			[Token(Token = "0x600562C")]
			[Address(RVA = "0xA3CA", Offset = "0xA3CA", VA = "0xA3CA")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600562D RID: 22061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600562D")]
		[Address(RVA = "0xA3CB", Offset = "0xA3CB", VA = "0xA3CB")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Accounts_View_OptionBuyButtonItem__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5889b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_View_OptionBuyButtonItem_HandleBtnClickEvent__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5889b = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Accounts_View_OptionBuyButtonItem_HandleBtnClickEvent__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600562E RID: 22062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600562E")]
		[Address(RVA = "0xA3CC", Offset = "0xA3CC", VA = "0xA3CC")]
		private void Start()
		{
		}

		// Token: 0x0600562F RID: 22063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600562F")]
		[Address(RVA = "0xA3CD", Offset = "0xA3CD", VA = "0xA3CD")]
		private void HandleBtnClickEvent()
		{
		}

		// Token: 0x06005630 RID: 22064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005630")]
		[Address(RVA = "0xA3CE", Offset = "0xA3CE", VA = "0xA3CE")]
		public OptionBuyButtonItem()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Accounts_View_OptionBuyButtonItem___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5889c == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12555);
		    DAT_ram_00a5889c = '\x01';
		  }
		  return StringLiteral_12555;
		}
		*/

		}

		// Token: 0x04002EBC RID: 11964
		[Token(Token = "0x4002EBC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _optionName;

		// Token: 0x04002EBD RID: 11965
		[Token(Token = "0x4002EBD")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _button;

		// Token: 0x04002EBE RID: 11966
		[Token(Token = "0x4002EBE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _buttonLabel;

		// Token: 0x04002EBF RID: 11967
		[Token(Token = "0x4002EBF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _saleLabel;

		// Token: 0x04002EC0 RID: 11968
		[Token(Token = "0x4002EC0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private VipPointsView _vipPointsView;

		// Token: 0x04002EC2 RID: 11970
		[Token(Token = "0x4002EC2")]
		[FieldOffset(Offset = "0x28")]
		public AccountOptionData OptionData;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_Accounts_View_OptionBuyButtonItem__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58899 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OptionBuyButtonItem__TypeInfo);
		    DAT_ram_00a58899 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_OptionBuyButtonItem__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_OptionBuyButtonItem__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
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


		/* --- GHIDRA: get_VipPointsView ---
		void Gameplay_Accounts_View_OptionBuyButtonItem__get_VipPointsView(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5889a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_View_OptionBuyButtonItem_HandleBtnClickEvent__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5889a = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Accounts_View_OptionBuyButtonItem_HandleBtnClickEvent__,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

}
