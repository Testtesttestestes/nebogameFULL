using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.GameEvents.View.Lists
{
	// Token: 0x02000789 RID: 1929
	[Token(Token = "0x2000789")]
	public class GameEventItemRenderer : MonoBehaviour
	{
		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06002DD3 RID: 11731 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002DD4 RID: 11732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008D1")]
		public GameEventsListView.GameEventsListItemWrapper Data
		{
			[Token(Token = "0x6002DD3")]
			[Address(RVA = "0x7E51", Offset = "0x7E51", VA = "0x7E51")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002DD4")]
			[Address(RVA = "0x7E52", Offset = "0x7E52", VA = "0x7E52")]
			set
			{
			}
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD5")]
		[Address(RVA = "0x7E53", Offset = "0x7E53", VA = "0x7E53")]
		private void HandleDataChanged(GameEventsListView.GameEventsListItemWrapper from, GameEventsListView.GameEventsListItemWrapper to)
		{
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD6")]
		[Address(RVA = "0x7E54", Offset = "0x7E54", VA = "0x7E54")]
		private void HandleOnEditModeChanged()
		{
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD7")]
		[Address(RVA = "0x7E55", Offset = "0x7E55", VA = "0x7E55")]
		private void HandleOnSelectedChanged()
		{
		}

		// Token: 0x06002DD8 RID: 11736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD8")]
		[Address(RVA = "0x7E56", Offset = "0x7E56", VA = "0x7E56")]
		private void ButtonClickedEventHandler()
		{
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD9")]
		[Address(RVA = "0x7E57", Offset = "0x7E57", VA = "0x7E57")]
		private void Awake()
		{
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DDA")]
		[Address(RVA = "0x7E58", Offset = "0x7E58", VA = "0x7E58")]
		private void HandleLongTapEvent(LongTap sender)
		{
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DDB")]
		[Address(RVA = "0x7E59", Offset = "0x7E59", VA = "0x7E59")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002DDC RID: 11740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DDC")]
		[Address(RVA = "0x7E5A", Offset = "0x7E5A", VA = "0x7E5A")]
		private void CheckBoxValueChanged(bool selected)
		{
		}

		// Token: 0x06002DDD RID: 11741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DDD")]
		[Address(RVA = "0x7E5B", Offset = "0x7E5B", VA = "0x7E5B")]
		private void SetSelect(bool value, GameEventsListView.GameEventsListItemWrapper data)
		{
		}

		// Token: 0x06002DDE RID: 11742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DDE")]
		[Address(RVA = "0x7E5C", Offset = "0x7E5C", VA = "0x7E5C")]
		public GameEventItemRenderer()
		{
		}

		// Token: 0x04001924 RID: 6436
		[Token(Token = "0x4001924")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001925 RID: 6437
		[Token(Token = "0x4001925")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _timestampField;

		// Token: 0x04001926 RID: 6438
		[Token(Token = "0x4001926")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Toggle _checkbox;

		// Token: 0x04001927 RID: 6439
		[Token(Token = "0x4001927")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameObject _selecetedBorder;

		// Token: 0x04001928 RID: 6440
		[Token(Token = "0x4001928")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameRawImage _backgroundLoader;

		// Token: 0x04001929 RID: 6441
		[Token(Token = "0x4001929")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Button _button;

		// Token: 0x0400192A RID: 6442
		[Token(Token = "0x400192A")]
		[FieldOffset(Offset = "0x28")]
		private GameEventsListView.GameEventsListItemWrapper _data;

		// Token: 0x0400192B RID: 6443
		[Token(Token = "0x400192B")]
		[FieldOffset(Offset = "0x2C")]
		private LongTap _longTap;
	}
}
