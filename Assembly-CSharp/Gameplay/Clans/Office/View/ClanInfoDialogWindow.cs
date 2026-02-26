using System;
using Gameplay.World.Model;
using Il2CppDummyDll;
using UI.ToolTip.Implementations.View;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Clans.Office.View
{
	// Token: 0x020009F1 RID: 2545
	[Token(Token = "0x20009F1")]
	public class ClanInfoDialogWindow : BaseDialogWindow<ClanInfoDialogWindow.ClanInfoDialogWindowArgs>
	{
		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06003CC0 RID: 15552 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BF5")]
		public override string WindowId
		{
			[Token(Token = "0x6003CC0")]
			[Address(RVA = "0x8B83", Offset = "0x8B83", VA = "0x8B83", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003CC1 RID: 15553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC1")]
		[Address(RVA = "0x8B84", Offset = "0x8B84", VA = "0x8B84", Slot = "22")]
		protected override void OnShow(ClanInfoDialogWindow.ClanInfoDialogWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Clans_Office_View_ClanInfoDialogWindow__OnShow(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57ef5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ClanInfoDialogWindow_ClanInfoDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a57ef5 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ClanInfoDialogWindow_ClanInfoDialogWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06003CC2 RID: 15554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CC2")]
		[Address(RVA = "0x8B85", Offset = "0x8B85", VA = "0x8B85")]
		public ClanInfoDialogWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_View_ClanInfoDialogWindow___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57ef6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ClanInfoDialogWindow_ClanInfoDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a57ef6 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ClanInfoDialogWindow_ClanInfoDialogWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0400218F RID: 8591
		[Token(Token = "0x400218F")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Clans/Office/ClanInfoDialogWindow";

		// Token: 0x04002190 RID: 8592
		[Token(Token = "0x4002190")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ClanToolTipView _clanToolTip;

		// Token: 0x020009F2 RID: 2546
		[Token(Token = "0x20009F2")]
		public class ClanInfoDialogWindowArgs : BaseDialogWindow<ClanInfoDialogWindow.ClanInfoDialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06003CC3 RID: 15555 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003CC3")]
			[Address(RVA = "0x8B86", Offset = "0x8B86", VA = "0x8B86")]
			public ClanInfoDialogWindowArgs()
			{
			}

			// Token: 0x04002191 RID: 8593
			[Token(Token = "0x4002191")]
			[FieldOffset(Offset = "0x2C")]
			public ClanData ClanData;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Clans_Office_View_ClanInfoDialogWindow__get_WindowId
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57ef4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ClanInfoDialogWindow_ClanInfoDialogWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_BaseToolTip_ClanData__set_Data__);
		    DAT_ram_00a57ef4 = '\x01';
		  }
		  UI_ToolTip_BaseToolTip_object___get_Data
		            (*(undefined4 *)(param1 + 0x50),*(undefined4 *)(param2 + 0x2c),
		             Method_UI_ToolTip_BaseToolTip_ClanData__set_Data__);
		  UI_Windows_BaseDialogWindow_object___OnDestroy
		            (param1,param2,
		             Method_UI_Windows_BaseDialogWindow_ClanInfoDialogWindow_ClanInfoDialogWindowArgs__OnShow__
		            );
		  return;
		}
		*/

}
