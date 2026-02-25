using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Com.TheFallenGames.OSA.DataHelpers;
using Core.Data;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.SmallGames.View
{
	// Token: 0x02000515 RID: 1301
	[Token(Token = "0x2000515")]
	public class RewardStorageOSAView : GridAdapter<GridParams, RewardsStorageCellViewHolder>
	{
		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001EFA RID: 7930 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001EFB RID: 7931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A0")]
		public SimpleDataHelper<ArtifactData> Data
		{
			[Token(Token = "0x6001EFA")]
			[Address(RVA = "0x7061", Offset = "0x7061", VA = "0x7061")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EFB")]
			[Address(RVA = "0x7062", Offset = "0x7062", VA = "0x7062")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EFC")]
		[Address(RVA = "0x7063", Offset = "0x7063", VA = "0x7063", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EFD")]
		[Address(RVA = "0x7064", Offset = "0x7064", VA = "0x7064", Slot = "128")]
		protected override void UpdateCellViewsHolder(RewardsStorageCellViewHolder newOrRecycled)
		{
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EFE")]
		[Address(RVA = "0x7065", Offset = "0x7065", VA = "0x7065")]
		private void NotifyStencilDelayed()
		{
		}

		// Token: 0x06001EFF RID: 7935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EFF")]
		[Address(RVA = "0x7066", Offset = "0x7066", VA = "0x7066", Slot = "129")]
		protected override void OnBeforeRecycleOrDisableCellViewsHolder(RewardsStorageCellViewHolder inRecycleBinOrVisible, int newItemIndex)
		{
		}

		// Token: 0x06001F00 RID: 7936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F00")]
		[Address(RVA = "0x7067", Offset = "0x7067", VA = "0x7067")]
		public void AddItemsAt(int index, IList<ArtifactData> items)
		{
		}

		// Token: 0x06001F01 RID: 7937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F01")]
		[Address(RVA = "0x7068", Offset = "0x7068", VA = "0x7068")]
		public void RemoveItemsFrom(int index, int count)
		{
		}

		// Token: 0x06001F02 RID: 7938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F02")]
		[Address(RVA = "0x7069", Offset = "0x7069", VA = "0x7069")]
		public void SetItems(IList<ArtifactData> items)
		{
		}

		// Token: 0x06001F03 RID: 7939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F03")]
		[Address(RVA = "0x706A", Offset = "0x706A", VA = "0x706A")]
		public RewardStorageOSAView()
		{
		}

		// Token: 0x040010C6 RID: 4294
		[Token(Token = "0x40010C6")]
		[FieldOffset(Offset = "0xB0")]
		public Component MaskOnTop;

		// Token: 0x040010C8 RID: 4296
		[Token(Token = "0x40010C8")]
		[FieldOffset(Offset = "0xB8")]
		private Tween _delayedCall;
	}
}
