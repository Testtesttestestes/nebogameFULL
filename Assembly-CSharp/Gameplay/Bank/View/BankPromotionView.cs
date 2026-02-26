using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C47 RID: 3143
	[Token(Token = "0x2000C47")]
	public class BankPromotionView : MonoBehaviour
	{
		// Token: 0x140001DD RID: 477
		// (add) Token: 0x06004CA4 RID: 19620 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004CA5 RID: 19621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001DD")]
		public event Action<PromotionsDic> InfoButtonClickedEvent
		{
			[Token(Token = "0x6004CA4")]
			[Address(RVA = "0x9AE5", Offset = "0x9AE5", VA = "0x9AE5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004CA5")]
			[Address(RVA = "0x9AE6", Offset = "0x9AE6", VA = "0x9AE6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06004CA6 RID: 19622 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004CA7 RID: 19623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F74")]
		public PromotionsDic PromotionsDic
		{
			[Token(Token = "0x6004CA6")]
			[Address(RVA = "0x9AE7", Offset = "0x9AE7", VA = "0x9AE7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004CA7")]
			[Address(RVA = "0x9AE8", Offset = "0x9AE8", VA = "0x9AE8")]
			set
			{
			}
		}

		// Token: 0x06004CA8 RID: 19624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CA8")]
		[Address(RVA = "0x9AE9", Offset = "0x9AE9", VA = "0x9AE9")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Bank_View_BankPromotionView__Awake(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param1 + 0x20),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004CA9 RID: 19625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CA9")]
		[Address(RVA = "0x9AEA", Offset = "0x9AEA", VA = "0x9AEA")]
		private void InfoButtonClickHandler()
		{
		/* --- GHIDRA: InfoButtonClickHandler ---
		void Gameplay_Bank_View_BankPromotionView__InfoButtonClickHandler(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5979e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_View_BankPromotionView_InfoButtonClickHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5979e = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,Method_Gameplay_Bank_View_BankPromotionView_InfoButtonClickHandler__,0
		            );
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004CAA RID: 19626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CAA")]
		[Address(RVA = "0x9AEB", Offset = "0x9AEB", VA = "0x9AEB")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004CAB RID: 19627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CAB")]
		[Address(RVA = "0x9AEC", Offset = "0x9AEC", VA = "0x9AEC")]
		public BankPromotionView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Bank_View_BankPromotionView___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5979f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PromotionsDic__TypeInfo);
		    DAT_ram_00a5979f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_PromotionsDic__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_PromotionsDic__TypeInfo), iVar2 == 0)) break;
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

		}

		// Token: 0x040029D7 RID: 10711
		[Token(Token = "0x40029D7")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _bgImage;

		// Token: 0x040029D8 RID: 10712
		[Token(Token = "0x40029D8")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _text;

		// Token: 0x040029D9 RID: 10713
		[Token(Token = "0x40029D9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _infoButton;

		// Token: 0x040029DB RID: 10715
		[Token(Token = "0x40029DB")]
		[FieldOffset(Offset = "0x20")]
		private PromotionsDic _promotionsDic;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InfoButtonClickedEvent ---
		void Gameplay_Bank_View_BankPromotionView__add_InfoButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5979c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_PromotionsDic__TypeInfo);
		    DAT_ram_00a5979c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_PromotionsDic__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_PromotionsDic__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: get_PromotionsDic ---
		void Gameplay_Bank_View_BankPromotionView__get_PromotionsDic
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  int iVar3;
		  
		  *(undefined4 *)(param1 + 0x20) = param2;
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = Gameplay_Bank_View_BankGalleryView__AddElement(param2,0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1_00,uVar1,0);
		  piVar2 = *(int **)(param1 + 0x14);
		  uVar1 = Core_Extensions_Dict_PromotionsDicExt__GetWideBannerAssetId
		                    (*(undefined4 *)(param1 + 0x20),0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/


		/* --- GHIDRA: set_PromotionsDic ---
		void Gameplay_Bank_View_BankPromotionView__set_PromotionsDic(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5979d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_View_BankPromotionView_InfoButtonClickHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5979d = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,Method_Gameplay_Bank_View_BankPromotionView_InfoButtonClickHandler__,0
		            );
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

}
