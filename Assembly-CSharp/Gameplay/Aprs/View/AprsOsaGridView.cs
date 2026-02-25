using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Com.TheFallenGames.OSA.DataHelpers;
using DG.Tweening;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Aprs.View
{
	// Token: 0x02000D54 RID: 3412
	[Token(Token = "0x2000D54")]
	public class AprsOsaGridView : GridAdapter<GridParams, AprCellViewHolder>
	{
		// Token: 0x170010FF RID: 4351
		// (get) Token: 0x060053A8 RID: 21416 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060053A9 RID: 21417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010FF")]
		public SimpleDataHelper<AprData> Data
		{
			[Token(Token = "0x60053A8")]
			[Address(RVA = "0xA167", Offset = "0xA167", VA = "0xA167")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60053A9")]
			[Address(RVA = "0xA168", Offset = "0xA168", VA = "0xA168")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060053AA RID: 21418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053AA")]
		[Address(RVA = "0xA169", Offset = "0xA169", VA = "0xA169", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x060053AB RID: 21419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053AB")]
		[Address(RVA = "0xA16A", Offset = "0xA16A", VA = "0xA16A", Slot = "128")]
		protected override void UpdateCellViewsHolder(AprCellViewHolder newOrRecycled)
		{
		}

		// Token: 0x060053AC RID: 21420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053AC")]
		[Address(RVA = "0xA16B", Offset = "0xA16B", VA = "0xA16B")]
		private void NotifyStencilDelayed()
		{
		}

		// Token: 0x060053AD RID: 21421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053AD")]
		[Address(RVA = "0xA16C", Offset = "0xA16C", VA = "0xA16C", Slot = "129")]
		protected override void OnBeforeRecycleOrDisableCellViewsHolder(AprCellViewHolder inRecycleBinOrVisible, int newItemIndex)
		{
		}

		// Token: 0x060053AE RID: 21422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053AE")]
		[Address(RVA = "0xA16D", Offset = "0xA16D", VA = "0xA16D")]
		public void AddItemsAt(int index, IList<AprData> items)
		{
		}

		// Token: 0x060053AF RID: 21423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053AF")]
		[Address(RVA = "0xA16E", Offset = "0xA16E", VA = "0xA16E")]
		public void RemoveItemsFrom(int index, int count)
		{
		}

		// Token: 0x060053B0 RID: 21424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053B0")]
		[Address(RVA = "0xA16F", Offset = "0xA16F", VA = "0xA16F")]
		public void SetItems(IList<AprData> items)
		{
		}

		// Token: 0x060053B1 RID: 21425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053B1")]
		[Address(RVA = "0xA170", Offset = "0xA170", VA = "0xA170", Slot = "73")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060053B2 RID: 21426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053B2")]
		[Address(RVA = "0xA171", Offset = "0xA171", VA = "0xA171")]
		public AprsOsaGridView()
		{
		}

		// Token: 0x04002D56 RID: 11606
		[Token(Token = "0x4002D56")]
		[FieldOffset(Offset = "0xB0")]
		public Component MaskOnTop;

		// Token: 0x04002D58 RID: 11608
		[Token(Token = "0x4002D58")]
		[FieldOffset(Offset = "0xB8")]
		private Tween _delayedCall;
	}
}
