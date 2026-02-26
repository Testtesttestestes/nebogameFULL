using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using Utils;

namespace UI.ToolTip.Implementations.View.Misc
{
	// Token: 0x02000153 RID: 339
	[Token(Token = "0x2000153")]
	public class BacktimeTitleToolTipView : BaseToolTip<BacktimeTitleToolTipView.BacktimeTitleArgs>
	{
		// Token: 0x060009D0 RID: 2512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x5D37", Offset = "0x5D37", VA = "0x5D37", Slot = "5")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void UI_ToolTip_Implementations_View_Misc_BacktimeTitleToolTipView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5997a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_ToolTip_BaseToolTip_BacktimeTitleToolTipView_BacktimeTitleArgs___ctor__);
		    DAT_ram_00a5997a = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_UI_ToolTip_BaseToolTip_BacktimeTitleToolTipView_BacktimeTitleArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x5D38", Offset = "0x5D38", VA = "0x5D38")]
		public BacktimeTitleToolTipView()
		{
		}

		// Token: 0x040003F2 RID: 1010
		[Token(Token = "0x40003F2")]
		public const string TOOL_TIP_ID = "Prefabs/UI/ToolTip/BacktimeTitleToolTipView";

		// Token: 0x040003F3 RID: 1011
		[Token(Token = "0x40003F3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040003F4 RID: 1012
		[Token(Token = "0x40003F4")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private BacktimeViewUGUI _backtime;

		// Token: 0x02000154 RID: 340
		[Token(Token = "0x2000154")]
		public class BacktimeTitleArgs
		{
			// Token: 0x060009D2 RID: 2514 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x5D39", Offset = "0x5D39", VA = "0x5D39")]
			public BacktimeTitleArgs()
			{
			}

			// Token: 0x040003F5 RID: 1013
			[Token(Token = "0x40003F5")]
			[FieldOffset(Offset = "0x8")]
			public string Title;

			// Token: 0x040003F6 RID: 1014
			[Token(Token = "0x40003F6")]
			[FieldOffset(Offset = "0xC")]
			public BackTime Backtime;
		}
	}
}
