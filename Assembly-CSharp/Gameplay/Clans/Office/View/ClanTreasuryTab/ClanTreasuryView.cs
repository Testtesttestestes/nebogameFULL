using System;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using Protocol.ClanWar;
using Protocol.Dic;
using TMPro;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Clans.Office.View.ClanTreasuryTab
{
	// Token: 0x02000A0B RID: 2571
	[Token(Token = "0x2000A0B")]
	public class ClanTreasuryView : MonoBehaviour
	{
		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06003D16 RID: 15638 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C14")]
		public ResourceTable ResourceTable
		{
			[Token(Token = "0x6003D16")]
			[Address(RVA = "0x8BD6", Offset = "0x8BD6", VA = "0x8BD6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06003D17 RID: 15639 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C15")]
		public ResourceInputTable ResourceInputTable
		{
			[Token(Token = "0x6003D17")]
			[Address(RVA = "0x8BD7", Offset = "0x8BD7", VA = "0x8BD7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06003D18 RID: 15640 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C16")]
		public Button SubmitToTreasuryButton
		{
			[Token(Token = "0x6003D18")]
			[Address(RVA = "0x8BD8", Offset = "0x8BD8", VA = "0x8BD8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06003D19 RID: 15641 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C17")]
		public Button ToEventsButton
		{
			[Token(Token = "0x6003D19")]
			[Address(RVA = "0x8BD9", Offset = "0x8BD9", VA = "0x8BD9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06003D1A RID: 15642 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C18")]
		public Price Price
		{
			[Token(Token = "0x6003D1A")]
			[Address(RVA = "0x8BDA", Offset = "0x8BDA", VA = "0x8BDA")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003D1B RID: 15643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D1B")]
		[Address(RVA = "0x8BDB", Offset = "0x8BDB", VA = "0x8BDB")]
		public void SetWarStatus(ClanWarInfo warInfo, BackTime backTime, Dictionaries dict)
		{
		}

		// Token: 0x06003D1C RID: 15644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D1C")]
		[Address(RVA = "0x8BDC", Offset = "0x8BDC", VA = "0x8BDC")]
		public void SetNoWarStatus()
		{
		}

		// Token: 0x06003D1D RID: 15645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D1D")]
		[Address(RVA = "0x8BDD", Offset = "0x8BDD", VA = "0x8BDD")]
		public ClanTreasuryView()
		{
		}

		// Token: 0x040021EC RID: 8684
		[Token(Token = "0x40021EC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ResourceTable _resourceTable;

		// Token: 0x040021ED RID: 8685
		[Token(Token = "0x40021ED")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ResourceInputTable _resourceInputTable;

		// Token: 0x040021EE RID: 8686
		[Token(Token = "0x40021EE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _submitToTreasuryButton;

		// Token: 0x040021EF RID: 8687
		[Token(Token = "0x40021EF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _toEventsButton;

		// Token: 0x040021F0 RID: 8688
		[Token(Token = "0x40021F0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Price _price;

		// Token: 0x040021F1 RID: 8689
		[Token(Token = "0x40021F1")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _warStatusAnnotation;

		// Token: 0x040021F2 RID: 8690
		[Token(Token = "0x40021F2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BacktimeRowViewDynamic _backtimeRow;
	}
}
