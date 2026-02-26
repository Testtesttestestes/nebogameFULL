using System;
using AssetContent;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.GenericList;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.WorldAxis.Office.View.Schedule
{
	// Token: 0x020002ED RID: 749
	[Token(Token = "0x20002ED")]
	public class ColossusBattleListElement : SelectableListElement<ColossusBattleListElement.ColossusBattleListElementArgs>
	{
		// Token: 0x060011C9 RID: 4553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011C9")]
		[Address(RVA = "0x63C6", Offset = "0x63C6", VA = "0x63C6", Slot = "11")]
		protected override void ApplyArgs()
		{
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011CA")]
		[Address(RVA = "0x63C7", Offset = "0x63C7", VA = "0x63C7", Slot = "10")]
		protected override void CallElementClickedEvent(ColossusBattleListElement.ColossusBattleListElementArgs args)
		{
		/* --- GHIDRA: CallElementClickedEvent ---
		void Gameplay_WorldAxis_Office_View_Schedule_ColossusBattleListElement__CallElementClickedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58b93 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElement_ColossusBattleListElement_ColossusBattleListElementArgs___ctor__
		              );
		    DAT_ram_00a58b93 = '\x01';
		  }
		  UI_Elements_GenericList_SelectableListElementArgs___Il2CppFullySharedGenericType____ctor
		            (param1,
		             Method_UI_Elements_GenericList_SelectableListElement_ColossusBattleListElement_ColossusBattleListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060011CB RID: 4555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011CB")]
		[Address(RVA = "0x63C8", Offset = "0x63C8", VA = "0x63C8")]
		public ColossusBattleListElement()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Office_View_Schedule_ColossusBattleListElement___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58b94 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_SelectableListElementArgs_ColossusBattleListElement___ctor__
		              );
		    DAT_ram_00a58b94 = '\x01';
		  }
		  UnityEngine_InputSystem_LowLevel_SelectObservable___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___Subscribe
		            (param1,
		             Method_UI_Elements_GenericList_SelectableListElementArgs_ColossusBattleListElement___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0400092D RID: 2349
		[Token(Token = "0x400092D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x0400092E RID: 2350
		[Token(Token = "0x400092E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _bg;

		// Token: 0x0400092F RID: 2351
		[Token(Token = "0x400092F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x04000930 RID: 2352
		[Token(Token = "0x4000930")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameAssetViewRawImage _gameAssetViewRawImage;

		// Token: 0x04000931 RID: 2353
		[Token(Token = "0x4000931")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private GameImage _clanCultIcon;

		// Token: 0x04000932 RID: 2354
		[Token(Token = "0x4000932")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _clanTitle;

		// Token: 0x04000933 RID: 2355
		[Token(Token = "0x4000933")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Image _stateIcon;

		// Token: 0x04000934 RID: 2356
		[Token(Token = "0x4000934")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI _stateText;

		// Token: 0x020002EE RID: 750
		[Token(Token = "0x20002EE")]
		public class ColossusBattleListElementArgs : SelectableListElementArgs<ColossusBattleListElement>
		{
			// Token: 0x060011CC RID: 4556 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60011CC")]
			[Address(RVA = "0x63C9", Offset = "0x63C9", VA = "0x63C9")]
			public ColossusBattleListElementArgs()
			{
			}

			// Token: 0x04000935 RID: 2357
			[Token(Token = "0x4000935")]
			[FieldOffset(Offset = "0x1C")]
			public ColossusBattleData ColossusData;

			// Token: 0x04000936 RID: 2358
			[Token(Token = "0x4000936")]
			[FieldOffset(Offset = "0x20")]
			public Sprite BgSprite;

			// Token: 0x04000937 RID: 2359
			[Token(Token = "0x4000937")]
			[FieldOffset(Offset = "0x24")]
			public Sprite StateIcon;
		}
	}
}
