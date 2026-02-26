using System;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Elements;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C45 RID: 3141
	[Token(Token = "0x2000C45")]
	public class BankPromotionInfoWindow : BaseDialogWindow<BankPromotionInfoWindow.BankPromotionInfoWindowArgs>
	{
		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06004C9F RID: 19615 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F73")]
		public override string WindowId
		{
			[Token(Token = "0x6004C9F")]
			[Address(RVA = "0x9AE0", Offset = "0x9AE0", VA = "0x9AE0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004CA0 RID: 19616 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004CA0")]
		[Address(RVA = "0x9AE1", Offset = "0x9AE1", VA = "0x9AE1")]
		public static BankPromotionInfoWindow Show(PromotionsDic promotionsDic)
		{
		/* --- GHIDRA: Show ---
		void Gameplay_Bank_View_BankPromotionInfoWindow__Show(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a59798 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BankPromotionInfoWindow_BankPromotionInfoWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_BankPromotionInfoWindow_BankPromotionInfoWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3539);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3540);
		    DAT_ram_00a59798 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BankPromotionInfoWindow_BankPromotionInfoWindowArgs__HandleContent__
		            );
		  uVar3 = *(undefined4 *)(param1 + 0x50);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_BankPromotionInfoWindow_BankPromotionInfoWindowArgs__get_WindowArgs__
		                      );
		  uVar2 = Core_Extensions_Dict_PromotionsDicExt__GetEventBannerEventAssetId
		                    (*(undefined4 *)(iVar1 + 0x2c),0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(uVar3,uVar2,0);
		  uVar2 = *(undefined4 *)(param1 + 0x54);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3539,1,0,1,0,0,0,0);
		  UI_Elements_DecoratedTitle__Rebuild(uVar2,uVar3,0);
		  uVar3 = *(undefined4 *)(param1 + 0x58);
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3540,1,0,1,0,0,0,0);
		  UI_Elements_DecoratedTitle__Rebuild(uVar3,uVar2,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004CA1 RID: 19617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CA1")]
		[Address(RVA = "0x9AE2", Offset = "0x9AE2", VA = "0x9AE2", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		void Gameplay_Bank_View_BankPromotionInfoWindow__HandleContent(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59799 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BankPromotionInfoWindow_BankPromotionInfoWindowArgs___ctor__
		              );
		    DAT_ram_00a59799 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BankPromotionInfoWindow_BankPromotionInfoWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06004CA2 RID: 19618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CA2")]
		[Address(RVA = "0x9AE3", Offset = "0x9AE3", VA = "0x9AE3")]
		public BankPromotionInfoWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Bank_View_BankPromotionInfoWindow___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5979a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_BankPromotionInfoWindow_BankPromotionInfoWindowArgs___ctor__
		              );
		    DAT_ram_00a5979a = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_BankPromotionInfoWindow_BankPromotionInfoWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x040029D2 RID: 10706
		[Token(Token = "0x40029D2")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Bank/BankPromotionInfoWindow";

		// Token: 0x040029D3 RID: 10707
		[Token(Token = "0x40029D3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameRawImage _gameRawImage;

		// Token: 0x040029D4 RID: 10708
		[Token(Token = "0x40029D4")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private DecoratedTitle _prizeTitle;

		// Token: 0x040029D5 RID: 10709
		[Token(Token = "0x40029D5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private DecoratedTitle _superPrizeTitle;

		// Token: 0x02000C46 RID: 3142
		[Token(Token = "0x2000C46")]
		public class BankPromotionInfoWindowArgs : BaseDialogWindow<BankPromotionInfoWindow.BankPromotionInfoWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06004CA3 RID: 19619 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004CA3")]
			[Address(RVA = "0x9AE4", Offset = "0x9AE4", VA = "0x9AE4")]
			public BankPromotionInfoWindowArgs()
			{
			}

			// Token: 0x040029D6 RID: 10710
			[Token(Token = "0x40029D6")]
			[FieldOffset(Offset = "0x2C")]
			public PromotionsDic PromotionsDic;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		undefined4
		Gameplay_Bank_View_BankPromotionInfoWindow__get_WindowId(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a59797 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Bank_View_BankPromotionInfoWindow_BankPromotionInfoWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_BankPromotionInfoWindow___)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_12570);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3541);
		    DAT_ram_00a59797 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Bank_View_BankPromotionInfoWindow_BankPromotionInfoWindowArgs_TypeInfo
		                        );
		  if (DAT_ram_00a5979a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_BankPromotionInfoWindow_BankPromotionInfoWindowArgs___ctor__
		              );
		    DAT_ram_00a5979a = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1_00,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_BankPromotionInfoWindow_BankPromotionInfoWindowArgs___ctor__
		            );
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3541,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  uVar2 = Core_Extensions_Dict_PromotionsDicExt__GetInfoWindowImageAssetId(param1,0);
		  *(undefined4 *)(param1_00 + 0x2c) = param1;
		  *(undefined4 *)(param1_00 + 0x1c) = uVar2;
		  uVar1 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar1,StringLiteral_12570,param1_00,
		                     Method_UI_Windows_PopupController_Show_BankPromotionInfoWindow___);
		  return uVar1;
		}
		*/

}
