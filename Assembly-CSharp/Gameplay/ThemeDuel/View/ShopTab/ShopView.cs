using System;
using System.Collections;
using System.Collections.Generic;
using AssetContent.Loaders;
using Gameplay.ThemeDuelState.Model;
using Il2CppDummyDll;
using Protocol.Themeduel;
using TMPro;
using UnityEngine;

namespace Gameplay.ThemeDuel.View.ShopTab
{
	// Token: 0x020004DD RID: 1245
	[Token(Token = "0x20004DD")]
	public class ShopView : MonoBehaviour
	{
		// Token: 0x17000551 RID: 1361
		// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000551")]
		public string PointIconAssetId
		{
			[Token(Token = "0x6001DB0")]
			[Address(RVA = "0x6F2E", Offset = "0x6F2E", VA = "0x6F2E")]
			set
			{
			}
		}

		// Token: 0x17000552 RID: 1362
		// (set) Token: 0x06001DB1 RID: 7601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000552")]
		public ThemeDuelStateModel StateModel
		{
			[Token(Token = "0x6001DB1")]
			[Address(RVA = "0x6F2F", Offset = "0x6F2F", VA = "0x6F2F")]
			set
			{
			}
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DB2")]
		[Address(RVA = "0x6F30", Offset = "0x6F30", VA = "0x6F30")]
		private void StopCurrentCoroutine()
		{
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DB3")]
		[Address(RVA = "0x6F31", Offset = "0x6F31", VA = "0x6F31")]
		public void PopulateGoods(IEnumerable<EventStoreItem> items)
		{
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001DB4")]
		[Address(RVA = "0x6F32", Offset = "0x6F32", VA = "0x6F32")]
		private IEnumerator DisplayCurrentBackTime()
		{
			return null;
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DB5")]
		[Address(RVA = "0x6F33", Offset = "0x6F33", VA = "0x6F33")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DB6")]
		[Address(RVA = "0x6F34", Offset = "0x6F34", VA = "0x6F34")]
		public ShopView()
		{
		}

		// Token: 0x04001021 RID: 4129
		[Token(Token = "0x4001021")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ThemeDuelShopItemView _itemViewPrefab;

		// Token: 0x04001022 RID: 4130
		[Token(Token = "0x4001022")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _shopContentContainer;

		// Token: 0x04001023 RID: 4131
		[Token(Token = "0x4001023")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Sprite> _markerSprites;

		// Token: 0x04001024 RID: 4132
		[Token(Token = "0x4001024")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameRawImageLoader _pointIcon;

		// Token: 0x04001025 RID: 4133
		[Token(Token = "0x4001025")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _timerText;

		// Token: 0x04001026 RID: 4134
		[Token(Token = "0x4001026")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameObject _timer;

		// Token: 0x04001027 RID: 4135
		[Token(Token = "0x4001027")]
		[FieldOffset(Offset = "0x28")]
		private ThemeDuelStateModel _stateModel;

		// Token: 0x04001028 RID: 4136
		[Token(Token = "0x4001028")]
		[FieldOffset(Offset = "0x2C")]
		private Coroutine _displayBackTimeCoroutine;
	}
}
