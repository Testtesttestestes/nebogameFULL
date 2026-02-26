using System;
using AssetContent;
using Gameplay.Accounts.Model.Data;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Accounts.View
{
	// Token: 0x02000DCE RID: 3534
	[Token(Token = "0x2000DCE")]
	public class SuggestActivateManufactureAccountDialogWindow : BaseDialogWindow<SuggestActivateManufactureAccountDialogWindow.SuggestActivateManufactureAccountDialogWindowArgs>
	{
		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x06005631 RID: 22065 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001187")]
		public override string WindowId
		{
			[Token(Token = "0x6005631")]
			[Address(RVA = "0xA3CF", Offset = "0xA3CF", VA = "0xA3CF", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005632 RID: 22066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005632")]
		[Address(RVA = "0xA3D0", Offset = "0xA3D0", VA = "0xA3D0", Slot = "22")]
		protected override void OnShow(SuggestActivateManufactureAccountDialogWindow.SuggestActivateManufactureAccountDialogWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Accounts_View_SuggestActivateManufactureAccountDialogWindow__OnShow
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5889e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_PopupController_Show_SuggestActivateManufactureAccountDialogWindow___
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_12555);
		    DAT_ram_00a5889e = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12555,param1,
		             Method_UI_Windows_PopupController_Show_SuggestActivateManufactureAccountDialogWindow___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06005633 RID: 22067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005633")]
		[Address(RVA = "0xA3D1", Offset = "0xA3D1", VA = "0xA3D1")]
		public static void Show(SuggestActivateManufactureAccountDialogWindow.SuggestActivateManufactureAccountDialogWindowArgs args)
		{
		/* --- GHIDRA: Show ---
		void Gameplay_Accounts_View_SuggestActivateManufactureAccountDialogWindow__Show
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5889f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_SuggestActivateManufactureAccountDialogWindow_SuggestActivateManufactureAccountDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a5889f = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_SuggestActivateManufactureAccountDialogWindow_SuggestActivateManufactureAccountDialogWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06005634 RID: 22068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005634")]
		[Address(RVA = "0xA3D2", Offset = "0xA3D2", VA = "0xA3D2")]
		public SuggestActivateManufactureAccountDialogWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Accounts_View_SuggestActivateManufactureAccountDialogWindow___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a588a0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_SuggestActivateManufactureAccountDialogWindow_SuggestActivateManufactureAccountDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a588a0 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_SuggestActivateManufactureAccountDialogWindow_SuggestActivateManufactureAccountDialogWindowArgs___ctor__
		            );
		  *(undefined4 *)(param1 + 0x2c) = param2;
		  return;
		}
		*/

		}

		// Token: 0x04002EC3 RID: 11971
		[Token(Token = "0x4002EC3")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Accounts/SuggestActivateManufactureAccountDialogWindow";

		// Token: 0x04002EC4 RID: 11972
		[Token(Token = "0x4002EC4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameRawImage _image;

		// Token: 0x04002EC5 RID: 11973
		[Token(Token = "0x4002EC5")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04002EC6 RID: 11974
		[Token(Token = "0x4002EC6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AccountDic.Types.ContentResource _contentResource;

		// Token: 0x02000DCF RID: 3535
		[Token(Token = "0x2000DCF")]
		public class SuggestActivateManufactureAccountDialogWindowArgs : BaseDialogWindow<SuggestActivateManufactureAccountDialogWindow.SuggestActivateManufactureAccountDialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06005635 RID: 22069 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005635")]
			[Address(RVA = "0xA3D3", Offset = "0xA3D3", VA = "0xA3D3")]
			public SuggestActivateManufactureAccountDialogWindowArgs(ManufactureAccount accountDataDecorator)
			{
			}

			// Token: 0x04002EC7 RID: 11975
			[Token(Token = "0x4002EC7")]
			[FieldOffset(Offset = "0x2C")]
			public ManufactureAccount AccountDataDecorator;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Accounts_View_SuggestActivateManufactureAccountDialogWindow__get_WindowId
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5889d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_SuggestActivateManufactureAccountDialogWindow_SuggestActivateManufactureAccountDialogWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2489);
		    DAT_ram_00a5889d = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x50);
		  uVar1 = Core_Extensions_Dict_AccountDicExt__GetImageListItemAssetId
		                    (*(undefined4 *)(*(int *)(param2 + 0x2c) + 8),*(undefined4 *)(param1 + 0x58),0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1_00,uVar1,0);
		  piVar2 = *(int **)(param1 + 0x54);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = func_ii_7508(StringLiteral_2489,1,0,1,0,0,0,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  UI_Windows_BaseDialogWindow_object___OnDestroy
		            (param1,param2,
		             Method_UI_Windows_BaseDialogWindow_SuggestActivateManufactureAccountDialogWindow_SuggestActivateManufactureAccountDialogWindowArgs__OnShow__
		            );
		  return;
		}
		*/

}
